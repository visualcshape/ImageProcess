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
    public partial class SharpenForm : Form
    {
        GeneralModel _generalModel;
        ImageProcessorPresentationModel _presentationModel;

        public SharpenForm(GeneralModel generalModel,ImageProcessorPresentationModel presentaionModel)
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

            _highBoostFilteringButton.DataBindings.Add(ENABLE_PROPERTY, _presentationModel, ENABLE_PRESENTATION_PROPERTY_NAME);
        }

        private void ClickHighBoostFilteringButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int allFactor = (int)_allPassFactorNumericUpDown.Value;
            Image<Bgr, byte> filteredImage = functions.GetHighBoostFilteredImage(_generalModel.ProcessedImage, allFactor);
            _generalModel.ProcessedImage = filteredImage;
        }
    }
}
