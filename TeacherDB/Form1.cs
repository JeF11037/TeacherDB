using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherDB
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;

        int ID;
        string Name;
        string Surname;
        string Group;
        string Dob;
        string Phone;
        string Address;
        string Foto;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\levpe\source\repos\TeacherDB\TeacherDB\MyDataBase.mdf;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataBaseDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.myDataBaseDataSet1.Student);
        }

        private void TableFormat(bool format)
        {
            if (format)
            {
                DGV_table.Columns[1].Visible = true;
                DGV_table.Columns[2].Visible = true;
                DGV_table.Columns[4].Visible = true;
                DGV_table.Columns[5].Visible = true;
                DGV_table.Columns[6].Visible = true;
            }
            else
            {
                DGV_table.Columns[1].Visible = false;
                DGV_table.Columns[2].Visible = false;
                DGV_table.Columns[4].Visible = false;
                DGV_table.Columns[5].Visible = false;
                DGV_table.Columns[6].Visible = false;
            }
        }

        private void InsertValues(int id, string name, string surname, string group, string dob, string phone, string address, string foto)
        {
            TXT_name.Text = name;
            TXT_surname.Text = surname;
            TXT_group.Text = group;
            TXT_dob.Text = dob;
            TXT_phone.Text = phone;
            TXT_address.Text = address;
            PICT_foto.ImageLocation = @"C:\Users\levpe\Source\Repos\TeacherDB\TeacherDB\img\" + foto;

            ID = id;
            Name = name;
            Surname = surname;
            Group = group;
            Dob = dob;
            Phone = phone;
            Address = address;
            Foto = foto;
        }

        private void ClearValues()
        {
            TXT_name.Text = "";
            TXT_surname.Text = "";
            TXT_group.Text = "";
            TXT_dob.Text = "";
            TXT_phone.Text = "";
            TXT_address.Text = "";
        }

        private void ShowGroup(string group)
        {
            connection.Open();
            DataTable tbl = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.Student WHERE ThisIsNotGroup = @ThisIsNotGroup", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@ThisIsNotGroup", group);
            adapter.Fill(tbl);
            DGV_table.DataSource = tbl;
            connection.Close();
        }

        private void DisplayDataGrid()
        {
            connection.Open();
            DataTable tbl = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.Student", connection);
            adapter.Fill(tbl);
            DGV_table.DataSource = tbl;
            connection.Close();
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            if (!check(TXT_name.Text) && !check(TXT_surname.Text) && !check(TXT_group.Text) && !check(TXT_dob.Text) && !check(TXT_phone.Text) && !check(TXT_address.Text))
            {
                OpenFileDialog file = new OpenFileDialog();
                string iName;
                file.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(file.FileName, @"C:\Users\levpe\Source\Repos\TeacherDB\TeacherDB\img\" + Path.GetFileName(file.FileName));
                    }
                    catch (Exception)
                    {
                    }
                    iName = Path.GetFileName(file.FileName);
                }
                else
                {
                    iName = "empty.png";
                }

                InsertValues(
                ID,
                TXT_name.Text,
                TXT_surname.Text,
                TXT_group.Text,
                TXT_dob.Text,
                TXT_phone.Text,
                TXT_address.Text,
                iName);

                connection.Open();
                command = new SqlCommand("INSERT INTO dbo.Student(Name, Surname, ThisIsNotGroup, DOB, Phone, Address, Foto) VALUES(@Name, @Surname, @ThisIsNotGroup, @DOB, @Phone, @Address, @Foto)", connection);
                command.Parameters.AddWithValue("@Name", TXT_name.Text);
                command.Parameters.AddWithValue("@Surname", TXT_surname.Text);
                command.Parameters.AddWithValue("@ThisIsNotGroup", TXT_group.Text);
                command.Parameters.AddWithValue("@DOB", TXT_dob.Text);
                command.Parameters.AddWithValue("@Phone", TXT_phone.Text);
                command.Parameters.AddWithValue("@Address", TXT_address.Text);
                command.Parameters.AddWithValue("@Foto", iName);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please, fill all fields!");
            }
            DisplayDataGrid();
        }

        private void BTN_change_Click(object sender, EventArgs e)
        {
            if (!check(TXT_name.Text) && !check(TXT_surname.Text) && !check(TXT_group.Text) && !check(TXT_dob.Text) && !check(TXT_phone.Text) && !check(TXT_address.Text))
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                string iName;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(file.FileName, @"C:\Users\levpe\Source\Repos\TeacherDB\TeacherDB\img\" + Path.GetFileName(file.FileName));
                    }
                    catch (Exception)
                    {
                    }
                    iName = Path.GetFileName(file.FileName);
                }
                else
                {
                    iName = "empty.png";
                }

                InsertValues(
                ID,
                TXT_name.Text,
                TXT_surname.Text,
                TXT_group.Text,
                TXT_dob.Text,
                TXT_phone.Text,
                TXT_address.Text,
                iName);

                connection.Open();
                command = new SqlCommand("UPDATE dbo.Student SET Name = @Name, Surname = @Surname, ThisIsNotGroup = @ThisIsNotGroup, DOB = @DOB, Phone = @Phone, Address = @Address, Foto = @Foto WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Name", TXT_name.Text);
                command.Parameters.AddWithValue("@Surname", TXT_surname.Text);
                command.Parameters.AddWithValue("@ThisIsNotGroup", TXT_group.Text);
                command.Parameters.AddWithValue("@DOB", TXT_dob.Text);
                command.Parameters.AddWithValue("@Phone", TXT_phone.Text);
                command.Parameters.AddWithValue("@Address", TXT_address.Text);
                command.Parameters.AddWithValue("@Foto", iName);
                command.Parameters.AddWithValue("@Id", ID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please, fill all fields!");
            }
            DisplayDataGrid();
        }

        private static bool check(string s)
        {
            return (s == null || s == String.Empty) ? true : false;
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand("DELETE FROM dbo.Student WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", ID);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
            ClearValues();
            DisplayDataGrid();
        }

        private void BTN_deleteall_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand("TRUNCATE TABLE dbo.Student", connection);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
            ClearValues();
            DisplayDataGrid();
        }

        private void BTN_backToGroup_Click(object sender, EventArgs e)
        {
            TableFormat(false);
            ClearValues();

            connection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.Student", connection);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            DGV_table.DataSource = tbl;
            connection.Close();
        }

        private void DGV_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TableFormat(true);

            ShowGroup(DGV_table.Rows[e.RowIndex].Cells[3].Value.ToString());

            try
            {
                if (DGV_table.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    InsertValues(
                    (int)DGV_table.Rows[e.RowIndex].Cells[0].Value,
                    DGV_table.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[7].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try to rewrite this row.");
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
