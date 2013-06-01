namespace maths_quiz.Forms
{
    partial class FormQuiz
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
            this.timerQuiz = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerQuiz
            // 
            this.timerQuiz.Interval = 1000;
            this.timerQuiz.Tick += new System.EventHandler(this.timerQuiz_Tick);
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(225, 7);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(101, 20);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "Score: ";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelScore.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(12, 7);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(75, 17);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time Left: ";
            this.labelTime.Visible = false;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(45, 48);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(248, 35);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "labelQuestion";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelQuestion.Visible = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(131, 115);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(78, 26);
            this.textBoxAnswer.TabIndex = 2;
            this.textBoxAnswer.Visible = false;
            this.textBoxAnswer.TextChanged += new System.EventHandler(this.textBoxAnswer_TextChanged);
            this.textBoxAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswer_KeyDown);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(176, 89);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.TabStop = false;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(87, 89);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Go back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(56, 7);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(227, 75);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "You will have 60 seconds to answer as many questions as you can. Type your answer" +
    " into the textbox and press enter to submit. For each correct answer you will ga" +
    "in 50 points.";
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(87, 24);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(164, 58);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "labelResult";
            this.labelResult.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(107, 144);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(138, 13);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "Enter a valid whole number!";
            this.labelError.Visible = false;
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 170);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormQuiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerQuiz;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelError;
    }
}