using System;
using System.Linq;
using System.Windows.Forms;
using Maths_Quiz.Forms;

namespace maths_quiz.Forms
{
    public partial class FormSelect : FormBase
    {
        private readonly int _profileId;

        public FormSelect(int profileId)
        {
            _profileId = profileId;
            InitializeComponent();
        }

        private void FormSelect_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            using (var db = new HighscoresEntities())
            {
                var profileName = (from n in db.Profiles
                             where n.ProfileId == _profileId
                             select n.ProfileName).FirstOrDefault();

                labelWelcome.Text = @"Welcome " + profileName + @"!";
            }
        }

        private void buttonHighscores_Click(object sender, EventArgs e)
        {
            var formHighscores = new FormHighscores(_profileId);
            formHighscores.Show();
            Close();
        }

        private void buttonQuizArithmetic_Click(object sender, EventArgs e)
        {
            var formQuiz = new FormQuiz(_profileId, 1);
            formQuiz.Show();
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is FormProfile);

            if (formToShow != null)
            {
                formToShow.Show();
            }

            Close();
        }

        private void buttonQuizAverages_Click(object sender, EventArgs e)
        {
            var formQuiz = new FormQuiz(_profileId, 2);
            formQuiz.Show();
            Close();
        }

        private void buttonQuizExponents_Click(object sender, EventArgs e)
        {
            var formQuiz = new FormQuiz(_profileId, 3);
            formQuiz.Show();
            Close();
        }
    }
}