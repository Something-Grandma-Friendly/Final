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
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader("Resources/NewScore.txt");
            List<int> list = new List<int>();
            TextWriter txt = new StreamWriter("resources/NewScore.txt");
            txt.Write(Score);
            while ((line = file.ReadLine()) != null  )
            {
                listBox1.Items.Add(line);
                list.Add(int.Parse(line));
                counter++;
            }
            int[] scoreArr = list.ToArray();
            Array.Sort(scoreArr);
            foreach(int item in scoreArr)
            {

                listBox2.Items.Add(item);
            }
        }
    }
}
