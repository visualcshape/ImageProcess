namespace ImageProcessor
{
    partial class EdgeDetectionForm
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
            this._edgeDetectionLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._sobelGroupBox = new System.Windows.Forms.GroupBox();
            this._laplacianGroupBox = new System.Windows.Forms.GroupBox();
            this._cannyGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._sobelThresholdLabel = new System.Windows.Forms.Label();
            this._sobelThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._sobelButton = new System.Windows.Forms.Button();
            this._laplacianTabelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._apertureSizeLabel = new System.Windows.Forms.Label();
            this._laplacianButton = new System.Windows.Forms.Button();
            this._apertureSizeNumericupDown = new System.Windows.Forms.NumericUpDown();
            this._cannyTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this._cannyThreshLabel = new System.Windows.Forms.Label();
            this._cannyThreshLinkinglabel = new System.Windows.Forms.Label();
            this._cannyButton = new System.Windows.Forms.Button();
            this._cannyThreshNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._cannyThreshLinkingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._edgeDetectionLayoutPanel.SuspendLayout();
            this._sobelGroupBox.SuspendLayout();
            this._laplacianGroupBox.SuspendLayout();
            this._cannyGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._sobelThresholdNumericUpDown)).BeginInit();
            this._laplacianTabelLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._apertureSizeNumericupDown)).BeginInit();
            this._cannyTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cannyThreshNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cannyThreshLinkingNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _edgeDetectionLayoutPanel
            // 
            this._edgeDetectionLayoutPanel.ColumnCount = 1;
            this._edgeDetectionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._edgeDetectionLayoutPanel.Controls.Add(this._cannyGroupBox, 0, 2);
            this._edgeDetectionLayoutPanel.Controls.Add(this._laplacianGroupBox, 0, 1);
            this._edgeDetectionLayoutPanel.Controls.Add(this._sobelGroupBox, 0, 0);
            this._edgeDetectionLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._edgeDetectionLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._edgeDetectionLayoutPanel.Name = "_edgeDetectionLayoutPanel";
            this._edgeDetectionLayoutPanel.RowCount = 3;
            this._edgeDetectionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._edgeDetectionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._edgeDetectionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._edgeDetectionLayoutPanel.Size = new System.Drawing.Size(284, 261);
            this._edgeDetectionLayoutPanel.TabIndex = 0;
            // 
            // _sobelGroupBox
            // 
            this._sobelGroupBox.Controls.Add(this.tableLayoutPanel1);
            this._sobelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sobelGroupBox.Location = new System.Drawing.Point(3, 3);
            this._sobelGroupBox.Name = "_sobelGroupBox";
            this._sobelGroupBox.Size = new System.Drawing.Size(278, 80);
            this._sobelGroupBox.TabIndex = 0;
            this._sobelGroupBox.TabStop = false;
            this._sobelGroupBox.Text = "Sobel";
            // 
            // _laplacianGroupBox
            // 
            this._laplacianGroupBox.Controls.Add(this._laplacianTabelLayoutPanel);
            this._laplacianGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._laplacianGroupBox.Location = new System.Drawing.Point(3, 89);
            this._laplacianGroupBox.Name = "_laplacianGroupBox";
            this._laplacianGroupBox.Size = new System.Drawing.Size(278, 80);
            this._laplacianGroupBox.TabIndex = 1;
            this._laplacianGroupBox.TabStop = false;
            this._laplacianGroupBox.Text = "Laplacian";
            // 
            // _cannyGroupBox
            // 
            this._cannyGroupBox.Controls.Add(this._cannyTableLayout);
            this._cannyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cannyGroupBox.Location = new System.Drawing.Point(3, 175);
            this._cannyGroupBox.Name = "_cannyGroupBox";
            this._cannyGroupBox.Size = new System.Drawing.Size(278, 83);
            this._cannyGroupBox.TabIndex = 2;
            this._cannyGroupBox.TabStop = false;
            this._cannyGroupBox.Text = "Canny";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this._sobelThresholdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._sobelThresholdNumericUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._sobelButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _sobelThresholdLabel
            // 
            this._sobelThresholdLabel.AutoSize = true;
            this._sobelThresholdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sobelThresholdLabel.Location = new System.Drawing.Point(3, 0);
            this._sobelThresholdLabel.Name = "_sobelThresholdLabel";
            this._sobelThresholdLabel.Size = new System.Drawing.Size(75, 29);
            this._sobelThresholdLabel.TabIndex = 0;
            this._sobelThresholdLabel.Text = "Threshold";
            this._sobelThresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _sobelThresholdNumericUpDown
            // 
            this._sobelThresholdNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sobelThresholdNumericUpDown.Location = new System.Drawing.Point(84, 3);
            this._sobelThresholdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._sobelThresholdNumericUpDown.Name = "_sobelThresholdNumericUpDown";
            this._sobelThresholdNumericUpDown.Size = new System.Drawing.Size(185, 22);
            this._sobelThresholdNumericUpDown.TabIndex = 1;
            this._sobelThresholdNumericUpDown.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // _sobelButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._sobelButton, 2);
            this._sobelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sobelButton.Location = new System.Drawing.Point(3, 32);
            this._sobelButton.Name = "_sobelButton";
            this._sobelButton.Size = new System.Drawing.Size(266, 24);
            this._sobelButton.TabIndex = 2;
            this._sobelButton.Text = "Sobel";
            this._sobelButton.UseVisualStyleBackColor = true;
            this._sobelButton.Click += new System.EventHandler(this.ClickSobelButton);
            // 
            // _laplacianTabelLayoutPanel
            // 
            this._laplacianTabelLayoutPanel.ColumnCount = 2;
            this._laplacianTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._laplacianTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._laplacianTabelLayoutPanel.Controls.Add(this._laplacianButton, 0, 1);
            this._laplacianTabelLayoutPanel.Controls.Add(this._apertureSizeLabel, 0, 0);
            this._laplacianTabelLayoutPanel.Controls.Add(this._apertureSizeNumericupDown, 1, 0);
            this._laplacianTabelLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._laplacianTabelLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._laplacianTabelLayoutPanel.Name = "_laplacianTabelLayoutPanel";
            this._laplacianTabelLayoutPanel.RowCount = 2;
            this._laplacianTabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._laplacianTabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._laplacianTabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._laplacianTabelLayoutPanel.Size = new System.Drawing.Size(272, 59);
            this._laplacianTabelLayoutPanel.TabIndex = 0;
            // 
            // _apertureSizeLabel
            // 
            this._apertureSizeLabel.AutoSize = true;
            this._apertureSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._apertureSizeLabel.Location = new System.Drawing.Point(3, 0);
            this._apertureSizeLabel.Name = "_apertureSizeLabel";
            this._apertureSizeLabel.Size = new System.Drawing.Size(75, 29);
            this._apertureSizeLabel.TabIndex = 1;
            this._apertureSizeLabel.Text = "Aperture";
            this._apertureSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _laplacianButton
            // 
            this._laplacianTabelLayoutPanel.SetColumnSpan(this._laplacianButton, 2);
            this._laplacianButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._laplacianButton.Location = new System.Drawing.Point(3, 32);
            this._laplacianButton.Name = "_laplacianButton";
            this._laplacianButton.Size = new System.Drawing.Size(266, 24);
            this._laplacianButton.TabIndex = 3;
            this._laplacianButton.Text = "Laplacian";
            this._laplacianButton.UseVisualStyleBackColor = true;
            this._laplacianButton.Click += new System.EventHandler(this.ClickLaplacianButton);
            // 
            // _apertureSizeNumericupDown
            // 
            this._apertureSizeNumericupDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this._apertureSizeNumericupDown.Location = new System.Drawing.Point(84, 3);
            this._apertureSizeNumericupDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._apertureSizeNumericupDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._apertureSizeNumericupDown.Name = "_apertureSizeNumericupDown";
            this._apertureSizeNumericupDown.Size = new System.Drawing.Size(185, 22);
            this._apertureSizeNumericupDown.TabIndex = 4;
            this._apertureSizeNumericupDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // _cannyTableLayout
            // 
            this._cannyTableLayout.ColumnCount = 2;
            this._cannyTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._cannyTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._cannyTableLayout.Controls.Add(this._cannyThreshLinkingNumericUpDown, 1, 1);
            this._cannyTableLayout.Controls.Add(this._cannyThreshNumericUpDown, 1, 0);
            this._cannyTableLayout.Controls.Add(this._cannyButton, 0, 2);
            this._cannyTableLayout.Controls.Add(this._cannyThreshLabel, 0, 0);
            this._cannyTableLayout.Controls.Add(this._cannyThreshLinkinglabel, 0, 1);
            this._cannyTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cannyTableLayout.Location = new System.Drawing.Point(3, 18);
            this._cannyTableLayout.Name = "_cannyTableLayout";
            this._cannyTableLayout.RowCount = 3;
            this._cannyTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._cannyTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._cannyTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._cannyTableLayout.Size = new System.Drawing.Size(272, 62);
            this._cannyTableLayout.TabIndex = 0;
            // 
            // _cannyThreshLabel
            // 
            this._cannyThreshLabel.AutoSize = true;
            this._cannyThreshLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cannyThreshLabel.Location = new System.Drawing.Point(3, 0);
            this._cannyThreshLabel.Name = "_cannyThreshLabel";
            this._cannyThreshLabel.Size = new System.Drawing.Size(75, 20);
            this._cannyThreshLabel.TabIndex = 2;
            this._cannyThreshLabel.Text = "Thresh";
            this._cannyThreshLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cannyThreshLinkinglabel
            // 
            this._cannyThreshLinkinglabel.AutoSize = true;
            this._cannyThreshLinkinglabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cannyThreshLinkinglabel.Font = new System.Drawing.Font("PMingLiU", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._cannyThreshLinkinglabel.Location = new System.Drawing.Point(3, 20);
            this._cannyThreshLinkinglabel.Name = "_cannyThreshLinkinglabel";
            this._cannyThreshLinkinglabel.Size = new System.Drawing.Size(75, 20);
            this._cannyThreshLinkinglabel.TabIndex = 3;
            this._cannyThreshLinkinglabel.Text = "Thresh Linking";
            this._cannyThreshLinkinglabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cannyButton
            // 
            this._cannyTableLayout.SetColumnSpan(this._cannyButton, 2);
            this._cannyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cannyButton.Location = new System.Drawing.Point(3, 43);
            this._cannyButton.Name = "_cannyButton";
            this._cannyButton.Size = new System.Drawing.Size(266, 16);
            this._cannyButton.TabIndex = 4;
            this._cannyButton.Text = "Canny";
            this._cannyButton.UseVisualStyleBackColor = true;
            this._cannyButton.Click += new System.EventHandler(this.ClickCannyButton);
            // 
            // _cannyThreshNumericUpDown
            // 
            this._cannyThreshNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cannyThreshNumericUpDown.Location = new System.Drawing.Point(84, 3);
            this._cannyThreshNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this._cannyThreshNumericUpDown.Name = "_cannyThreshNumericUpDown";
            this._cannyThreshNumericUpDown.Size = new System.Drawing.Size(185, 22);
            this._cannyThreshNumericUpDown.TabIndex = 5;
            this._cannyThreshNumericUpDown.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // _cannyThreshLinkingNumericUpDown
            // 
            this._cannyThreshLinkingNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cannyThreshLinkingNumericUpDown.Location = new System.Drawing.Point(84, 23);
            this._cannyThreshLinkingNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this._cannyThreshLinkingNumericUpDown.Name = "_cannyThreshLinkingNumericUpDown";
            this._cannyThreshLinkingNumericUpDown.Size = new System.Drawing.Size(185, 22);
            this._cannyThreshLinkingNumericUpDown.TabIndex = 6;
            this._cannyThreshLinkingNumericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // EdgeDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._edgeDetectionLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EdgeDetectionForm";
            this.Text = "Edge Detection";
            this._edgeDetectionLayoutPanel.ResumeLayout(false);
            this._sobelGroupBox.ResumeLayout(false);
            this._laplacianGroupBox.ResumeLayout(false);
            this._cannyGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._sobelThresholdNumericUpDown)).EndInit();
            this._laplacianTabelLayoutPanel.ResumeLayout(false);
            this._laplacianTabelLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._apertureSizeNumericupDown)).EndInit();
            this._cannyTableLayout.ResumeLayout(false);
            this._cannyTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cannyThreshNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cannyThreshLinkingNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _edgeDetectionLayoutPanel;
        private System.Windows.Forms.GroupBox _cannyGroupBox;
        private System.Windows.Forms.TableLayoutPanel _cannyTableLayout;
        private System.Windows.Forms.NumericUpDown _cannyThreshLinkingNumericUpDown;
        private System.Windows.Forms.NumericUpDown _cannyThreshNumericUpDown;
        private System.Windows.Forms.Button _cannyButton;
        private System.Windows.Forms.Label _cannyThreshLabel;
        private System.Windows.Forms.Label _cannyThreshLinkinglabel;
        private System.Windows.Forms.GroupBox _laplacianGroupBox;
        private System.Windows.Forms.TableLayoutPanel _laplacianTabelLayoutPanel;
        private System.Windows.Forms.Button _laplacianButton;
        private System.Windows.Forms.Label _apertureSizeLabel;
        private System.Windows.Forms.NumericUpDown _apertureSizeNumericupDown;
        private System.Windows.Forms.GroupBox _sobelGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _sobelThresholdLabel;
        private System.Windows.Forms.NumericUpDown _sobelThresholdNumericUpDown;
        private System.Windows.Forms.Button _sobelButton;
    }
}