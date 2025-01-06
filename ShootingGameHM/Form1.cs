using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ShootingGameHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblOver.Hide();
        }

        bool up, down, space;
        int score;

        void GameResult()
        {
            foreach (Control j in this.Controls)
            {
                foreach (Control i in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                i.Top = -100;
                                ((PictureBox)j).Image = Properties.Resources.heart;
                                score++;
                                lblScore.Text = "Score : " + score;
                            }
                        }
                    }
                }
            }

            if (player.Bounds.IntersectsWith(bird.Bounds) || player.Bounds.IntersectsWith(balloon1.Bounds)
            || player.Bounds.IntersectsWith(balloon2.Bounds) || player.Bounds.IntersectsWith(balloon3.Bounds)
                || player.Bounds.IntersectsWith(balloon4.Bounds))
            {
                timer1.Stop();
                lblOver.Show();
                lblOver.BringToFront();
            }
        }
        void Cloud()
        {
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "cloud")
                {
                    j.Left -= 15;
                    if (j.Left < -818)
                    {
                        j.Left = 400;
                    }
                }
            }
        }
        void AddBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.Zoom;
            bullet.Image = Properties.Resources.bullet;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = player.Right + 15;
            bullet.Top = player.Top + (player.Height / 2) - (bullet.Height / 2);
            this.Controls.Add(bullet);
            bullet.BringToFront();

        }
        void BulletMovement()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Left += 10;
                    if (x.Left < 50)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }
        void EnemyMovement()
        {
            Random rnd = new Random();
            PictureBox[] balloons = { balloon1, balloon2, balloon3, balloon4 };
            int x, y;

            foreach (var balloon in balloons)
            {
                if (balloon.Left <= 0)
                {
                    x = rnd.Next(0, 497);
                    balloon.Location = new Point(818, x);
                }
                if (bird.Right <= 0)
                {
                    y = rnd.Next(0, 497);
                    bird.Location = new Point(818, y);
                }
                else
                {
                    balloon.Left -= 15;
                    bird.Left -= 10;
                }
            }


        }

        void ArrowKeyMovement()
        {
            if (up)
            {
                if (player.Top > 0)
                {
                    player.Top -= 20;
                }
            }


            if (down)
            {
                if (player.Top + player.Height < 368)
                {
                    player.Top += 20;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                AddBullet();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ArrowKeyMovement();
            EnemyMovement();
            BulletMovement();
            Cloud();
            GameResult();

        }
    }
}
