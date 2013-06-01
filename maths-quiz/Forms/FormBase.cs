using System;
using System.Linq;
using System.Windows.Forms;
using maths_quiz;

namespace Maths_Quiz.Forms
{
    public partial class FormBase : Form
    {
        public const int ScClose = 0xF060;
        public const int WmSyscommand = 0x0112;

        public FormBase()
        {
            InitializeComponent();
        }

        // Captures the user pressing alt-f4 and clicking on X(Close button)
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WmSyscommand && (int) m.WParam == ScClose)
            {
                Application.Exit();
            }

            base.WndProc(ref m);
        }

        private void menuItemClearDatabase_Click(object sender, EventArgs e)
        {
            // Delete database
            using (var db = new HighscoresEntities())
            {
                db.Database.Delete();
            }

            // Restart Application
            Application.Restart();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemHelp_Click(object sender, EventArgs e)
        {

        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is FormAbout);

            // If about window is already open it will switc to it instead of creating another about window.
            if (formToShow != null)
            {
                formToShow.Show();
                formToShow.Focus();
            }
            else
            {
                var formAbout = new FormAbout();
                formAbout.Show();
            }

        }
    }
}