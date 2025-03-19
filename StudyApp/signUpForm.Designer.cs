namespace StudyApp
{
    partial class signUpForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.haveAccount = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.accountLbl = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.avatarLbl = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.emailLbl = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.errorUsername = new System.Windows.Forms.Label();
            this.errorPassword = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.errorEmail = new System.Windows.Forms.Label();
            this.errorAva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(213, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 52);
            this.label3.TabIndex = 19;
            this.label3.Text = "Get started";
            // 
            // haveAccount
            // 
            this.haveAccount.AutoSize = true;
            this.haveAccount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveAccount.ForeColor = System.Drawing.Color.Gray;
            this.haveAccount.Location = new System.Drawing.Point(182, 627);
            this.haveAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.haveAccount.Name = "haveAccount";
            this.haveAccount.Size = new System.Drawing.Size(185, 23);
            this.haveAccount.TabIndex = 18;
            this.haveAccount.Text = "Bạn đã có tài khoản?";
            this.haveAccount.Click += new System.EventHandler(this.haveAccount_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.signUpBtn.FlatAppearance.BorderSize = 0;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.Location = new System.Drawing.Point(87, 574);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(378, 39);
            this.signUpBtn.TabIndex = 15;
            this.signUpBtn.Text = "ĐĂNG KÝ";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.passwordLbl.Location = new System.Drawing.Point(74, 203);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(93, 23);
            this.passwordLbl.TabIndex = 14;
            this.passwordLbl.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(78, 239);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(387, 33);
            this.txtPassword.TabIndex = 13;
            // 
            // accountLbl
            // 
            this.accountLbl.AutoSize = true;
            this.accountLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.accountLbl.Location = new System.Drawing.Point(74, 122);
            this.accountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountLbl.Name = "accountLbl";
            this.accountLbl.Size = new System.Drawing.Size(96, 23);
            this.accountLbl.TabIndex = 12;
            this.accountLbl.Text = "Tài khoản:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(78, 154);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(387, 33);
            this.txtUsername.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StudyApp.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(95, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 79);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.nameLbl.Location = new System.Drawing.Point(74, 284);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(95, 23);
            this.nameLbl.TabIndex = 22;
            this.nameLbl.Text = "Họ và tên:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(78, 318);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 33);
            this.txtName.TabIndex = 21;
            // 
            // avatarLbl
            // 
            this.avatarLbl.AutoSize = true;
            this.avatarLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.avatarLbl.Location = new System.Drawing.Point(80, 463);
            this.avatarLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avatarLbl.Name = "avatarLbl";
            this.avatarLbl.Size = new System.Drawing.Size(68, 23);
            this.avatarLbl.TabIndex = 24;
            this.avatarLbl.Text = "Avatar:";
            // 
            // txtImage
            // 
            this.txtImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.Location = new System.Drawing.Point(84, 497);
            this.txtImage.Margin = new System.Windows.Forms.Padding(2);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(263, 33);
            this.txtImage.TabIndex = 23;
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(363, 497);
            this.uploadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(107, 30);
            this.uploadBtn.TabIndex = 25;
            this.uploadBtn.Text = "Browse..";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.emailLbl.Location = new System.Drawing.Point(74, 372);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(63, 23);
            this.emailLbl.TabIndex = 27;
            this.emailLbl.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(78, 406);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 33);
            this.txtEmail.TabIndex = 26;
            // 
            // errorUsername
            // 
            this.errorUsername.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorUsername.ForeColor = System.Drawing.Color.Maroon;
            this.errorUsername.Location = new System.Drawing.Point(273, 189);
            this.errorUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorUsername.Name = "errorUsername";
            this.errorUsername.Size = new System.Drawing.Size(192, 23);
            this.errorUsername.TabIndex = 28;
            this.errorUsername.Text = "Vui lòng không để trống";
            this.errorUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorPassword
            // 
            this.errorPassword.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPassword.ForeColor = System.Drawing.Color.Maroon;
            this.errorPassword.Location = new System.Drawing.Point(273, 274);
            this.errorPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorPassword.Name = "errorPassword";
            this.errorPassword.Size = new System.Drawing.Size(192, 23);
            this.errorPassword.TabIndex = 29;
            this.errorPassword.Text = "Vui lòng không để trống";
            this.errorPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorName
            // 
            this.errorName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorName.ForeColor = System.Drawing.Color.Maroon;
            this.errorName.Location = new System.Drawing.Point(273, 353);
            this.errorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(192, 23);
            this.errorName.TabIndex = 30;
            this.errorName.Text = "Vui lòng không để trống";
            this.errorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorEmail
            // 
            this.errorEmail.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEmail.ForeColor = System.Drawing.Color.Maroon;
            this.errorEmail.Location = new System.Drawing.Point(273, 441);
            this.errorEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(192, 23);
            this.errorEmail.TabIndex = 31;
            this.errorEmail.Text = "Vui lòng không để trống";
            this.errorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorAva
            // 
            this.errorAva.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAva.ForeColor = System.Drawing.Color.Maroon;
            this.errorAva.Location = new System.Drawing.Point(278, 532);
            this.errorAva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorAva.Name = "errorAva";
            this.errorAva.Size = new System.Drawing.Size(192, 23);
            this.errorAva.TabIndex = 32;
            this.errorAva.Text = "Vui lòng không để trống";
            this.errorAva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 688);
            this.Controls.Add(this.errorAva);
            this.Controls.Add(this.errorEmail);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.errorPassword);
            this.Controls.Add(this.errorUsername);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.avatarLbl);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.haveAccount);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.accountLbl);
            this.Controls.Add(this.txtUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "signUpForm";
            this.Text = "signUpForm";
            this.Load += new System.EventHandler(this.signUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label haveAccount;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label accountLbl;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label avatarLbl;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label errorUsername;
        private System.Windows.Forms.Label errorPassword;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.Label errorAva;
    }
}