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
    public partial class StartScreen : Form
    {

        public int speed;

        public StartScreen()
        {
            InitializeComponent();
        }

        private void btnWeak_Click(object sender, EventArgs e)                  //These buttons set difficulty. This is the easiest
        {
            speed = 1;
            GameBoard myForm = new GameBoard(speed);
            this.Close();
            myForm.ShowDialog();                                                //These open the Gameboard form
            this.Show();
        }

        private void btnRespectable_Click(object sender, EventArgs e)           //This is the medium difficulty
        {
            speed = 5;
            GameBoard myForm = new GameBoard(speed);
            this.Close();
            myForm.ShowDialog();
            this.Show();
        }

        private void btnBeast_Click(object sender, EventArgs e)                  //This is the hardest difficulty
        {
            speed = 10;
            GameBoard myForm = new GameBoard(speed);
            this.Close();
            myForm.ShowDialog();
            this.Show();
        }
}
}
