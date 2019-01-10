using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class EndScreen : Form
    {
        public int Score;
        public int[] scoreArray = new int[5];

        public EndScreen(int score)
        {
            InitializeComponent();
            Score = score;
            lblScore.Text = "Your score was : " + score;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            GameBoard gameBoard = new GameBoard(1);
            StartScreen startScreen = new StartScreen();
            gameBoard.Close();
            startScreen.Close();
            this.Close();
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            this.Hide();
            startScreen.ShowDialog();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {

            if (Score > Convert.ToInt32(lblScore1.Text)) //If Score Is Higher Than #1
            {
                scoreArray[1] = Convert.ToInt32(lblScore1.Text);
                lblScore1.Text = Convert.ToString(Score);
                scoreArray[2] = Convert.ToInt32(lblScore2.Text);
                lblScore2.Text = Convert.ToString(scoreArray[1]);
                scoreArray[3] = Convert.ToInt32(lblScore3.Text);
                lblScore3.Text = Convert.ToString(scoreArray[2]);
                scoreArray[4] = Convert.ToInt32(lblScore4.Text);
                lblScore4.Text = Convert.ToString(scoreArray[3]);
                lblScore5.Text = Convert.ToString(scoreArray[4]);
            }
            else if (Score > Convert.ToInt32(lblScore2.Text)) //If Score Is Higher Than #2
            {
                    scoreArray[1] = Convert.ToInt32(lblScore2.Text);
                    lblScore2.Text = Convert.ToString(Score);
                    scoreArray[2] = Convert.ToInt32(lblScore3.Text);
                    lblScore3.Text = Convert.ToString(scoreArray[1]);
                    scoreArray[3] = Convert.ToInt32(lblScore4.Text);
                    lblScore4.Text = Convert.ToString(scoreArray[2]);
                    lblScore5.Text = Convert.ToString(scoreArray[3]);
            }
            else if (Score > Convert.ToInt32(lblScore3.Text)) //If NewScore Is Higher Than #3
            {
                    scoreArray[1] = Convert.ToInt32(lblScore3.Text);
                    lblScore3.Text = Convert.ToString(Score);
                    scoreArray[2] = Convert.ToInt32(lblScore4.Text);
                    lblScore4.Text = Convert.ToString(scoreArray[1]);
                    lblScore5.Text = Convert.ToString(scoreArray[2]);
            }
            else if (Score > Convert.ToInt32(lblScore4.Text)) //If NewScore Is Higher Than #4
            {
                    scoreArray[1] = Convert.ToInt32(lblScore4.Text);
                    lblScore4.Text = Convert.ToString(Score);
                    lblScore5.Text = Convert.ToString(scoreArray[1]);
            }
            else if (Score > Convert.ToInt32(lblScore5.Text)) //If NewScore Is Higher Than #5
            {
                    scoreArray[1] = Convert.ToInt32(lblScore5.Text);
                    lblScore5.Text = Convert.ToString(Score);
            }
        }
    }
}
