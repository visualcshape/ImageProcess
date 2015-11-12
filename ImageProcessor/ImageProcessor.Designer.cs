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
            this._imageProcessTabPage1 = new System.Windows.Forms.TabPage();
            this._imageProcessTabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._imageProcessTabPage4 = new System.Windows.Forms.TabPage();
            this._imageProcessTabPage5 = new System.Windows.Forms.TabPage();
            this._menuGroupBox = new System.Windows.Forms.GroupBox();
            this._restoreImageButton = new System.Windows.Forms.Button();
            this._loadImageButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _imageProcessTabControl
            // 
            this._imageProcessTabControl.Controls.Add(this._imageProcessTabPage1);
            this._imageProcessTabControl.Controls.Add(this._imageProcessTabPage2);
            this._imageProcessTabControl.Controls.Add(this.tabPage1);
            this._imageProcessTabControl.Controls.Add(this._imageProcessTabPage4);
            this._imageProcessTabControl.Controls.Add(this._imageProcessTabPage5);
            this._imageProcessTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imageProcessTabControl.Location = new System.Drawing.Point(153, 3);
            this._imageProcessTabControl.Name = "_imageProcessTabControl";
            this._imageProcessTabControl.SelectedIndex = 0;
            this._imageProcessTabControl.Size = new System.Drawing.Size(598, 455);
            this._imageProcessTabControl.TabIndex = 0;
            // 
            // _imageProcessTabPage1
            // 
            this._imageProcessTabPage1.Location = new System.Drawing.Point(4, 22);
            this._imageProcessTabPage1.Name = "_imageProcessTabPage1";
            this._imageProcessTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this._imageProcessTabPage1.Size = new System.Drawing.Size(590, 429);
            this._imageProcessTabPage1.TabIndex = 0;
            this._imageProcessTabPage1.Text = "1";
            this._imageProcessTabPage1.UseVisualStyleBackColor = true;
            // 
            // _imageProcessTabPage2
            // 
            this._imageProcessTabPage2.Location = new System.Drawing.Point(4, 22);
            this._imageProcessTabPage2.Name = "_imageProcessTabPage2";
            this._imageProcessTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._imageProcessTabPage2.Size = new System.Drawing.Size(590, 429);
            this._imageProcessTabPage2.TabIndex = 1;
            this._imageProcessTabPage2.Text = "2";
            this._imageProcessTabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 429);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "3";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this._menuGroupBox.Controls.Add(this._restoreImageButton);
            this._menuGroupBox.Controls.Add(this._loadImageButton);
            this._menuGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._menuGroupBox.Location = new System.Drawing.Point(3, 3);
            this._menuGroupBox.Name = "_menuGroupBox";
            this._menuGroupBox.Size = new System.Drawing.Size(144, 455);
            this._menuGroupBox.TabIndex = 1;
            this._menuGroupBox.TabStop = false;
            this._menuGroupBox.Text = "Menu";
            // 
            // _restoreImageButton
            // 
            this._restoreImageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._restoreImageButton.Location = new System.Drawing.Point(3, 41);
            this._restoreImageButton.Name = "_restoreImageButton";
            this._restoreImageButton.Size = new System.Drawing.Size(138, 23);
            this._restoreImageButton.TabIndex = 1;
            this._restoreImageButton.Text = "Restore the Image";
            this._restoreImageButton.UseVisualStyleBackColor = true;
            // 
            // _loadImageButton
            // 
            this._loadImageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._loadImageButton.Location = new System.Drawing.Point(3, 18);
            this._loadImageButton.Name = "_loadImageButton";
            this._loadImageButton.Size = new System.Drawing.Size(138, 23);
            this._loadImageButton.TabIndex = 0;
            this._loadImageButton.Text = "Load Image...";
            this._loadImageButton.UseVisualStyleBackColor = true;
            this._loadImageButton.Click += new System.EventHandler(this.ClickLoadImageButton);
            // 
            // _imageProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 461);
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
        private System.Windows.Forms.TabPage _imageProcessTabPage1;
        private System.Windows.Forms.TabPage _imageProcessTabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage _imageProcessTabPage4;
        private System.Windows.Forms.TabPage _imageProcessTabPage5;
        private System.Windows.Forms.GroupBox _menuGroupBox;
        private System.Windows.Forms.Button _restoreImageButton;
        private System.Windows.Forms.Button _loadImageButton;


    }
}

