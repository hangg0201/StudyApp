namespace StudyApp
{
    partial class doneCourse
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
            this.orgLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.certBtn = new System.Windows.Forms.Button();
            this.courseLbl = new System.Windows.Forms.Label();
            this.rateLbl = new System.Windows.Forms.Label();
            this.picThumb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // orgLbl
            // 
            this.orgLbl.AutoSize = true;
            this.orgLbl.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgLbl.ForeColor = System.Drawing.Color.DimGray;
            this.orgLbl.Location = new System.Drawing.Point(352, 22);
            this.orgLbl.Name = "orgLbl";
            this.orgLbl.Size = new System.Drawing.Size(37, 19);
            this.orgLbl.TabIndex = 28;
            this.orgLbl.Text = "IBM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(991, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 100);
            this.panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(280, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Course  |  ";
            // 
            // certBtn
            // 
            this.certBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.certBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.certBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certBtn.ForeColor = System.Drawing.Color.White;
            this.certBtn.Location = new System.Drawing.Point(1115, 40);
            this.certBtn.Name = "certBtn";
            this.certBtn.Size = new System.Drawing.Size(173, 40);
            this.certBtn.TabIndex = 29;
            this.certBtn.Text = "Xem chứng nhận";
            this.certBtn.UseVisualStyleBackColor = false;
            this.certBtn.Click += new System.EventHandler(this.certBtn_Click);
            // 
            // courseLbl
            // 
            this.courseLbl.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.courseLbl.Location = new System.Drawing.Point(281, 61);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(696, 67);
            this.courseLbl.TabIndex = 18;
            this.courseLbl.Text = "Python for Data Science, AI & Development";
            // 
            // rateLbl
            // 
            this.rateLbl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.rateLbl.Location = new System.Drawing.Point(1164, 83);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(70, 49);
            this.rateLbl.TabIndex = 30;
            this.rateLbl.Text = "Review";
            this.rateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rateLbl.Click += new System.EventHandler(this.rateLbl_Click);
            // 
            // picThumb
            // 
            this.picThumb.BackColor = System.Drawing.Color.White;
            this.picThumb.BackgroundImage = global::StudyApp.Properties.Resources.pythonCourse;
            this.picThumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picThumb.Location = new System.Drawing.Point(26, 13);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(207, 132);
            this.picThumb.TabIndex = 17;
            this.picThumb.TabStop = false;
            // 
            // doneCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rateLbl);
            this.Controls.Add(this.certBtn);
            this.Controls.Add(this.orgLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courseLbl);
            this.Controls.Add(this.picThumb);
            this.Name = "doneCourse";
            this.Size = new System.Drawing.Size(1406, 160);
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orgLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picThumb;
        private System.Windows.Forms.Button certBtn;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.Label rateLbl;
    }
}
