using System;
using System.Collections.Generic;

namespace ChartProject.Models
{
    public class Question:ICloneable
    {
        public string question { get; set; }
        public List<int> ChoseAnswers=>choseAnswers;
        public List<string> Answers => answers;

        private List<int> choseAnswers;
        private List<string> answers;

        public Question(string question, List<string> answers, List<int> choseAnswers)
        {
            this.question = question;
            this.choseAnswers = choseAnswers;
            this.answers = answers;
        }

        public Question(string question,List<string> answers):this(question,answers, new List<int>()) { }

        public Question() : this("", new List<string>()) { }

        public void AddChoseAnswer(int answer)
        {
            choseAnswers.Add(answer);
        }

        public object Clone()
        {
            return new Question(question, answers);
        }
    }
}
