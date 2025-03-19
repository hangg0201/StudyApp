namespace StudyApp
{
    partial class videoDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(videoDetail));
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.nextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(28, 25);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(912, 491);
            this.videoPlayer.TabIndex = 18;
            this.videoPlayer.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.videoPlayer_PositionChange);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(844, 528);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(95, 40);
            this.nextBtn.TabIndex = 21;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // videoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.videoPlayer);
            this.Name = "videoDetail";
            this.Size = new System.Drawing.Size(968, 1049);
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Button nextBtn;
    }
}
