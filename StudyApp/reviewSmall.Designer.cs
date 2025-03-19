namespace StudyApp
{
    partial class reviewSmall
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
            this.components = new System.ComponentModel.Container();
            this.starLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reviewLbl = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // starLbl
            // 
            this.starLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.starLbl.Location = new System.Drawing.Point(234, 20);
            this.starLbl.Name = "starLbl";
            this.starLbl.Size = new System.Drawing.Size(34, 23);
            this.starLbl.TabIndex = 24;
            this.starLbl.Text = "5";
            this.starLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameLbl.Location = new System.Drawing.Point(26, 22);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(185, 45);
            this.nameLbl.TabIndex = 22;
            this.nameLbl.Text = "Nguyễn Thị Ngọc Hà";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // reviewLbl
            // 
            this.reviewLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reviewLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reviewLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewLbl.ForeColor = System.Drawing.Color.DimGray;
            this.reviewLbl.Location = new System.Drawing.Point(30, 61);
            this.reviewLbl.Name = "reviewLbl";
            this.reviewLbl.Size = new System.Drawing.Size(777, 45);
            this.reviewLbl.TabIndex = 28;
            this.reviewLbl.Text = "This course is what I really need to understand what is Computational Thinking. I" +
    " learned about all aspect of it. To who want to begin your road to Computer Scie" +
    "nce, this course is my recommend";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::StudyApp.Properties.Resources.star;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(198, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 23);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // reviewSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.reviewLbl);
            this.Controls.Add(this.starLbl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.nameLbl);
            this.Name = "reviewSmall";
            this.Size = new System.Drawing.Size(836, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label starLbl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox reviewLbl;
    }
}
