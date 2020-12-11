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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PICT_foto = new System.Windows.Forms.PictureBox();
            this.LBL_name = new System.Windows.Forms.Label();
            this.TXT_name = new System.Windows.Forms.TextBox();
            this.TXT_surname = new System.Windows.Forms.TextBox();
            this.LBL_surname = new System.Windows.Forms.Label();
            this.TXT_group = new System.Windows.Forms.TextBox();
            this.LBL_group = new System.Windows.Forms.Label();
            this.LBL_dob = new System.Windows.Forms.Label();
            this.TXT_phone = new System.Windows.Forms.TextBox();
            this.LBL_phone = new System.Windows.Forms.Label();
            this.TXT_address = new System.Windows.Forms.TextBox();
            this.LBL_address = new System.Windows.Forms.Label();
            this.BTN_add = new System.Windows.Forms.Button();
            this.DGV_table = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataBaseDataSet = new TeacherDB.MyDataBaseDataSet();
            this.BTN_change = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.BTN_deleteall = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.studentTableAdapter = new TeacherDB.MyDataBaseDataSetTableAdapters.StudentTableAdapter();
            this.BTN_backToGroup = new System.Windows.Forms.Button();
            this.TXT_dob = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PICT_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PICT_foto
            // 
            this.PICT_foto.BackColor = System.Drawing.Color.Wheat;
            this.PICT_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PICT_foto.Location = new System.Drawing.Point(3, 3);
            this.PICT_foto.Name = "PICT_foto";
            this.PICT_foto.Size = new System.Drawing.Size(163, 180);
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
            this.LBL_name.Location = new System.Drawing.Point(172, 3);
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
            this.LBL_surname.Location = new System.Drawing.Point(172, 34);
            this.LBL_surname.Name = "LBL_surname";
            this.LBL_surname.Size = new System.Drawing.Size(82, 25);
            this.LBL_surname.TabIndex = 3;
            this.LBL_surname.Text = "Surname";
            // 
            // TXT_group
            // 
            this.TXT_group.BackColor = System.Drawing.Color.Wheat;
            this.TXT_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_group.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_group.Location = new System.Drawing.Point(323, 65);
            this.TXT_group.Multiline = true;
            this.TXT_group.Name = "TXT_group";
            this.TXT_group.Size = new System.Drawing.Size(116, 25);
            this.TXT_group.TabIndex = 6;
            // 
            // LBL_group
            // 
            this.LBL_group.AutoSize = true;
            this.LBL_group.BackColor = System.Drawing.Color.Wheat;
            this.LBL_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_group.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_group.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_group.Location = new System.Drawing.Point(172, 65);
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
            this.LBL_dob.Location = new System.Drawing.Point(172, 96);
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
            this.LBL_phone.Location = new System.Drawing.Point(172, 127);
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
            this.LBL_address.Location = new System.Drawing.Point(172, 158);
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
            this.BTN_add.Location = new System.Drawing.Point(514, 22);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(96, 32);
            this.BTN_add.TabIndex = 14;
            this.BTN_add.Text = "Add";
            this.BTN_add.UseVisualStyleBackColor = false;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // DGV_table
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DGV_table.AutoGenerateColumns = false;
            this.DGV_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_table.BackgroundColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.fotoDataGridViewTextBoxColumn});
            this.DGV_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_table.DataSource = this.studentBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_table.DefaultCellStyle = dataGridViewCellStyle16;
            this.DGV_table.GridColor = System.Drawing.Color.Maroon;
            this.DGV_table.Location = new System.Drawing.Point(15, 210);
            this.DGV_table.Name = "DGV_table";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.BlanchedAlmond;
            this.DGV_table.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DGV_table.Size = new System.Drawing.Size(598, 258);
            this.DGV_table.TabIndex = 15;
            this.DGV_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_table_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.BlanchedAlmond;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // fotoDataGridViewTextBoxColumn
            // 
            this.fotoDataGridViewTextBoxColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewTextBoxColumn.HeaderText = "Foto";
            this.fotoDataGridViewTextBoxColumn.Name = "fotoDataGridViewTextBoxColumn";
            this.fotoDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "MyDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTN_change
            // 
            this.BTN_change.BackColor = System.Drawing.Color.Wheat;
            this.BTN_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_change.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_change.Location = new System.Drawing.Point(514, 60);
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
            this.BTN_delete.Location = new System.Drawing.Point(514, 98);
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
            this.BTN_deleteall.Location = new System.Drawing.Point(514, 136);
            this.BTN_deleteall.Name = "BTN_deleteall";
            this.BTN_deleteall.Size = new System.Drawing.Size(96, 32);
            this.BTN_deleteall.TabIndex = 18;
            this.BTN_deleteall.Text = "Delete all";
            this.BTN_deleteall.UseVisualStyleBackColor = false;
            this.BTN_deleteall.Click += new System.EventHandler(this.BTN_deleteall_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // BTN_backToGroup
            // 
            this.BTN_backToGroup.BackColor = System.Drawing.Color.Wheat;
            this.BTN_backToGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_backToGroup.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_backToGroup.Location = new System.Drawing.Point(15, 474);
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
            this.panel1.Controls.Add(this.PICT_foto);
            this.panel1.Controls.Add(this.TXT_dob);
            this.panel1.Controls.Add(this.LBL_name);
            this.panel1.Controls.Add(this.TXT_name);
            this.panel1.Controls.Add(this.LBL_surname);
            this.panel1.Controls.Add(this.TXT_surname);
            this.panel1.Controls.Add(this.LBL_group);
            this.panel1.Controls.Add(this.TXT_group);
            this.panel1.Controls.Add(this.LBL_dob);
            this.panel1.Controls.Add(this.TXT_address);
            this.panel1.Controls.Add(this.LBL_phone);
            this.panel1.Controls.Add(this.LBL_address);
            this.panel1.Controls.Add(this.TXT_phone);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 192);
            this.panel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(624, 516);
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
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PICT_foto;
        private System.Windows.Forms.Label LBL_name;
        private System.Windows.Forms.TextBox TXT_name;
        private System.Windows.Forms.TextBox TXT_surname;
        private System.Windows.Forms.Label LBL_surname;
        private System.Windows.Forms.TextBox TXT_group;
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
        private MyDataBaseDataSet myDataBaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MyDataBaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button BTN_backToGroup;
        private System.Windows.Forms.TextBox TXT_dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}

