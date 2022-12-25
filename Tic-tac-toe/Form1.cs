using System;
using System.Drawing;
using System.Windows.Forms;

namespace _1093333_HW2
{
    public partial class Form1 : Form
    {
        Rectangle rec1 = new Rectangle(0, 30, 60, 60);
        Rectangle rec2 = new Rectangle(60, 30, 60, 60);
        Rectangle rec3 = new Rectangle(120, 30, 60, 60);
        Rectangle rec4 = new Rectangle(0, 90, 60, 60);
        Rectangle rec5 = new Rectangle(60, 90, 60, 60);
        Rectangle rec6 = new Rectangle(120, 90, 60, 60);
        Rectangle rec7 = new Rectangle(0, 150, 60, 60);
        Rectangle rec8 = new Rectangle(60, 150, 60, 60);
        Rectangle rec9 = new Rectangle(120, 150, 60, 60);
        int[] play = new int[9];// -1:X   0:none  1:O
        bool full = true;
        bool haveO = false;
        bool draw = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = " ";
            e.Graphics.DrawRectangle(Pens.Black, rec1);
            e.Graphics.DrawRectangle(Pens.Black, rec2);
            e.Graphics.DrawRectangle(Pens.Black, rec3);
            e.Graphics.DrawRectangle(Pens.Black, rec4);
            e.Graphics.DrawRectangle(Pens.Black, rec5);
            e.Graphics.DrawRectangle(Pens.Black, rec6);
            e.Graphics.DrawRectangle(Pens.Black, rec7);
            e.Graphics.DrawRectangle(Pens.Black, rec8);
            e.Graphics.DrawRectangle(Pens.Black, rec9);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            play = new int[9];
            full = true;
            haveO = false;
            draw = false;
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics graph = this.CreateGraphics();

            if (rec1.Contains(e.Location))
            {
                if (play[0] == 0)
                {
                    haveO = true;
                    play[0] = 1;
                    graph.DrawEllipse(Pens.Blue, 5, 35, 50, 50);
                }
                else
                    haveO = false;
            }
            if (rec2.Contains(e.Location))
            {
                if (play[1] == 0)
                {
                    haveO = true;
                    play[1] = 1;
                    graph.DrawEllipse(Pens.Blue, 65, 35, 50, 50);
                }
                else
                    haveO = false;
            }
            if (rec3.Contains(e.Location))
            {
                if (play[2] == 0)
                {
                    haveO = true;
                    play[2] = 1;
                    graph.DrawEllipse(Pens.Blue, 125, 35, 50, 50);
                }
                else
                    haveO = false;
            }
            if (rec4.Contains(e.Location))
            {
                if (play[3] == 0)
                {
                    haveO = true;
                    play[3] = 1;
                    graph.DrawEllipse(Pens.Blue, 5, 95, 50, 50);
                }
                else
                    haveO = false;
            }
            if (rec5.Contains(e.Location))
            {
                if (play[4] == 0)
                {
                    haveO = true;
                    play[4] = 1;
                    graph.DrawEllipse(Pens.Blue, 65, 95, 50, 50);
                }
                else
                    haveO = false;
            }
            if (rec6.Contains(e.Location))
            {
                if (play[5] == 0)
                {
                    haveO = true;
                    play[5] = 1;
                    graph.DrawEllipse(Pens.Blue, 125, 95, 50, 50);
                }
                else
                    haveO = false;
            }
            if (rec7.Contains(e.Location))
            {
                if (play[6] == 0)
                {
                    haveO = true;
                    play[6] = 1;
                    graph.DrawEllipse(Pens.Blue, 5, 155, 50, 50);
                }
                else
                    haveO = false;
            }
            if (rec8.Contains(e.Location))
            {
                if (play[7] == 0)
                {
                    haveO = true;
                    play[7] = 1;
                    graph.DrawEllipse(Pens.Blue, 65, 155, 50, 50);
                }
                else
                    haveO = false;
            }
            if (rec9.Contains(e.Location))
            {
                if (play[8] == 0)
                {
                    haveO = true;
                    play[8] = 1;
                    graph.DrawEllipse(Pens.Blue, 125, 155, 50, 50);
                }
                else
                    haveO = false;
            }

            for (int j = 0; j < 9; j++)
            {
                if (play[j] == 0)
                {
                    full = false;
                    break;
                }
                else
                    full = true;
            }

