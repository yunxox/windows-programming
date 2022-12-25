using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1093333_hw5
{
    public partial class Form1 : Form
    {
        Image img0 = Properties.Resources._8_0; Image img1 = Properties.Resources._8_1; Image img2 = Properties.Resources._8_2;
        Image img3 = Properties.Resources._8_3; Image img4 = Properties.Resources._8_4; Image img5 = Properties.Resources._8_5;
        Image img6 = Properties.Resources._8_6; Image img7 = Properties.Resources._8_7; Image img8 = Properties.Resources._8_8;

        Rectangle rec1 = new Rectangle(0, 30, 100, 100); Rectangle rec2 = new Rectangle(100, 30, 100, 100);
        Rectangle rec3 = new Rectangle(200, 30, 100, 100); Rectangle rec4 = new Rectangle(300, 30, 100, 100);
        Rectangle rec5 = new Rectangle(0, 130, 100, 100); Rectangle rec6 = new Rectangle(100, 130, 100, 100);
        Rectangle rec7 = new Rectangle(200, 130, 100, 100); Rectangle rec8 = new Rectangle(300, 130, 100, 100);
        Rectangle rec9 = new Rectangle(0, 230, 100, 100); Rectangle rec10 = new Rectangle(100, 230, 100, 100);
        Rectangle rec11 = new Rectangle(200, 230, 100, 100); Rectangle rec12 = new Rectangle(300, 230, 100, 100);
        Rectangle rec13 = new Rectangle(0, 330, 100, 100); Rectangle rec14 = new Rectangle(100, 330, 100, 100);
        Rectangle rec15 = new Rectangle(200, 330, 100, 100); Rectangle rec16 = new Rectangle(300, 330, 100, 100);

        Image[] picture = new Image[9];//0~8的照片(照順序)
        int[] fruit = new int[16];//隨機排列
        int first, second, count = 0, time = 0, right = 0;//第一張卡，第二張卡，計算是翻第一還是第二張卡，時間，對的組數
        int position1, position2;//翻卡時在哪一格
        bool End = false;//結束與否
        Image[] draw = new Image[16];//畫圖

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(500, 500);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pen, rec1);
            e.Graphics.DrawRectangle(pen, rec2);
            e.Graphics.DrawRectangle(pen, rec3);
            e.Graphics.DrawRectangle(pen, rec4);
            e.Graphics.DrawRectangle(pen, rec5);
            e.Graphics.DrawRectangle(pen, rec6);
            e.Graphics.DrawRectangle(pen, rec7);
            e.Graphics.DrawRectangle(pen, rec8);
            e.Graphics.DrawRectangle(pen, rec9);
            e.Graphics.DrawRectangle(pen, rec10);
            e.Graphics.DrawRectangle(pen, rec11);
            e.Graphics.DrawRectangle(pen, rec12);
            e.Graphics.DrawRectangle(pen, rec13);
            e.Graphics.DrawRectangle(pen, rec14);
            e.Graphics.DrawRectangle(pen, rec15);
            e.Graphics.DrawRectangle(pen, rec16);

            e.Graphics.DrawImage(draw[0], rec1);
            e.Graphics.DrawImage(draw[1], rec2);
            e.Graphics.DrawImage(draw[2], rec3);
            e.Graphics.DrawImage(draw[3], rec4);
            e.Graphics.DrawImage(draw[4], rec5);
            e.Graphics.DrawImage(draw[5], rec6);
            e.Graphics.DrawImage(draw[6], rec7);
            e.Graphics.DrawImage(draw[7], rec8);
            e.Graphics.DrawImage(draw[8], rec9);
            e.Graphics.DrawImage(draw[9], rec10);
            e.Graphics.DrawImage(draw[10], rec11);
            e.Graphics.DrawImage(draw[11], rec12);
            e.Graphics.DrawImage(draw[12], rec13);
            e.Graphics.DrawImage(draw[13], rec14);
            e.Graphics.DrawImage(draw[14], rec15);
            e.Graphics.DrawImage(draw[15], rec16);

            Pen pen2 = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(pen2, 0, 30, 400, 30);
            e.Graphics.DrawLine(pen2, 0, 130, 400, 130);
            e.Graphics.DrawLine(pen2, 0, 230, 400, 230);
            e.Graphics.DrawLine(pen2, 0, 330, 400, 330);
            e.Graphics.DrawLine(pen2, 100, 30, 100, 430);
            e.Graphics.DrawLine(pen2, 200, 30, 200, 430);
            e.Graphics.DrawLine(pen2, 300, 30, 300, 430);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (timer2.Enabled == false)
            {
                if (rec1.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 0;
                        first = fruit[0];
                        draw[0] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 0;
                        second = fruit[0];
                        draw[0] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec2.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 1;
                        first = fruit[1];
                        draw[1] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 1;
                        second = fruit[1];
                        draw[1] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec3.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 2;
                        first = fruit[2];
                        draw[2] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 2;
                        second = fruit[2];
                        draw[2] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec4.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 3;
                        first = fruit[3];
                        draw[3] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 3;
                        second = fruit[3];
                        draw[3] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec5.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 4;
                        first = fruit[4];
                        draw[4] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 4;
                        second = fruit[4];
                        draw[4] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec6.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 5;
                        first = fruit[5];
                        draw[5] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 5;
                        second = fruit[5];
                        draw[5] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec7.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 6;
                        first = fruit[6];
                        draw[6] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 6;
                        second = fruit[6];
                        draw[6] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec8.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 7;
                        first = fruit[7];
                        draw[7] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 7;
                        second = fruit[7];
                        draw[7] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec9.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 8;
                        first = fruit[8];
                        draw[8] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 8;
                        second = fruit[8];
                        draw[8] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec10.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 9;
                        first = fruit[9];
                        draw[9] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 9;
                        second = fruit[9];
                        draw[9] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec11.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 10;
                        first = fruit[10];
                        draw[10] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 10;
                        second = fruit[10];
                        draw[10] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec12.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 11;
                        first = fruit[11];
                        draw[11] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 11;
                        second = fruit[11];
                        draw[11] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec13.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 12;
                        first = fruit[12];
                        draw[12] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 12;
                        second = fruit[12];
                        draw[12] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec14.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 13;
                        first = fruit[13];
                        draw[13] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 13;
                        second = fruit[13];
                        draw[13] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec15.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 14;
                        first = fruit[14];
                        draw[14] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 14;
                        second = fruit[14];
                        draw[14] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (rec16.Contains(e.Location))
                {
                    if (count == 0)
                    {
                        position1 = 15;
                        first = fruit[15];
                        draw[15] = picture[first];
                        count++;
                        Invalidate();
                    }
                    else
                    {
                        position2 = 15;
                        second = fruit[15];
                        draw[15] = picture[second];
                        count++;
                        Invalidate();
                    }
                }

                if (count == 2)
                {
                    if (first == second)
                    {
                        right++;
                        if (right == 7)
                        {
                            End = true;
                            timer1.Stop();
                        }
                    }
                    else if (first != second)
                    {
                        timer2.Start();
                    }
                    count = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (End)
            {
                timer1.Stop();
            }
            else
            {
                time++;
                label1.Text = time.ToString() + " Seconds";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            draw[position1] = img0;
            draw[position2] = img0;
            timer2.Stop();
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                draw[i] = img0;
            }
            int k = 0, num = 1;
            while (k < 16)
            {
                for (int j = 0; j < 2; j++)
                {
                    fruit[k] = num;
                    k++;
                    if (j == 1)
                        num++;
                }
            }
            Random rand = new Random();
            int x, buffer;
            for (int i = 0; i < 16; i++)
            {
                x = rand.Next(16);
                buffer = fruit[i];
                fruit[i] = fruit[x];
                fruit[x] = buffer;
            }
            picture[0] = img0; picture[1] = img1; picture[2] = img2;
            picture[3] = img3; picture[4] = img4; picture[5] = img5;
            picture[6] = img6; picture[7] = img7; picture[8] = img8;
            time = 0;
            label1.Text = time.ToString() + " Seconds";
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Start();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                draw[i] = img0;
            }
            int k = 0, num = 1;
            while (k < 16)
            {
                for (int j = 0; j < 2; j++)
                {
                    fruit[k] = num;
                    k++;
                    if (j == 1)
                        num++;
                }
            }
            Random rand = new Random();
            int x, buffer;
            for (int i = 0; i < 16; i++)
            {
                x = rand.Next(16);
                buffer = fruit[i];
                fruit[i] = fruit[x];
                fruit[x] = buffer;
            }
            count = 0;
            time = 0;
            right = 0;
            End = false;
            time = 0;
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            label1.Text = time.ToString() + " Seconds";
            timer1.Start();
            Invalidate();
        }

    }
}
