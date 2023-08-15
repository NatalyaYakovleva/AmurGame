using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowShooting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        int score;

        void Game()
        {
            if (Arrow.Bounds.IntersectsWith(b_1.Bounds))
            {
                b_1.Top = 400;
                score += 5;
                lbl_score.Text = " " + score;
                Arrow.Image = Properties.Resources.blood;
            }
            if (Arrow.Bounds.IntersectsWith(b_2.Bounds))
            {
                b_2.Top = 400;
                score += 5;
                lbl_score.Text = " " + score;
                Arrow.Image = Properties.Resources.blood;
            }
            if (Arrow.Bounds.IntersectsWith(b_3.Bounds))
            {
                b_3.Top = 400;
                score += 5;
                lbl_score.Text = " " + score;
                Arrow.Image = Properties.Resources.blood;
            }
            if (Arrow.Bounds.IntersectsWith(b_4.Bounds))
            {
                b_4.Top = 400;
                score += 5;
                lbl_score.Text = " " + score;
                Arrow.Image = Properties.Resources.blood;
            }
        }

        //создание функции для рандомного перемещения шариков
        void Ball()
        {
            Random rand = new Random();
            int x, y, z, w;
            if (b_1.Top < 20)
            {
                b_1.Top = 100;
                x = rand.Next(300, 900);
                b_1.Location = new Point(x, 500);
            }
            if (b_2.Top < 20)
            {
                b_2.Top = 100;
                y = rand.Next(300, 900);
                b_2.Location = new Point(y, 500);
            }
            if (b_3.Top < 20)
            {
                b_3.Top = 100;
                z = rand.Next(300, 900);
                b_3.Location = new Point(z, 500);
            }
            if (b_4.Top < 20)
            {
                b_4.Top = 100;
                w = rand.Next(300, 900);
                b_4.Location = new Point(w, 500);
            }
            else
            {
                b_1.Top -= 7;
                b_2.Top -= 11;
                b_3.Top -= 15;
                b_4.Top -= 18;
            }
        }

        void Shoot()
        {
            Arrow.Left += 100;
            if (Arrow.Left > 600)
            {
                player.Image = Properties.Resources.Valentine1__2_;
                Arrow.Image = Properties.Resources.arr;
                Arrow.Top = player.Top + 25;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) //этот код предназначен для стрельбы стрелкой, измените изображение выстрела игрока, если нажата клавиша со стрелкой вправо
            {
                Arrow.Left = player.Left;
                player.Image = Properties.Resources.Valentine2__2_;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (player.Top > 55)
                {
                    player.Top -= 5;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (player.Top < 220)
                {
                    player.Top += 5;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shoot();
            Ball();
            Game();
        }
    }
}
