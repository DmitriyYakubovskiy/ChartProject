using ChartProject.Forms;
using ChartProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ChartProject
{
    public partial class Form1 : Form
    {
        private const string path = "students.csv";
        private List<Student> students;

        public Form1()
        {
            InitializeComponent();
            students = Student.FileToList(path);
        }

        private void SurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SurveyForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                if(form.Student != null) students.Add(form.Student);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(path);
            Student.ListToFile(students,path);
        }

        private void FirstQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuestionForm(students, 0);
            form.ShowDialog();
        }

        private void SecondQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuestionForm(students, 1);
            form.ShowDialog();
        }

        private void ThirdQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuestionForm(students, 2);
            form.ShowDialog();
        }

        private void FourQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuestionForm(students, 3);
            form.ShowDialog();
        }

        private void FithQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuestionForm(students, 4);
            form.ShowDialog();
        }
    }
}
