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

        public GameBoard()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(GameBoard_KeyDown);

            MoveTimer.Interval = 100;
            MoveTimer.Start();

            CollisionTimer.Interval = 100;
            CollisionTimer.Start();
        }

       void GameBoard_KeyDown(object sender, KeyEventArgs e)
        {
                int x = Frog.Location.X;
                int y = Frog.Location.Y;

                if (e.KeyCode == Keys.Right) x += 10;
                else if (e.KeyCode == Keys.Left) x -= 10;
                else if (e.KeyCode == Keys.Up) y -= 10;
                else if (e.KeyCode == Keys.Down) y += 10;

                Frog.Location = new Point(x, y);
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Car1.Location = new Point(Car1.Location.X + 10, Car1.Location.Y);
            Car2.Location = new Point(Car2.Location.X - 10, Car2.Location.Y);
            Car3.Location = new Point(Car3.Location.X + 10, Car3.Location.Y);
            Car4.Location = new Point(Car4.Location.X - 10, Car4.Location.Y);
            Car5.Location = new Point(Car5.Location.X + 10, Car5.Location.Y);
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
        }
    }
}
