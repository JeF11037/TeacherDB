using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherDB
{
    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;

        public Form2()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\Source\Repos\TeacherDB\TeacherDB\MyDB.mdf;Integrated Security=True");
        }

        private void BTN_deleteall_Click(object sender, EventArgs e)
        {
            if (BTN_reg.BackColor == Color.Wheat)
            {
                connection.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT * FROM dbo.Users WHERE Password = @Password", connection);
                check_User_Name.Parameters.AddWithValue("@Password", TXT_pass.Text);
                SqlDataReader reader = check_User_Name.ExecuteReader();
                if (reader.HasRows)
                {
                    connection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User or password are incorrect !");
                }
                connection.Close();
            }
            else
            {
                if (TXT_pass.Text == TXT_pass2.Text)
                {
                    connection.Open();
                    command = new SqlCommand("INSERT INTO dbo.Users(UserName, Password, Email) VALUES(@UserName, @Password, @Email)", connection);
                    command.Parameters.AddWithValue("@UserName", TXT_user.Text);
                    command.Parameters.AddWithValue("@Password", TXT_pass.Text);
                    command.Parameters.AddWithValue("@Email", TXT_email.Text);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect password !");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BTN_reg.BackColor == Color.Wheat)
            {
                BTN_reg.BackColor = Color.BlanchedAlmond;
                TXT_pass2.Visible = true;
                LBL_pass2.Visible = true;
            }
            else
            {
                BTN_reg.BackColor = Color.Wheat;
                TXT_pass2.Visible = false;
                LBL_pass2.Visible = false;
            }
        }
    }
}
