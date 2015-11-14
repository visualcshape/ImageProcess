namespace ImageProcessor
{
    partial class _imageProcessorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._imageProcessTabControl = new System.Windows.Forms.TabControl();
            this._basicOperationTabPage = new System.Windows.Forms.TabPage();
            this._mosaicTabPage = new System.Windows.Forms.TabPage();
            this._averagingTabPage = new System.Windows.Forms.TabPage();
            this._imageProcessTabPage4 = new System.Windows.Forms.TabPage();
            this._imageProcessTabPage5 = new System.Windows.Forms.TabPage();
            this._menuGroupBox = new System.Windows.Forms.GroupBox();
            this._openPreviewerButton = new System.Windows.Forms.Button();
            this._resetImageButton = new System.Windows.Forms.Button();
            this._loadImageButton = new System.Windows.Forms.Button();
            this._openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this._imageProcessTabControl.SuspendLayout();
            this._menuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this._imageProcessTabControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._menuGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 351);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _imageProcessTabControl
            // 
            this._imageProcessTabControl.Controls.Add(this._basicOperationTabPage);
            this._imageProcessTabControl.Controls.Add(this._mosaicTabPage);
            this._imageProcessTabControl.Controls.Add(this._averagingTabPage);
            this._imageProcessTabControl.Controls.Add(this._imageProcessTabPage4);
            this._imageProcessTabControl.Controls.Add(this._imageProcessTabPage5);
            this._imageProcessTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imageProcessTabControl.Location = new System.Drawing.Point(122, 3);
            this._imageProcessTabControl.Name = "_imageProcessTabControl";
            this._imageProcessTabControl.SelectedIndex = 0;
            this._imageProcessTabControl.Size = new System.Drawing.Size(470, 345);
            this._imageProcessTabControl.TabIndex = 0;
            // 
            // _basicOperationTabPage
            // 
            this._basicOperationTabPage.Location = new System.Drawing.Point(4, 22);
            this._basicOperationTabPage.Name = "_basicOperationTabPage";
            this._basicOperationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._basicOperationTabPage.Size = new System.Drawing.Size(462, 319);
            this._basicOperationTabPage.TabIndex = 0;
            this._basicOperationTabPage.Text = "Basic Operation";
            this._basicOperationTabPage.UseVisualStyleBackColor = true;
            // 
            // _mosaicTabPage
            // 
            this._mosaicTabPage.Location = new System.Drawing.Point(4, 22);
            this._mosaicTabPage.Name = "_mosaicTabPage";
            this._mosaicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._mosaicTabPage.Size = new System.Drawing.Size(462, 319);
            this._mosaicTabPage.TabIndex = 1;
            this._mosaicTabPage.Text = "Mosaic";
            this._mosaicTabPage.UseVisualStyleBackColor = true;
            // 
            // _averagingTabPage
            // 
            this._averagingTabPage.Location = new System.Drawing.Point(4, 22);
            this._averagingTabPage.Name = "_averagingTabPage";
            this._averagingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._averagingTabPage.Size = new System.Drawing.Size(462, 319);
            this._averagingTabPage.TabIndex = 2;
            this._averagingTabPage.Text = "Averaging";
            this._averagingTabPage.UseVisualStyleBackColor = true;
            // 
            // _imageProcessTabPage4
            // 
            this._imageProcessTabPage4.Location = new System.Drawing.Point(4, 22);
            this._imageProcessTabPage4.Name = "_imageProcessTabPage4";
            this._imageProcessTabPage4.Padding = new System.Windows.Forms.Padding(3);
            this._imageProcessTabPage4.Size = new System.Drawing.Size(590, 429);
            this._imageProcessTabPage4.TabIndex = 3;
            this._imageProcessTabPage4.Text = "4";
            this._imageProcessTabPage4.UseVisualStyleBackColor = true;
            // 
            // _imageProcessTabPage5
            // 
            this._imageProcessTabPage5.Location = new System.Drawing.Point(4, 22);
            this._imageProcessTabPage5.Name = "_imageProcessTabPage5";
            this._imageProcessTabPage5.Padding = new System.Windows.Forms.Padding(3);
            this._imageProcessTabPage5.Size = new System.Drawing.Size(590, 429);
            this._imageProcessTabPage5.TabIndex = 4;
            this._imageProcessTabPage5.Text = "5";
            this._imageProcessTabPage5.UseVisualStyleBackColor = true;
            // 
            // _menuGroupBox
            // 
            this._menuGroupBox.Controls.Add(this._openPreviewerButton);
            this._menuGroupBox.Controls.Add(this._resetImageButton);
            this._menuGroupBox.Controls.Add(this._loadImageButton);
            this._menuGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._menuGroupBox.Location = new System.Drawing.Point(3, 3);
            this._menuGroupBox.Name = "_menuGroupBox";
            this._menuGroupBox.Size = new System.Drawing.Size(113, 345);
            this._menuGroupBox.TabIndex = 1;
            this._menuGroupBox.TabStop = false;
            this._menuGroupBox.Text = "Menu";
            // 
            // _openPreviewerButton
            // 
            this._openPreviewerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._openPreviewerButton.Location = new System.Drawing.Point(3, 64);
            this._openPreviewerButton.Name = "_openPreviewerButton";
            this._openPreviewerButton.Size = new System.Drawing.Size(107, 23);
            this._openPreviewerButton.TabIndex = 2;
            this._openPreviewerButton.Text = "Open Previewer";
            this._openPreviewerButton.UseVisualStyleBackColor = true;
            this._openPreviewerButton.Click += new System.EventHandler(this.ClickOpenPreviewerButton);
            // 
            // _resetImageButton
            // 
            this._resetImageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._resetImageButton.Location = new System.Drawing.Point(3, 41);
            this._resetImageButton.Name = "_resetImageButton";
            this._resetImageButton.Size = new System.Drawing.Size(107, 23);
            this._resetImageButton.TabIndex = 1;
            this._resetImageButton.Text = "Reset the Image";
            this._resetImageButton.UseVisualStyleBackColor = true;
            this._resetImageButton.Click += new System.EventHandler(this.ClickRestoreImageButton);
            // 
            // _loadImageButton
            // 
            this._loadImageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._loadImageButton.Location = new System.Drawing.Point(3, 18);
            this._loadImageButton.Name = "_loadImageButton";
            this._loadImageButton.Size = new System.Drawing.Size(107, 23);
            this._loadImageButton.TabIndex = 0;
            this._loadImageButton.Text = "Load Image...";
            this._loadImageButton.UseVisualStyleBackColor = true;
            this._loadImageButton.Click += new System.EventHandler(this.ClickLoadImageButton);
            // 
            // _openImageDialog
            // 
            this._openImageDialog.Filter = "Images|*.jpg;*.png*.bmp;*.jpeg;*.PNG;*.BMP";
            // 
            // _imageProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 351);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "_imageProcessorForm";
            this.Text = "ImageProcessor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this._imageProcessTabControl.ResumeLayout(false);
            this._menuGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl _imageProcessTabControl;
        private System.Windows.Forms.TabPage _basicOperationTabPage;
        private System.Windows.Forms.TabPage _mosaicTabPage;
        private System.Windows.Forms.TabPage _averagingTabPage;
        private System.Windows.Forms.TabPage _imageProcessTabPage4;
        private System.Windows.Forms.TabPage _imageProcessTabPage5;
        private System.Windows.Forms.GroupBox _menuGroupBox;
        private System.Windows.Forms.Button _resetImageButton;
        private System.Windows.Forms.Button _loadImageButton;
        private System.Windows.Forms.OpenFileDialog _openImageDialog;
        private System.Windows.Forms.Button _openPreviewerButton;


    }
}

