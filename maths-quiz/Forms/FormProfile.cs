using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Maths_Quiz.Forms;

namespace maths_quiz.Forms
{
    public partial class FormProfile : FormBase
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            CollapseForm();

            // Create the database if it doesn't exist
            if (!File.Exists("Highscores.sdf"))
            {
                // Create database and add the levels to it
                using (var db = new HighscoresEntities())
                {
                    var level1 = new Level {LevelName = "Arithmetic"};
                    var level2 = new Level {LevelName = "Averages"};
                    var level3 = new Level {LevelName = "Exponents"};

                    db.Database.Create();
                    db.Levels.Add(level1);
                    db.Levels.Add(level2);
                    db.Levels.Add(level3);
                    db.SaveChanges();
                }
            }

            GetData();
        }

        // Expands form when create profile button is clicked
        private void buttonCreateProfile_Click(object sender, EventArgs e)
        {
            ExpandForm();
        }

        // Selects currently selected profile
        private void buttonSelectProfile_Click(object sender, EventArgs e)
        {
            SelectProfile();
        }

        // Adds profile to database and updates listbox when ok button is clicked
        private void buttonOK_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            AddProfileToDatabase(name);
            GetData();
        }

        // Collapses form back to default when cancel button is clicked
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            CollapseForm();
        }

        // Adds the option of using enter key instead of pressing select.
        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return) return;
            {
                var name = textBoxName.Text;
                AddProfileToDatabase(name);
                GetData();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Adds the option to double click a profile to select it
        private void listBoxProfile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxProfile.SelectedIndex != -1)
            {
                var rect = listBoxProfile.GetItemRectangle(listBoxProfile.SelectedIndex);
                if (rect.Contains(e.Location))
                {
                    SelectProfile();
                }
            }
        }
        // Expand form downwards and shows textinput and buttons to enter name
        private void ExpandForm()
        {
            splitContainer1.Panel2Collapsed = false;
            Height = 300;
            textBoxName.Focus();
        }

        // Collapses form back to default
        private void CollapseForm()
        {
            splitContainer1.Panel2Collapsed = true;
            Height = 235;
            listBoxProfile.Focus();
        }

        // Get all the profile names from the database by a query and adds them all to the listbox
        private void GetData()
        {
            using (var db = new HighscoresEntities())
            {
                listBoxProfile.DataSource = db.Profiles.OrderBy(n => n.ProfileId).Select(n => n.ProfileName).ToList();
            }
        }

        // Create new profile using Entity Framework and save the changes to the database
        private void AddProfileToDatabase(String name)
        {
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show(@"Please enter a name");
                return;
            }

            if (textBoxName.Text.Length > 20)
            {
                MessageBox.Show(@"There is a limit of 20 characters" + Environment.NewLine +
                                @"You entered " + textBoxName.Text.Length + @" characters");
                return;
            }

            using (var db = new HighscoresEntities())
            {
                var profile = new Profile {ProfileName = name};
              
                db.Profiles.Add(profile);
                db.SaveChanges();
            }

            textBoxName.Clear();
            CollapseForm();
        }


        // Close this form, pass selected profile information to the main form and open it. 
        private void SelectProfile()
        {
            if (listBoxProfile.SelectedIndex == -1)
            {
                MessageBox.Show(@"No Profile Selected");
            }
            else
            {
                var profileId = listBoxProfile.SelectedIndex + 1;

                Hide(); // hide current form

                var formSelect = new FormSelect(profileId);
                formSelect.Show();
            }
        }

    }
}