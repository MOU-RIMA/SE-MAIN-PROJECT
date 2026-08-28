namespace General_Shop_Billing_System
{
    partial class ProfileAdmin
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
            this.pnlEditManagerInfo = new System.Windows.Forms.Panel();
            this.btnBackProfileAdmin = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnUpdateProfileAdmin = new System.Windows.Forms.Button();
            this.lblUpdateProfile = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIDNo = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblNIDNo = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.pnlEditManagerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditManagerInfo
            // 
            this.pnlEditManagerInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlEditManagerInfo.Controls.Add(this.btnBackProfileAdmin);
            this.pnlEditManagerInfo.Controls.Add(this.cmbGender);
            this.pnlEditManagerInfo.Controls.Add(this.lblGender);
            this.pnlEditManagerInfo.Controls.Add(this.btnUpdateProfileAdmin);
            this.pnlEditManagerInfo.Controls.Add(this.lblUpdateProfile);
            this.pnlEditManagerInfo.Controls.Add(this.lblDOB);
            this.pnlEditManagerInfo.Controls.Add(this.dtpDOB);
            this.pnlEditManagerInfo.Controls.Add(this.txtName);
            this.pnlEditManagerInfo.Controls.Add(this.txtNIDNo);
            this.pnlEditManagerInfo.Controls.Add(this.txtSalary);
            this.pnlEditManagerInfo.Controls.Add(this.txtPassword);
            this.pnlEditManagerInfo.Controls.Add(this.txtPhoneNo);
            this.pnlEditManagerInfo.Controls.Add(this.txtEmail);
            this.pnlEditManagerInfo.Controls.Add(this.txtUserId);
            this.pnlEditManagerInfo.Controls.Add(this.lblName);
            this.pnlEditManagerInfo.Controls.Add(this.lblEmail);
            this.pnlEditManagerInfo.Controls.Add(this.lblPhoneNo);
            this.pnlEditManagerInfo.Controls.Add(this.lblNIDNo);
            this.pnlEditManagerInfo.Controls.Add(this.lblSalary);
            this.pnlEditManagerInfo.Controls.Add(this.lblPassword);
            this.pnlEditManagerInfo.Controls.Add(this.lblUserId);
            this.pnlEditManagerInfo.Location = new System.Drawing.Point(-2, -1);
            this.pnlEditManagerInfo.Name = "pnlEditManagerInfo";
            this.pnlEditManagerInfo.Size = new System.Drawing.Size(1078, 682);
            this.pnlEditManagerInfo.TabIndex = 1;
            // 
            // btnBackProfileAdmin
            // 
            this.btnBackProfileAdmin.BackColor = System.Drawing.Color.LightCoral;
            this.btnBackProfileAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackProfileAdmin.Location = new System.Drawing.Point(962, 13);
            this.btnBackProfileAdmin.Name = "btnBackProfileAdmin";
            this.btnBackProfileAdmin.Size = new System.Drawing.Size(102, 42);
            this.btnBackProfileAdmin.TabIndex = 67;
            this.btnBackProfileAdmin.Text = "Back";
            this.btnBackProfileAdmin.UseVisualStyleBackColor = false;
            this.btnBackProfileAdmin.Click += new System.EventHandler(this.btnBackProfileAdmin_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(736, 308);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(223, 24);
            this.cmbGender.TabIndex = 64;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(594, 308);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 63;
            this.lblGender.Text = "Gender";
            // 
            // btnUpdateProfileAdmin
            // 
            this.btnUpdateProfileAdmin.BackColor = System.Drawing.Color.Lavender;
            this.btnUpdateProfileAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfileAdmin.Location = new System.Drawing.Point(460, 516);
            this.btnUpdateProfileAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProfileAdmin.Name = "btnUpdateProfileAdmin";
            this.btnUpdateProfileAdmin.Size = new System.Drawing.Size(217, 58);
            this.btnUpdateProfileAdmin.TabIndex = 61;
            this.btnUpdateProfileAdmin.Text = "Update";
            this.btnUpdateProfileAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateProfileAdmin.Click += new System.EventHandler(this.btnUpdateProfileAdmin_Click);
            // 
            // lblUpdateProfile
            // 
            this.lblUpdateProfile.AutoSize = true;
            this.lblUpdateProfile.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateProfile.Location = new System.Drawing.Point(417, 68);
            this.lblUpdateProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateProfile.Name = "lblUpdateProfile";
            this.lblUpdateProfile.Size = new System.Drawing.Size(210, 41);
            this.lblUpdateProfile.TabIndex = 60;
            this.lblUpdateProfile.Text = "Update Profile";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(109, 429);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(145, 25);
            this.lblDOB.TabIndex = 59;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(284, 429);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(223, 22);
            this.dtpDOB.TabIndex = 58;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(284, 245);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 22);
            this.txtName.TabIndex = 57;
            // 
            // txtNIDNo
            // 
            this.txtNIDNo.Location = new System.Drawing.Point(736, 177);
            this.txtNIDNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIDNo.Name = "txtNIDNo";
            this.txtNIDNo.Size = new System.Drawing.Size(223, 22);
            this.txtNIDNo.TabIndex = 56;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(736, 239);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(223, 22);
            this.txtSalary.TabIndex = 55;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(736, 378);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 22);
            this.txtPassword.TabIndex = 54;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(284, 378);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(223, 22);
            this.txtPhoneNo.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(284, 314);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 22);
            this.txtEmail.TabIndex = 52;
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(284, 177);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(223, 22);
            this.txtUserId.TabIndex = 51;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(109, 239);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 25);
            this.lblName.TabIndex = 50;
            this.lblName.Text = "Name :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(109, 308);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 25);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "Email :";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(109, 372);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(114, 25);
            this.lblPhoneNo.TabIndex = 48;
            this.lblPhoneNo.Text = "Phone No:";
            // 
            // lblNIDNo
            // 
            this.lblNIDNo.AutoSize = true;
            this.lblNIDNo.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIDNo.Location = new System.Drawing.Point(591, 177);
            this.lblNIDNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIDNo.Name = "lblNIDNo";
            this.lblNIDNo.Size = new System.Drawing.Size(96, 25);
            this.lblNIDNo.TabIndex = 47;
            this.lblNIDNo.Text = "NID No:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(591, 239);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(86, 25);
            this.lblSalary.TabIndex = 46;
            this.lblSalary.Text = "Salary :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(594, 378);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(116, 25);
            this.lblPassword.TabIndex = 45;
            this.lblPassword.Text = "Password :";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(109, 177);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(90, 25);
            this.lblUserId.TabIndex = 44;
            this.lblUserId.Text = "User Id:";
            // 
            // ProfileAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 680);
            this.Controls.Add(this.pnlEditManagerInfo);
            this.Name = "ProfileAdmin";
            this.Text = "ProfileAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileAdmin_FormClosing);
            this.Load += new System.EventHandler(this.ProfileAdmin_Load);
            this.pnlEditManagerInfo.ResumeLayout(false);
            this.pnlEditManagerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditManagerInfo;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnUpdateProfileAdmin;
        private System.Windows.Forms.Label lblUpdateProfile;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNIDNo;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblNIDNo;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnBackProfileAdmin;
    }
}