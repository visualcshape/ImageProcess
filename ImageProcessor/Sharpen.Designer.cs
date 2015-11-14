namespace ImageProcessor
{
    partial class SharpenForm
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
            this._allPassFactorLabel = new System.Windows.Forms.Label();
            this._allPassFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._highBoostFilteringButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._allPassFactorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this._allPassFactorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._allPassFactorNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._highBoostFilteringButton, 0, 4);
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _allPassFactorLabel
            // 
            this._allPassFactorLabel.AutoSize = true;
            this._allPassFactorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._allPassFactorLabel.Location = new System.Drawing.Point(3, 100);
            this._allPassFactorLabel.Name = "_allPassFactorLabel";
            this._allPassFactorLabel.Size = new System.Drawing.Size(79, 30);
            this._allPassFactorLabel.TabIndex = 1;
            this._allPassFactorLabel.Text = "All Pass Factor";
            this._allPassFactorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _allPassFactorNumericUpDown
            // 
            this._allPassFactorNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this._allPassFactorNumericUpDown.Location = new System.Drawing.Point(88, 103);
            this._allPassFactorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._allPassFactorNumericUpDown.Name = "_allPassFactorNumericUpDown";
            this._allPassFactorNumericUpDown.Size = new System.Drawing.Size(193, 22);
            this._allPassFactorNumericUpDown.TabIndex = 4;
            this._allPassFactorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _highBoostFilteringButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._highBoostFilteringButton, 2);
            this._highBoostFilteringButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._highBoostFilteringButton.Location = new System.Drawing.Point(3, 163);
            this._highBoostFilteringButton.Name = "_highBoostFilteringButton";
            this._highBoostFilteringButton.Size = new System.Drawing.Size(278, 24);
            this._highBoostFilteringButton.TabIndex = 6;
            this._highBoostFilteringButton.Text = "High-Boost Filtering";
            this._highBoostFilteringButton.UseVisualStyleBackColor = true;
            this._highBoostFilteringButton.Click += new System.EventHandler(this.ClickHighBoostFilteringButton);
            // 
            // SharpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SharpenForm";
            this.Text = "Sharpen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._allPassFactorNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _allPassFactorLabel;
        private System.Windows.Forms.NumericUpDown _allPassFactorNumericUpDown;
        private System.Windows.Forms.Button _highBoostFilteringButton;
    }
}