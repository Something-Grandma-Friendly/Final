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

        public int lives = 3;
        int easy = 1;
        int medium = 2;
        int high = 3;
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btnWeak_Click(object sender, EventArgs e)
        {
            
            GameBoard myForm = new GameBoard(easy);
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }

        private void btnRespectable_Click(object sender, EventArgs e)
        {
            GameBoard myForm = new GameBoard(medium);
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }

        private void btnBeast_Click(object sender, EventArgs e)
        {
            GameBoard myForm = new GameBoard(high);
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }
    }
}
