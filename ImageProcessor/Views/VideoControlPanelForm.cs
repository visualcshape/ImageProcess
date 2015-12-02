using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor.PresentaionModel;

namespace ImageProcessor
{
    public partial class VideoControlPanelForm : Form
    {
        VideoControlPanelFormPresentationModel _presentationModel;
        VideoModel _videoModel;

        public VideoControlPanelForm(VideoModel videoModel)
        {
            _videoModel = videoModel;
            _presentationModel = new VideoControlPanelFormPresentationModel(_videoModel);
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            const string ENABLED_PROPERTY = "Enabled";
            const string STOP_BUTTON_ENABLED_PROPERTY_NAME_PRESENTATION_MODEL = "IsStopButtonEnabled";
            const string PLAY_BUTTON_ENABLED_PROPERTY_NAME_PRESENTATION_MODEL = "IsPlayButtonEnabled";
            const string PAUSE_BUTTON_ENABLED_PROPERTY_NAME_PRESENTATION_MODEL = "IsPauseButtonEnabled";

            _stopButton.DataBindings.Add(ENABLED_PROPERTY, _presentationModel, STOP_BUTTON_ENABLED_PROPERTY_NAME_PRESENTATION_MODEL);
            _playButton.DataBindings.Add(ENABLED_PROPERTY, _presentationModel, PLAY_BUTTON_ENABLED_PROPERTY_NAME_PRESENTATION_MODEL);
            _pauseButton.DataBindings.Add(ENABLED_PROPERTY, _presentationModel, PAUSE_BUTTON_ENABLED_PROPERTY_NAME_PRESENTATION_MODEL);

        }

        private void ClickStopButton(object sender, EventArgs e)
        {
            _videoModel.Stop();
        }

        private void ClickPlayButton(object sender, EventArgs e)
        {
            _videoModel.Play();
        }

        private void ClickPauseButton(object sender, EventArgs e)
        {
            _videoModel.Pause();
        }
    }
}
