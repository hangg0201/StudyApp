namespace StudyApp
{
    partial class Main
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.progressBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAva = new StudyApp.RoundPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(316, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(766, 40);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.Location = new System.Drawing.Point(1464, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(185, 23);
            this.name.TabIndex = 13;
            this.name.Text = "Nguyễn Thị Ngọc Hà";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.doneBtn);
            this.panel1.Controls.Add(this.progressBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 799);
            this.panel1.TabIndex = 14;
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.logoutBtn.Image = global::StudyApp.Properties.Resources.logout1;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(2, 286);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(303, 66);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = " Đăng xuất";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.profileBtn.Image = global::StudyApp.Properties.Resources.profile;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(2, 216);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(303, 66);
            this.profileBtn.TabIndex = 7;
            this.profileBtn.Text = "      Trang cá nhân";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.FlatAppearance.BorderSize = 0;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.doneBtn.Image = global::StudyApp.Properties.Resources.donecourse;
            this.doneBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doneBtn.Location = new System.Drawing.Point(2, 146);
            this.doneBtn.Margin = new System.Windows.Forms.Padding(2);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(303, 66);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "   Hoàn thành";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // progressBtn
            // 
            this.progressBtn.FlatAppearance.BorderSize = 0;
            this.progressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.progressBtn.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.progressBtn.Image = global::StudyApp.Properties.Resources.inprogress1;
            this.progressBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.progressBtn.Location = new System.Drawing.Point(2, 76);
            this.progressBtn.Margin = new System.Windows.Forms.Padding(2);
            this.progressBtn.Name = "progressBtn";
            this.progressBtn.Size = new System.Drawing.Size(303, 66);
            this.progressBtn.TabIndex = 3;
            this.progressBtn.Text = "Đang học";
            this.progressBtn.UseVisualStyleBackColor = true;
            this.progressBtn.Click += new System.EventHandler(this.progressBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.homeBtn.Image = global::StudyApp.Properties.Resources.home;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(2, 0);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(303, 72);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "Trang chủ";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Location = new System.Drawing.Point(306, 130);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1406, 799);
            this.mainPanel.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::StudyApp.Properties.Resources.search;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1082, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ImageLocation = "C:\\Users\\COMPUTER\\source\\repos\\StudyApp\\StudyApp\\Resources\\logowithtext.png";
            this.pictureBox1.Location = new System.Drawing.Point(42, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picAva
            // 
            this.picAva.BackgroundImage = global::StudyApp.Properties.Resources.avatar;
            this.picAva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAva.Location = new System.Drawing.Point(1396, 35);
            this.picAva.Name = "picAva";
            this.picAva.Size = new System.Drawing.Size(50, 50);
            this.picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAva.TabIndex = 12;
            this.picAva.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1709, 924);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.picAva);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button progressBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundPictureBox picAva;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
    }
}

