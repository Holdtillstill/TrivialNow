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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TriviaNow
{
    public partial class MainWindow : Form
    {
        BindingList<Question> questionList;
        Question selectedQuestion;
        QuestionDetails detailForm;
        GameForm triviaGame;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                FileStream file = new FileStream("questionData.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                questionList = (BindingList<Question>)bf.Deserialize(file);
                file.Close();
            }
            catch (Exception)
            {
                statusLabel.Text = "Data loading not successful";
            }
        }
        
        private void SaveData()
        {
            try
            {
                FileStream file = new FileStream("questionData.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, questionList);
                file.Close();
            }
            catch (Exception)
            {

            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            questionList = new BindingList<Question>();
            LoadData();
            questionListBox.DataSource = questionList;
            statusLabel.Text = string.Empty;
            


        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailForm = new QuestionDetails();
            detailForm.Show();
            detailForm.QuestionAdded += new EventHandler(this.QuestionDetailForm_QuestionAdded);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
            System.Environment.Exit(0);
        }

        private void questionListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (questionListBox.SelectedItem == null)
            {
                return;
            }
            selectedQuestion = (Question)questionListBox.SelectedItem;

            detailForm = new QuestionDetails();

            detailForm.QuestionUpdated += new EventHandler(this.QuestionDetailForm_QuestionUpdated);
            
            detailForm.Show();
            detailForm.ViewQuestion(selectedQuestion);
        }

        private void QuestionDetailForm_QuestionUpdated(object sender, EventArgs e)
        {
            if(e is QuestionEventArgs)
            {
                QuestionEventArgs tmpArgs = (QuestionEventArgs)e;
                Question tmpQuestion = tmpArgs.Question;
                statusLabel.Text = "Question updated";
                timer.Enabled = true;

                questionList.ResetBindings();
            }
        }

        private void QuestionDetailForm_QuestionAdded(object sender, EventArgs e)
        {
            if (e is QuestionEventArgs)
            {
                QuestionEventArgs tmpArgs = (QuestionEventArgs)e;
                Question tmpQuestion = tmpArgs.Question;
                questionList.Add(tmpQuestion);
                statusLabel.Text = "New question added";
                timer.Enabled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            statusLabel.Text = string.Empty;
        }

        

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem == null)
            {
                return;
            }
            selectedQuestion = (Question)questionListBox.SelectedItem;
            questionList.Remove(selectedQuestion);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyWord;
            BindingList<Question> searchResultList;
            searchResultList = new BindingList<Question>();
            
            if (searchTextBox.Text == string.Empty)
            {
                questionListBox.DataSource = questionList;
                return;
            }
            else
            {
                keyWord = (string)searchTextBox.Text;
            }
            
            foreach (Question q in questionList)
            {
                if (q.QuestionText.Contains(keyWord) || q.Choices.Contains(keyWord) || q.Feedback.Contains(keyWord))
                {
                    searchResultList.Add(q);
                    questionListBox.DataSource = searchResultList;
                }
            }
            searchResultList.ResetBindings();
            //Clear textbox so that next time if user click button again without typing anything into textbox
            //listbox will refresh and show list of all questions again
            searchTextBox.Clear();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            triviaGame = new GameForm();
            triviaGame.SetData(questionList);
            triviaGame.Show();
        }
    }
}
