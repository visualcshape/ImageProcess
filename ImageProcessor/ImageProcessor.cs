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
    public partial class _imageProcessorForm : Form
    {
        private ImageProcessorPresentationModel _presentationModel;
        private GeneralModel _generalModel;

        public _imageProcessorForm()
        {
            _generalModel = new GeneralModel();
            _presentationModel = new ImageProcessorPresentationModel(_generalModel);
            InitializeComponent();

            BindData();
            ImagePreviewer previewer = new ImagePreviewer(_generalModel);
            previewer.Show();

            BasicOperationForm basicOperationForm = new BasicOperationForm();
            basicOperationForm.TopLevel = false;
            basicOperationForm.Dock = DockStyle.Fill;
            _basicOperationTabPage.Controls.Add(basicOperationForm);
            basicOperationForm.Show();

            MosaicForm mosaicForm = new MosaicForm();
            mosaicForm.TopLevel = false;
            mosaicForm.Dock = DockStyle.Fill;
            _mosaicTabPage.Controls.Add(mosaicForm);
            mosaicForm.Show();

            AveragingForm averagingForm = new AveragingForm();
            averagingForm.TopLevel = false;
            averagingForm.Dock = DockStyle.Fill;
            _averagingTabPage.Controls.Add(averagingForm);
            averagingForm.Show();
        }

        private void ClickLoadImageButton(object sender, EventArgs e)
        {
            _openImageDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            DialogResult dialogResult = _openImageDialog.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                _generalModel.ImagePath = _openImageDialog.FileName;
                _presentationModel.IsImageButtonEnabled = true;
            }
            else
            {

            }
            return;
        }

        private void BindData()
        {
            string RESTORE_BUTTON_ENABLED_PROPERTY_NAME = "IsImageButtonEnabled";
            string OPEN_PREVIEWER_ENABLED_PROPERTY_NAME = "IsOpenPreviewerEnabled";
            string ENABLE_PROPERTY = "Enabled";

            _resetImageButton.DataBindings.Add(ENABLE_PROPERTY, _presentationModel, RESTORE_BUTTON_ENABLED_PROPERTY_NAME);
            _openPreviewerButton.DataBindings.Add(ENABLE_PROPERTY, _presentationModel, OPEN_PREVIEWER_ENABLED_PROPERTY_NAME);
        }

        private void ClickOpenPreviewerButton(object sender, EventArgs e)
        {
            ImagePreviewer previewerForm = new ImagePreviewer(_generalModel);
            previewerForm.Show();
            _presentationModel.IsOpenPreviewerEnabled = false;
        }

        private void ClickRestoreImageButton(object sender, EventArgs e)
        {
            _generalModel.ResetToOriginalImage();
        }
    }
}
