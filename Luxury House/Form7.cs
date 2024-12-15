using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Luxury_House
{
    public partial class Form7 : Form
    {
        int f;
        string z;
        string x;
        int userId; 
        public Form7()
        {
           

            userId=Form1.userid;
            


            if (Form2.f2.vip == 130)
            {
                z = "room : VIP Suite";
                x = "VIP Suite";
            }
            if (Form2.f2.vip == 30)
            {
                z = "room : Studio ";
                x = "Studio";
            }
            if (Form2.f2.vip == 45)
            {
                z = "room : Deluxe Single Room ";
                x = "Deluxe Single Room";
            }
            if (Form2.f2.vip == 60)
            {
                z = "room : Deluxe Double Room";
                x = "Deluxe Double Room";
            }
            f = Form9.ins.w * Form2.f2.vip;
            InitializeComponent();
            label2.Text = $"name : {Form9.ins.tbn.Text}";
            label3.Text = $"phone : {Form9.ins.tbp.Text}";
            label4.Text = z;
            label5.Text = $"days spend : {Form9.ins.w}";
            label6.Text = $"date of Arrival : {Form9.ins.dtpa.Text}";
            label8.Text = $"date of departure : {Form9.ins.dtpd.Text}";
            labelPrice.Text = $"Price   {f}$";



            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    conn.Open();




                    string insertQuery = "INSERT INTO Reservations (name,phone,roomType,start_date,end_date,total_price,user_id) VALUES (@name,@phone,@roomType,@start_date,@end_date,@total_price,@user_id)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@name", Form9.ins.tbn.Text);
                    insertCmd.Parameters.AddWithValue("@phone", Form9.ins.tbp.Text);
                    insertCmd.Parameters.AddWithValue("@roomType", x);
                    insertCmd.Parameters.AddWithValue("@start_date", Form9.ins.dtpa.Text);
                    insertCmd.Parameters.AddWithValue("@end_date", Form9.ins.dtpd.Text);
                    insertCmd.Parameters.AddWithValue("@total_price", f);
                    insertCmd.Parameters.AddWithValue("@user_id", userId);



                    insertCmd.ExecuteNonQuery();



                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f2 = new Form9();
            f2.Show();
            this.Hide();


        }
    }
}
