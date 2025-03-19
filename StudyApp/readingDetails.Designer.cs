namespace StudyApp
{
    partial class readingDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(readingDetails));
            this.panel2 = new System.Windows.Forms.Panel();
            this.readingTxt = new System.Windows.Forms.RichTextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.checkLbl = new System.Windows.Forms.Label();
            this.checkPic = new System.Windows.Forms.PictureBox();
            this.completedBtn = new System.Windows.Forms.Button();
            this.readingLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.readingTxt);
            this.panel2.Controls.Add(this.nextBtn);
            this.panel2.Controls.Add(this.checkLbl);
            this.panel2.Controls.Add(this.checkPic);
            this.panel2.Controls.Add(this.completedBtn);
            this.panel2.Controls.Add(this.readingLbl);
            this.panel2.Location = new System.Drawing.Point(28, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 999);
            this.panel2.TabIndex = 21;
            // 
            // readingTxt
            // 
            this.readingTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readingTxt.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readingTxt.Location = new System.Drawing.Point(44, 84);
            this.readingTxt.Name = "readingTxt";
            this.readingTxt.Size = new System.Drawing.Size(836, 787);
            this.readingTxt.TabIndex = 22;
            this.readingTxt.Text = resources.GetString("readingTxt.Text");
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(44, 901);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(183, 40);
            this.nextBtn.TabIndex = 24;
            this.nextBtn.Text = "Go to next item";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // checkLbl
            // 
            this.checkLbl.AutoSize = true;
            this.checkLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(124)))), ((int)(((byte)(80)))));
            this.checkLbl.Location = new System.Drawing.Point(273, 912);
            this.checkLbl.Name = "checkLbl";
            this.checkLbl.Size = new System.Drawing.Size(92, 19);
            this.checkLbl.TabIndex = 22;
            this.checkLbl.Text = "Hoàn thành";
            // 
            // checkPic
            // 
            this.checkPic.BackgroundImage = global::StudyApp.Properties.Resources.green_tick2;
            this.checkPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkPic.Location = new System.Drawing.Point(235, 897);
            this.checkPic.Name = "checkPic";
            this.checkPic.Size = new System.Drawing.Size(42, 48);
            this.checkPic.TabIndex = 21;
            this.checkPic.TabStop = false;
            // 
            // completedBtn
            // 
            this.completedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.completedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completedBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedBtn.ForeColor = System.Drawing.Color.White;
            this.completedBtn.Location = new System.Drawing.Point(44, 901);
            this.completedBtn.Name = "completedBtn";
            this.completedBtn.Size = new System.Drawing.Size(183, 40);
            this.completedBtn.TabIndex = 20;
            this.completedBtn.Text = "Mask as completed";
            this.completedBtn.UseVisualStyleBackColor = false;
            this.completedBtn.Click += new System.EventHandler(this.completedBtn_Click);
            // 
            // readingLbl
            // 
            this.readingLbl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.readingLbl.Location = new System.Drawing.Point(0, 15);
            this.readingLbl.Name = "readingLbl";
            this.readingLbl.Size = new System.Drawing.Size(912, 55);
            this.readingLbl.TabIndex = 19;
            this.readingLbl.Text = "Contributor Acknowledgements";
            this.readingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panel2);
            this.Name = "readingDetails";
            this.Size = new System.Drawing.Size(968, 1049);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox readingTxt;
        private System.Windows.Forms.Label readingLbl;
        private System.Windows.Forms.Button completedBtn;
        private System.Windows.Forms.PictureBox checkPic;
        private System.Windows.Forms.Label checkLbl;
        private System.Windows.Forms.Button nextBtn;
    }
}
