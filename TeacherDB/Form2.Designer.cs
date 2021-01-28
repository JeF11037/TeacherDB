namespace TeacherDB
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXT_pass = new System.Windows.Forms.TextBox();
            this.LBL_pass = new System.Windows.Forms.Label();
            this.TXT_email = new System.Windows.Forms.TextBox();
            this.LBL_email = new System.Windows.Forms.Label();
            this.TXT_user = new System.Windows.Forms.TextBox();
            this.LBL_user = new System.Windows.Forms.Label();
            this.TXT_pass2 = new System.Windows.Forms.TextBox();
            this.LBL_pass2 = new System.Windows.Forms.Label();
            this.BTN_login = new System.Windows.Forms.Button();
            this.BTN_reg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TXT_pass2);
            this.panel1.Controls.Add(this.LBL_pass2);
            this.panel1.Controls.Add(this.TXT_email);
            this.panel1.Controls.Add(this.LBL_email);
            this.panel1.Controls.Add(this.TXT_pass);
            this.panel1.Controls.Add(this.LBL_pass);
            this.panel1.Controls.Add(this.TXT_user);
            this.panel1.Controls.Add(this.LBL_user);
            this.panel1.Location = new System.Drawing.Point(126, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 275);
            this.panel1.TabIndex = 6;
            // 
            // TXT_pass
            // 
            this.TXT_pass.BackColor = System.Drawing.Color.Wheat;
            this.TXT_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_pass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_pass.Location = new System.Drawing.Point(8, 101);
            this.TXT_pass.Multiline = true;
            this.TXT_pass.Name = "TXT_pass";
            this.TXT_pass.PasswordChar = '*';
            this.TXT_pass.Size = new System.Drawing.Size(116, 25);
            this.TXT_pass.TabIndex = 7;
            this.TXT_pass.UseSystemPasswordChar = true;
            // 
            // LBL_pass
            // 
            this.LBL_pass.AutoSize = true;
            this.LBL_pass.BackColor = System.Drawing.Color.Wheat;
            this.LBL_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_pass.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_pass.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_pass.Location = new System.Drawing.Point(23, 73);
            this.LBL_pass.Name = "LBL_pass";
            this.LBL_pass.Size = new System.Drawing.Size(88, 25);
            this.LBL_pass.TabIndex = 6;
            this.LBL_pass.Text = "Password";
            // 
            // TXT_email
            // 
            this.TXT_email.BackColor = System.Drawing.Color.Wheat;
            this.TXT_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_email.Location = new System.Drawing.Point(8, 233);
            this.TXT_email.Multiline = true;
            this.TXT_email.Name = "TXT_email";
            this.TXT_email.Size = new System.Drawing.Size(116, 25);
            this.TXT_email.TabIndex = 9;
            // 
            // LBL_email
            // 
            this.LBL_email.AutoSize = true;
            this.LBL_email.BackColor = System.Drawing.Color.Wheat;
            this.LBL_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_email.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_email.Location = new System.Drawing.Point(38, 203);
            this.LBL_email.Name = "LBL_email";
            this.LBL_email.Size = new System.Drawing.Size(55, 25);
            this.LBL_email.TabIndex = 8;
            this.LBL_email.Text = "Email";
            // 
            // TXT_user
            // 
            this.TXT_user.BackColor = System.Drawing.Color.Wheat;
            this.TXT_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_user.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_user.Location = new System.Drawing.Point(9, 38);
            this.TXT_user.Multiline = true;
            this.TXT_user.Name = "TXT_user";
            this.TXT_user.Size = new System.Drawing.Size(116, 25);
            this.TXT_user.TabIndex = 5;
            // 
            // LBL_user
            // 
            this.LBL_user.AutoSize = true;
            this.LBL_user.BackColor = System.Drawing.Color.Wheat;
            this.LBL_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_user.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_user.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_user.Location = new System.Drawing.Point(44, 10);
            this.LBL_user.Name = "LBL_user";
            this.LBL_user.Size = new System.Drawing.Size(49, 25);
            this.LBL_user.TabIndex = 4;
            this.LBL_user.Text = "User";
            // 
            // TXT_pass2
            // 
            this.TXT_pass2.BackColor = System.Drawing.Color.Wheat;
            this.TXT_pass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_pass2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TXT_pass2.Location = new System.Drawing.Point(8, 166);
            this.TXT_pass2.Multiline = true;
            this.TXT_pass2.Name = "TXT_pass2";
            this.TXT_pass2.PasswordChar = '*';
            this.TXT_pass2.Size = new System.Drawing.Size(116, 25);
            this.TXT_pass2.TabIndex = 11;
            this.TXT_pass2.UseSystemPasswordChar = true;
            this.TXT_pass2.Visible = false;
            // 
            // LBL_pass2
            // 
            this.LBL_pass2.AutoSize = true;
            this.LBL_pass2.BackColor = System.Drawing.Color.Wheat;
            this.LBL_pass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_pass2.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_pass2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_pass2.Location = new System.Drawing.Point(23, 138);
            this.LBL_pass2.Name = "LBL_pass2";
            this.LBL_pass2.Size = new System.Drawing.Size(88, 25);
            this.LBL_pass2.TabIndex = 10;
            this.LBL_pass2.Text = "Password";
            this.LBL_pass2.Visible = false;
            // 
            // BTN_login
            // 
            this.BTN_login.BackColor = System.Drawing.Color.Wheat;
            this.BTN_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_login.Location = new System.Drawing.Point(142, 313);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(96, 32);
            this.BTN_login.TabIndex = 19;
            this.BTN_login.Text = "Login";
            this.BTN_login.UseVisualStyleBackColor = false;
            this.BTN_login.Click += new System.EventHandler(this.BTN_deleteall_Click);
            // 
            // BTN_reg
            // 
            this.BTN_reg.BackColor = System.Drawing.Color.Wheat;
            this.BTN_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_reg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BTN_reg.Location = new System.Drawing.Point(124, 351);
            this.BTN_reg.Name = "BTN_reg";
            this.BTN_reg.Size = new System.Drawing.Size(127, 32);
            this.BTN_reg.TabIndex = 20;
            this.BTN_reg.Text = "Registration";
            this.BTN_reg.UseVisualStyleBackColor = false;
            this.BTN_reg.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.BTN_reg);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXT_pass2;
        private System.Windows.Forms.Label LBL_pass2;
        private System.Windows.Forms.TextBox TXT_email;
        private System.Windows.Forms.Label LBL_email;
        private System.Windows.Forms.TextBox TXT_pass;
        private System.Windows.Forms.Label LBL_pass;
        private System.Windows.Forms.TextBox TXT_user;
        private System.Windows.Forms.Label LBL_user;
        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Button BTN_reg;
    }
}