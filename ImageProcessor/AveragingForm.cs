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
    public partial class AveragingForm : Form
    {
        GeneralModel _generalModel;
        ImageProcessorPresentationModel _presentationModel;

        public AveragingForm(GeneralModel generalModel,ImageProcessorPresentationModel presentationModel)
        {
            _generalModel = generalModel;
            _presentationModel = presentationModel;
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            const string ENABLE_PROPERTY = "Enabled";
            const string ENABLE_PRESENTATION_PROPERTY_NAME = "IsProcessedButtonsEnabled";

            _averagingButton.DataBindings.Add(ENABLE_PROPERTY, _presentationModel, ENABLE_PRESENTATION_PROPERTY_NAME);
        }

        private void ClickAveragingButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int matrixWidth = (int)_matrixWidthNumericUpDown.Value;
            int matrixHeight = (int)_matrixHeightNumericUpDown.Value;
            Image<Bgr, byte> averagedImage = functions.GetAveraging(_generalModel.ProcessedImage, matrixWidth, matrixHeight);
            _generalModel.ProcessedImage = averagedImage;
        }
    }
}