            //畫X
            Random rd = new Random();
            int i = rd.Next(8);
            while (!full && haveO == true)
            {
                if (play[i] == 0)
                {
                    play[i] = -1;
                    if (i == 0)
                    {
                        graph.DrawLine(Pens.Blue, 5, 35, 55, 85);
                        graph.DrawLine(Pens.Blue, 5, 85, 55, 35);
                        break;
                    }
                    else if (i == 1)
                    {
                        graph.DrawLine(Pens.Blue, 65, 35, 115, 85);
                        graph.DrawLine(Pens.Blue, 65, 85, 115, 35);
                        break;
                    }
                    else if (i == 2)
                    {
                        graph.DrawLine(Pens.Blue, 125, 35, 175, 85);
                        graph.DrawLine(Pens.Blue, 125, 85, 175, 35);
                        break;
                    }
                    else if (i == 3)
                    {
                        graph.DrawLine(Pens.Blue, 5, 95, 55, 145);
                        graph.DrawLine(Pens.Blue, 5, 145, 55, 95);
                        break;
                    }
                    else if (i == 4)
                    {
                        graph.DrawLine(Pens.Blue, 65, 95, 115, 145);
                        graph.DrawLine(Pens.Blue, 65, 145, 115, 95);
                        break;
                    }
                    else if (i == 5)
                    {
                        graph.DrawLine(Pens.Blue, 125, 95, 175, 145);
                        graph.DrawLine(Pens.Blue, 125, 145, 175, 95);
                        break;
                    }
                    else if (i == 6)
                    {
                        graph.DrawLine(Pens.Blue, 5, 155, 55, 205);
                        graph.DrawLine(Pens.Blue, 5, 205, 55, 155);
                        break;
                    }
                    else if (i == 7)
                    {
                        graph.DrawLine(Pens.Blue, 65, 155, 115, 205);
                        graph.DrawLine(Pens.Blue, 65, 205, 115, 155);
                        break;
                    }
                    else if (i == 8)
                    {
                        graph.DrawLine(Pens.Blue, 125, 155, 175, 205);
                        graph.DrawLine(Pens.Blue, 125, 205, 175, 155);
                        break;
                    }
                }
                else
                    i = rd.Next(8);

            }

            if (play[0] == 1 && play[1] == 1 && play[2] == 1 || play[3] == 1 && play[4] == 1 && play[5] == 1 || play[6] == 1 && play[7] == 1 && play[8] == 1
                || play[0] == 1 && play[3] == 1 && play[6] == 1 || play[1] == 1 && play[4] == 1 && play[7] == 1 || play[2] == 1 && play[5] == 1 && play[8] == 1
                || play[0] == 1 && play[4] == 1 && play[8] == 1 || play[2] == 1 && play[4] == 1 && play[6] == 1)
            {
                label1.Text = "You Win!";
                draw = false;
            }
            else if (play[0] == -1 && play[1] == -1 && play[2] == -1 || play[3] == -1 && play[4] == -1 && play[5] == -1 || play[6] == -1 && play[7] == -1 && play[8] == -1
                || play[0] == -1 && play[3] == -1 && play[6] == -1 || play[1] == -1 && play[4] == -1 && play[7] == -1 || play[2] == -1 && play[5] == -1 && play[8] == -1
                || play[0] == -1 && play[4] == -1 && play[8] == -1 || play[2] == -1 && play[4] == -1 && play[6] == -1)
            {
                label1.Text = "You Lose!";
                draw = false;
            }
            else
                draw = true;

            if (full && draw)
                label1.Text = "Draw!";


            if (play[0] == 1 && play[1] == 1 && play[2] == 1 || play[0] == -1 && play[1] == -1 && play[2] == -1)
                graph.DrawLine(Pens.Red, 0, 60, 180, 60);
            else if (play[3] == 1 && play[4] == 1 && play[5] == 1 || play[3] == -1 && play[4] == -1 && play[5] == -1)
                graph.DrawLine(Pens.Red, 0, 120, 180, 120);
            else if (play[6] == 1 && play[7] == 1 && play[8] == 1 || play[6] == -1 && play[7] == -1 && play[8] == -1)
                graph.DrawLine(Pens.Red, 0, 180, 180, 180);
            else if (play[0] == 1 && play[3] == 1 && play[6] == 1 || play[0] == -1 && play[3] == -1 && play[6] == -1)
                graph.DrawLine(Pens.Red, 30, 30, 30, 210);
            else if (play[1] == 1 && play[4] == 1 && play[7] == 1 || play[1] == -1 && play[4] == -1 && play[7] == -1)
                graph.DrawLine(Pens.Red, 90, 30, 90, 210);
            else if (play[2] == 1 && play[5] == 1 && play[8] == 1 || play[2] == -1 && play[5] == -1 && play[8] == -1)
                graph.DrawLine(Pens.Red, 150, 30, 150, 210);
            else if (play[0] == 1 && play[4] == 1 && play[8] == 1 || play[0] == -1 && play[4] == -1 && play[8] == -1)
                graph.DrawLine(Pens.Red, 0, 30, 180, 210);
            else if (play[2] == 1 && play[4] == 1 && play[6] == 1 || play[2] == -1 && play[4] == -1 && play[6] == -1)
                graph.DrawLine(Pens.Red, 0, 210, 180, 30);
        }
    }
}
