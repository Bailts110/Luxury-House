using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
namespace Luxury_House
{
    public partial class Form1 : Form
    {
        Form1 f1;
       public static int userid=0;
        public Form1()
        {
            f1 = this;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            string username = textBoxUserLogin.Text.Trim();
            string password = textBoxPassLogin.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                textBox1.Text = "يرجي ادخال اسم المستخدم";
                return;
            }
            if (username.Length < 3)
            {

                textBox1.Text = "اسم المستخدم يجب ان تتكون عالاقل من 3 حروف";
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                textBox1.Text = "يرجي ادخال كلمة السر";
                return;
            }
            if (password.Length < 6)
            {
                textBox1.Text = "كلمة السر يجب ان تتكون علي الاقل من 6 حروف";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT id FROM Users WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                         userid = (int)result;


                        Form9 f9 = new Form9();
                        f9.Show();
                        this.Hide();
                    }
                    else
                    {
                        textBox1.Text = "اسم المستخدم او كلمة السر غير صحيحة";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


            private void buttonRegister_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        
           
        }
    }
    }