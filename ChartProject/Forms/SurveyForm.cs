using ChartProject.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChartProject.Forms
{
    public partial class SurveyForm : Form
    {
        public Student Student => student;

        private Student student;
        private int currentQuestionId = 0;
        private List<RadioButton> radioButtons = new List<RadioButton>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();

        public SurveyForm()
        {
            InitializeComponent();
            student = new Student();
            radioButtons.Add(radioButton1);
            radioButtons.Add(radioButton2);
            radioButtons.Add(radioButton3);
            checkBoxes.Add(checkBox1);
            checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3);
            checkBoxes.Add(checkBox4);
            checkBoxes.Add(checkBox5);
            checkBoxes.Add(checkBox6);
            checkBoxes.Add(checkBox7);
            UpdateUI();
        }

        private void EndButton_Click(object sender, System.EventArgs e)
        {
            if (!AnswerIsGiven())
            {
                MessageBox.Show("Ответьте на вопрос!");
                return;
            }
            SetAnswers(true);
            DialogResult = DialogResult.OK;
        }

        private void NextButton_Click(object sender, System.EventArgs e)
        {
            if (NameTextBox.Text.Length < 1)
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (!AnswerIsGiven())
            {
                MessageBox.Show("Ответьте на вопрос!");
                return;
            }
            if (currentQuestionId == 3 || currentQuestionId==4) SetAnswers(false);
            else SetAnswers(true);
            currentQuestionId++;
            UpdateUI();
        }


        private void UpdateUI()
        {
            CountOfQuestionLabel.Text = $"{currentQuestionId + 1}/{QuestionsManager.Questions.Count}";
            QuestionLabel.Text = QuestionsManager.Questions[currentQuestionId].question;
            if (currentQuestionId == 1)
            {
                NameLabel.Visible = false;
                NameTextBox.Visible = false;
                student.Name = NameTextBox.Text;
            }
            if (currentQuestionId == 4 || currentQuestionId == 3) SetTextQuestion(false);
            else SetTextQuestion(true);
            if (currentQuestionId == QuestionsManager.Questions.Count - 1)
            {
                NextButton.Enabled = false;
                EndButton.Enabled = true;
            }
            else
            {
                EndButton.Enabled = false;
                NextButton.Enabled = true; 
            }
        }

        private void SetAnswers(bool isRadioButton)
        {
            if (currentQuestionId == 0)
            {
                if (radioButton1.Checked) student.Core = Enums.Core.Soft;
                if (radioButton2.Checked) student.Core = Enums.Core.Hard;
                return;
            }
            if (currentQuestionId == 1)
            {
                if (radioButton1.Checked) student.Sex = Enums.Sex.Male;
                if (radioButton2.Checked) student.Sex = Enums.Sex.Female;
                return;
            }
            if (currentQuestionId == 2)
            {
                if (radioButton1.Checked) student.Age = Enums.Age.LessThan18;
                if (radioButton2.Checked) student.Age = Enums.Age.From18To21;
                if (radioButton3.Checked) student.Age = Enums.Age.MoreThan21;
                return;
            }
            Question question = (Question)QuestionsManager.Questions[currentQuestionId].Clone();
            if (isRadioButton)
            {
                for (int i = 0; i < radioButtons.Count; i++)
                {
                    if (radioButtons[i].Checked)
                    {
                        question.AddChoseAnswer(i);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < checkBoxes.Count; i++)
                {
                    if (checkBoxes[i].Checked) question.AddChoseAnswer(i);
                }
            }
            student.AddQuestion(question);
        }

        private void SetTextQuestion(bool isRadioButton)
        {
            ResetRadioButton();
            ResetCheckBox();
            if (isRadioButton)
            {
                for (int i = 0; i < radioButtons.Count; i++)
                {
                    if (i < QuestionsManager.Questions[currentQuestionId].Answers.Count)
                    {
                        radioButtons[i].Text = QuestionsManager.Questions[currentQuestionId].Answers[i];
                        radioButtons[i].Visible = true;
                    }
                    else
                    {
                        radioButtons[i].Visible = false;
                    }
                }
                CheckBoxesVisible(false);
            }
            else
            {
                for (int i = 0; i < checkBoxes.Count; i++)
                {
                    if (i < QuestionsManager.Questions[currentQuestionId].Answers.Count)
                    {
                        checkBoxes[i].Text = QuestionsManager.Questions[currentQuestionId].Answers[i];
                        checkBoxes[i].Visible = true;
                    }
                    else
                    {
                        checkBoxes[i].Visible = false;
                    }
                }
                RadioButtonsVisible(false);
            }
        }

        private bool AnswerIsGiven()
        {
            for (int i = 0; i < radioButtons.Count; i++)
            {
                if(radioButtons[i].Checked) return true;
            }
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                if (checkBoxes[i].Checked) return true;
            }
            return false;
        }

        private void CheckBoxesVisible(bool isVisible)
        {
            for (int i = 0; i < checkBoxes.Count; i++) checkBoxes[i].Visible = isVisible;
        }

        private void RadioButtonsVisible(bool isVisible)
        {
            for (int i = 0; i < radioButtons.Count; i++) radioButtons[i].Visible = isVisible;
        }

        private void ResetCheckBox()
        {
            for (int i = 0; i < checkBoxes.Count; i++) checkBoxes[i].Checked = false;
        }

        private void ResetRadioButton()
        {
            for (int i = 0; i < radioButtons.Count; i++) radioButtons[i].Checked = false;
        }
    }
}
