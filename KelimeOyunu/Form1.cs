﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new KelimeEkleForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbAd.Text!="")
            {
                new OyunForm_(tbAd.Text).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Adınızı giriniz.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
