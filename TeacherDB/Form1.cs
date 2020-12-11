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
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\JeF11037\TeacherDB\TeacherDB\MyDataBase.mdf;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataBaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.myDataBaseDataSet.Student);
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

        private void InsertValues(string name, string surname, string group, string dob, string phone, string address, string foto)
        {
            TXT_name.Text = name;
            TXT_surname.Text = surname;
            TXT_group.Text = group;
            TXT_dob.Text = dob;
            TXT_phone.Text = phone;
            TXT_address.Text = address;
        }

        private void ShowGroup(string group)
        {
            adapter = new SqlDataAdapter("SELECT Name, Surname, Group, DOB, Phone, Address FROM dbo.Student WHERE Group = @Group", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@Group", group);
            connection.Open();
            DataSet tbl = new DataSet();
            adapter.Fill(tbl);
            DGV_table.DataSource = tbl;
            connection.Close();
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {

        }

        private void BTN_change_Click(object sender, EventArgs e)
        {

        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {

        }

        private void BTN_deleteall_Click(object sender, EventArgs e)
        {

        }

        private void BTN_backToGroup_Click(object sender, EventArgs e)
        {
            TableFormat(false);
        }

        private void DGV_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TableFormat(true);

            ShowGroup(DGV_table.Rows[e.RowIndex].Cells[3].Value.ToString());

            InsertValues(
                DGV_table.Rows[e.RowIndex].Cells[1].Value.ToString(),
                DGV_table.Rows[e.RowIndex].Cells[2].Value.ToString(),
                DGV_table.Rows[e.RowIndex].Cells[3].Value.ToString(),
                DGV_table.Rows[e.RowIndex].Cells[4].Value.ToString(),
                DGV_table.Rows[e.RowIndex].Cells[5].Value.ToString(),
                DGV_table.Rows[e.RowIndex].Cells[6].Value.ToString(),
                DGV_table.Rows[e.RowIndex].Cells[7].Value.ToString());
        }
    }
}
