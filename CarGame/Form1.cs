using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        enum Dir{ Left,Rigth,None}
        Dir dir = Dir.None;
        Random r = new Random();
        int speed = 7;
        int score = 0;
        private void TimerGame_Tick(object sender, EventArgs e)
        {
            Line1.Top += speed;
            Line2.Top += speed;
            Line3.Top += speed;
            Line4.Top += speed;
            Line5.Top += speed;
            Line6.Top += speed;
            if (Line1.Top > panalGame.Height)
                Line1.Top = -Line1.Height;
            if (Line2.Top > panalGame.Height)
                Line2.Top = -Line2.Height;
            if (Line3.Top > panalGame.Height)
                Line3.Top = -Line3.Height;
            if (Line4.Top > panalGame.Height)
                Line4.Top = -Line4.Height;
            if (Line5.Top > panalGame.Height)
                Line5.Top = -Line5.Height;
            if (Line6.Top > panalGame.Height)
                Line6.Top = -Line6.Height;

            if (dir == Dir.Left && Car.Left>0)
                Car.Left -= speed;
            if (dir == Dir.Rigth && Car.Left<panalGame.Width-Car.Width)
                Car.Left += speed;

            if (Car1.Visible)
                Car1.Top += speed;
            if(Car1.Top>panalGame.Height)
            {
                Car1.Visible = false;
                Car1.Top = -Car1.Height;
                Car1.Left = r.Next((panalGame.Width - Car1.Width) / 2);
                Car1.Visible = true;
                int car = r.Next(1, 5);
                if (car == 1)
                    Car1.Image = Properties.Resources.car1;
                else if (car == 2)
                    Car1.Image = Properties.Resources.car2;
                else if (car == 3)
                    Car1.Image = Properties.Resources.car3;
                else 
                    Car1.Image = Properties.Resources.car4;
            }
            if (Car2.Visible)
                Car2.Top += speed;
            if (Car2.Top > panalGame.Height)
            {
                Car2.Visible = false;
                Car2.Top = -Car2.Height;
                Car2.Left = r.Next(panalGame.Width / 2, panalGame.Width-Car2.Width);
                Car2.Visible = true;
                int car = r.Next(1, 5);
                if (car == 1)
                    Car2.Image = Properties.Resources.car1;
                else if (car == 2)
                    Car2.Image = Properties.Resources.car2;
                else if (car == 3)
                    Car2.Image = Properties.Resources.car3;
                else
                    Car2.Image = Properties.Resources.car4;
                
            }
            if(Car.Bounds.IntersectsWith(Car1.Bounds) ||Car.Bounds.IntersectsWith(Car2.Bounds))
            {
                TimerGame.Enabled = false;
                labelgame.Visible = true;
            }

            score++;
            if (score > 1000)
                speed = 8;
            if (score > 2000)
                speed = 9;
            if (score > 3000)
                speed = 10;
            if (score > 4000)
                speed = 11;
            if (score > 5000)
                speed = 12;
            Score.Text = "Score: " + score;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
                dir = Dir.Left;
            else if (e.KeyData == Keys.Right)
                dir = Dir.Rigth;
            else
                dir = Dir.None;

            if(labelgame.Visible)
                if(e.KeyData==Keys.Enter)
                {
                    labelgame.Visible = false;
                    Car.Left = panalGame.Width / 2;
                    Car1.Left = 0;
                    Car1.Left = panalGame.Width - Car1.Width;
                    speed = 5;
                    score = 0;
                    TimerGame.Enabled = true;
                }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            dir = Dir.None;
        }
    }
}
