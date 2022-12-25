using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1093333_hw4
{
    public partial class Form1 : Form
    {
        int x, y, Xmove, Ymove;
        int color;// 0: red  1: green  2: blue
        int num = 0;
        int mousemove;
        int time;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = 0;
            y = 50;
            Xmove = 4;
            Ymove = 4;
            color = 0;
            mousemove = 130;
            time = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            toolStripButton1.Checked = true;
            Size = new Size(500, 500);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            color = 0;
            toolStripButton1.Checked = true;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;
            Invalidate();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            color = 1;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = true;
            toolStripButton3.Checked = false;
            Invalidate();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            color = 2;
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = true;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            e.Graphics.DrawRectangle(p, 0, 50, 300, 300);

            Brush b = new SolidBrush(Color.Red);
            e.Graphics.FillRectangle(b, mousemove, 350, 40, 15);

            Brush ball;
            if (color == 0)
            {
                ball = new SolidBrush(Color.Red);
            }
            else if (color == 1)
            {
                ball = new SolidBrush(Color.Green);
            }
            else
            {
                ball = new SolidBrush(Color.Blue);
            }
            e.Graphics.FillEllipse(ball, x, y, 20, 20);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mousemove = e.X - 20;
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            time++;
            if (time == 5)
                time = 0;
            toolStripStatusLabel1.Text = num.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x += Xmove;
            y += Ymove;
            if (num % 5 == 0 && num != 0) 
            {
                if (time == 0)
                {
                    Xmove += 4;
                    Ymove += 4;
                    if (x >= 280)
                    {
                        Xmove = Xmove * (-1);
                        x = 280;
                        if (y >= 330)
                            y = 330;
                        Invalidate();
                    }
                    else if (y >= 330)
                    {
                        Ymove = Ymove * (-1);
                        y = 330;
                        if (x >= 280)
                            x = 280;
                        if (x > mousemove + 21)
                        {
                            timer1.Enabled = false;
                            timer2.Enabled = false;
                            toolStripStatusLabel2.Text = "Game over!";
                        }
                        else if (x < mousemove - 21)
                        {
                            timer1.Enabled = false;
                            timer2.Enabled = false;
                            toolStripStatusLabel2.Text = "Game over!";
                        }
                        Invalidate();
                    }
                    else if (x <= 0)
                    {
                        Xmove = Xmove * (-1);
                        x = 0;
                        Invalidate();
                    }
                    else if (y <= 50)
                    {
                        Ymove = Ymove * (-1);
                        y = 50;
                        Invalidate();
                    }
                }
            }
            else
            {
                if (x >= 280)
                {
                    Xmove = Xmove * (-1);
                    x = 280;
                    if (y >= 330)
                        y = 330;
                    Invalidate();
                }
                else if (y >= 330)
                {
                    Ymove = Ymove * (-1);
                    y = 330;
                    if (x >= 280)
                        x = 280;
                    if (x > mousemove + 21)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        toolStripStatusLabel2.Text = "Game over!";
                    }
                    else if (x < mousemove - 21)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        toolStripStatusLabel2.Text = "Game over!";
                    }
                    Invalidate();
                }
                else if (x <= 0)
                {
                    Xmove = Xmove * (-1);
                    x = 0;
                    Invalidate();
                }
                else if (y <= 50)
                {
                    Ymove = Ymove * (-1);
                    y = 50;
                    Invalidate();
                }
            }

            Invalidate();  
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 50;
            Xmove = 4;
            Ymove = 4;
            color = 0;
            num = 0;
            mousemove = 130;
            time = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            toolStripButton1.Checked = true;
            toolStripStatusLabel2.Text = "Playing!";
            Size = new Size(500, 500);
            Invalidate();
        }
    }
}
