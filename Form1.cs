﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYLENE_CARUANA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            GetAction Addition = new GetAction(Process.getSum);

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("Equal to:" + " " + Addition(a, b).ToString());



        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAction Subtraction = new GetAction(Process.getDifference);

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("Equal to:" + " " + Subtraction(a, b).ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetAction Multiplication = new GetAction(Process.getProduct);

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("Equal to:" + " " + Multiplication(a, b).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAction Divition = new GetAction(Process.getQuotient);

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("Equal to:" + " " + Divition(a, b).ToString());

        }
    }
}

   