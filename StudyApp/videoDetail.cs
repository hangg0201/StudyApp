using System;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace StudyApp
{
    public partial class videoDetail : UserControl
    {
        public event EventHandler NextButtonClicked;
        public event EventHandler VideoCompleted;
        public videoDetail()
        {
            InitializeComponent();
        }

        public void content(string videoPath)
        {

            videoPlayer.URL = videoPath;
            videoPlayer.Ctlcontrols.play();
        }

        public void Stop()
        {
            if (videoPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                videoPlayer.Ctlcontrols.pause();
            }   
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }


        private void videoPlayer_PositionChange(object sender, _WMPOCXEvents_PositionChangeEvent e)
        {
            if (videoPlayer.currentMedia != null)
            {
                double duration = videoPlayer.currentMedia.duration;
                if (e.newPosition >= duration * 0.9)
                {
                    VideoCompleted?.Invoke(this, EventArgs.Empty); 
                }
            }
        }

        public void completed()
        {

        }
    }
}
