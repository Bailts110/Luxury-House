using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Luxury_House
{
    public partial class Form9 : Form
    {
        public TextBox tbn;
        public static Form9 ins;
        public TextBox tbp;
        public DateTimePicker dtpa;
        public DateTimePicker dtpd;

        public int l, w, i;





        public Form9()
        {
            InitializeComponent();
            ins = this;
            tbn = textBoxName;
            tbp = textBoxPhone;


            dtpa = dateTimePickerArrive;
            dtpd = dateTimePickerDepart;





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int n;
            bool success = int.TryParse(tbp.Text, out n);


            if (tbn.Text == "")
            {
                textBox1.Text = "برجاء ادخال اسمك";
            }
            else if (tbp.Text == "" || tbp.Text.Length!=11 || !success)
            {
                textBox1.Text = "برجاء ادخال رقم هاتفك بشكل صحيح ويجب ان يتكون من 11 رقم";
            }

            else if (dtpa.Value > dtpd.Value)
            {
                textBox1.Text = "برجاء ادخال تاريخ مغادرة صحيح";
            }
            else
            {

                l = dtpd.Value.Month - dtpa.Value.Month;
                i = dtpd.Value.Year - dtpa.Value.Year;
                w = (l * 30) + (dtpd.Value.Day - dtpa.Value.Day) + (i * 361);

                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerArrive_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDepart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }
    }
}