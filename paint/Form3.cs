using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1093333_12
{
    public partial class Form3 : Form
    {
        private float r = -1, g = -1, b = -1, a = -1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            r = (float)trackBar1.Value / 10;
            g = (float)trackBar2.Value / 10;
            b = (float)trackBar3.Value / 10;
            a = (float)trackBar4.Value / 10;
            label5.Text = r.ToString();
            label6.Text = g.ToString();
            label7.Text = b.ToString();
            label8.Text = a.ToString();
        }

        public float getR()
        {
            return r;
        }

        public float getG()
        {
            return g;
        }

        public float getB()
        {
            return b;
        }

        public float getA()
        {
            return a;
        }
    }
}
