﻿using System;
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
    public partial class Form2 : Form
    {
        private int width = -1, height = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            width = int.Parse(textBox1.Text);
            height = int.Parse(textBox2.Text);
            Close();
        }

        public int getWidth()
        { 
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
