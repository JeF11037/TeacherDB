using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
        string Email;
        bool SubsidyF;
        bool SubsidyS;
        string CaretakerF;
        string CaretakerS;
        string CaretakerFEmail;
        string CaretakerSEmail;
        string CaretakerFPhone;
        string CaretakerSPhone;

        public Form1()
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\Source\Repos\TeacherDB\TeacherDB\MyDB.mdf;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.myDBDataSet1.Student);
            // TODO: This line of code loads data into the 'myDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.myDBDataSet.Student);
        }

        private void TableFormat(bool format)
        {
            if (format)
            {
                DGV_table.Columns[1].Visible = true;
                DGV_table.Columns[2].Visible = true;
                DGV_table.Columns[3].Visible = true;
                DGV_table.Columns[4].Visible = true;
                DGV_table.Columns[5].Visible = true;
                DGV_table.Columns[6].Visible = true;
                DGV_table.Columns[8].Visible = true;
                DGV_table.Columns[9].Visible = false;
                DGV_table.Columns[10].Visible = false;
                DGV_table.Columns[11].Visible = false;
                DGV_table.Columns[12].Visible = false;
                DGV_table.Columns[13].Visible = false;
                DGV_table.Columns[14].Visible = false;
                DGV_table.Columns[15].Visible = false;
                DGV_table.Columns[16].Visible = false;
            }
            else
            {
                DGV_table.Columns[1].Visible = false;
                DGV_table.Columns[2].Visible = false;
                DGV_table.Columns[3].Visible = true;
                DGV_table.Columns[4].Visible = false;
                DGV_table.Columns[5].Visible = false;
                DGV_table.Columns[6].Visible = false;
                DGV_table.Columns[8].Visible = false;
                DGV_table.Columns[9].Visible = false;
                DGV_table.Columns[10].Visible = false;
                DGV_table.Columns[11].Visible = false;
                DGV_table.Columns[12].Visible = false;
                DGV_table.Columns[13].Visible = false;
                DGV_table.Columns[14].Visible = false;
                DGV_table.Columns[15].Visible = false;
                DGV_table.Columns[16].Visible = false;
            }
        }

        private void InsertValues(int id, string name, string surname, string group, string dob, string phone, string address, string foto, string email, bool subsidyf, bool subsidys, string caretakerf, string caretakers, string caretakerfemail, string caretakersemail, string caretakerfphone, string caretakersphone)
        {
            TXT_name.Text = name;
            TXT_surname.Text = surname;
            CBX_group.Text = group;
            TXT_dob.Text = dob;
            TXT_phone.Text = phone;
            TXT_address.Text = address;
            PICT_foto.ImageLocation = @"C:\Users\levpe\Source\Repos\TeacherDB\TeacherDB\img\" + foto;
            TXT_email.Text = email;

            ID = id;
            Name = name;
            Surname = surname;
            Group = group;
            Dob = dob;
            Phone = phone;
            Address = address;
            Foto = foto;
            Email = email;

            SubsidyF = subsidyf;
            SubsidyS = subsidys;
            CaretakerF = caretakerf;
            CaretakerS = caretakers;
            CaretakerFEmail = caretakerfemail;
            CaretakerSEmail = caretakersemail;
            CaretakerFPhone = caretakerfphone;
            CaretakerSPhone = caretakersphone;
        }

        private void InsertValues(int id, string name, string surname, string group, string dob, string phone, string address, string foto, string email)
        {
            TXT_name.Text = name;
            TXT_surname.Text = surname;
            CBX_group.Text = group;
            TXT_dob.Text = dob;
            TXT_phone.Text = phone;
            TXT_address.Text = address;
            PICT_foto.ImageLocation = @"C:\Users\levpe\Source\Repos\TeacherDB\TeacherDB\img\" + foto;
            TXT_email.Text = email;

            ID = id;
            Name = name;
            Surname = surname;
            Group = group;
            Dob = dob;
            Phone = phone;
            Address = address;
            Foto = foto;
            Email = email;
        }

        private void ClearValues()
        {
            TXT_name.Text = "";
            TXT_surname.Text = "";
            CBX_group.Text = "";
            TXT_dob.Text = "";
            TXT_phone.Text = "";
            TXT_address.Text = "";
            TXT_email.Text = "";
        }

        private void ShowGroup(string group)
        {
            try
            {
                connection.Open();
                DataTable tbl = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM dbo.Student WHERE ThisIsNotGroup = @ThisIsNotGroup", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ThisIsNotGroup", group);
                adapter.Fill(tbl);
                DGV_table.DataSource = tbl;
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Table is empty !");
            }
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
            if (!check(TXT_name.Text) && !check(TXT_surname.Text) && !check(CBX_group.Text) && !check(TXT_dob.Text) && !check(TXT_phone.Text) && !check(TXT_address.Text))
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
                CBX_group.Text,
                TXT_dob.Text,
                TXT_phone.Text,
                TXT_address.Text,
                iName,
                TXT_email.Text);

                connection.Open();
                command = new SqlCommand("INSERT INTO dbo.Student(Name, Surname, ThisIsNotGroup, DOB, Phone, Address, Foto) VALUES(@Name, @Surname, @ThisIsNotGroup, @DOB, @Phone, @Address, @Foto)", connection);
                command.Parameters.AddWithValue("@Name", TXT_name.Text);
                command.Parameters.AddWithValue("@Surname", TXT_surname.Text);
                command.Parameters.AddWithValue("@ThisIsNotGroup", CBX_group.Text);
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
            BTN_subChange_Click();
            BTN_careChange_Click();
        }

        private void BTN_change_Click(object sender, EventArgs e)
        {
            if (!check(TXT_name.Text) && !check(TXT_surname.Text) && !check(CBX_group.Text) && !check(TXT_dob.Text) && !check(TXT_phone.Text) && !check(TXT_address.Text))
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
                CBX_group.Text,
                TXT_dob.Text,
                TXT_phone.Text,
                TXT_address.Text,
                iName,
                TXT_email.Text);

                connection.Open();
                command = new SqlCommand("UPDATE dbo.Student SET Name = @Name, Surname = @Surname, ThisIsNotGroup = @ThisIsNotGroup, DOB = @DOB, Phone = @Phone, Address = @Address, Foto = @Foto WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Name", TXT_name.Text);
                command.Parameters.AddWithValue("@Surname", TXT_surname.Text);
                command.Parameters.AddWithValue("@ThisIsNotGroup", CBX_group.Text);
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

            try
            {
                connection.Open();
                adapter = new SqlDataAdapter("SELECT * FROM dbo.Student", connection);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                DGV_table.DataSource = tbl;
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Table is empty !");
            }
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
                    DGV_table.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[8].Value.ToString(),
                    Convert.ToBoolean(DGV_table.Rows[e.RowIndex].Cells[9].Value),
                    Convert.ToBoolean(DGV_table.Rows[e.RowIndex].Cells[10].Value),
                    DGV_table.Rows[e.RowIndex].Cells[11].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[12].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[13].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[14].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[15].Value.ToString(),
                    DGV_table.Rows[e.RowIndex].Cells[16].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try to rewrite this row.");
                }

                if (DGV_table.Rows[e.RowIndex].Cells[8].Value != null)
                {
                    if (BTN_care.BackColor == Color.Wheat)
                    {
                        if (BTN_to.BackColor == Color.BlanchedAlmond)
                        {
                            if (TXT_to.Text != string.Empty)
                            {
                                TXT_to.Text += ", ";
                            }
                            TXT_to.Text += DGV_table.Rows[e.RowIndex].Cells[8].Value.ToString();
                        }

                        if (BTN_toall.BackColor == Color.BlanchedAlmond)
                        {
                            TXT_to.Text = string.Empty;
                            for (int tick = 0; tick < DGV_table.Rows.Count - 1; tick++)
                            {
                                if (TXT_to.Text != string.Empty)
                                {
                                    TXT_to.Text += ", ";
                                }
                                TXT_to.Text += DGV_table.Rows[tick].Cells[8].Value.ToString();
                            }
                        }
                    }
                    else
                    {
                        if (BTN_to.BackColor == Color.BlanchedAlmond)
                        {
                            if (TXT_to.Text != string.Empty)
                            {
                                TXT_to.Text += ", ";
                            }
                            if (DGV_table.Rows[e.RowIndex].Cells[13].Value.ToString() != "Unknown")
                            {
                                TXT_to.Text += DGV_table.Rows[e.RowIndex].Cells[13].Value.ToString();
                            }
                            if (DGV_table.Rows[e.RowIndex].Cells[14].Value.ToString() != "Unknown")
                            {
                                if (TXT_to.Text != string.Empty)
                                {
                                    TXT_to.Text += ", ";
                                }
                                TXT_to.Text += DGV_table.Rows[e.RowIndex].Cells[14].Value.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void BTN_send_Click(object sender, EventArgs e)
        {
            string[] rec = TXT_to.Text.Split(',', (char)StringSplitOptions.RemoveEmptyEntries);
            MailMessage mail;
            try
            {
                if (rec.Length > 1)
                {
                    mail = new MailMessage();
                    mail.From = new MailAddress(TXT_from.Text);
                    mail.Subject = TXT_subject.Text;
                    mail.Body = TXT_msgbody.Text;
                    foreach (var el in rec)
                    {
                        mail.To.Add(new MailAddress(el));
                    }
                }
                else
                {
                    mail = new MailMessage(TXT_from.Text, TXT_to.Text, TXT_subject.Text, TXT_msgbody.Text);
                }
                try
                {
                    mail.Attachments.Add(new Attachment(TXT_file.Text));
                }
                catch (Exception)
                {
                }
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("lev.petryakov@gmail.com", "");
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Mail sent!", "Successful", MessageBoxButtons.OK);
                TXT_from.Text = "";
                TXT_to.Text = "";
                TXT_subject.Text = "";
                TXT_msgbody.Text = "";
                TXT_file.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Fill all fields");
            }
        }

        private void BTN_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (op.ShowDialog() == DialogResult.OK)
            {
                TXT_file.Text = op.FileName;
            }
        }

        private void BTN_to_Click(object sender, EventArgs e)
        {
            if (BTN_to.BackColor == Color.Wheat)
            {
                BTN_to.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                BTN_to.BackColor = Color.Wheat;
            }

            BTN_toall.BackColor = Color.Wheat;
        }

        private void BTN_toall_Click(object sender, EventArgs e)
        {
            if (BTN_toall.BackColor == Color.Wheat)
            {
                BTN_toall.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                BTN_toall.BackColor = Color.Wheat;
            }

            BTN_to.BackColor = Color.Wheat;
        }

        private void BTN_sub_Click(object sender, EventArgs e)
        {
            BTN_care.BackColor = Color.Wheat;
            if (BTN_sub.BackColor == Color.Wheat)
            {
                BTN_sub.BackColor = Color.BlanchedAlmond;
                DGV_table.Columns[1].Visible = true;
                DGV_table.Columns[2].Visible = true;
                DGV_table.Columns[3].Visible = false;
                DGV_table.Columns[4].Visible = false;
                DGV_table.Columns[5].Visible = false;
                DGV_table.Columns[6].Visible = false;
                DGV_table.Columns[8].Visible = false;
                DGV_table.Columns[9].Visible = true;
                DGV_table.Columns[10].Visible = true;
                DGV_table.Columns[11].Visible = false;
                DGV_table.Columns[12].Visible = false;
                DGV_table.Columns[13].Visible = false;
                DGV_table.Columns[14].Visible = false;
                DGV_table.Columns[15].Visible = false;
                DGV_table.Columns[16].Visible = false;
            }
            else
            {
                BTN_sub.BackColor = Color.Wheat;
                TableFormat(true);
            }
        }

        private void BTN_care_Click(object sender, EventArgs e)
        {
            BTN_sub.BackColor = Color.Wheat;
            if (BTN_care.BackColor == Color.Wheat)
            {
                BTN_care.BackColor = Color.BlanchedAlmond;
                DGV_table.Columns[1].Visible = true;
                DGV_table.Columns[2].Visible = true;
                DGV_table.Columns[3].Visible = false;
                DGV_table.Columns[4].Visible = false;
                DGV_table.Columns[5].Visible = false;
                DGV_table.Columns[6].Visible = false;
                DGV_table.Columns[8].Visible = false;
                DGV_table.Columns[9].Visible = false;
                DGV_table.Columns[10].Visible = false;
                DGV_table.Columns[11].Visible = true;
                DGV_table.Columns[12].Visible = true;
                DGV_table.Columns[13].Visible = true;
                DGV_table.Columns[14].Visible = true;
                DGV_table.Columns[15].Visible = true;
                DGV_table.Columns[16].Visible = true;
            }
            else
            {
                BTN_care.BackColor = Color.Wheat;
                TableFormat(true);
            }
        }

        private void BTN_subChange_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Eri", "Change", MessageBoxButtons.YesNoCancel))
                {
                    SubsidyF = true;
                }
                else
                {
                    SubsidyF = false;
                }
                if (DialogResult.Yes == MessageBox.Show("Põhi", "Change", MessageBoxButtons.YesNoCancel))
                {
                    SubsidyS = true;
                }
                else
                {
                    SubsidyS = false;
                }
                connection.Open();
                command = new SqlCommand("UPDATE dbo.Student SET SubsidyF = @SubsidyF, SubsidyS = @SubsidyS WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@SubsidyF", SubsidyF);
                command.Parameters.AddWithValue("@SubsidyS", SubsidyS);
                command.Parameters.AddWithValue("@Id", ID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.Close();
                DisplayDataGrid();
            }
            else
            {
                MessageBox.Show("Choose someone...");
            }
        }

        private void BTN_subChange_Click()
        {
            if (ID != 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Eri", "Change", MessageBoxButtons.YesNoCancel))
                {
                    SubsidyF = true;
                }
                else
                {
                    SubsidyF = false;
                }
                if (DialogResult.Yes == MessageBox.Show("Põhi", "Change", MessageBoxButtons.YesNoCancel))
                {
                    SubsidyS = true;
                }
                else
                {
                    SubsidyS = false;
                }
                connection.Open();
                command = new SqlCommand("UPDATE dbo.Student SET SubsidyF = @SubsidyF, SubsidyS = @SubsidyS WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@SubsidyF", SubsidyF);
                command.Parameters.AddWithValue("@SubsidyS", SubsidyS);
                command.Parameters.AddWithValue("@Id", ID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.Close();
                DisplayDataGrid();
            }
            else
            {
                MessageBox.Show("Choose someone...");
            }
        }

        private void BTN_careChange_Click()
        {
            if (ID != 0)
            {
                if (DateTime.Now.Year - Convert.ToDateTime(Dob).Year < 18)
                {
                    if (DialogResult.Yes == MessageBox.Show("First caretaker", "Change", MessageBoxButtons.YesNoCancel))
                    {
                        CaretakerF = Microsoft.VisualBasic.Interaction.InputBox("First caretaker Name and Surname");
                        CaretakerFEmail = Microsoft.VisualBasic.Interaction.InputBox("First caretaker Email");
                        CaretakerFPhone = Microsoft.VisualBasic.Interaction.InputBox("First caretaker Phone");
                    }
                    else
                    {
                        CaretakerF = "Unknown";
                        CaretakerFEmail = "Unknown";
                        CaretakerFPhone = "Unknown";
                    }
                    if (DialogResult.Yes == MessageBox.Show("Second caretaker", "Change", MessageBoxButtons.YesNoCancel))
                    {
                        CaretakerS = Microsoft.VisualBasic.Interaction.InputBox("Second caretaker Name and Surname");
                        CaretakerSEmail = Microsoft.VisualBasic.Interaction.InputBox("Second caretaker Email");
                        CaretakerSPhone = Microsoft.VisualBasic.Interaction.InputBox("Second caretaker Phone");
                    }
                    else
                    {
                        CaretakerS = "Unknown";
                        CaretakerSEmail = "Unknown";
                        CaretakerSPhone = "Unknown";
                    }
                }
                else
                {
                    CaretakerF = "Adult";
                    CaretakerS = "Adult";
                    CaretakerFEmail = "Adult";
                    CaretakerSEmail = "Adult";
                    CaretakerFPhone = "Adult";
                    CaretakerSPhone = "Adult";
                }

                connection.Open();
                command = new SqlCommand("UPDATE dbo.Student SET CaretakerF = @CaretakerF, CaretakerFEmail = @CaretakerFEmail, CaretakerFPhone = @CaretakerFPhone, CaretakerS = @CaretakerS, CaretakerSEmail = @CaretakerSEmail, CaretakerSPhone = @CaretakerSPhone WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@CaretakerF", CaretakerF);
                command.Parameters.AddWithValue("@CaretakerFEmail", CaretakerFEmail);
                command.Parameters.AddWithValue("@CaretakerFPhone", CaretakerFPhone);
                command.Parameters.AddWithValue("@CaretakerS", CaretakerS);
                command.Parameters.AddWithValue("@CaretakerSEmail", CaretakerSEmail);
                command.Parameters.AddWithValue("@CaretakerSPhone", CaretakerSPhone);
                command.Parameters.AddWithValue("@Id", ID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.Close();
                DisplayDataGrid();
            }
            else
            {
                MessageBox.Show("Choose someone...");
            }
        }

        private void BTN_careChange_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (DateTime.Now.Year - Convert.ToDateTime(Dob).Year < 18)
                {
                    if (DialogResult.Yes == MessageBox.Show("First caretaker", "Change", MessageBoxButtons.YesNoCancel))
                    {
                        CaretakerF = Microsoft.VisualBasic.Interaction.InputBox("First caretaker Name and Surname");
                        CaretakerFEmail = Microsoft.VisualBasic.Interaction.InputBox("First caretaker Email");
                        CaretakerFPhone = Microsoft.VisualBasic.Interaction.InputBox("First caretaker Phone");
                    }
                    else
                    {
                        CaretakerF = "Unknown";
                        CaretakerFEmail = "Unknown";
                        CaretakerFPhone = "Unknown";
                    }
                    if (DialogResult.Yes == MessageBox.Show("Second caretaker", "Change", MessageBoxButtons.YesNoCancel))
                    {
                        CaretakerS = Microsoft.VisualBasic.Interaction.InputBox("Second caretaker Name and Surname");
                        CaretakerSEmail = Microsoft.VisualBasic.Interaction.InputBox("Second caretaker Email");
                        CaretakerSPhone = Microsoft.VisualBasic.Interaction.InputBox("Second caretaker Phone");
                    }
                    else
                    {
                        CaretakerS = "Unknown";
                        CaretakerSEmail = "Unknown";
                        CaretakerSPhone = "Unknown";
                    }
                }
                else
                {
                    CaretakerF = "Adult";
                    CaretakerS = "Adult";
                    CaretakerFEmail = "Adult";
                    CaretakerSEmail = "Adult";
                    CaretakerFPhone = "Adult";
                    CaretakerSPhone = "Adult";
                }

                connection.Open();
                command = new SqlCommand("UPDATE dbo.Student SET CaretakerF = @CaretakerF, CaretakerFEmail = @CaretakerFEmail, CaretakerFPhone = @CaretakerFPhone, CaretakerS = @CaretakerS, CaretakerSEmail = @CaretakerSEmail, CaretakerSPhone = @CaretakerSPhone WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@CaretakerF", CaretakerF);
                command.Parameters.AddWithValue("@CaretakerFEmail", CaretakerFEmail);
                command.Parameters.AddWithValue("@CaretakerFPhone", CaretakerFPhone);
                command.Parameters.AddWithValue("@CaretakerS", CaretakerS);
                command.Parameters.AddWithValue("@CaretakerSEmail", CaretakerSEmail);
                command.Parameters.AddWithValue("@CaretakerSPhone", CaretakerSPhone);
                command.Parameters.AddWithValue("@Id", ID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.Close();
                DisplayDataGrid();
            }
            else
            {
                MessageBox.Show("Choose someone...");
            }
        }

        private void TXT_from_TextChanged(object sender, EventArgs e)
        {
            if (TXT_from.Text.Split('@').Length < 2 || TXT_from.Text.Split('@').Length > 2)
            {
                TXT_from.BackColor = Color.Red;
            }
            else
            {
                TXT_from.BackColor = Color.Wheat;
            }
            if (TXT_from.Text == string.Empty)
            {
                TXT_from.BackColor = Color.Wheat;
            }
        }
    }
}
