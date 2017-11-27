//CIS 345 9:00 Bozhi Yin Project
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class QuestionDetails : Form
    {
        public event EventHandler QuestionUpdated;
        public event EventHandler QuestionAdded;
        private Question currentQuestion;
        

        public QuestionDetails()
        {
            InitializeComponent();
        }
        
        

        private void QuestionDetails_Load(object sender, EventArgs e)
        {
            //form is opened for add question purpose
            updateButton.Visible = false;
            addButton.Visible = true;
            
        }

        public void LoadData(Question question)
        {
            currentQuestion = question;

            questionTextBox.Text = currentQuestion.QuestionText;
            choiceOneTextBox.Text = currentQuestion.Choices[0];
            choiceTwoTextBox.Text = currentQuestion.Choices[1];
            choiceThreeTextBox.Text = currentQuestion.Choices[2];
            choiceFourTextBox.Text = currentQuestion.Choices[3];
            feedbackTextBox.Text = currentQuestion.Feedback;
            correctChoiceTextBox.Text = currentQuestion.CorrectAnswer.ToString();
        }

        private bool CheckNumericInput(TextBox t)
        {
            bool success = false;
            int integer = 0;
            success = int.TryParse(t.Text, out integer);
            return success;
        }

        private bool CheckTextBoxInput()
        {
            bool inputOk = true;

            if (questionTextBox.Text == string.Empty || choiceOneTextBox.Text == string.Empty || choiceTwoTextBox.Text == string.Empty || choiceThreeTextBox.Text == string.Empty || choiceFourTextBox.Text == string.Empty || feedbackTextBox.Text == string.Empty || correctChoiceTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields.");
                inputOk = false;
            }    
            else
            {
                inputOk = CheckNumericInput(correctChoiceTextBox);
                if (!inputOk)
                {
                    MessageBox.Show("Please enter valid correct choice number.");
                }
            }
            return inputOk;
        }


        //reuseable code to store data in a question object and convert to a QuestionEventArgs 
        private QuestionEventArgs DataToEventArgs()
        {
            if (!CheckTextBoxInput())
            {
                return null;
            }

            string question = questionTextBox.Text;
            string[] choiceArray = new string[4];
            choiceArray[0] = choiceOneTextBox.Text;
            choiceArray[1] = choiceTwoTextBox.Text;
            choiceArray[2] = choiceThreeTextBox.Text;
            choiceArray[3] = choiceFourTextBox.Text;
            string feedback = feedbackTextBox.Text;

            int correctChoice;
            bool success = int.TryParse(correctChoiceTextBox.Text, out correctChoice);

            Question tmpQuestion = new Question(question, choiceArray, feedback, correctChoice);
            QuestionEventArgs tmpArgs = new QuestionEventArgs(tmpQuestion);
            return tmpArgs;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
             currentQuestion.QuestionText = questionTextBox.Text;
            currentQuestion.Choices[0] = choiceOneTextBox.Text;
            currentQuestion.Choices[1] = choiceTwoTextBox.Text;
            currentQuestion.Choices[2] = choiceThreeTextBox.Text;
            currentQuestion.Choices[3] = choiceFourTextBox.Text;
            currentQuestion.Feedback = feedbackTextBox.Text;
            currentQuestion.CorrectAnswer = Convert.ToInt32(correctChoiceTextBox.Text);

            QuestionEventArgs tmpArgs;
            tmpArgs = DataToEventArgs();

            if (QuestionUpdated != null)
            {
                QuestionUpdated(this, tmpArgs);
            }

            this.Close();
            // For convenience of next update question selection in mainwindow
        }

        public void SetData(Question question)
        {
            
        }
        public void ViewQuestion(Question question)
        {
            LoadData(question);
            //method called in questionListBox double click event handler
            //form is used for view and update question 
            addButton.Visible = false;
            updateButton.Visible = true;
        }
        
        

        private void addButton_Click(object sender, EventArgs e)
        {
            QuestionEventArgs tmpArgs;

            if (DataToEventArgs() == null)
            {
                return;
            }
            else
            {
                tmpArgs = DataToEventArgs();
            }
            if (QuestionAdded!=null)
            {
                QuestionAdded(this, tmpArgs);
            }

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            // do not close for easy of adding additional question
        }
    }
}
