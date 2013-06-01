namespace maths_quiz.Forms
{
    partial class FormHighscores
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
            this.dataGridViewHighscores = new System.Windows.Forms.DataGridView();
            this.comboBoxLevels = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighscores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHighscores
            // 
            this.dataGridViewHighscores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHighscores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHighscores.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewHighscores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHighscores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewHighscores.Location = new System.Drawing.Point(11, 32);
            this.dataGridViewHighscores.Name = "dataGridViewHighscores";
            this.dataGridViewHighscores.RowHeadersVisible = false;
            this.dataGridViewHighscores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHighscores.Size = new System.Drawing.Size(301, 263);
            this.dataGridViewHighscores.TabIndex = 0;
            // 
            // comboBoxLevels
            // 
            this.comboBoxLevels.FormattingEnabled = true;
            this.comboBoxLevels.Location = new System.Drawing.Point(120, 5);
            this.comboBoxLevels.Name = "comboBoxLevels";
            this.comboBoxLevels.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLevels.TabIndex = 1;
            this.comboBoxLevels.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevels_SelectedIndexChanged);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(84, 9);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(39, 13);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "Level: ";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(11, 301);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Go back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormHighscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 329);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.comboBoxLevels);
            this.Controls.Add(this.dataGridViewHighscores);
            this.Name = "FormHighscores";
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.FormHighscores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighscores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHighscores;
        private System.Windows.Forms.ComboBox comboBoxLevels;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Button buttonBack;






    }
}