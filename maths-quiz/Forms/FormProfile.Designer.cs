namespace maths_quiz.Forms
{
    partial class FormProfile
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
            this.listBoxProfile = new System.Windows.Forms.ListBox();
            this.buttonCreateProfile = new System.Windows.Forms.Button();
            this.buttonSelectProfile = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelEnterName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProfile
            // 
            this.listBoxProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProfile.FormattingEnabled = true;
            this.listBoxProfile.ItemHeight = 20;
            this.listBoxProfile.Location = new System.Drawing.Point(10, 4);
            this.listBoxProfile.Name = "listBoxProfile";
            this.listBoxProfile.Size = new System.Drawing.Size(185, 124);
            this.listBoxProfile.TabIndex = 0;
            this.listBoxProfile.TabStop = false;
            this.listBoxProfile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProfile_MouseDoubleClick);
            // 
            // buttonCreateProfile
            // 
            this.buttonCreateProfile.Location = new System.Drawing.Point(10, 144);
            this.buttonCreateProfile.Name = "buttonCreateProfile";
            this.buttonCreateProfile.Size = new System.Drawing.Size(80, 26);
            this.buttonCreateProfile.TabIndex = 1;
            this.buttonCreateProfile.TabStop = false;
            this.buttonCreateProfile.Text = "Create Profile";
            this.buttonCreateProfile.UseVisualStyleBackColor = true;
            this.buttonCreateProfile.Click += new System.EventHandler(this.buttonCreateProfile_Click);
            // 
            // buttonSelectProfile
            // 
            this.buttonSelectProfile.Location = new System.Drawing.Point(115, 144);
            this.buttonSelectProfile.Name = "buttonSelectProfile";
            this.buttonSelectProfile.Size = new System.Drawing.Size(80, 26);
            this.buttonSelectProfile.TabIndex = 2;
            this.buttonSelectProfile.TabStop = false;
            this.buttonSelectProfile.Text = "Select Profile";
            this.buttonSelectProfile.UseVisualStyleBackColor = true;
            this.buttonSelectProfile.Click += new System.EventHandler(this.buttonSelectProfile_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(71, 11);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(124, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TabStop = false;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(10, 37);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.TabStop = false;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(120, 37);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, -1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSelectProfile);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxProfile);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCreateProfile);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelEnterName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxName);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainer1.Panel2.Controls.Add(this.buttonOK);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(202, 243);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 7;
            // 
            // labelEnterName
            // 
            this.labelEnterName.AutoSize = true;
            this.labelEnterName.Location = new System.Drawing.Point(27, 14);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(38, 13);
            this.labelEnterName.TabIndex = 6;
            this.labelEnterName.Text = "Name:";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 174);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProfile";
            this.Text = "Select a Profile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProfile;
        private System.Windows.Forms.Button buttonCreateProfile;
        private System.Windows.Forms.Button buttonSelectProfile;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelEnterName;
    }
}