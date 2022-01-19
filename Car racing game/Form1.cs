using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_racing_game
{
    public partial class Form1 : Form
    {
        int carSpeed = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            obstacle1.Top += 2;
            obstacle2.Top += 2;
            obstacle3.Top += 2;


            if(car.Top <=0 || car.Top>= 470)
            {
                gameTimer.Stop();
            }
            
                if (carSpeed > 0)
                {
                    car.Top -= carSpeed;
                }
                else if (carSpeed <= 0)
                {
                    car.Top -= carSpeed;
                }
         
            
            if(obstacle1.Top>=550)
            {
                obstacle1.Top = 0;
            }
            if (obstacle2.Top >= 550)
            {
                obstacle2.Top = 0;
            }
            if (obstacle3.Top >= 550)
            {
                obstacle3.Top = 0;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                if(car.Top > 0)
                {
                    if(carSpeed<2)
                    {
                        carSpeed += 1;
                    }

                   // car.Top -= carSpeed;
                }
            }
            if(e.KeyCode == Keys.Left)
            {
                if(car.Left >200)
                {
                    car.Left -=4;
                }
            }
            if(e.KeyCode == Keys.Right)
            {
                if(car.Right <650)
                {
                    car.Left += 4;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                if(car.Top < 470)
                {
                    if(carSpeed > -1)
                    {
                        carSpeed -= 1;
                    }
                    
                   // car.Top += carSpeed ;
                }
            }
        }
    }
}
