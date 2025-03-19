namespace StudyApp
{
    partial class SignInForm
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.accountLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.showPwd = new System.Windows.Forms.CheckBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.forgotPassLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(64, 220);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(387, 33);
            this.txtUsername.TabIndex = 1;
            // 
            // accountLbl
            // 
            this.accountLbl.AutoSize = true;
            this.accountLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.accountLbl.Location = new System.Drawing.Point(60, 182);
            this.accountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountLbl.Name = "accountLbl";
            this.accountLbl.Size = new System.Drawing.Size(96, 23);
            this.accountLbl.TabIndex = 2;
            this.accountLbl.Text = "Tài khoản:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.passwordLbl.Location = new System.Drawing.Point(60, 280);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(93, 23);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(64, 322);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(387, 33);
            this.txtPassword.TabIndex = 3;
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(64, 419);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(2);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(386, 39);
            this.signInBtn.TabIndex = 5;
            this.signInBtn.Text = "ĐĂNG NHẬP";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // showPwd
            // 
            this.showPwd.AutoSize = true;
            this.showPwd.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.showPwd.Location = new System.Drawing.Point(312, 374);
            this.showPwd.Margin = new System.Windows.Forms.Padding(2);
            this.showPwd.Name = "showPwd";
            this.showPwd.Size = new System.Drawing.Size(145, 22);
            this.showPwd.TabIndex = 6;
            this.showPwd.Text = "Hiển thị mật khẩu";
            this.showPwd.UseVisualStyleBackColor = true;
            this.showPwd.CheckedChanged += new System.EventHandler(this.showPwd_CheckedChanged);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.White;
            this.signUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.signUpBtn.Location = new System.Drawing.Point(64, 477);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(386, 39);
            this.signUpBtn.TabIndex = 7;
            this.signUpBtn.Text = "ĐĂNG KÝ";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // forgotPassLbl
            // 
            this.forgotPassLbl.AutoSize = true;
            this.forgotPassLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLbl.ForeColor = System.Drawing.Color.Gray;
            this.forgotPassLbl.Location = new System.Drawing.Point(179, 539);
            this.forgotPassLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forgotPassLbl.Name = "forgotPassLbl";
            this.forgotPassLbl.Size = new System.Drawing.Size(145, 23);
            this.forgotPassLbl.TabIndex = 8;
            this.forgotPassLbl.Text = "Quên mật khẩu?";
            this.forgotPassLbl.Click += new System.EventHandler(this.forgotPassLbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(90, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 58);
            this.label3.TabIndex = 9;
            this.label3.Text = "Welcome back";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(431, 606);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StudyApp.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(198, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 79);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 608);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forgotPassLbl);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.showPwd);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.accountLbl);
            this.Controls.Add(this.txtUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignInForm";
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label accountLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.CheckBox showPwd;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label forgotPassLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}