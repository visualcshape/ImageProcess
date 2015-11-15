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
            this._maskTypeLabel = new System.Windows.Forms.Label();
            this._maskTypeRadioButtonGroupBox = new System.Windows.Forms.GroupBox();
            this._typeRadioButtonPanel = new System.Windows.Forms.Panel();
            this._maskType2RadioButton = new System.Windows.Forms.RadioButton();
            this._maskType1RadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._allPassFactorNumericUpDown)).BeginInit();
            this._maskTypeRadioButtonGroupBox.SuspendLayout();
            this._typeRadioButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this._allPassFactorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._allPassFactorNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._highBoostFilteringButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._maskTypeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._maskTypeRadioButtonGroupBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _allPassFactorLabel
            // 
            this._allPassFactorLabel.AutoSize = true;
            this._allPassFactorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._allPassFactorLabel.Location = new System.Drawing.Point(3, 85);
            this._allPassFactorLabel.Name = "_allPassFactorLabel";
            this._allPassFactorLabel.Size = new System.Drawing.Size(79, 30);
            this._allPassFactorLabel.TabIndex = 1;
            this._allPassFactorLabel.Text = "All Pass Factor";
            this._allPassFactorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _allPassFactorNumericUpDown
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._allPassFactorNumericUpDown, 2);
            this._allPassFactorNumericUpDown.DecimalPlaces = 2;
            this._allPassFactorNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this._allPassFactorNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._allPassFactorNumericUpDown.Location = new System.Drawing.Point(88, 88);
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
            this.tableLayoutPanel1.SetColumnSpan(this._highBoostFilteringButton, 3);
            this._highBoostFilteringButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._highBoostFilteringButton.Location = new System.Drawing.Point(3, 178);
            this._highBoostFilteringButton.Name = "_highBoostFilteringButton";
            this._highBoostFilteringButton.Size = new System.Drawing.Size(278, 24);
            this._highBoostFilteringButton.TabIndex = 6;
            this._highBoostFilteringButton.Text = "High-Boost Filtering";
            this._highBoostFilteringButton.UseVisualStyleBackColor = true;
            this._highBoostFilteringButton.Click += new System.EventHandler(this.ClickHighBoostFilteringButton);
            // 
            // _maskTypeLabel
            // 
            this._maskTypeLabel.AutoSize = true;
            this._maskTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._maskTypeLabel.Location = new System.Drawing.Point(3, 115);
            this._maskTypeLabel.Name = "_maskTypeLabel";
            this._maskTypeLabel.Size = new System.Drawing.Size(79, 60);
            this._maskTypeLabel.TabIndex = 7;
            this._maskTypeLabel.Text = "Mask Type";
            this._maskTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _maskTypeRadioButtonGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._maskTypeRadioButtonGroupBox, 2);
            this._maskTypeRadioButtonGroupBox.Controls.Add(this._typeRadioButtonPanel);
            this._maskTypeRadioButtonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._maskTypeRadioButtonGroupBox.Location = new System.Drawing.Point(88, 118);
            this._maskTypeRadioButtonGroupBox.Name = "_maskTypeRadioButtonGroupBox";
            this._maskTypeRadioButtonGroupBox.Size = new System.Drawing.Size(193, 54);
            this._maskTypeRadioButtonGroupBox.TabIndex = 8;
            this._maskTypeRadioButtonGroupBox.TabStop = false;
            // 
            // _typeRadioButtonPanel
            // 
            this._typeRadioButtonPanel.Controls.Add(this._maskType2RadioButton);
            this._typeRadioButtonPanel.Controls.Add(this._maskType1RadioButton);
            this._typeRadioButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._typeRadioButtonPanel.Location = new System.Drawing.Point(3, 18);
            this._typeRadioButtonPanel.Name = "_typeRadioButtonPanel";
            this._typeRadioButtonPanel.Size = new System.Drawing.Size(187, 33);
            this._typeRadioButtonPanel.TabIndex = 0;
            // 
            // _maskType2RadioButton
            // 
            this._maskType2RadioButton.AutoSize = true;
            this._maskType2RadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._maskType2RadioButton.Location = new System.Drawing.Point(29, 0);
            this._maskType2RadioButton.Name = "_maskType2RadioButton";
            this._maskType2RadioButton.Size = new System.Drawing.Size(29, 33);
            this._maskType2RadioButton.TabIndex = 1;
            this._maskType2RadioButton.Text = "2";
            this._maskType2RadioButton.UseVisualStyleBackColor = true;
            this._maskType2RadioButton.CheckedChanged += new System.EventHandler(this.CheckTypeRadioButton);
            // 
            // _maskType1RadioButton
            // 
            this._maskType1RadioButton.AutoSize = true;
            this._maskType1RadioButton.Checked = true;
            this._maskType1RadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._maskType1RadioButton.Location = new System.Drawing.Point(0, 0);
            this._maskType1RadioButton.Name = "_maskType1RadioButton";
            this._maskType1RadioButton.Size = new System.Drawing.Size(29, 33);
            this._maskType1RadioButton.TabIndex = 0;
            this._maskType1RadioButton.TabStop = true;
            this._maskType1RadioButton.Text = "1";
            this._maskType1RadioButton.UseVisualStyleBackColor = true;
            this._maskType1RadioButton.CheckedChanged += new System.EventHandler(this.CheckTypeRadioButton);
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
            this._maskTypeRadioButtonGroupBox.ResumeLayout(false);
            this._typeRadioButtonPanel.ResumeLayout(false);
            this._typeRadioButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _allPassFactorLabel;
        private System.Windows.Forms.NumericUpDown _allPassFactorNumericUpDown;
        private System.Windows.Forms.Button _highBoostFilteringButton;
        private System.Windows.Forms.Label _maskTypeLabel;
        private System.Windows.Forms.GroupBox _maskTypeRadioButtonGroupBox;
        private System.Windows.Forms.Panel _typeRadioButtonPanel;
        private System.Windows.Forms.RadioButton _maskType2RadioButton;
        private System.Windows.Forms.RadioButton _maskType1RadioButton;
    }
}