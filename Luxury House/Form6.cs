﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxury_House
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
