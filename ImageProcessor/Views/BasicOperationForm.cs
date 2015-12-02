using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace ImageProcessor
{
    public partial class BasicOperationForm : Form
    {
        VideoModel _videoModel;
        VideoProcessorPresentationModel _presenatationModel;

        public BasicOperationForm(VideoModel videoModel,VideoProcessorPresentationModel presenationModel)
        {
            _videoModel = videoModel;
            _presenatationModel = presenationModel;
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            const string ENABLE_PROPERTY = "Enabled";
            const string ENABLE_PRESENTATION_PROPERTY_NAME = "IsProcessedButtonsEnabled";

            _grayScaleButton.DataBindings.Add(ENABLE_PROPERTY, _presenatationModel, ENABLE_PRESENTATION_PROPERTY_NAME);
            _thresholdingButton.DataBindings.Add(ENABLE_PROPERTY, _presenatationModel, ENABLE_PRESENTATION_PROPERTY_NAME);
            _inverseButton.DataBindings.Add(ENABLE_PROPERTY, _presenatationModel, ENABLE_PRESENTATION_PROPERTY_NAME);
        }

        private void ClickGrayScaleButton(object sender, EventArgs e)
        {
            _videoModel.SetProcessMethod(ImageProcessFunctions.Methods.GrayScale);
            _videoModel.Play();
        }

        private void ClickThresholdingButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int thresholdValue = _thresholdScaleTrackBar.Value;

            _videoModel.SetProcessMethod(ImageProcessFunctions.Methods.Thresholding, thresholdValue);
            _videoModel.Play();
        }

        private void ClickInverseButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            _videoModel.SetProcessMethod(ImageProcessFunctions.Methods.Inverse);
            _videoModel.Play();
        }
    }
}
