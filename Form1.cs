﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    
    public partial class Form1 : Form
    {
        int spped = 10;
        int moveX;
        int moveY;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveY = -spped;
            moveX = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveY = spped;
            moveX = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveX = -spped;
            moveY = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveX = spped;
            moveY = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += moveX;
            pictureBox1.Top += moveY;
        }
    }
}
