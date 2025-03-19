namespace StudyApp
{
    partial class fillinanswer
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
            this.questionLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.questionLbl.Location = new System.Drawing.Point(27, 23);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(838, 56);
            this.questionLbl.TabIndex = 7;
            this.questionLbl.Text = "In computational thinking terms, breaking down a complex problem into smaller, mo" +
    "re specific sub-problems is called ___________. ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(38, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(815, 117);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // fillinanswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.questionLbl);
            this.Name = "fillinanswer";
            this.Size = new System.Drawing.Size(876, 223);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
