namespace StudyApp
{
    partial class videoDetailsProgress
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
            this.lessonLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.picType = new System.Windows.Forms.PictureBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            this.SuspendLayout();
            // 
            // lessonLbl
            // 
            this.lessonLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lessonLbl.Location = new System.Drawing.Point(88, 20);
            this.lessonLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lessonLbl.Name = "lessonLbl";
            this.lessonLbl.Size = new System.Drawing.Size(354, 37);
            this.lessonLbl.TabIndex = 15;
            this.lessonLbl.Text = "Python for Data Science, AI & Development";
            // 
            // typeLbl
            // 
            this.typeLbl.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typeLbl.Location = new System.Drawing.Point(100, 58);
            this.typeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(96, 37);
            this.typeLbl.TabIndex = 16;
            this.typeLbl.Text = "Video";
            // 
            // picType
            // 
            this.picType.BackColor = System.Drawing.Color.Transparent;
            this.picType.BackgroundImage = global::StudyApp.Properties.Resources.video1;
            this.picType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picType.Location = new System.Drawing.Point(10, 30);
            this.picType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picType.Name = "picType";
            this.picType.Size = new System.Drawing.Size(68, 38);
            this.picType.TabIndex = 17;
            this.picType.TabStop = false;
            // 
            // timeLbl
            // 
            this.timeLbl.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeLbl.Location = new System.Drawing.Point(236, 58);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(83, 37);
            this.timeLbl.TabIndex = 18;
            this.timeLbl.Text = "15 min";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(196, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "-";
            // 
            // videoDetailsProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.picType);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.lessonLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "videoDetailsProgress";
            this.Size = new System.Drawing.Size(470, 95);
            ((System.ComponentModel.ISupportInitialize)(this.picType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lessonLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label label3;
    }
}
