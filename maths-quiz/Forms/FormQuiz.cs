using System;
using System.Linq;
using System.Windows.Forms;
using Maths_Quiz.Forms;

namespace maths_quiz.Forms
{
    public partial class FormQuiz : FormBase
    {
        private readonly Random _random = new Random();
        private readonly int _levelId;
        private readonly int _profileId;
        private int _answer;
        private int _score;
        private int _seconds;


        public FormQuiz(int profileId, int levelId)
        {
            _profileId = profileId;
            _levelId = levelId;

            InitializeComponent();
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            timerQuiz.Enabled = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formSelect = new FormSelect(_profileId);
            formSelect.Show();

            Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void textBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return) return;

            try
            {
                int enteredAnswer = Convert.ToInt32(textBoxAnswer.Text);

                if (enteredAnswer == _answer)
                {
                    _score += 50;
                    labelScore.Text = @"Score: " + _score;
                }

                GetNewQuestion();
            }
            catch (Exception)
            {
                labelError.Visible = true;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        // Get new question
        private void GetNewQuestion()
        {
            switch (_levelId)
            {
                case 1:
                    ArithmeticQuizQuestion();
                    break;
                case 2:
                    AveragesQuizQuestion();
                    break;
                case 3:
                    ExponentsQuizQuestion();
                    break;
            }
        }

        // Sets question and answer for Arithmetic Quiz
        private void ArithmeticQuizQuestion()
        {
            string[] operations = {"+", "-", "×", "÷"};
            int num1 = RandomNumber(0, 12);
            int num2 = RandomNumber(0, 12);
            string operation = operations[RandomNumber(0, operations.Length - 1)];

            string question = num1 + " " + operation + " " + num2;

            if (operation == "+")
            {
                _answer = num1 + num2;
            }
            else if (operation == "-")
            {
                _answer = num1 - num2;
            }
            else if (operation == "×")
            {
                _answer = num1*num2;
            }
            else
            {
                do
                {
                    num1 = RandomNumber(0, 12);
                    num2 = RandomNumber(1, 12);
                    question = num1 + " " + operation + " " + num2;
                } while (num1%num2 != 0);

                _answer = num1/num2;
            }

            labelQuestion.Text = question;
            textBoxAnswer.Text = string.Empty;
        }

        // Sets question and answer for Averages Quiz
        private void AveragesQuizQuestion()
        {
            int amount = RandomNumber(3, 4);

            int num1, num2, num3, num4, total;

            if (amount == 3)
            {
                do
                {
                    num1 = RandomNumber(0, 12);
                    num2 = RandomNumber(0, 12);
                    num3 = RandomNumber(0, 12);
                    total = num1 + num2 + num3;
                } while (total%3 != 0);

                string question = @"{ " + num1 + @" , " + num2 + @" , " + num3 + @" }";
                labelQuestion.Text = question;

                _answer = (total/3);
            }

            else if (amount == 4)
            {
                do
                {
                    num1 = RandomNumber(0, 10);
                    num2 = RandomNumber(0, 10);
                    num3 = RandomNumber(0, 10);
                    num4 = RandomNumber(0, 10);
                    total = num1 + num2 + num3 + num4;
                } while (total%4 != 0);

                string question = @"{ " + num1 + @" , " + num2 + @" , " + num3 + @" , " + num4 + @" }";
                labelQuestion.Text = question;

                _answer = (total/4);
            }

            textBoxAnswer.Text = string.Empty;
        }

        // Sets question and answer for Exponents Quiz
        private void ExponentsQuizQuestion()
        {
            int power = RandomNumber(2, 3);

            if (power == 2)
            {
                int number = RandomNumber(0, 20);
                string question = number + @"²";
                labelQuestion.Text = question;
                _answer = number*number;
            }
            else if (power == 3)
            {
                int number = RandomNumber(0, 10);
                string question = number + @"³";
                labelQuestion.Text = question;
                _answer = number*number*number;
            }

            textBoxAnswer.Text = string.Empty;
        }

        // Start the quiz
        private void StartQuiz()
        {
            timerQuiz.Enabled = true;

            _seconds = 60;
            _score = 0;

            labelTime.Text = @"Time left: " + 0;
            labelScore.Text = @"Score: " + 0;

            labelResult.Visible = false;
            labelInfo.Visible = false;
            buttonStart.Visible = false;
            buttonBack.Visible = false;

            textBoxAnswer.Enabled = true;

            labelScore.Visible = true;
            labelTime.Visible = true;
            labelQuestion.Visible = true;
            textBoxAnswer.Visible = true;

            GetNewQuestion();

            textBoxAnswer.Focus();
        }

        // Stop the quiz
        private void StopQuiz()
        {
            timerQuiz.Enabled = false;

            buttonStart.Visible = true;
            buttonBack.Visible = true;

            textBoxAnswer.Enabled = false;

            labelScore.Visible = false;
            labelTime.Visible = false;
            labelQuestion.Visible = false;
            textBoxAnswer.Visible = false;

            ShowResult();
            EnterResult();
        }

        // Decrements _seconds by 1 every second and stops quiz when _seconds reaches 0
        private void timerQuiz_Tick(object sender, EventArgs e)
        {
            _seconds--;

            labelTime.Text = @"Time left: " + _seconds;

            if (_seconds == 0)
            {
                StopQuiz();
            }
        }

        // Get current profile name using a query
        private string GetProfileName()
        {
            using (var db = new HighscoresEntities())
            {
                return (from n in db.Profiles
                        where n.ProfileId == _profileId
                        select n.ProfileName).FirstOrDefault();
            }
        }

        // Enter the result into the database
        private void EnterResult()
        {
            using (var db = new HighscoresEntities())
            {
                var game = new Game {Date = DateTime.Now, LevelId = _levelId, ProfileId = _profileId, Score = _score};

                db.Games.Add(game);
                db.SaveChanges();
            }
        }

        // Show the result
        private void ShowResult()
        {
            labelResult.Visible = true;
            labelResult.Text = @"Congratulations " + GetProfileName() + @" you got a score of " + _score;

            buttonStart.Text = @"Try again";
        }

        // Generate random integer
        private int RandomNumber(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}