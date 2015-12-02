namespace ImageProcessor
{
    partial class VideoProcessorForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoProcessorForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._imageProcessTabControl = new System.Windows.Forms.TabControl();
            this._basicOperationTabPage = new System.Windows.Forms.TabPage();
            this._mosaicTabPage = new System.Windows.Forms.TabPage();
            this._averagingTabPage = new System.Windows.Forms.TabPage();
            this._sharpenTabPage = new System.Windows.Forms.TabPage();
            this._edgeDetectiontabPage = new System.Windows.Forms.TabPage();
            this._menuGroupBox = new System.Windows.Forms.GroupBox();
            this._loadVideoButton = new System.Windows.Forms.Button();
            this._hintLabel = new System.Windows.Forms.Label();
            this._informationPictureBox = new System.Windows.Forms.PictureBox();
            this._openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this._openVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this._imageProcessTabControl.SuspendLayout();
            this._menuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._informationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this._imageProcessTabControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._menuGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._hintLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._informationPictureBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 351);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _imageProcessTabControl
            // 
            this._imageProcessTabControl.Controls.Add(this._basicOperationTabPage);
            this._imageProcessTabControl.Controls.Add(this._mosaicTabPage);
            this._imageProcessTabControl.Controls.Add(this._averagingTabPage);
            this._imageProcessTabControl.Controls.Add(this._sharpenTabPage);
            this._imageProcessTabControl.Controls.Add(this._edgeDetectiontabPage);
            this._imageProcessTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imageProcessTabControl.Location = new System.Drawing.Point(122, 3);
            this._imageProcessTabControl.Name = "_imageProcessTabControl";
            this._imageProcessTabControl.SelectedIndex = 0;
            this._imageProcessTabControl.Size = new System.Drawing.Size(470, 325);
            this._imageProcessTabControl.TabIndex = 0;
            // 
            // _basicOperationTabPage
            // 
            this._basicOperationTabPage.Location = new System.Drawing.Point(4, 22);
            this._basicOperationTabPage.Name = "_basicOperationTabPage";
            this._basicOperationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._basicOperationTabPage.Size = new System.Drawing.Size(462, 299);
            this._basicOperationTabPage.TabIndex = 0;
            this._basicOperationTabPage.Text = "Basic Operation";
            this._basicOperationTabPage.UseVisualStyleBackColor = true;
            // 
            // _mosaicTabPage
            // 
            this._mosaicTabPage.Location = new System.Drawing.Point(4, 22);
            this._mosaicTabPage.Name = "_mosaicTabPage";
            this._mosaicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._mosaicTabPage.Size = new System.Drawing.Size(462, 299);
            this._mosaicTabPage.TabIndex = 1;
            this._mosaicTabPage.Text = "Mosaic";
            this._mosaicTabPage.UseVisualStyleBackColor = true;
            // 
            // _averagingTabPage
            // 
            this._averagingTabPage.Location = new System.Drawing.Point(4, 22);
            this._averagingTabPage.Name = "_averagingTabPage";
            this._averagingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._averagingTabPage.Size = new System.Drawing.Size(462, 299);
            this._averagingTabPage.TabIndex = 2;
            this._averagingTabPage.Text = "Averaging";
            this._averagingTabPage.UseVisualStyleBackColor = true;
            // 
            // _sharpenTabPage
            // 
            this._sharpenTabPage.Location = new System.Drawing.Point(4, 22);
            this._sharpenTabPage.Name = "_sharpenTabPage";
            this._sharpenTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._sharpenTabPage.Size = new System.Drawing.Size(462, 299);
            this._sharpenTabPage.TabIndex = 3;
            this._sharpenTabPage.Text = "Sharpen - High-Boost Filter";
            this._sharpenTabPage.UseVisualStyleBackColor = true;
            // 
            // _edgeDetectiontabPage
            // 
            this._edgeDetectiontabPage.Location = new System.Drawing.Point(4, 22);
            this._edgeDetectiontabPage.Name = "_edgeDetectiontabPage";
            this._edgeDetectiontabPage.Padding = new System.Windows.Forms.Padding(3);
            this._edgeDetectiontabPage.Size = new System.Drawing.Size(462, 299);
            this._edgeDetectiontabPage.TabIndex = 4;
            this._edgeDetectiontabPage.Text = "Edge Detection";
            this._edgeDetectiontabPage.UseVisualStyleBackColor = true;
            // 
            // _menuGroupBox
            // 
            this._menuGroupBox.Controls.Add(this._loadVideoButton);
            this._menuGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._menuGroupBox.Location = new System.Drawing.Point(3, 3);
            this._menuGroupBox.Name = "_menuGroupBox";
            this._menuGroupBox.Size = new System.Drawing.Size(113, 325);
            this._menuGroupBox.TabIndex = 1;
            this._menuGroupBox.TabStop = false;
            this._menuGroupBox.Text = "Menu";
            // 
            // _loadVideoButton
            // 
            this._loadVideoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._loadVideoButton.Location = new System.Drawing.Point(3, 18);
            this._loadVideoButton.Name = "_loadVideoButton";
            this._loadVideoButton.Size = new System.Drawing.Size(107, 23);
            this._loadVideoButton.TabIndex = 3;
            this._loadVideoButton.Text = "Load Video...";
            this._loadVideoButton.UseVisualStyleBackColor = true;
            this._loadVideoButton.Click += new System.EventHandler(this.ClickLoadVideoButton);
            // 
            // _hintLabel
            // 
            this._hintLabel.AutoSize = true;
            this._hintLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._hintLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._hintLabel.Location = new System.Drawing.Point(122, 331);
            this._hintLabel.Name = "_hintLabel";
            this._hintLabel.Size = new System.Drawing.Size(317, 20);
            this._hintLabel.TabIndex = 2;
            this._hintLabel.Text = "載入影片後，按下任一影像處理方法鍵便會開始撥放影片。";
            this._hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _informationPictureBox
            // 
            this._informationPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this._informationPictureBox.Image = global::ImageProcessor.Properties.Resources.info_128;
            this._informationPictureBox.Location = new System.Drawing.Point(3, 334);
            this._informationPictureBox.Name = "_informationPictureBox";
            this._informationPictureBox.Size = new System.Drawing.Size(113, 14);
            this._informationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._informationPictureBox.TabIndex = 3;
            this._informationPictureBox.TabStop = false;
            // 
            // _openImageDialog
            // 
            this._openImageDialog.Filter = "Images|*.jpg;*.png*.bmp;*.jpeg;*.PNG;*.BMP";
            // 
            // _openVideoDialog
            // 
            this._openVideoDialog.Filter = "Video|*.avi;*.AVI;*.mov;*.MOV";
            // 
            // VideoProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 351);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoProcessorForm";
            this.Text = "Video Processor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._imageProcessTabControl.ResumeLayout(false);
            this._menuGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._informationPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl _imageProcessTabControl;
        private System.Windows.Forms.TabPage _basicOperationTabPage;
        private System.Windows.Forms.TabPage _mosaicTabPage;
        private System.Windows.Forms.TabPage _averagingTabPage;
        private System.Windows.Forms.TabPage _sharpenTabPage;
        private System.Windows.Forms.TabPage _edgeDetectiontabPage;
        private System.Windows.Forms.GroupBox _menuGroupBox;
        private System.Windows.Forms.OpenFileDialog _openImageDialog;
        private System.Windows.Forms.Button _loadVideoButton;
        private System.Windows.Forms.OpenFileDialog _openVideoDialog;
        private System.Windows.Forms.Label _hintLabel;
        private System.Windows.Forms.PictureBox _informationPictureBox;


    }
}

