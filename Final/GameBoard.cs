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
    public partial class GameBoard : Form
    {
        public int frogLives = 3;
        public int score = 0;

        public int speed;

        public GameBoard(int speed)
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(GameBoard_KeyDown);

            MoveTimer.Interval = 100 / speed;
            MoveTimer.Start();

            CollisionTimer.Interval = 100 / speed;
            CollisionTimer.Start();
            int speedMultiplier = speed;

        }

        void GameBoard_KeyDown(object sender, KeyEventArgs e)
        {
            int x = Frog.Location.X;
            int y = Frog.Location.Y;

            if (e.KeyCode == Keys.Right) x += 15;
            else if (e.KeyCode == Keys.Left) x -= 15;
            else if (e.KeyCode == Keys.Up) y -= 15;
            else if (e.KeyCode == Keys.Down) y += 15;

            Frog.Location = new Point(x, y);
        }
        private void MoveTimer_Tick_1(object sender, EventArgs e)
        {
            Car1.Location = new Point(Car1.Location.X + 10, Car1.Location.Y);
            Car2.Location = new Point(Car2.Location.X - 10, Car2.Location.Y);
            Car3.Location = new Point(Car3.Location.X + 10, Car3.Location.Y);
            Car4.Location = new Point(Car4.Location.X - 10, Car4.Location.Y);
            Car5.Location = new Point(Car5.Location.X + 10, Car5.Location.Y);

            Log1.Location = new Point(Log1.Location.X + 10, Log1.Location.Y);
            Log2.Location = new Point(Log2.Location.X - 10, Log2.Location.Y);
        }

        private void CollisionTimer_Tick(object sender, EventArgs e)
        {
            if (Car1.Bounds.IntersectsWith(Lane1End.Bounds))
            {
                Car1.Left = 12;
            }
            if (Car2.Bounds.IntersectsWith(Lane2End.Bounds))
            {
                Car2.Left = 815;
            }
            if (Car3.Bounds.IntersectsWith(Lane3End.Bounds))
            {
                Car3.Left = 12;
            }
            if (Car4.Bounds.IntersectsWith(Lane4End.Bounds))
            {
                Car4.Left = 815;
            }
            if (Car5.Bounds.IntersectsWith(Lane5End.Bounds))
            {
                Car5.Left = 12;
            }


            if (Log1.Bounds.IntersectsWith(River1End.Bounds))
            {
                Log1.Left = 12;
            }
            if (Log2.Bounds.IntersectsWith(River2End.Bounds))
            {
                Log2.Left = 815;
            }


            if (Frog.Bounds.IntersectsWith(Car1.Bounds))
            {
                frogLives = frogLives - 1;
                Frog.Top = 453;
                Frog.Left = 420;
            }
            if (Frog.Bounds.IntersectsWith(Car2.Bounds))
            {
                frogLives = frogLives - 1;
                Frog.Top = 453;
                Frog.Left = 420;
            }
            if (Frog.Bounds.IntersectsWith(Car3.Bounds))
            {
                frogLives = frogLives - 1;
                Frog.Top = 453;
                Frog.Left = 420;
            }
            if (Frog.Bounds.IntersectsWith(Car4.Bounds))
            {
                frogLives = frogLives - 1;
                Frog.Top = 453;
                Frog.Left = 420;
            }
            if (Frog.Bounds.IntersectsWith(Car5.Bounds))
            {
                frogLives = frogLives - 1;
                Frog.Top = 453;
                Frog.Left = 420;
            }

            if (Frog.Bounds.IntersectsWith(River1.Bounds))
            {
                if (Frog.Bounds.IntersectsWith(Log1.Bounds))
                {
                    Frog.Location = new Point(Frog.Location.X + 10, Frog.Location.Y);
                }
                else if (Frog.Bounds.IntersectsWith(Log2.Bounds))
                {
                    Frog.Location = new Point(Frog.Location.X - 10, Frog.Location.Y);
                }
                else
                {
                    frogLives = frogLives - 1;
                    Frog.Top = 453;
                    Frog.Left = 420;
                }
            }
            if (Frog.Bounds.IntersectsWith(endZone.Bounds))
            {
                score = score + (1 * 100);
                Frog.Top = 453;
                Frog.Left = 420;
            }
            if (frogLives == 0)
            {
                frogLives = 3;
                EndScreen endScreen = new EndScreen();
                this.Close();
                endScreen.ShowDialog();
                this.Show();
            }
        }

        private void Car4_Click(object sender, EventArgs e)
        {

        }
    }

}
