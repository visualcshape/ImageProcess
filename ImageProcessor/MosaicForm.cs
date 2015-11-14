﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV;

namespace ImageProcessor
{
    public partial class MosaicForm : Form
    {
        GeneralModel _generalModel;
        ImageProcessorPresentationModel _presentationModel;

        public MosaicForm(GeneralModel generalModel,ImageProcessorPresentationModel presentationModel)
        {
            _presentationModel = presentationModel;
            _generalModel = generalModel;
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            const string ENABLE_PROPERTY = "Enabled";
            const string ENABLE_PRESENTATION_PROPERTY_NAME = "IsProcessedButtonsEnabled";

            _mosaicButton.DataBindings.Add(ENABLE_PROPERTY, _presentationModel, ENABLE_PRESENTATION_PROPERTY_NAME);
        }

        private void ClickMosaicButton(object sender, EventArgs e)
        {
            ImageProcessFunctions functions = new ImageProcessFunctions();
            int matrixWidth = (int)_matrixWidthNumericUpDown.Value;
            int matrixHeight = (int)_matrixHeightNumericUpDown.Value;
            Image<Bgr, byte> mosaicImage = functions.GetMosaic(_generalModel.ProcessedImage, matrixWidth, matrixHeight);
            _generalModel.ProcessedImage = mosaicImage;
        }
    }
}
