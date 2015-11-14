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
    public partial class ImageProcessorForm : Form
    {
        private ImageProcessorPresentationModel _presentationModel;
        private GeneralModel _generalModel;

        public ImageProcessorForm()
        {
            _generalModel = new GeneralModel();
            _presentationModel = new ImageProcessorPresentationModel(_generalModel);
            InitializeComponent();

            BindData();
            ImagePreviewer previewer = new ImagePreviewer(_generalModel);
            previewer.Show();

            BasicOperationForm basicOperationForm = new BasicOperationForm(_generalModel, _presentationModel);
            basicOperationForm.TopLevel = false;
            basicOperationForm.Dock = DockStyle.Fill;
            _basicOperationTabPage.Controls.Add(basicOperationForm);
            basicOperationForm.Show();

            MosaicForm mosaicForm = new MosaicForm(_generalModel, _presentationModel);
            mosaicForm.TopLevel = false;
            mosaicForm.Dock = DockStyle.Fill;
            _mosaicTabPage.Controls.Add(mosaicForm);
            mosaicForm.Show();

            AveragingForm averagingForm = new AveragingForm(_generalModel, _presentationModel);
            averagingForm.TopLevel = false;
            averagingForm.Dock = DockStyle.Fill;
            _averagingTabPage.Controls.Add(averagingForm);
            averagingForm.Show();

            SharpenForm sharpenForm = new SharpenForm(_generalModel, _presentationModel);
            sharpenForm.TopLevel = false;
            sharpenForm.Dock = DockStyle.Fill;
            _sharpenTabPage.Controls.Add(sharpenForm);
            sharpenForm.Show();
        }

        private void ClickLoadImageButton(object sender, EventArgs e)
        {
            _openImageDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            DialogResult dialogResult = _openImageDialog.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                _generalModel.ImagePath = _openImageDialog.FileName;
                _presentationModel.IsImageButtonEnabled = true;
                _presentationModel.IsProcessedButtonsEnabled = true;
            }
            else
            {
                MessageBox.Show("Cannot open file.");
            }
            return;
        }

        private void BindData()
        {
            const string RESTORE_BUTTON_ENABLED_PROPERTY_NAME = "IsImageButtonEnabled";
            const string OPEN_PREVIEWER_ENABLED_PROPERTY_NAME = "IsOpenPreviewerEnabled";
            const string ENABLE_PROPERTY = "Enabled";

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
