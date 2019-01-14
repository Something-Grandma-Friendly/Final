using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final
{
    public partial class EndScreen : Form
    {

        public EndScreen(int score)
        {
            InitializeComponent();
            lblScore.Text = "Your score was : " + score;                //This sets the score
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            GameBoard gameBoard = new GameBoard(1);
            StartScreen startScreen = new StartScreen();                //This closes all game boards
            gameBoard.Close();
            startScreen.Close();
            this.Close();
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();                //This hides this screen and goes to the start screen to select difficulty
            this.Hide();
            startScreen.ShowDialog();
        }
    }
}
