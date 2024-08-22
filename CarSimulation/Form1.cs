using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSimulation
{
    public partial class CarSimulation : Form
    {
        int Speed = 15;
        public CarSimulation()
        {
            InitializeComponent();
        }

        private void PlayBTN(object sender, EventArgs e)
        {
            timer1.Start();
            Car2.Visible = false;
            Car3.Visible = false;
            Car4.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Car1.Location = new Point(Car1.Location.X + Speed, Car1.Location.Y);

            if(Car1.Location.X > 784)
            {
                Car1.Visible = false;
                Car2.Visible = true;
                timer2.Start();
                timer1.Stop();
                Car1.Location = new Point(3, 328);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Car2.Location = new Point(Car2.Location.X, Car2.Location.Y - Speed);

            if (Car2.Location.Y < 2)
            {
                Car2.Visible = false;
                Car3.Visible = true;
                timer3.Start();
                timer2.Stop();
                Car2.Location = new Point(784, 328);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Car3.Location = new Point(Car3.Location.X - Speed, Car3.Location.Y);

            if (Car3.Location.X < 4)
            {
                Car3.Visible = false;
                Car4.Visible = true;
                timer4.Start();
                timer3.Stop();
                Car3.Location = new Point(784, 2);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Car4.Location = new Point(Car4.Location.X, Car4.Location.Y + Speed);

            if (Car4.Location.Y > 328)
            {
                Car4.Visible = false;
                Car1.Visible = true;
                timer1.Start();
                timer4.Stop();
                Car4.Location = new Point(4, 2);
            }
        }

        private void BrakeBTN(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }

        private void GEAR1(object sender, EventArgs e)
        {
            Speed = 25;
        }

        private void GEAR2(object sender, EventArgs e)
        {
            Speed = 35;
        }

        private void GEAR3(object sender, EventArgs e)
        {
            Speed = 45;
        }

        private void GEAR4(object sender, EventArgs e)
        {
            Speed = 55;
        }

        private void LaunchBTN(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            Car1.Visible = true;
            Car2.Visible = false;
            Car3.Visible = false;
            Car4.Visible = false;
            Car1.Location = new Point(3, 328);
        }

        private void Car4_Click(object sender, EventArgs e)
        {

        }

        private void Car2_Click(object sender, EventArgs e)
        {

        }

        private void Car1_Click(object sender, EventArgs e)
        {

        }
    }
}
