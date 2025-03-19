namespace StudyApp
{
    partial class userReview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.avaPic = new StudyApp.RoundPictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.starLbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.contentLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // avaPic
            // 
            this.avaPic.BackgroundImage = global::StudyApp.Properties.Resources.avatar;
            this.avaPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avaPic.Location = new System.Drawing.Point(34, 35);
            this.avaPic.Name = "avaPic";
            this.avaPic.Size = new System.Drawing.Size(50, 50);
            this.avaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.avaPic.TabIndex = 13;
            this.avaPic.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameLbl.Location = new System.Drawing.Point(102, 45);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(185, 45);
            this.nameLbl.TabIndex = 14;
            this.nameLbl.Text = "Nguyễn Thị Ngọc Hà";
            // 
            // starLbl
            // 
            this.starLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.starLbl.Location = new System.Drawing.Point(354, 16);
            this.starLbl.Name = "starLbl";
            this.starLbl.Size = new System.Drawing.Size(34, 23);
            this.starLbl.TabIndex = 18;
            this.starLbl.Text = "5";
            this.starLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::StudyApp.Properties.Resources.star;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(323, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 23);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // contentLbl
            // 
            this.contentLbl.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contentLbl.Location = new System.Drawing.Point(320, 49);
            this.contentLbl.Name = "contentLbl";
            this.contentLbl.Size = new System.Drawing.Size(901, 56);
            this.contentLbl.TabIndex = 20;
            this.contentLbl.Text = "This course is what I really need to understand what is Computational Thinking. I" +
    " learned about all aspect of it. To who want to begin your road to Computer Scie" +
    "nce, this course is my recommend";
            // 
            // userReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentLbl);
            this.Controls.Add(this.starLbl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.avaPic);
            this.Name = "userReview";
            this.Size = new System.Drawing.Size(1244, 125);
            ((System.ComponentModel.ISupportInitialize)(this.avaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundPictureBox avaPic;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label starLbl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label contentLbl;
    }
}
