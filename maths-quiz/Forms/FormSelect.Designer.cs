namespace maths_quiz.Forms
{
    partial class FormSelect
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonHighscores = new System.Windows.Forms.Button();
            this.buttonQuizArithmetic = new System.Windows.Forms.Button();
            this.labelChoose = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonQuizAverages = new System.Windows.Forms.Button();
            this.buttonQuizExponents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(8, 4);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(74, 13);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "labelWelcome";
            // 
            // buttonHighscores
            // 
            this.buttonHighscores.Location = new System.Drawing.Point(92, 139);
            this.buttonHighscores.Name = "buttonHighscores";
            this.buttonHighscores.Size = new System.Drawing.Size(75, 23);
            this.buttonHighscores.TabIndex = 1;
            this.buttonHighscores.TabStop = false;
            this.buttonHighscores.Text = "Highscores";
            this.buttonHighscores.UseVisualStyleBackColor = true;
            this.buttonHighscores.Click += new System.EventHandler(this.buttonHighscores_Click);
            // 
            // buttonQuizArithmetic
            // 
            this.buttonQuizArithmetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuizArithmetic.Location = new System.Drawing.Point(49, 79);
            this.buttonQuizArithmetic.Name = "buttonQuizArithmetic";
            this.buttonQuizArithmetic.Size = new System.Drawing.Size(75, 33);
            this.buttonQuizArithmetic.TabIndex = 2;
            this.buttonQuizArithmetic.TabStop = false;
            this.buttonQuizArithmetic.Text = "Arithmetic";
            this.buttonQuizArithmetic.UseVisualStyleBackColor = true;
            this.buttonQuizArithmetic.Click += new System.EventHandler(this.buttonQuizArithmetic_Click);
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.Location = new System.Drawing.Point(124, 38);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(117, 20);
            this.labelChoose.TabIndex = 3;
            this.labelChoose.Text = "Choose a Quiz!";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(7, 139);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Go back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonQuizAverages
            // 
            this.buttonQuizAverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuizAverages.Location = new System.Drawing.Point(144, 79);
            this.buttonQuizAverages.Name = "buttonQuizAverages";
            this.buttonQuizAverages.Size = new System.Drawing.Size(75, 33);
            this.buttonQuizAverages.TabIndex = 5;
            this.buttonQuizAverages.TabStop = false;
            this.buttonQuizAverages.Text = "Averages";
            this.buttonQuizAverages.UseVisualStyleBackColor = true;
            this.buttonQuizAverages.Click += new System.EventHandler(this.buttonQuizAverages_Click);
            // 
            // buttonQuizExponents
            // 
            this.buttonQuizExponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuizExponents.Location = new System.Drawing.Point(236, 79);
            this.buttonQuizExponents.Name = "buttonQuizExponents";
            this.buttonQuizExponents.Size = new System.Drawing.Size(75, 33);
            this.buttonQuizExponents.TabIndex = 6;
            this.buttonQuizExponents.TabStop = false;
            this.buttonQuizExponents.Text = "Exponents";
            this.buttonQuizExponents.UseVisualStyleBackColor = true;
            this.buttonQuizExponents.Click += new System.EventHandler(this.buttonQuizExponents_Click);
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 172);
            this.Controls.Add(this.buttonQuizExponents);
            this.Controls.Add(this.buttonQuizAverages);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.buttonQuizArithmetic);
            this.Controls.Add(this.buttonHighscores);
            this.Controls.Add(this.labelWelcome);
            this.Name = "FormSelect";
            this.Text = "Maths Quiz";
            this.Load += new System.EventHandler(this.FormSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonHighscores;
        private System.Windows.Forms.Button buttonQuizArithmetic;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonQuizAverages;
        private System.Windows.Forms.Button buttonQuizExponents;
    }
}