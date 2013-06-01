using System.Windows.Forms;

namespace Maths_Quiz.Forms
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, System.EventArgs e)
        {
            CenterToScreen();
        }

        private void FormAbout_Click(object sender, System.EventArgs e)
        {
            Close();
        }

    }
}