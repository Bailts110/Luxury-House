using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Luxury_House
{
    public partial class Form8 : Form
    {



        public Form8()
        {
            InitializeComponent();
            buttonLogin.Hide();
        }

        private void buttonNewRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxUserRegister.Text))
            {
                textBoxError.Text = "برجاء ادخال اسم المستخدم";
                return;
            }
            if (textBoxUserRegister.Text.Length < 3)
            {
                textBoxError.Text = "اسم المستخدم يجب ان تتكون عالاقل من 3 حروف";
                return;
            }

            if (string.IsNullOrEmpty(textBoxtextBoxPassRegis.Text) || string.IsNullOrEmpty(textBoxPassConfirm.Text))
            {
                textBoxError.Text = "برجاء ادخال كلمة السر والتاكيد كلمة السر";
                return;
            }
            if (textBoxtextBoxPassRegis.Text.Length < 6 || textBoxPassConfirm.Text.Length < 6)
            {
                textBoxError.Text = "كلمة السر يجب ان تتكون عالاقل من 6 حروف";
                return;
            }

            if (textBoxtextBoxPassRegis.Text != textBoxPassConfirm.Text)
            {
                textBoxError.Text = "كلمة السر لا تتوافق ";
                return;
            }


            // Create a SQL connection to check for existing user in the database
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                try
                {
                    conn.Open();


                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";
                    SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, conn);
                    checkUserCmd.Parameters.AddWithValue("@username", textBoxUserRegister.Text);

                    int userCount = (int)checkUserCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        textBoxError.Text = "اسم المستخدم موجود بالفعل يرجي استخدام اسم اخر";
                        return;
                    }


                    string insertQuery = "INSERT INTO Users (username, password) VALUES (@username, @password)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@username", textBoxUserRegister.Text);
                    insertCmd.Parameters.AddWithValue("@password", textBoxtextBoxPassRegis.Text);

                    insertCmd.ExecuteNonQuery();
                    textBoxError.Text = "تم التسجيل بنجاح!";


                    buttonLogin.Show();
                    buttonNewRegister.Hide();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
