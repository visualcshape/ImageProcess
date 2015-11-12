namespace ImageProcessor
{
    partial class ImagePreviewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._imagePreviewPanel = new System.Windows.Forms.Panel();
            this._previrePictureBox = new System.Windows.Forms.PictureBox();
            this._openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this._informationLabel = new System.Windows.Forms.Label();
            this._imagePreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._previrePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _imagePreviewPanel
            // 
            this._imagePreviewPanel.Controls.Add(this._informationLabel);
            this._imagePreviewPanel.Controls.Add(this._previrePictureBox);
            this._imagePreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imagePreviewPanel.Location = new System.Drawing.Point(0, 0);
            this._imagePreviewPanel.Name = "_imagePreviewPanel";
            this._imagePreviewPanel.Size = new System.Drawing.Size(744, 500);
            this._imagePreviewPanel.TabIndex = 0;
            // 
            // _previrePictureBox
            // 
            this._previrePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._previrePictureBox.Location = new System.Drawing.Point(0, 0);
            this._previrePictureBox.Name = "_previrePictureBox";
            this._previrePictureBox.Size = new System.Drawing.Size(744, 500);
            this._previrePictureBox.TabIndex = 0;
            this._previrePictureBox.TabStop = false;
            // 
            // _openImageDialog
            // 
            this._openImageDialog.FileName = "openFileDialog1";
            // 
            // _informationLabel
            // 
            this._informationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._informationLabel.Location = new System.Drawing.Point(0, 0);
            this._informationLabel.Name = "_informationLabel";
            this._informationLabel.Size = new System.Drawing.Size(744, 500);
            this._informationLabel.TabIndex = 1;
            this._informationLabel.Text = "請先載入圖片...";
            this._informationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImagePreviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 500);
            this.Controls.Add(this._imagePreviewPanel);
            this.Name = "ImagePreviewer";
            this.Text = "ImagePreviewer";
            this._imagePreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._previrePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _imagePreviewPanel;
        private System.Windows.Forms.PictureBox _previrePictureBox;
        private System.Windows.Forms.OpenFileDialog _openImageDialog;
        private System.Windows.Forms.Label _informationLabel;
    }
}