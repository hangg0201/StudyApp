namespace StudyApp
{
    partial class homeCourse
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
            this.nameCourse = new System.Windows.Forms.Label();
            this.nameOrg = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.picOrg = new System.Windows.Forms.PictureBox();
            this.picCourse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // nameCourse
            // 
            this.nameCourse.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameCourse.Location = new System.Drawing.Point(13, 272);
            this.nameCourse.Name = "nameCourse";
            this.nameCourse.Size = new System.Drawing.Size(311, 49);
            this.nameCourse.TabIndex = 1;
            this.nameCourse.Text = "Python for Data Science, AI & Development";
            // 
            // nameOrg
            // 
            this.nameOrg.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOrg.ForeColor = System.Drawing.Color.Gray;
            this.nameOrg.Location = new System.Drawing.Point(46, 234);
            this.nameOrg.Name = "nameOrg";
            this.nameOrg.Size = new System.Drawing.Size(278, 26);
            this.nameOrg.TabIndex = 2;
            this.nameOrg.Text = "IBM";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.DimGray;
            this.course.Location = new System.Drawing.Point(13, 344);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(58, 19);
            this.course.TabIndex = 4;
            this.course.Text = "Course";
            // 
            // picOrg
            // 
            this.picOrg.BackgroundImage = global::StudyApp.Properties.Resources.coursera_projectnetwork_purplesquare;
            this.picOrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOrg.Location = new System.Drawing.Point(17, 234);
            this.picOrg.Name = "picOrg";
            this.picOrg.Size = new System.Drawing.Size(23, 23);
            this.picOrg.TabIndex = 3;
            this.picOrg.TabStop = false;
            // 
            // picCourse
            // 
            this.picCourse.BackColor = System.Drawing.Color.White;
            this.picCourse.BackgroundImage = global::StudyApp.Properties.Resources.pythonCourse;
            this.picCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCourse.Location = new System.Drawing.Point(15, 15);
            this.picCourse.Name = "picCourse";
            this.picCourse.Size = new System.Drawing.Size(309, 202);
            this.picCourse.TabIndex = 0;
            this.picCourse.TabStop = false;
            // 
            // homeCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.course);
            this.Controls.Add(this.picOrg);
            this.Controls.Add(this.nameOrg);
            this.Controls.Add(this.nameCourse);
            this.Controls.Add(this.picCourse);
            this.Name = "homeCourse";
            this.Size = new System.Drawing.Size(339, 397);
            ((System.ComponentModel.ISupportInitialize)(this.picOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCourse;
        private System.Windows.Forms.Label nameCourse;
        private System.Windows.Forms.Label nameOrg;
        private System.Windows.Forms.PictureBox picOrg;
        private System.Windows.Forms.Label course;
    }
}
