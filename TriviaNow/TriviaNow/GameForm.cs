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
using System.Media;

namespace TriviaNow
{
    public partial class GameForm : Form
    {
        SoundPlayer soundPlayer;
        int numOfQuestionAnswered = 0;
        List<Question> questionPool;
        List<Question> randomSelectedQuestion;
        int userAnswer;
        int correctQuestionNum = 0;
        int correctAnswer;
        Question currentQuestion;

        public GameForm()
        {
            InitializeComponent();
        }

        public void SetData(BindingList<Question> listOfQuestions)
        {

            questionPool = new List<Question>();
            questionPool = listOfQuestions.ToList();
        }

        private void RandomSelectQuestionFromQuestionPool()
        {
            Random randomGenerator;
            int index;
            Question tmpQuestion;
            randomGenerator = new Random();
            randomSelectedQuestion = new List<Question>();

            for (int i = 0; i < 3; i++)
            {
                index = randomGenerator.Next(0, questionPool.Count);
                tmpQuestion = questionPool.ElementAt(index);
                randomSelectedQuestion.Add(tmpQuestion);
                questionPool.Remove(tmpQuestion);
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("media.wav");
            soundPlayer.Load();
            soundPlayer.Play();
            

            RandomSelectQuestionFromQuestionPool();

            progressBar.Minimum = 0;
            progressBar.Maximum = 3;

            progressBar.Value = numOfQuestionAnswered;
            loadQuestion();
            feedBackLabel.Visible = false;
            feedBackDisplayTextBox.Visible = false;
            progressLabel.Text = $"You have answered {numOfQuestionAnswered} out of 3. {correctQuestionNum} answered correctly";
            closeGameButton.Visible = false;
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            feedBackLabel.Visible = false;
            feedBackDisplayTextBox.Visible = false;
            submitButton.Enabled = true;
            
            loadQuestion();

        }

        private void loadQuestion()
        {
            currentQuestion = randomSelectedQuestion.ElementAt(numOfQuestionAnswered);
            questionTextLabel.Text = currentQuestion.QuestionText;
            choiceOneRadioButton.Text = currentQuestion.Choices[0];
            choiceTwoRadioButton.Text = currentQuestion.Choices[1];
            choiceThreeRadioButton.Text = currentQuestion.Choices[2];
            choiceFourRadioButton.Text = currentQuestion.Choices[3];
            correctAnswer = currentQuestion.CorrectAnswer;
            nextQuestionButton.Enabled = false;
        }

        private void choiceOneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (choiceOneRadioButton.Checked)
            {
                userAnswer = 1;
            }
        }

        private void choiceTwoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (choiceTwoRadioButton.Checked)
            {
                userAnswer = 2;
            }
        }

        private void choiceThreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (choiceThreeRadioButton.Checked)
            {
                userAnswer = 3;
            }
        }

        private void choiceFourRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (choiceFourRadioButton.Checked)
            {
                userAnswer = 4;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            feedBackLabel.Visible = true;
            feedBackDisplayTextBox.Visible = true;
            currentQuestion = randomSelectedQuestion.ElementAt(numOfQuestionAnswered);
            feedBackDisplayTextBox.Text = currentQuestion.Feedback;

            //progressBar.Value = numOfQuestionAnswered;
            //progressLabel.Text = $"You have answered {numOfQuestionAnswered} out of 3. {correctQuestionNum} answered correctly";

            if (userAnswer == correctAnswer)
            {
                correctQuestionNum++;
                feedBackLabel.Text = "You are corret!";
            }
            else
            {
                feedBackLabel.Text = $"You are wrong. The correct answer is choice {correctAnswer}";
            }
            numOfQuestionAnswered++;
            submitButton.Enabled = false;
            if (numOfQuestionAnswered == 3)
            {
                nextQuestionButton.Enabled = false;
                nextQuestionButton.Visible = false;
                closeGameButton.Visible = true;
            }
            else
            {
                nextQuestionButton.Enabled = true;
            }
            progressBar.Value = numOfQuestionAnswered;
            progressLabel.Text = $"You have answered {numOfQuestionAnswered} out of 3. {correctQuestionNum} answered correctly";
        }

        private void closeGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
  