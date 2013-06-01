namespace Maths_Quiz.Forms
{
    partial class FormBase
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
            this.mainMenuBase = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemClearDatabase = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenuBase
            // 
            this.mainMenuBase.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemClearDatabase,
            this.menuItemExit});
            this.menuItem1.Text = "File";
            // 
            // menuItemClearDatabase
            // 
            this.menuItemClearDatabase.Index = 0;
            this.menuItemClearDatabase.Text = "Clear Database";
            this.menuItemClearDatabase.Click += new System.EventHandler(this.menuItemClearDatabase_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 1;
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemHelp,
            this.menuItemAbout});
            this.menuItem2.Text = "Help";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 0;
            this.menuItemHelp.Text = "Help";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemHelp_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 1;
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 65);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Menu = this.mainMenuBase;
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenuBase;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItemClearDatabase;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private System.Windows.Forms.MenuItem menuItemAbout;
    }
}