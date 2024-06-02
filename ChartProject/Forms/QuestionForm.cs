using ChartProject.Enums;
using ChartProject.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartProject.Forms
{
    public partial class QuestionForm : Form
    {
        private List<Student> students;
        private int questionId;

        private Age age = Age.None;
        private Core core = Core.None;
        private Sex sex = Sex.None;

        public QuestionForm(List<Student> students, int questionId)
        {
            InitializeComponent();
            this.students = students;
            this.questionId = questionId;
            chart.Palette = ChartColorPalette.Pastel;
            ChartArea chartArea = new ChartArea();
            chartArea.Position.Width = 17;
            chartArea.Position.Height = 17;
            chart.ChartAreas.Add(chartArea);
            chart.Legends.Add(new Legend());
            AgeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CoreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AgeComboBox.SelectedIndex = 3;
            SexComboBox.SelectedIndex = 2;
            CoreComboBox.SelectedIndex = 2;
        }

        private void SetSeries()
        {
            string[] variantsOfAnswer = QuestionsManager.Questions[questionId+3].Answers.ToArray();
            List<int> numberOfAnwers = new List<int>();

            for (int i = 0; i < variantsOfAnswer.Length; i++)
            {
                numberOfAnwers.Add(0);
            }
            foreach (var student in students)
            {
                if (core != Core.None)
                    if (student.Core != core) continue;
                if (age != Age.None)
                    if (student.Age != age) continue;
                if (sex != Sex.None)
                    if (student.Sex != sex) continue;
                for (int i = 0; i < student.GetQuestion(questionId).ChoseAnswers.Count; i++)
                {
                    numberOfAnwers[student.GetQuestion(questionId).ChoseAnswers[i]] += 1;
                }
            }
            SetTitle();

            Series series = new Series(QuestionsManager.Questions[questionId + 3].question);
            if (questionId == 0 || questionId == 1)
            {
                series.ChartType = SeriesChartType.Bar;
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart.Legends[0].Enabled = false;
            }
            else
            {
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;
            }
            for (int i = 0; i < variantsOfAnswer.Length; i++)
            {
                series.Points.AddXY(variantsOfAnswer[i], numberOfAnwers[i]);
            }
            foreach (DataPoint p in series.Points)
            {
                p.LegendText = "#VALX";
                p.Label = "#PERCENT";
            }
            chart.Series.Add(series);
        }

        private void SetTitle()
        {
            string title = $"{QuestionsManager.Questions[questionId + 3].question}";
            if (age != Age.None)
            {
                if(age == Age.LessThan18) title += $"|{"Меньше 18"}";
                if (age == Age.From18To21) title += $"|{"18 - 21"}";
                if (age == Age.MoreThan21) title += $"|{"Больше 21"}";
            }
            if (sex != Sex.None)
            {
                title += $"|{(sex == Sex.Female ? "Женщина" : "Мужчина")}";
            }
            if (core != Core.None)
            {
                title += $"|{core}";
            }
            chart.Titles.Add(title);
        }
         

        private void ClearChart()
        {
            chart.Series.Clear();
            chart.Titles.Clear();
        }

        private void AgesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            age=(Age)AgeComboBox.SelectedIndex;
            ClearChart();
            SetSeries();
        }

        private void SexComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            sex = (Sex)SexComboBox.SelectedIndex;
            ClearChart();
            SetSeries();
        }

        private void CoreComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            core = (Core)CoreComboBox.SelectedIndex;
            ClearChart();
            SetSeries();
        }
    }
}
