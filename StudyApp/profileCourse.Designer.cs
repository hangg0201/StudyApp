namespace StudyApp
{
    partial class profileCourse
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.Label();
            this.picThumb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(231, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Overall progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(229, -18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Course  |  IBM";
            // 
            // courseName
            // 
            this.courseName.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.courseName.Location = new System.Drawing.Point(158, 35);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(637, 24);
            this.courseName.TabIndex = 14;
            this.courseName.Text = "Python for Data Science, AI & Development";
            // 
            // picThumb
            // 
            this.picThumb.BackColor = System.Drawing.Color.White;
            this.picThumb.BackgroundImage = global::StudyApp.Properties.Resources.pythonCourse;
            this.picThumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picThumb.Location = new System.Drawing.Point(18, 16);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(110, 68);
            this.picThumb.TabIndex = 13;
            this.picThumb.TabStop = false;
            // 
            // profileCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.picThumb);
            this.Name = "profileCourse";
            this.Size = new System.Drawing.Size(869, 99);
            this.Load += new System.EventHandler(this.profileCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.PictureBox picThumb;
    }
}
