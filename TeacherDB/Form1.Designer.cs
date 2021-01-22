namespace TeacherDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PICT_foto = new System.Windows.Forms.PictureBox();
            this.LBL_name = new System.Windows.Forms.Label();
            this.TXT_name = new System.Windows.Forms.TextBox();
            this.TXT_surname = new System.Windows.Forms.TextBox();
            this.LBL_surname = new System.Windows.Forms.Label();
            this.LBL_group = new System.Windows.Forms.Label();
            this.LBL_dob = new System.Windows.Forms.Label();
            this.TXT_phone = new System.Windows.Forms.TextBox();
            this.LBL_phone = new System.Windows.Forms.Label();
            this.TXT_address = new System.Windows.Forms.TextBox();
            this.LBL_address = new System.Windows.Forms.Label();
            this.BTN_add = new System.Windows.Forms.Button();
            this.DGV_table = new System.Windows.Forms.DataGridView();
            this.studentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new TeacherDB.MyDBDataSet();
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_change = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.BTN_deleteall = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BTN_backToGroup = new System.Windows.Forms.Button();
            this.TXT_dob = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_care = new System.Windows.Forms.Button();
            this.LBL_care = new System.Windows.Forms.Label();
            this.BTN_sub = new System.Windows.Forms.Button();
            this.LBL_sub = new System.Windows.Forms.Label();
            this.TXT_email = new System.Windows.Forms.TextBox();
            this.LBL_email = new System.Windows.Forms.Label();
            this.CBX_group = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_to = new System.Windows.Forms.Button();
            this.TXT_file = new System.Windows.Forms.TextBox();
            this.TXT_from = new System.Windows.Forms.TextBox();
            this.LBL_from = new System.Windows.Forms.Label();
            this.TXT_msgbody = new System.Windows.Forms.TextBox();
            this.BTN_file = new System.Windows.Forms.Button();
            this.BTN_send = new System.Windows.Forms.Button();
            this.TXT_to = new System.Windows.Forms.TextBox();
            this.LBL_to = new System.Windows.Forms.Label();
            this.TXT_subject = new System.Windows.Forms.TextBox();
            this.BTN_toall = new System.Windows.Forms.Button();
            this.LBL_subject = new System.Windows.Forms.Label();
            this.studentTableAdapter = new TeacherDB.MyDBDataSetTableAdapters.StudentTableAdapter();
            this.BTN_subChange = new System.Windows.Forms.Button();
            this.BTN_careChange = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subsidyFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.subsidySDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.caretakerFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caretakerSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caretakerFEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caretakerSEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caretakerFPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caretakerSPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PICT_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PICT_foto
            // 
            this.PICT_foto.BackColor = System.Drawing.Color.Wheat;
            this.PICT_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PICT_foto.Location = new System.Drawing.Point(3, 3);
            this.PICT_foto.Name = "PICT_foto";
            this.PICT_foto.Size = new System.Drawing.Size(193, 311);
            this.PICT_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICT_foto.TabIndex = 0;
            this.PICT_foto.TabStop = false;
            // 
            // LBL_name
            // 
            this.LBL_name.AutoSize = true;
            this.LBL_name.BackColor = System.Drawing.Color.Wheat;
            this.LBL_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_name.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_name.Location = new System.Drawing.Point(202, 3);
            this.LBL_name.Name = "LBL_name";
            this.LBL_name.Size = new System.Drawing.Size(59, 25);
            this.LBL_name.TabIndex = 1;
            this.LBL_name.Text = "Name";
            // 
            // TXT_name
            // 
            this.TXT_name.BackColor = System.Drawing.Color.Wheat;
            this.TXT_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_name.Location = new System.Drawing.Point(323, 3);
            this.TXT_name.Multiline = true;
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.Size = new System.Drawing.Size(116, 25);
            this.TXT_name.TabIndex = 2;
            // 
            // TXT_surname
            // 
            this.TXT_surname.BackColor = System.Drawing.Color.Wheat;
            this.TXT_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_surname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_surname.Location = new System.Drawing.Point(323, 34);
            this.TXT_surname.Multiline = true;
            this.TXT_surname.Name = "TXT_surname";
            this.TXT_surname.Size = new System.Drawing.Size(116, 25);
            this.TXT_surname.TabIndex = 4;
            // 
            // LBL_surname
            // 
            this.LBL_surname.AutoSize = true;
            this.LBL_surname.BackColor = System.Drawing.Color.Wheat;
            this.LBL_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_surname.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_surname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_surname.Location = new System.Drawing.Point(202, 34);
            this.LBL_surname.Name = "LBL_surname";
            this.LBL_surname.Size = new System.Drawing.Size(82, 25);
            this.LBL_surname.TabIndex = 3;
            this.LBL_surname.Text = "Surname";
            // 
            // LBL_group
            // 
            this.LBL_group.AutoSize = true;
            this.LBL_group.BackColor = System.Drawing.Color.Wheat;
            this.LBL_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_group.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_group.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_group.Location = new System.Drawing.Point(202, 65);
            this.LBL_group.Name = "LBL_group";
            this.LBL_group.Size = new System.Drawing.Size(61, 25);
            this.LBL_group.TabIndex = 5;
            this.LBL_group.Text = "Group";
            // 
            // LBL_dob
            // 
            this.LBL_dob.AutoSize = true;
            this.LBL_dob.BackColor = System.Drawing.Color.Wheat;
            this.LBL_dob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_dob.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_dob.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_dob.Location = new System.Drawing.Point(202, 96);
            this.LBL_dob.Name = "LBL_dob";
            this.LBL_dob.Size = new System.Drawing.Size(48, 25);
            this.LBL_dob.TabIndex = 7;
            this.LBL_dob.Text = "DOB";
            // 
            // TXT_phone
            // 
            this.TXT_phone.BackColor = System.Drawing.Color.Wheat;
            this.TXT_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_phone.Location = new System.Drawing.Point(323, 127);
            this.TXT_phone.Multiline = true;
            this.TXT_phone.Name = "TXT_phone";
            this.TXT_phone.Size = new System.Drawing.Size(116, 25);
            this.TXT_phone.TabIndex = 10;
            // 
            // LBL_phone
            // 
            this.LBL_phone.AutoSize = true;
            this.LBL_phone.BackColor = System.Drawing.Color.Wheat;
            this.LBL_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_phone.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_phone.Location = new System.Drawing.Point(202, 127);
            this.LBL_phone.Name = "LBL_phone";
            this.LBL_phone.Size = new System.Drawing.Size(62, 25);
            this.LBL_phone.TabIndex = 9;
            this.LBL_phone.Text = "Phone";
            // 
            // TXT_address
            // 
            this.TXT_address.BackColor = System.Drawing.Color.Wheat;
            this.TXT_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_address.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_address.Location = new System.Drawing.Point(323, 158);
            this.TXT_address.Multiline = true;
            this.TXT_address.Name = "TXT_address";
            this.TXT_address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_address.Size = new System.Drawing.Size(116, 25);
            this.TXT_address.TabIndex = 12;
            // 
            // LBL_address
            // 
            this.LBL_address.AutoSize = true;
            this.LBL_address.BackColor = System.Drawing.Color.Wheat;
            this.LBL_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_address.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_address.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_address.Location = new System.Drawing.Point(202, 158);
            this.LBL_address.Name = "LBL_address";
            this.LBL_address.Size = new System.Drawing.Size(77, 25);
            this.LBL_address.TabIndex = 11;
            this.LBL_address.Text = "Address";
            // 
            // BTN_add
            // 
            this.BTN_add.BackColor = System.Drawing.Color.Wheat;
            this.BTN_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_add.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_add.Location = new System.Drawing.Point(493, 22);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(96, 32);
            this.BTN_add.TabIndex = 14;
            this.BTN_add.Text = "Add";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // DGV_table
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_table.AutoGenerateColumns = false;
            this.DGV_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_table.BackgroundColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.subsidyFDataGridViewCheckBoxColumn,
            this.subsidySDataGridViewCheckBoxColumn,
            this.caretakerFDataGridViewTextBoxColumn,
            this.caretakerSDataGridViewTextBoxColumn,
            this.caretakerFEmailDataGridViewTextBoxColumn,
            this.caretakerSEmailDataGridViewTextBoxColumn,
            this.caretakerFPhoneDataGridViewTextBoxColumn,
            this.caretakerSPhoneDataGridViewTextBoxColumn});
            this.DGV_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_table.DataSource = this.studentBindingSource4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_table.GridColor = System.Drawing.Color.Maroon;
            this.DGV_table.Location = new System.Drawing.Point(12, 337);
            this.DGV_table.Name = "DGV_table";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.BlanchedAlmond;
            this.DGV_table.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_table.Size = new System.Drawing.Size(598, 258);
            this.DGV_table.TabIndex = 15;
            this.DGV_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_table_CellClick);
            // 
            // studentBindingSource4
            // 
            this.studentBindingSource4.DataMember = "Student";
            this.studentBindingSource4.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataMember = "Student";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            // 
            // BTN_change
            // 
            this.BTN_change.BackColor = System.Drawing.Color.Wheat;
            this.BTN_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_change.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_change.Location = new System.Drawing.Point(493, 60);
            this.BTN_change.Name = "BTN_change";
            this.BTN_change.Size = new System.Drawing.Size(96, 32);
            this.BTN_change.TabIndex = 16;
            this.BTN_change.Text = "Change";
            this.BTN_change.UseVisualStyleBackColor = false;
            this.BTN_change.Click += new System.EventHandler(this.BTN_change_Click);
            // 
            // BTN_delete
            // 
            this.BTN_delete.BackColor = System.Drawing.Color.Wheat;
            this.BTN_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_delete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_delete.Location = new System.Drawing.Point(493, 98);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(96, 32);
            this.BTN_delete.TabIndex = 17;
            this.BTN_delete.Text = "Delete";
            this.BTN_delete.UseVisualStyleBackColor = false;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // BTN_deleteall
            // 
            this.BTN_deleteall.BackColor = System.Drawing.Color.Wheat;
            this.BTN_deleteall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_deleteall.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_deleteall.Location = new System.Drawing.Point(493, 136);
            this.BTN_deleteall.Name = "BTN_deleteall";
            this.BTN_deleteall.Size = new System.Drawing.Size(96, 32);
            this.BTN_deleteall.TabIndex = 18;
            this.BTN_deleteall.Text = "Delete all";
            this.BTN_deleteall.UseVisualStyleBackColor = false;
            this.BTN_deleteall.Click += new System.EventHandler(this.BTN_deleteall_Click);
            // 
            // BTN_backToGroup
            // 
            this.BTN_backToGroup.BackColor = System.Drawing.Color.Wheat;
            this.BTN_backToGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_backToGroup.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_backToGroup.Location = new System.Drawing.Point(15, 601);
            this.BTN_backToGroup.Name = "BTN_backToGroup";
            this.BTN_backToGroup.Size = new System.Drawing.Size(598, 32);
            this.BTN_backToGroup.TabIndex = 19;
            this.BTN_backToGroup.Text = "Back To Group";
            this.BTN_backToGroup.UseVisualStyleBackColor = false;
            this.BTN_backToGroup.Click += new System.EventHandler(this.BTN_backToGroup_Click);
            // 
            // TXT_dob
            // 
            this.TXT_dob.BackColor = System.Drawing.Color.Wheat;
            this.TXT_dob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_dob.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_dob.Location = new System.Drawing.Point(323, 96);
            this.TXT_dob.Multiline = true;
            this.TXT_dob.Name = "TXT_dob";
            this.TXT_dob.Size = new System.Drawing.Size(116, 25);
            this.TXT_dob.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BTN_care);
            this.panel1.Controls.Add(this.LBL_care);
            this.panel1.Controls.Add(this.BTN_sub);
            this.panel1.Controls.Add(this.LBL_sub);
            this.panel1.Controls.Add(this.TXT_email);
            this.panel1.Controls.Add(this.LBL_email);
            this.panel1.Controls.Add(this.CBX_group);
            this.panel1.Controls.Add(this.PICT_foto);
            this.panel1.Controls.Add(this.TXT_dob);
            this.panel1.Controls.Add(this.LBL_name);
            this.panel1.Controls.Add(this.TXT_name);
            this.panel1.Controls.Add(this.LBL_surname);
            this.panel1.Controls.Add(this.TXT_surname);
            this.panel1.Controls.Add(this.LBL_group);
            this.panel1.Controls.Add(this.LBL_dob);
            this.panel1.Controls.Add(this.TXT_address);
            this.panel1.Controls.Add(this.LBL_phone);
            this.panel1.Controls.Add(this.LBL_address);
            this.panel1.Controls.Add(this.TXT_phone);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 319);
            this.panel1.TabIndex = 21;
            // 
            // BTN_care
            // 
            this.BTN_care.BackColor = System.Drawing.Color.Wheat;
            this.BTN_care.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_care.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_care.Location = new System.Drawing.Point(323, 256);
            this.BTN_care.Name = "BTN_care";
            this.BTN_care.Size = new System.Drawing.Size(116, 32);
            this.BTN_care.TabIndex = 26;
            this.BTN_care.Text = "Check";
            this.BTN_care.UseVisualStyleBackColor = false;
            this.BTN_care.Click += new System.EventHandler(this.BTN_care_Click);
            // 
            // LBL_care
            // 
            this.LBL_care.AutoSize = true;
            this.LBL_care.BackColor = System.Drawing.Color.Wheat;
            this.LBL_care.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_care.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_care.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_care.Location = new System.Drawing.Point(202, 261);
            this.LBL_care.Name = "LBL_care";
            this.LBL_care.Size = new System.Drawing.Size(97, 25);
            this.LBL_care.TabIndex = 25;
            this.LBL_care.Text = "Caretakers";
            // 
            // BTN_sub
            // 
            this.BTN_sub.BackColor = System.Drawing.Color.Wheat;
            this.BTN_sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_sub.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_sub.Location = new System.Drawing.Point(323, 218);
            this.BTN_sub.Name = "BTN_sub";
            this.BTN_sub.Size = new System.Drawing.Size(116, 32);
            this.BTN_sub.TabIndex = 23;
            this.BTN_sub.Text = "Check";
            this.BTN_sub.UseVisualStyleBackColor = false;
            this.BTN_sub.Click += new System.EventHandler(this.BTN_sub_Click);
            // 
            // LBL_sub
            // 
            this.LBL_sub.AutoSize = true;
            this.LBL_sub.BackColor = System.Drawing.Color.Wheat;
            this.LBL_sub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_sub.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_sub.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_sub.Location = new System.Drawing.Point(202, 221);
            this.LBL_sub.Name = "LBL_sub";
            this.LBL_sub.Size = new System.Drawing.Size(87, 25);
            this.LBL_sub.TabIndex = 24;
            this.LBL_sub.Text = "Subsidies";
            // 
            // TXT_email
            // 
            this.TXT_email.BackColor = System.Drawing.Color.Wheat;
            this.TXT_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_email.Location = new System.Drawing.Point(323, 189);
            this.TXT_email.Multiline = true;
            this.TXT_email.Name = "TXT_email";
            this.TXT_email.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_email.Size = new System.Drawing.Size(116, 25);
            this.TXT_email.TabIndex = 23;
            // 
            // LBL_email
            // 
            this.LBL_email.AutoSize = true;
            this.LBL_email.BackColor = System.Drawing.Color.Wheat;
            this.LBL_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_email.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_email.Location = new System.Drawing.Point(202, 189);
            this.LBL_email.Name = "LBL_email";
            this.LBL_email.Size = new System.Drawing.Size(55, 25);
            this.LBL_email.TabIndex = 22;
            this.LBL_email.Text = "Email";
            // 
            // CBX_group
            // 
            this.CBX_group.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.CBX_group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBX_group.DataSource = this.studentBindingSource3;
            this.CBX_group.DisplayMember = "ThisIsNotGroup";
            this.CBX_group.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBX_group.FormattingEnabled = true;
            this.CBX_group.Location = new System.Drawing.Point(323, 63);
            this.CBX_group.Name = "CBX_group";
            this.CBX_group.Size = new System.Drawing.Size(116, 31);
            this.CBX_group.TabIndex = 21;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BTN_to);
            this.panel2.Controls.Add(this.TXT_file);
            this.panel2.Controls.Add(this.TXT_from);
            this.panel2.Controls.Add(this.LBL_from);
            this.panel2.Controls.Add(this.TXT_msgbody);
            this.panel2.Controls.Add(this.BTN_file);
            this.panel2.Controls.Add(this.BTN_send);
            this.panel2.Controls.Add(this.TXT_to);
            this.panel2.Controls.Add(this.LBL_to);
            this.panel2.Controls.Add(this.TXT_subject);
            this.panel2.Controls.Add(this.BTN_toall);
            this.panel2.Controls.Add(this.LBL_subject);
            this.panel2.Location = new System.Drawing.Point(616, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 621);
            this.panel2.TabIndex = 22;
            // 
            // BTN_to
            // 
            this.BTN_to.BackColor = System.Drawing.Color.Wheat;
            this.BTN_to.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_to.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_to.Location = new System.Drawing.Point(3, 3);
            this.BTN_to.Name = "BTN_to";
            this.BTN_to.Size = new System.Drawing.Size(96, 32);
            this.BTN_to.TabIndex = 33;
            this.BTN_to.Text = "To";
            this.BTN_to.UseVisualStyleBackColor = false;
            this.BTN_to.Click += new System.EventHandler(this.BTN_to_Click);
            // 
            // TXT_file
            // 
            this.TXT_file.BackColor = System.Drawing.Color.Wheat;
            this.TXT_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_file.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_file.Location = new System.Drawing.Point(105, 169);
            this.TXT_file.Multiline = true;
            this.TXT_file.Name = "TXT_file";
            this.TXT_file.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_file.Size = new System.Drawing.Size(230, 25);
            this.TXT_file.TabIndex = 32;
            // 
            // TXT_from
            // 
            this.TXT_from.BackColor = System.Drawing.Color.Wheat;
            this.TXT_from.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_from.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_from.Location = new System.Drawing.Point(83, 76);
            this.TXT_from.Multiline = true;
            this.TXT_from.Name = "TXT_from";
            this.TXT_from.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_from.Size = new System.Drawing.Size(252, 25);
            this.TXT_from.TabIndex = 30;
            this.TXT_from.TextChanged += new System.EventHandler(this.TXT_from_TextChanged);
            // 
            // LBL_from
            // 
            this.LBL_from.AutoSize = true;
            this.LBL_from.BackColor = System.Drawing.Color.Wheat;
            this.LBL_from.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_from.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_from.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_from.Location = new System.Drawing.Point(3, 76);
            this.LBL_from.Name = "LBL_from";
            this.LBL_from.Size = new System.Drawing.Size(53, 25);
            this.LBL_from.TabIndex = 31;
            this.LBL_from.Text = "From";
            // 
            // TXT_msgbody
            // 
            this.TXT_msgbody.BackColor = System.Drawing.Color.Wheat;
            this.TXT_msgbody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_msgbody.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_msgbody.Location = new System.Drawing.Point(3, 204);
            this.TXT_msgbody.Multiline = true;
            this.TXT_msgbody.Name = "TXT_msgbody";
            this.TXT_msgbody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_msgbody.Size = new System.Drawing.Size(332, 412);
            this.TXT_msgbody.TabIndex = 29;
            // 
            // BTN_file
            // 
            this.BTN_file.BackColor = System.Drawing.Color.Wheat;
            this.BTN_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_file.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_file.Location = new System.Drawing.Point(3, 166);
            this.BTN_file.Name = "BTN_file";
            this.BTN_file.Size = new System.Drawing.Size(96, 32);
            this.BTN_file.TabIndex = 28;
            this.BTN_file.Text = "File";
            this.BTN_file.UseVisualStyleBackColor = false;
            this.BTN_file.Click += new System.EventHandler(this.BTN_file_Click);
            // 
            // BTN_send
            // 
            this.BTN_send.BackColor = System.Drawing.Color.Wheat;
            this.BTN_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_send.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_send.Location = new System.Drawing.Point(3, 41);
            this.BTN_send.Name = "BTN_send";
            this.BTN_send.Size = new System.Drawing.Size(96, 32);
            this.BTN_send.TabIndex = 27;
            this.BTN_send.Text = "Send";
            this.BTN_send.UseVisualStyleBackColor = false;
            this.BTN_send.Click += new System.EventHandler(this.BTN_send_Click);
            // 
            // TXT_to
            // 
            this.TXT_to.BackColor = System.Drawing.Color.Wheat;
            this.TXT_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_to.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_to.Location = new System.Drawing.Point(83, 107);
            this.TXT_to.Multiline = true;
            this.TXT_to.Name = "TXT_to";
            this.TXT_to.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_to.Size = new System.Drawing.Size(252, 25);
            this.TXT_to.TabIndex = 25;
            // 
            // LBL_to
            // 
            this.LBL_to.AutoSize = true;
            this.LBL_to.BackColor = System.Drawing.Color.Wheat;
            this.LBL_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_to.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_to.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_to.Location = new System.Drawing.Point(3, 107);
            this.LBL_to.Name = "LBL_to";
            this.LBL_to.Size = new System.Drawing.Size(29, 25);
            this.LBL_to.TabIndex = 26;
            this.LBL_to.Text = "To";
            // 
            // TXT_subject
            // 
            this.TXT_subject.BackColor = System.Drawing.Color.Wheat;
            this.TXT_subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_subject.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_subject.Location = new System.Drawing.Point(83, 138);
            this.TXT_subject.Multiline = true;
            this.TXT_subject.Name = "TXT_subject";
            this.TXT_subject.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_subject.Size = new System.Drawing.Size(252, 25);
            this.TXT_subject.TabIndex = 24;
            // 
            // BTN_toall
            // 
            this.BTN_toall.BackColor = System.Drawing.Color.Wheat;
            this.BTN_toall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_toall.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_toall.Location = new System.Drawing.Point(105, 3);
            this.BTN_toall.Name = "BTN_toall";
            this.BTN_toall.Size = new System.Drawing.Size(96, 32);
            this.BTN_toall.TabIndex = 23;
            this.BTN_toall.Text = "To all";
            this.BTN_toall.UseVisualStyleBackColor = false;
            this.BTN_toall.Click += new System.EventHandler(this.BTN_toall_Click);
            // 
            // LBL_subject
            // 
            this.LBL_subject.AutoSize = true;
            this.LBL_subject.BackColor = System.Drawing.Color.Wheat;
            this.LBL_subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_subject.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_subject.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_subject.Location = new System.Drawing.Point(3, 138);
            this.LBL_subject.Name = "LBL_subject";
            this.LBL_subject.Size = new System.Drawing.Size(71, 25);
            this.LBL_subject.TabIndex = 24;
            this.LBL_subject.Text = "Subject";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // BTN_subChange
            // 
            this.BTN_subChange.BackColor = System.Drawing.Color.Wheat;
            this.BTN_subChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_subChange.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_subChange.Location = new System.Drawing.Point(482, 234);
            this.BTN_subChange.Name = "BTN_subChange";
            this.BTN_subChange.Size = new System.Drawing.Size(116, 32);
            this.BTN_subChange.TabIndex = 27;
            this.BTN_subChange.Text = "Change";
            this.BTN_subChange.UseVisualStyleBackColor = false;
            this.BTN_subChange.Click += new System.EventHandler(this.BTN_subChange_Click);
            // 
            // BTN_careChange
            // 
            this.BTN_careChange.BackColor = System.Drawing.Color.Wheat;
            this.BTN_careChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_careChange.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_careChange.Location = new System.Drawing.Point(482, 269);
            this.BTN_careChange.Name = "BTN_careChange";
            this.BTN_careChange.Size = new System.Drawing.Size(116, 32);
            this.BTN_careChange.TabIndex = 28;
            this.BTN_careChange.Text = "Change";
            this.BTN_careChange.UseVisualStyleBackColor = false;
            this.BTN_careChange.Click += new System.EventHandler(this.BTN_careChange_Click);
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn17.HeaderText = "Id";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn18.HeaderText = "Name";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn19.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ThisIsNotGroup";
            this.dataGridViewTextBoxColumn20.HeaderText = "Group";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn21.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn22.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn23.HeaderText = "Address";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Foto";
            this.dataGridViewTextBoxColumn24.HeaderText = "Foto";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn25.HeaderText = "Email";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // subsidyFDataGridViewCheckBoxColumn
            // 
            this.subsidyFDataGridViewCheckBoxColumn.DataPropertyName = "SubsidyF";
            this.subsidyFDataGridViewCheckBoxColumn.HeaderText = "Eri";
            this.subsidyFDataGridViewCheckBoxColumn.Name = "subsidyFDataGridViewCheckBoxColumn";
            this.subsidyFDataGridViewCheckBoxColumn.Visible = false;
            // 
            // subsidySDataGridViewCheckBoxColumn
            // 
            this.subsidySDataGridViewCheckBoxColumn.DataPropertyName = "SubsidyS";
            this.subsidySDataGridViewCheckBoxColumn.HeaderText = "Põhi";
            this.subsidySDataGridViewCheckBoxColumn.Name = "subsidySDataGridViewCheckBoxColumn";
            this.subsidySDataGridViewCheckBoxColumn.Visible = false;
            // 
            // caretakerFDataGridViewTextBoxColumn
            // 
            this.caretakerFDataGridViewTextBoxColumn.DataPropertyName = "CaretakerF";
            this.caretakerFDataGridViewTextBoxColumn.HeaderText = "Name 1";
            this.caretakerFDataGridViewTextBoxColumn.Name = "caretakerFDataGridViewTextBoxColumn";
            this.caretakerFDataGridViewTextBoxColumn.Visible = false;
            // 
            // caretakerSDataGridViewTextBoxColumn
            // 
            this.caretakerSDataGridViewTextBoxColumn.DataPropertyName = "CaretakerS";
            this.caretakerSDataGridViewTextBoxColumn.HeaderText = "Name 2";
            this.caretakerSDataGridViewTextBoxColumn.Name = "caretakerSDataGridViewTextBoxColumn";
            this.caretakerSDataGridViewTextBoxColumn.Visible = false;
            // 
            // caretakerFEmailDataGridViewTextBoxColumn
            // 
            this.caretakerFEmailDataGridViewTextBoxColumn.DataPropertyName = "CaretakerFEmail";
            this.caretakerFEmailDataGridViewTextBoxColumn.HeaderText = "Email 1";
            this.caretakerFEmailDataGridViewTextBoxColumn.Name = "caretakerFEmailDataGridViewTextBoxColumn";
            this.caretakerFEmailDataGridViewTextBoxColumn.Visible = false;
            // 
            // caretakerSEmailDataGridViewTextBoxColumn
            // 
            this.caretakerSEmailDataGridViewTextBoxColumn.DataPropertyName = "CaretakerSEmail";
            this.caretakerSEmailDataGridViewTextBoxColumn.HeaderText = "Email 2";
            this.caretakerSEmailDataGridViewTextBoxColumn.Name = "caretakerSEmailDataGridViewTextBoxColumn";
            this.caretakerSEmailDataGridViewTextBoxColumn.Visible = false;
            // 
            // caretakerFPhoneDataGridViewTextBoxColumn
            // 
            this.caretakerFPhoneDataGridViewTextBoxColumn.DataPropertyName = "CaretakerFPhone";
            this.caretakerFPhoneDataGridViewTextBoxColumn.HeaderText = "Phone 1";
            this.caretakerFPhoneDataGridViewTextBoxColumn.Name = "caretakerFPhoneDataGridViewTextBoxColumn";
            this.caretakerFPhoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // caretakerSPhoneDataGridViewTextBoxColumn
            // 
            this.caretakerSPhoneDataGridViewTextBoxColumn.DataPropertyName = "CaretakerSPhone";
            this.caretakerSPhoneDataGridViewTextBoxColumn.HeaderText = "Phone 2";
            this.caretakerSPhoneDataGridViewTextBoxColumn.Name = "caretakerSPhoneDataGridViewTextBoxColumn";
            this.caretakerSPhoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(971, 645);
            this.Controls.Add(this.BTN_careChange);
            this.Controls.Add(this.BTN_subChange);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_backToGroup);
            this.Controls.Add(this.BTN_deleteall);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_change);
            this.Controls.Add(this.DGV_table);
            this.Controls.Add(this.BTN_add);
            this.Name = "Form1";
            this.Text = "TeacherDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PICT_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PICT_foto;
        private System.Windows.Forms.Label LBL_name;
        private System.Windows.Forms.TextBox TXT_name;
        private System.Windows.Forms.TextBox TXT_surname;
        private System.Windows.Forms.Label LBL_surname;
        private System.Windows.Forms.Label LBL_group;
        private System.Windows.Forms.Label LBL_dob;
        private System.Windows.Forms.TextBox TXT_phone;
        private System.Windows.Forms.Label LBL_phone;
        private System.Windows.Forms.TextBox TXT_address;
        private System.Windows.Forms.Label LBL_address;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.DataGridView DGV_table;
        private System.Windows.Forms.Button BTN_change;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Button BTN_deleteall;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button BTN_backToGroup;
        private System.Windows.Forms.TextBox TXT_dob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.ComboBox CBX_group;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.BindingSource studentBindingSource3;
        private System.Windows.Forms.TextBox TXT_email;
        private System.Windows.Forms.Label LBL_email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TXT_msgbody;
        private System.Windows.Forms.Button BTN_file;
        private System.Windows.Forms.Button BTN_send;
        private System.Windows.Forms.TextBox TXT_to;
        private System.Windows.Forms.Label LBL_to;
        private System.Windows.Forms.TextBox TXT_subject;
        private System.Windows.Forms.Button BTN_toall;
        private System.Windows.Forms.Label LBL_subject;
        private System.Windows.Forms.TextBox TXT_from;
        private System.Windows.Forms.Label LBL_from;
        private System.Windows.Forms.TextBox TXT_file;
        private System.Windows.Forms.Button BTN_to;
        private System.Windows.Forms.Button BTN_sub;
        private System.Windows.Forms.Label LBL_sub;
        private System.Windows.Forms.Button BTN_care;
        private System.Windows.Forms.Label LBL_care;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource4;
        private MyDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button BTN_subChange;
        private System.Windows.Forms.Button BTN_careChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewCheckBoxColumn subsidyFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn subsidySDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caretakerFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caretakerSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caretakerFEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caretakerSEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caretakerFPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caretakerSPhoneDataGridViewTextBoxColumn;
    }
}

