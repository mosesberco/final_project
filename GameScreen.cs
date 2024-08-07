﻿using final_project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class GameScreen : Form
    {
        private User user;
        private class QuestionData
        {
            public string ImageName { get; set; }
            public Dictionary<string, int> AnimalCounts { get; set; }
        }

        private List<QuestionData> questions = new List<QuestionData>
        {
        new QuestionData
        {
            ImageName = "q1",
            AnimalCounts = new Dictionary<string, int>
            {
                { "dog", 2 },
                { "cat", 3 },
                { "elephant", 1 },
                { "tiger", 0 },
                { "monkey", 0 },

            }
        },
         new QuestionData
        {
            ImageName = "q2",
            AnimalCounts = new Dictionary<string, int>
            {
                { "dog", 2 },
                { "cat", 2 },
                { "elephant", 2 },
                { "tiger", 0 },
                { "monkey", 0 },
            }
        },
         new QuestionData
        {
            ImageName = "q3",
            AnimalCounts = new Dictionary<string, int>
            {
                { "dog", 1 },
                { "cat", 1 },
                { "elephant", 2 },
                { "tiger", 1 },
                { "monkey", 1 },
            }
        },
          new QuestionData
        {
            ImageName = "q4",
            AnimalCounts = new Dictionary<string, int>
            {
                { "dog", 0 },
                { "cat", 0 },
                { "elephant", 1 },
                { "tiger", 2 },
                { "monkey", 3 },
            }
        },
            new QuestionData
        {
            ImageName = "q5",
            AnimalCounts = new Dictionary<string, int>
            {
                { "dog", 1 },
                { "cat", 0 },
                { "elephant", 1 },
                { "tiger", 2 },
                { "monkey", 2 },
            }
        },
                 new QuestionData
        {
            ImageName = "q6",
            AnimalCounts = new Dictionary<string, int>
            {
                { "dog", 0 },
                { "cat", 2 },
                { "elephant", 2 },
                { "tiger", 1 },
                { "monkey", 1 },
            }
        },
        // Add more questions here
        };


        private Random random = new Random();
        private PictureBox largePictureBox;
        private PictureBox[] smallPictureBoxes;
        private Button[] submitButtons;
        private TextBox[] answerTextBoxes;
        private string[] animalImages = { "cat", "dog", "elephant", "tiger", "monkey" }; // Add all animal image names without .png
        private QuestionData currentQuestion;
        private int score = 0;
        private int roundsCompleted = 0;
        private Timer gameTimer;
        private int timeLeft = 60;
        private bool roundCompleted = false;


        public GameScreen(User user)
        {
            this.user = user;
            InitializeComponent();
            SetupControls();
            SetupTimer();
            UpdateUserInfo();
            NewRound();
        }

        private void SetupControls()
        {
            largePictureBox = pictureBoxQuestion;
            smallPictureBoxes = new PictureBox[] { pictureBoxAnswer1, pictureBoxAnswer2, pictureBoxAnswer3 };
            submitButtons = new Button[] { buttonSubmit1, buttonSubmit2, buttonSubmit3 };
            answerTextBoxes = new TextBox[] { textBoxAnswer1, textBoxAnswer2, textBoxAnswer3 };
            buttonExit.Click += buttonExit_Click;
            for (int i = 0; i < submitButtons.Length; i++)
            {
                int index = i;
                submitButtons[i].Click += (sender, e) => CheckAnswer(index);
            }

            // Set up timerLabel
            timerLabel.Font = new Font("Gill Sans MT", 12, FontStyle.Bold);
            timerLabel.ForeColor = Color.White;
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(950, 20);

            // Set up userInfoLabel
            userInfoLabel.Font = new Font("Gill Sans MT", 12);
            userInfoLabel.ForeColor = Color.White;
            userInfoLabel.AutoSize = true;
            userInfoLabel.Location = new Point(1160,0);
        }

        private void SetupTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000; // 1 second
            gameTimer.Tick += GameTimer_Tick;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            UpdateTimerDisplay();

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                EndRound();
            }
        }

        private void UpdateTimerDisplay()
        {
            timerLabel.Text = $"Time: {timeLeft}s";
        }

        private void UpdateUserInfo()
        {
            userInfoLabel.Text = $"User: {user.Username}\nID: {user.ID}\nBalance: ${user.Balance}";
        }

        private void NewRound()
        {
            currentQuestion = questions[random.Next(questions.Count)];
            largePictureBox.Image = (Image)Resources.ResourceManager.GetObject(currentQuestion.ImageName);

            List<string> roundAnimals = new List<string>(animalImages);
            roundAnimals = roundAnimals.OrderBy(a => random.Next()).ToList();

            for (int i = 0; i < smallPictureBoxes.Length; i++)
            {
                smallPictureBoxes[i].Image = (Image)Resources.ResourceManager.GetObject(roundAnimals[i]);
                smallPictureBoxes[i].Tag = roundAnimals[i];
                answerTextBoxes[i].Clear();
                submitButtons[i].Enabled = true;
            }

            roundCompleted = false;
            timeLeft = 60;
            UpdateTimerDisplay();
            gameTimer.Start();
        }

        private void CheckAnswer(int index)
        {
            string animal = (string)smallPictureBoxes[index].Tag;
            if (int.TryParse(answerTextBoxes[index].Text, out int count))
            {
                int correctCount = currentQuestion.AnimalCounts[animal];
                if (count == correctCount)
                {
                    MessageBox.Show("Good Job!");
                    submitButtons[index].Enabled = false;
                }
                else
                {
                    MessageBox.Show("Try again :)");
                }
            }
            else
            {
                MessageBox.Show("Not valid number, please try again");
            }

            if (submitButtons.All(b => !b.Enabled))
            {
                roundCompleted = true;
                EndRound();
            }
        }

        private void EndRound()
        {
            gameTimer.Stop();
            roundsCompleted++;

            if (roundCompleted)
            {
                user.UpdateBalance(new Database(), user.Balance + 10);
                UpdateUserInfo();
                MessageBox.Show($"Round completed! You earned 10 coins. New balance: ${user.Balance}");
            }
            else
            {
                MessageBox.Show($"Time's up! Round not completed, Your balance remains: ${user.Balance}");
            }

            roundCompleted = false;
            NewRound();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            gameTimer.Stop();
            var DB = new Database();
            DB.SetBalance(int.Parse(user.ID), user.Balance);
        }
    }
}

