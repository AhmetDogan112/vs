﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanıcı_adı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2;
            sayı1=Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int sayı1, sayı2, snouc;
            sayı1=Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            if(radioButton1.Checked==true) 
            {
                label4.Text=(sayı1+sayı2).ToString();
            }
            else
            {
                label4.Text=(sayı1-sayı2).ToString();
            }
            if(radioButton2.Checked==true)
            {
                label4.Text = (sayı1 * sayı2).ToString();
            }
            else
            {
                label4.Text= (sayı1/sayı2).ToString();
            }
        }
    }
}
