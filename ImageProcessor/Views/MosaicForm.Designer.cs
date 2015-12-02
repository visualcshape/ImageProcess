namespace ImageProcessor
{
    partial class MosaicForm
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
            this._mosaicButton = new System.Windows.Forms.Button();
            this._matrixWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._matrixHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._matrixWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._matrixHeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._mosaicButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._matrixWidthNumericUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._matrixHeightNumericUpDown, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _mosaicButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._mosaicButton, 4);
            this._mosaicButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mosaicButton.Location = new System.Drawing.Point(3, 133);
            this._mosaicButton.Name = "_mosaicButton";
            this._mosaicButton.Size = new System.Drawing.Size(278, 24);
            this._mosaicButton.TabIndex = 2;
            this._mosaicButton.Text = "Mosaic";
            this._mosaicButton.UseVisualStyleBackColor = true;
            this._mosaicButton.Click += new System.EventHandler(this.ClickMosaicButton);
            // 
            // _matrixWidthNumericUpDown
            // 
            this._matrixWidthNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this._matrixWidthNumericUpDown.Location = new System.Drawing.Point(23, 103);
            this._matrixWidthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._matrixWidthNumericUpDown.Name = "_matrixWidthNumericUpDown";
            this._matrixWidthNumericUpDown.Size = new System.Drawing.Size(116, 22);
            this._matrixWidthNumericUpDown.TabIndex = 1;
            this._matrixWidthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _matrixHeightNumericUpDown
            // 
            this._matrixHeightNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this._matrixHeightNumericUpDown.Location = new System.Drawing.Point(165, 103);
            this._matrixHeightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._matrixHeightNumericUpDown.Name = "_matrixHeightNumericUpDown";
            this._matrixHeightNumericUpDown.Size = new System.Drawing.Size(116, 22);
            this._matrixHeightNumericUpDown.TabIndex = 3;
            this._matrixHeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "W";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(145, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "H";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MosaicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MosaicForm";
            this.Text = "MosaicForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._matrixWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._matrixHeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _mosaicButton;
        private System.Windows.Forms.NumericUpDown _matrixWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown _matrixHeightNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}