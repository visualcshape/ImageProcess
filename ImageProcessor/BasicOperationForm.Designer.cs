namespace ImageProcessor
{
    partial class BasicOperationForm
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
            this._inverseButton = new System.Windows.Forms.Button();
            this._grayScaleButton = new System.Windows.Forms.Button();
            this._thresholdGroupBox = new System.Windows.Forms.GroupBox();
            this._thresholdTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._thresholdScaleTrackBar = new System.Windows.Forms.TrackBar();
            this._thresholdingButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._thresholdGroupBox.SuspendLayout();
            this._thresholdTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._thresholdScaleTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _inverseButton
            // 
            this._inverseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._inverseButton.Location = new System.Drawing.Point(3, 183);
            this._inverseButton.Name = "_inverseButton";
            this._inverseButton.Size = new System.Drawing.Size(278, 24);
            this._inverseButton.TabIndex = 2;
            this._inverseButton.Text = "Inverse";
            this._inverseButton.UseVisualStyleBackColor = true;
            this._inverseButton.Click += new System.EventHandler(this.ClickInverseButton);
            // 
            // _grayScaleButton
            // 
            this._grayScaleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grayScaleButton.Location = new System.Drawing.Point(3, 53);
            this._grayScaleButton.Name = "_grayScaleButton";
            this._grayScaleButton.Size = new System.Drawing.Size(278, 24);
            this._grayScaleButton.TabIndex = 0;
            this._grayScaleButton.Text = "Gray Scale";
            this._grayScaleButton.UseVisualStyleBackColor = true;
            this._grayScaleButton.Click += new System.EventHandler(this.ClickGrayScaleButton);
            // 
            // _thresholdGroupBox
            // 
            this._thresholdGroupBox.Controls.Add(this._thresholdTableLayoutPanel);
            this._thresholdGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thresholdGroupBox.Location = new System.Drawing.Point(3, 83);
            this._thresholdGroupBox.Name = "_thresholdGroupBox";
            this.tableLayoutPanel1.SetRowSpan(this._thresholdGroupBox, 2);
            this._thresholdGroupBox.Size = new System.Drawing.Size(278, 94);
            this._thresholdGroupBox.TabIndex = 5;
            this._thresholdGroupBox.TabStop = false;
            this._thresholdGroupBox.Text = "Threshold";
            // 
            // _thresholdTableLayoutPanel
            // 
            this._thresholdTableLayoutPanel.ColumnCount = 1;
            this._thresholdTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._thresholdTableLayoutPanel.Controls.Add(this._thresholdingButton, 0, 1);
            this._thresholdTableLayoutPanel.Controls.Add(this._thresholdScaleTrackBar, 0, 0);
            this._thresholdTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thresholdTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._thresholdTableLayoutPanel.Name = "_thresholdTableLayoutPanel";
            this._thresholdTableLayoutPanel.RowCount = 2;
            this._thresholdTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._thresholdTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._thresholdTableLayoutPanel.Size = new System.Drawing.Size(272, 73);
            this._thresholdTableLayoutPanel.TabIndex = 0;
            // 
            // _thresholdScaleTrackBar
            // 
            this._thresholdScaleTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thresholdScaleTrackBar.Location = new System.Drawing.Point(3, 3);
            this._thresholdScaleTrackBar.Maximum = 255;
            this._thresholdScaleTrackBar.Name = "_thresholdScaleTrackBar";
            this._thresholdScaleTrackBar.Size = new System.Drawing.Size(266, 30);
            this._thresholdScaleTrackBar.TabIndex = 4;
            // 
            // _thresholdingButton
            // 
            this._thresholdingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._thresholdingButton.Location = new System.Drawing.Point(3, 39);
            this._thresholdingButton.Name = "_thresholdingButton";
            this._thresholdingButton.Size = new System.Drawing.Size(266, 31);
            this._thresholdingButton.TabIndex = 5;
            this._thresholdingButton.Text = "Thresholding";
            this._thresholdingButton.UseVisualStyleBackColor = true;
            this._thresholdingButton.Click += new System.EventHandler(this.ClickThresholdingButton);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._grayScaleButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._inverseButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._thresholdGroupBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BasicOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasicOperationForm";
            this.Text = "BasicOperationForm";
            this._thresholdGroupBox.ResumeLayout(false);
            this._thresholdTableLayoutPanel.ResumeLayout(false);
            this._thresholdTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._thresholdScaleTrackBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _inverseButton;
        private System.Windows.Forms.Button _grayScaleButton;
        private System.Windows.Forms.GroupBox _thresholdGroupBox;
        private System.Windows.Forms.TableLayoutPanel _thresholdTableLayoutPanel;
        private System.Windows.Forms.Button _thresholdingButton;
        private System.Windows.Forms.TrackBar _thresholdScaleTrackBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}