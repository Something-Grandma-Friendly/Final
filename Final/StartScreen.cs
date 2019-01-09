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

        private void btnWeak_Click(object sender, EventArgs e)
        {
            speed = 1;
            GameBoard myForm = new GameBoard(speed);
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }

        private void btnRespectable_Click(object sender, EventArgs e)
        {
            speed = 5;
            GameBoard myForm = new GameBoard(speed);
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }

        private void btnBeast_Click(object sender, EventArgs e)
        {
            speed = 10;
            GameBoard myForm = new GameBoard(speed);
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }
}
}
