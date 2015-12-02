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
    public partial class VideoProcessorForm : Form
    {
        private VideoProcessorPresentationModel _presentationModel;
        private VideoModel _videoModel;

        public VideoProcessorForm()
        {
            _videoModel = new VideoModel();
            _presentationModel = new VideoProcessorPresentationModel();
            InitializeComponent();
            VideoControlPanelForm controlPanel = new VideoControlPanelForm(_videoModel);
            controlPanel.Show();
            BindData();

            BasicOperationForm basicOperationForm = new BasicOperationForm(_videoModel, _presentationModel);
            basicOperationForm.TopLevel = false;
            basicOperationForm.Dock = DockStyle.Fill;
            _basicOperationTabPage.Controls.Add(basicOperationForm);
            basicOperationForm.Show();

            MosaicForm mosaicForm = new MosaicForm(_videoModel, _presentationModel);
            mosaicForm.TopLevel = false;
            mosaicForm.Dock = DockStyle.Fill;
            _mosaicTabPage.Controls.Add(mosaicForm);
            mosaicForm.Show();

            AveragingForm averagingForm = new AveragingForm(_videoModel, _presentationModel);
            averagingForm.TopLevel = false;
            averagingForm.Dock = DockStyle.Fill;
            _averagingTabPage.Controls.Add(averagingForm);
            averagingForm.Show();

            SharpenForm sharpenForm = new SharpenForm(_videoModel, _presentationModel);
            sharpenForm.TopLevel = false;
            sharpenForm.Dock = DockStyle.Fill;
            _sharpenTabPage.Controls.Add(sharpenForm);
            sharpenForm.Show();

            EdgeDetectionForm edgeDetectionForm = new EdgeDetectionForm(_videoModel, _presentationModel);
            edgeDetectionForm.TopLevel = false;
            edgeDetectionForm.Dock = DockStyle.Fill;
            _edgeDetectiontabPage.Controls.Add(edgeDetectionForm);
            edgeDetectionForm.Show();
        }

        private void BindData()
        {
            const string TEXT_PROPERTY = "Text";
            const string HINT_LABEL_TEXT_PROPERTY_PRESENTATION_MODEL = "HintLabelText";

            _hintLabel.DataBindings.Add(TEXT_PROPERTY, _presentationModel, HINT_LABEL_TEXT_PROPERTY_PRESENTATION_MODEL);
        }

        private void ClickLoadVideoButton(object sender, EventArgs e)
        {
            _openVideoDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            DialogResult result = _openVideoDialog.ShowDialog();
            
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                _videoModel.VideoPath = _openVideoDialog.FileName;
            }
        }
    }
}
