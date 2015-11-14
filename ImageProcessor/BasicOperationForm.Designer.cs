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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grayScaleButton = new System.Windows.Forms.Button();
            this.thresholdingButton = new System.Windows.Forms.Button();
            this.InversingButton = new System.Windows.Forms.Button();
            this._grayScaleTrackBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grayScaleTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grayScaleButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.thresholdingButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.InversingButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._grayScaleTrackBar, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grayScaleButton
            // 
            this.grayScaleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayScaleButton.Location = new System.Drawing.Point(3, 73);
            this.grayScaleButton.Name = "grayScaleButton";
            this.grayScaleButton.Size = new System.Drawing.Size(278, 24);
            this.grayScaleButton.TabIndex = 0;
            this.grayScaleButton.Text = "Gray Scale";
            this.grayScaleButton.UseVisualStyleBackColor = true;
            this.grayScaleButton.Click += new System.EventHandler(this.ClickGrayScaleButton);
            // 
            // thresholdingButton
            // 
            this.thresholdingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdingButton.Location = new System.Drawing.Point(3, 133);
            this.thresholdingButton.Name = "thresholdingButton";
            this.thresholdingButton.Size = new System.Drawing.Size(278, 24);
            this.thresholdingButton.TabIndex = 1;
            this.thresholdingButton.Text = "Thresholding";
            this.thresholdingButton.UseVisualStyleBackColor = true;
            // 
            // InversingButton
            // 
            this.InversingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InversingButton.Location = new System.Drawing.Point(3, 163);
            this.InversingButton.Name = "InversingButton";
            this.InversingButton.Size = new System.Drawing.Size(278, 24);
            this.InversingButton.TabIndex = 2;
            this.InversingButton.Text = "Inverse";
            this.InversingButton.UseVisualStyleBackColor = true;
            // 
            // _grayScaleTrackBar
            // 
            this._grayScaleTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grayScaleTrackBar.Location = new System.Drawing.Point(3, 103);
            this._grayScaleTrackBar.Maximum = 255;
            this._grayScaleTrackBar.Name = "_grayScaleTrackBar";
            this._grayScaleTrackBar.Size = new System.Drawing.Size(278, 24);
            this._grayScaleTrackBar.TabIndex = 3;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grayScaleTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button grayScaleButton;
        private System.Windows.Forms.Button thresholdingButton;
        private System.Windows.Forms.Button InversingButton;
        private System.Windows.Forms.TrackBar _grayScaleTrackBar;
    }
}