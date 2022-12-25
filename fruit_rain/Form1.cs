using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace _1093333_hw6
{
    public partial class Form1 : Form
    {
        int time, img, count, x, y, banana_x, strawberry_x, tomato_x;
        Image[] images = new Image[3];
        Bitmap fruit1, fruit2, fruit3, bowl;

        public Form1()
        {
            InitializeComponent();
            count = 0;
            img = 0;
            y = 0;
            time = 120;
            Random rd = new Random();
            banana_x = rd.Next(400);
            strawberry_x = rd.Next(400);
            tomato_x = rd.Next(400);
            images[0] = Properties.Resources.Penguins;
            images[1] = Properties.Resources.Hydrangeas;
            images[2] = Properties.Resources.Tulips;
            fruit1 = Properties.Resources.Banana;
            fruit2 = Properties.Resources.StawBerry;
            fruit3 = Properties.Resources.Tomato;
            bowl = Properties.Resources.Bowl;
            ClientSize = new Size(400, 400);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
            {
                label2.Text = time.ToString();
                timer1.Stop();
            }
            else
            {
                label2.Text = time.ToString();
            }

            if (time % 10 == 0)
            {
                img++;
                if (img == 3) img = 0;
                Invalidate();
            }
            y += 30;
            if (banana_x > x - 7 && banana_x < x + 77 && y == 300) count++;
            if (strawberry_x > x - 7 && strawberry_x < x + 77 && y == 300) count++;
            if (tomato_x > x - 7 && tomato_x < x + 77 && y == 300) count++;
            label5.Text = count.ToString();
            if (y == 300)
            {
                y = 0;
                Random rd = new Random();
                banana_x = rd.Next(390);
                strawberry_x = rd.Next(390);
                tomato_x = rd.Next(390);
            }
            Invalidate();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count = 0;
            y = 0;
            img = 0;
            time = 120;
            label2.Text = time.ToString();
            label5.Text = count.ToString();
            timer1.Start();           
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            float[][] cmArray1 =
            {
                  new float[] {1, 0, 0, 0, 0},
                  new float[] {0, 1, 0, 0, 0},
                  new float[] {0, 0, 1, 0, 0},
                  new float[] {0, 0, 0, 0.5f, 0},
                  new float[] {0, 0, 0, 0, 1}
                };
            ColorMatrix cm1 = new ColorMatrix(cmArray1);
            ImageAttributes ia1 = new ImageAttributes();
            ia1.SetColorMatrix(cm1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Rectangle rectDest = new Rectangle(0, 0, 400, 300);
            e.Graphics.DrawImage(images[img], rectDest,
                0, 0, images[img].Width, images[img].Height, GraphicsUnit.Pixel, ia1);

            if (y < 300)
            {
                Rectangle DestFruit1 = new Rectangle(banana_x, y, 40, 40);
                e.Graphics.DrawImage(fruit1, DestFruit1, 0, 0, fruit1.Width, fruit1.Height, GraphicsUnit.Pixel);

                Rectangle DestFruit2 = new Rectangle(strawberry_x, y, 40, 40);
                e.Graphics.DrawImage(fruit2, DestFruit2, 0, 0, fruit2.Width, fruit2.Height, GraphicsUnit.Pixel);

                Rectangle DestFruit3 = new Rectangle(tomato_x, y, 40, 40);
                e.Graphics.DrawImage(fruit3, DestFruit3, 0, 0, fruit3.Width, fruit3.Height, GraphicsUnit.Pixel);
            }
            
            Rectangle Dest = new Rectangle(x, 300, 70, 40);
            e.Graphics.DrawImage(bowl, Dest, 0, 0, bowl.Width, bowl.Height, GraphicsUnit.Pixel);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.Location.X - 35;
            Invalidate();
        }

    }
}
