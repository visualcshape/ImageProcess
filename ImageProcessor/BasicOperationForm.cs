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
        GeneralModel _generalModel;
        ImageProcessorPresentationModel _presenatationModel;

        public BasicOperationForm(GeneralModel generalModel,ImageProcessorPresentationModel presenationModel)
        {
            _generalModel = generalModel;
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
            ImageProcessFunctions functions = new ImageProcessFunctions();
            Image<Bgr, byte> grayImage = functions.GetGrayScale(_generalModel.ProcessedImage);
            _generalModel.ProcessedImage = grayImage;
        }

        private void ClickThresholdingButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int thresholdValue = _thresholdScaleTrackBar.Value;
            Image<Bgr, byte> thresholdImage = functions.GetThresholding(_generalModel.ProcessedImage,thresholdValue);
            _generalModel.ProcessedImage = thresholdImage;
        }

        private void ClickInverseButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            Image<Bgr, byte> inversedImage = functions.GetInverse(_generalModel.ProcessedImage);
            _generalModel.ProcessedImage = inversedImage;
        }
    }
}
