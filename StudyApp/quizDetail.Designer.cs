namespace StudyApp
{
    partial class quizDetail
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
            this.scoreLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.quizLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.retryBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkLbl = new System.Windows.Forms.Label();
            this.checkPic = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPic)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLbl
            // 
            this.scoreLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scoreLbl.Location = new System.Drawing.Point(239, 913);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(40, 19);
            this.scoreLbl.TabIndex = 22;
            this.scoreLbl.Text = "0";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(44, 901);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(183, 40);
            this.submitBtn.TabIndex = 20;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // quizLbl
            // 
            this.quizLbl.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.quizLbl.Location = new System.Drawing.Point(0, 26);
            this.quizLbl.Name = "quizLbl";
            this.quizLbl.Size = new System.Drawing.Size(909, 55);
            this.quizLbl.TabIndex = 19;
            this.quizLbl.Text = "Foundations of Computational Thinking Quiz";
            this.quizLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.retryBtn);
            this.panel2.Controls.Add(this.nextBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkLbl);
            this.panel2.Controls.Add(this.checkPic);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.scoreLbl);
            this.panel2.Controls.Add(this.submitBtn);
            this.panel2.Controls.Add(this.quizLbl);
            this.panel2.Location = new System.Drawing.Point(28, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 999);
            this.panel2.TabIndex = 23;
            // 
            // retryBtn
            // 
            this.retryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.retryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retryBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryBtn.ForeColor = System.Drawing.Color.White;
            this.retryBtn.Location = new System.Drawing.Point(44, 902);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.Size = new System.Drawing.Size(183, 40);
            this.retryBtn.TabIndex = 28;
            this.retryBtn.Text = "Retry";
            this.retryBtn.UseVisualStyleBackColor = false;
            this.retryBtn.Click += new System.EventHandler(this.retryBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(666, 901);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(183, 40);
            this.nextBtn.TabIndex = 27;
            this.nextBtn.Text = "Go to next item";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(275, 912);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "/100";
            // 
            // checkLbl
            // 
            this.checkLbl.AutoSize = true;
            this.checkLbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(124)))), ((int)(((byte)(80)))));
            this.checkLbl.Location = new System.Drawing.Point(379, 912);
            this.checkLbl.Name = "checkLbl";
            this.checkLbl.Size = new System.Drawing.Size(92, 19);
            this.checkLbl.TabIndex = 25;
            this.checkLbl.Text = "Hoàn thành";
            // 
            // checkPic
            // 
            this.checkPic.BackgroundImage = global::StudyApp.Properties.Resources.green_tick2;
            this.checkPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkPic.Location = new System.Drawing.Point(331, 894);
            this.checkPic.Name = "checkPic";
            this.checkPic.Size = new System.Drawing.Size(42, 48);
            this.checkPic.TabIndex = 24;
            this.checkPic.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(909, 735);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // quizDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panel2);
            this.Name = "quizDetail";
            this.Size = new System.Drawing.Size(968, 1049);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label quizLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label checkLbl;
        private System.Windows.Forms.PictureBox checkPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button retryBtn;
    }
}
