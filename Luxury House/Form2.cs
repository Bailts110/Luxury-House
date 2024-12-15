using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxury_House
{
    public partial class Form2 : Form
    {

        public static Form2 f2;
       
        public int vip;
        public Form2()
        {
            f2 = this;
            InitializeComponent();
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (radioButtonStudio.Checked)
            {

                vip = 30;
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
            if (radioButtonVIP.Checked)
            {
                vip = 130;
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
            if (radioButtonSR.Checked)
            {
                vip = 45;
                this.Hide();
                Form5 f5 = new Form5();
                f5.Show();
            }
            if (radioButtonDR.Checked)
            {
                vip = 60;
                this.Hide();
                Form6 f6 = new Form6();
                f6.Show();
            }
            else {
                textBox1.Text = "Please Select A Room";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f1 = new Form9();
            f1.Show();
        }

        private void buttonStudioDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void buttonVipDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void buttonDoubleRoomDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void buttonSingleRoomDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
