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
        GeneralModel _generalModel;
        ImageProcessorPresentationModel _presentationModel;

        public EdgeDetectionForm(GeneralModel generalModel, ImageProcessorPresentationModel presentaionModel)
        {
            _generalModel = generalModel;
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

            Image<Bgr, byte> sobelImage = functions.GetSobel(_generalModel.ProcessedImage, threshold);
            _generalModel.ProcessedImage = sobelImage;
        }

        private void ClickLaplacianButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int aperture = (int)_apertureSizeNumericupDown.Value;
            Image<Bgr, byte> laplacianImage = functions.GetLaplacian(_generalModel.ProcessedImage, aperture);
            _generalModel.ProcessedImage = laplacianImage;
        }

        private void ClickCannyButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int thresh = (int)_cannyThreshNumericUpDown.Value;
            int threshLinking = (int)_cannyThreshLinkingNumericUpDown.Value;

            Image<Bgr, byte> cannyImage = functions.GetCanny(_generalModel.ProcessedImage, thresh, threshLinking);
            _generalModel.ProcessedImage = cannyImage;
        }
    }
}
