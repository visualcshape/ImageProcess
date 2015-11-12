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

            ImagePreviewer previewer = new ImagePreviewer();
            previewer.Show();
            BindData();
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
            string ENABLE_PROPERTY = "Enabled";

            _restoreImageButton.DataBindings.Add(ENABLE_PROPERTY, _presentationModel, RESTORE_BUTTON_ENABLED_PROPERTY_NAME);
        }
    }
}
