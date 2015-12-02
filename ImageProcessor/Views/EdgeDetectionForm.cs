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
    public partial class EdgeDetectionForm : Form
    {
        VideoModel _videoModel;
        VideoProcessorPresentationModel _presentationModel;

        public EdgeDetectionForm(VideoModel videoModel, VideoProcessorPresentationModel presentaionModel)
        {
            _videoModel = videoModel;
            _presentationModel = presentaionModel;
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            const string ENABLE_PROPERTY = "Enabled";
            const string ENABLE_PRESENTATION_PROPERTY_NAME = "IsProcessedButtonsEnabled";

            _sobelButton.DataBindings.Add(ENABLE_PROPERTY, _presentationModel, ENABLE_PRESENTATION_PROPERTY_NAME);
            _cannyButton.DataBindings.Add(ENABLE_PROPERTY, _presentationModel, ENABLE_PRESENTATION_PROPERTY_NAME);
            _laplacianButton.DataBindings.Add(ENABLE_PROPERTY, _presentationModel, ENABLE_PRESENTATION_PROPERTY_NAME);
        }

        private void ClickSobelButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int threshold = (int)_sobelThresholdNumericUpDown.Value;

            _videoModel.SetProcessMethod(ImageProcessFunctions.Methods.Sobel, threshold);
            _videoModel.Play();
        }

        private void ClickLaplacianButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int aperture = (int)_apertureSizeNumericupDown.Value;

            _videoModel.SetProcessMethod(ImageProcessFunctions.Methods.Laplacian, aperture);
            _videoModel.Play();
        }

        private void ClickCannyButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int thresh = (int)_cannyThreshNumericUpDown.Value;
            int threshLinking = (int)_cannyThreshLinkingNumericUpDown.Value;

            _videoModel.SetProcessMethod(ImageProcessFunctions.Methods.Canny, thresh, threshLinking);
            _videoModel.Play();
        }
    }
}
