﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            bool rez1 = int.TryParse(textBox3.Text, out a);
            if (rez1 == false) 
            { 
                MessageBox.Show("Неверный формат числа" + textBox3.Text + "!");
                return; 
            }
            bool rez2 = int.TryParse(textBox5.Text, out b);
            if (rez2 == false)
            { 
                MessageBox.Show("Неверный формат числа" + textBox5.Text + "!");
                return; 
            }
            c = 2*(5*a+6*b)/5;
            string cStr = c.ToString();
            label6.Text = cStr;
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
