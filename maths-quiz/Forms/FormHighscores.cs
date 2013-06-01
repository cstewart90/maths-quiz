using System;
using System.Linq;
using Maths_Quiz.Forms;

namespace maths_quiz.Forms
{
    public partial class FormHighscores : FormBase
    {
        private readonly int _profileId;

        public FormHighscores(int profileId)
        {
            _profileId = profileId;
            InitializeComponent();
        }

        private void FormHighscores_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            GetLevels();
            comboBoxLevels.SelectedIndex = 0;
            GetHighscores(1);
        }

        private void comboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var levelId = comboBoxLevels.SelectedIndex + 1;
            GetHighscores(levelId);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formSelect = new FormSelect(_profileId);
            formSelect.Show();
            Close();
        }

        // Get the list of levels and fill the combobox with them
        private void GetLevels()
        {
            using (var db = new HighscoresEntities())
            {
                var query = from l in db.Levels
                            select l.LevelName;

                foreach (var level in query)
                {
                    comboBoxLevels.Items.Add(level);
                }

            }
        }

        // Get the highscores from the database for the selected level
        private void GetHighscores(int levelId)
        {
            using (var db = new HighscoresEntities())
            {
                var query = from g in db.Games
                            join p in db.Profiles on g.ProfileId equals p.ProfileId
                            where g.LevelId == levelId
                            orderby g.Score descending
                            select new {p.ProfileName, g.Score, g.Date};

                dataGridViewHighscores.DataSource = query.ToList();
                dataGridViewHighscores.Columns[0].HeaderText = @"Name";
            }
        }

    }
}