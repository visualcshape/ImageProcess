using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class ImagePreviewer : Form
    {
        private GeneralModel _generalModel;
        private ImagePreviewerPresentationModel _presentationModel;

        public ImagePreviewer(GeneralModel generalModel)
        {
            _generalModel = generalModel;
            InitializeComponent();
            int borderWidth = (this.Width - this.ClientSize.Width) / 2;
            int titleBarHeight = this.Height - this.ClientSize.Height - 2 * borderWidth;
            _presentationModel = new ImagePreviewerPresentationModel(_generalModel,new Size(borderWidth,borderWidth+titleBarHeight));
            BindData();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            ImageProcessorPresentationModel presentationModel = ImageProcessorPresentationModel.ImageProcesseorPresentationModel;
            presentationModel.IsOpenPreviewerEnabled = true;
        }

        private void BindData()
        {
            const string VISIBLE_PROPERTY_NAME = "Visible";
            const string IMAGE_PROPERTY_NAME = "Image";
            const string SIZE_PROPERTY_NAME = "Size";

            const string INFORMATION_VISIBLE_PRESENTATION_PROPERTY_NAME = "IsInformationLabelVisible";
            const string IMAGE_PICTURE_BOX_PRESENTATION_PROPERTY_NAME = "PictureBoxImage";
            const string FORM_SIZE_PRESENTATION_PROPERTY_NAME = "FormSize";

            Binding previewerImageBinding = new Binding(IMAGE_PROPERTY_NAME, _presentationModel, IMAGE_PICTURE_BOX_PRESENTATION_PROPERTY_NAME);
            previewerImageBinding.FormattingEnabled = true;
            previewerImageBinding.NullValue = null;
            _informationLabel.DataBindings.Add(VISIBLE_PROPERTY_NAME, _presentationModel, INFORMATION_VISIBLE_PRESENTATION_PROPERTY_NAME);
            _previewerPictureBox.DataBindings.Add(previewerImageBinding);
            this.DataBindings.Add(SIZE_PROPERTY_NAME, _presentationModel, FORM_SIZE_PRESENTATION_PROPERTY_NAME);
        }
    }
}
