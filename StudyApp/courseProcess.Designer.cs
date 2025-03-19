namespace StudyApp
{
    partial class courseProcess
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
            this.coursePn = new System.Windows.Forms.FlowLayoutPanel();
            this.courseLbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lessonLbl = new System.Windows.Forms.Label();
            this.viewDetailPn = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // coursePn
            // 
            this.coursePn.AutoScroll = true;
            this.coursePn.BackColor = System.Drawing.Color.White;
            this.coursePn.Location = new System.Drawing.Point(51, 186);
            this.coursePn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coursePn.Name = "coursePn";
            this.coursePn.Size = new System.Drawing.Size(507, 1626);
            this.coursePn.TabIndex = 9;
            // 
            // courseLbl
            // 
            this.courseLbl.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.courseLbl.Location = new System.Drawing.Point(50, 60);
            this.courseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(510, 103);
            this.courseLbl.TabIndex = 10;
            this.courseLbl.Text = "Python for Data Science, AI & Development";
            this.courseLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lessonLbl
            // 
            this.lessonLbl.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lessonLbl.Location = new System.Drawing.Point(664, 102);
            this.lessonLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lessonLbl.Name = "lessonLbl";
            this.lessonLbl.Size = new System.Drawing.Size(1374, 66);
            this.lessonLbl.TabIndex = 18;
            this.lessonLbl.Text = "Welcome to Computational Thinking";
            // 
            // viewDetailPn
            // 
            this.viewDetailPn.Location = new System.Drawing.Point(612, 186);
            this.viewDetailPn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewDetailPn.Name = "viewDetailPn";
            this.viewDetailPn.Size = new System.Drawing.Size(1426, 1626);
            this.viewDetailPn.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::StudyApp.Properties.Resources.arrow_right;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(604, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 31);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = global::StudyApp.Properties.Resources.arrow_left;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(22, 28);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(52, 31);
            this.backBtn.TabIndex = 8;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // courseProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewDetailPn);
            this.Controls.Add(this.lessonLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.courseLbl);
            this.Controls.Add(this.coursePn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "courseProcess";
            this.Size = new System.Drawing.Size(2109, 1853);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.FlowLayoutPanel coursePn;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lessonLbl;
        private System.Windows.Forms.FlowLayoutPanel viewDetailPn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
