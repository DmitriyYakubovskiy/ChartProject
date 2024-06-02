using ChartProject.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ChartProject.Models
{
    public class Student
    {
        public string Name { get; set; }
        public Sex Sex { get; set; }
        public Age Age { get; set; }
        public Core Core { get; set; }
        public List<Question> Questions => questions;

        private List<Question> questions;

        public Student(string name, Sex sex, Age age, Core core, List<Question> questions)
        {
            Name = name;
            Sex = sex;
            Age = age;
            Core = core;
            this.questions = questions;
        }

        public Student() : this("", 0, 0, 0, new List<Question>()) { }

        public void SetQuestions(List<Question> qustions)
        {
            questions = qustions;
        }

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public void SetQuestion(Question question, int index)
        {
            if (index < 0 || index >= questions.Count) return;
            questions[index] = question;
        }

        public Question GetQuestion(int index)
        {
            try
            {
                return questions[index];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static List<Student> FileToList(string path)
        {
            List<Student> students = new List<Student>();
            if (!File.Exists(path)) File.Create(path).Close();
            using (StreamReader reader = new StreamReader(path,encoding:Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    Student student = new Student
                    {
                        Name = parts[0],
                        Sex = (Sex)int.Parse(parts[1]),
                        Age = (Age)int.Parse(parts[2]),
                        Core = (Core)int.Parse(parts[3])
                    };
                    for (int i = 4; i < QuestionsManager.Questions.Count+1; i++)
                    {
                        string[] choseAnswers= parts[i].Split();
                        Question question = (Question)QuestionsManager.Questions[i-1].Clone();
                        for(int j = 0; j < choseAnswers.Length; j++)
                        {
                            if (choseAnswers[j]!="") question.AddChoseAnswer(int.Parse(choseAnswers[j]));
                        }
                        student.AddQuestion(question);
                    }
                    students.Add(student);
                }
            }
            return students;
        }

        public static void ListToFile(List<Student> students, string path)
        {
            using (StreamWriter writer = new StreamWriter(path,true, Encoding.UTF8))
            {
                foreach (Student student in students)
                {
                    string str = $"{student.Name};{(int)student.Sex};{(int)student.Age};{(int)student.Core};";
                    for (int i = 0; i < student.questions.Count; i++)
                    {
                        for(int j = 0; j < student.questions[i].ChoseAnswers.Count; j++)
                        {
                            str += $"{student.GetQuestion(i).ChoseAnswers[j]}";
                            if (j != student.questions[i].ChoseAnswers.Count - 1) str += " ";
                        }
                        if (i != student.questions.Count - 1) str += ";";
                    }
                    writer.WriteLine(str);
                }
            }
        }

        public override string ToString()
        {
            string str = $"{Name} {Sex} {Age} {Core}\n";
            for (int i = 0; i < questions.Count; i++)
            {
                str += $"{questions[i].question}: ";
                for (int j = 0; j < questions[i].ChoseAnswers.Count; j++)
                {
                    str += $"{GetQuestion(i).ChoseAnswers[j]}";
                    if (j != questions[i].ChoseAnswers.Count - 1) str += " ";
                }
                if (i != questions.Count - 1) str += "\n";
            }
            return str;
        }
    }
}
