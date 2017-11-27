namespace TriviaNow
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.triviaPictureBox = new System.Windows.Forms.PictureBox();
            this.answerChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.choiceFourRadioButton = new System.Windows.Forms.RadioButton();
            this.choiceThreeRadioButton = new System.Windows.Forms.RadioButton();
            this.choiceTwoRadioButton = new System.Windows.Forms.RadioButton();
            this.choiceOneRadioButton = new System.Windows.Forms.RadioButton();
            this.progressLabel = new System.Windows.Forms.Label();
            this.feedBackLabel = new System.Windows.Forms.Label();
            this.feedBackDisplayTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.closeGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.triviaPictureBox)).BeginInit();
            this.answerChoiceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(271, 627);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(346, 43);
            this.progressBar.TabIndex = 1;
            // 
            // triviaPictureBox
            // 
            this.triviaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("triviaPictureBox.Image")));
            this.triviaPictureBox.Location = new System.Drawing.Point(12, 564);
            this.triviaPictureBox.Name = "triviaPictureBox";
            this.triviaPictureBox.Size = new System.Drawing.Size(253, 106);
            this.triviaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.triviaPictureBox.TabIndex = 2;
            this.triviaPictureBox.TabStop = false;
            // 
            // answerChoiceGroupBox
            // 
            this.answerChoiceGroupBox.Controls.Add(this.submitButton);
            this.answerChoiceGroupBox.Controls.Add(this.nextQuestionButton);
            this.answerChoiceGroupBox.Controls.Add(this.choiceFourRadioButton);
            this.answerChoiceGroupBox.Controls.Add(this.choiceThreeRadioButton);
            this.answerChoiceGroupBox.Controls.Add(this.choiceTwoRadioButton);
            this.answerChoiceGroupBox.Controls.Add(this.choiceOneRadioButton);
            this.answerChoiceGroupBox.Location = new System.Drawing.Point(12, 170);
            this.answerChoiceGroupBox.Name = "answerChoiceGroupBox";
            this.answerChoiceGroupBox.Size = new System.Drawing.Size(605, 203);
            this.answerChoiceGroupBox.TabIndex = 3;
            this.answerChoiceGroupBox.TabStop = false;
            this.answerChoiceGroupBox.Text = "Choice";
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(455, 164);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(144, 33);
            this.nextQuestionButton.TabIndex = 4;
            this.nextQuestionButton.Text = "Next Question";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // choiceFourRadioButton
            // 
            this.choiceFourRadioButton.AutoSize = true;
            this.choiceFourRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceFourRadioButton.Location = new System.Drawing.Point(7, 164);
            this.choiceFourRadioButton.Name = "choiceFourRadioButton";
            this.choiceFourRadioButton.Size = new System.Drawing.Size(101, 20);
            this.choiceFourRadioButton.TabIndex = 3;
            this.choiceFourRadioButton.TabStop = true;
            this.choiceFourRadioButton.Text = "radioButton4";
            this.choiceFourRadioButton.UseVisualStyleBackColor = true;
            this.choiceFourRadioButton.CheckedChanged += new System.EventHandler(this.choiceFourRadioButton_CheckedChanged);
            // 
            // choiceThreeRadioButton
            // 
            this.choiceThreeRadioButton.AutoSize = true;
            this.choiceThreeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceThreeRadioButton.Location = new System.Drawing.Point(7, 113);
            this.choiceThreeRadioButton.Name = "choiceThreeRadioButton";
            this.choiceThreeRadioButton.Size = new System.Drawing.Size(101, 20);
            this.choiceThreeRadioButton.TabIndex = 2;
            this.choiceThreeRadioButton.TabStop = true;
            this.choiceThreeRadioButton.Text = "radioButton3";
            this.choiceThreeRadioButton.UseVisualStyleBackColor = true;
            this.choiceThreeRadioButton.CheckedChanged += new System.EventHandler(this.choiceThreeRadioButton_CheckedChanged);
            // 
            // choiceTwoRadioButton
            // 
            this.choiceTwoRadioButton.AutoSize = true;
            this.choiceTwoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceTwoRadioButton.Location = new System.Drawing.Point(6, 63);
            this.choiceTwoRadioButton.Name = "choiceTwoRadioButton";
            this.choiceTwoRadioButton.Size = new System.Drawing.Size(101, 20);
            this.choiceTwoRadioButton.TabIndex = 1;
            this.choiceTwoRadioButton.TabStop = true;
            this.choiceTwoRadioButton.Text = "radioButton2";
            this.choiceTwoRadioButton.UseVisualStyleBackColor = true;
            this.choiceTwoRadioButton.CheckedChanged += new System.EventHandler(this.choiceTwoRadioButton_CheckedChanged);
            // 
            // choiceOneRadioButton
            // 
            this.choiceOneRadioButton.AutoSize = true;
            this.choiceOneRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceOneRadioButton.Location = new System.Drawing.Point(7, 20);
            this.choiceOneRadioButton.Name = "choiceOneRadioButton";
            this.choiceOneRadioButton.Size = new System.Drawing.Size(101, 20);
            this.choiceOneRadioButton.TabIndex = 0;
            this.choiceOneRadioButton.TabStop = true;
            this.choiceOneRadioButton.Text = "radioButton1";
            this.choiceOneRadioButton.UseVisualStyleBackColor = true;
            this.choiceOneRadioButton.CheckedChanged += new System.EventHandler(this.choiceOneRadioButton_CheckedChanged);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(271, 592);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(46, 18);
            this.progressLabel.TabIndex = 4;
            this.progressLabel.Text = "label1";
            // 
            // feedBackLabel
            // 
            this.feedBackLabel.AutoSize = true;
            this.feedBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedBackLabel.Location = new System.Drawing.Point(16, 419);
            this.feedBackLabel.Name = "feedBackLabel";
            this.feedBackLabel.Size = new System.Drawing.Size(71, 16);
            this.feedBackLabel.TabIndex = 5;
            this.feedBackLabel.Text = "FeedBack";
            // 
            // feedBackDisplayTextBox
            // 
            this.feedBackDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedBackDisplayTextBox.Location = new System.Drawing.Point(12, 447);
            this.feedBackDisplayTextBox.Multiline = true;
            this.feedBackDisplayTextBox.Name = "feedBackDisplayTextBox";
            this.feedBackDisplayTextBox.Size = new System.Drawing.Size(605, 60);
            this.feedBackDisplayTextBox.TabIndex = 6;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoEllipsis = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextLabel.Location = new System.Drawing.Point(12, 29);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.questionTextLabel.Size = new System.Drawing.Size(605, 111);
            this.questionTextLabel.TabIndex = 7;
            this.questionTextLabel.Text = "label1";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(455, 125);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(144, 33);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit Answer";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // closeGameButton
            // 
            this.closeGameButton.Location = new System.Drawing.Point(467, 409);
            this.closeGameButton.Name = "closeGameButton";
            this.closeGameButton.Size = new System.Drawing.Size(144, 33);
            this.closeGameButton.TabIndex = 6;
            this.closeGameButton.Text = "Close Game Window";
            this.closeGameButton.UseVisualStyleBackColor = true;
            this.closeGameButton.Click += new System.EventHandler(this.closeGameButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 682);
            this.Controls.Add(this.closeGameButton);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.feedBackDisplayTextBox);
            this.Controls.Add(this.feedBackLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.answerChoiceGroupBox);
            this.Controls.Add(this.triviaPictureBox);
            this.Controls.Add(this.progressBar);
            this.Name = "GameForm";
            this.Text = "Trivia Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.triviaPictureBox)).EndInit();
            this.answerChoiceGroupBox.ResumeLayout(false);
            this.answerChoiceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox triviaPictureBox;
        private System.Windows.Forms.GroupBox answerChoiceGroupBox;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.RadioButton choiceFourRadioButton;
        private System.Windows.Forms.RadioButton choiceThreeRadioButton;
        private System.Windows.Forms.RadioButton choiceTwoRadioButton;
        private System.Windows.Forms.RadioButton choiceOneRadioButton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label feedBackLabel;
        private System.Windows.Forms.TextBox feedBackDisplayTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button closeGameButton;
    }
}