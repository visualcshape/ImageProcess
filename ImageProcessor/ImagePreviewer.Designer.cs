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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._imagePreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _imagePreviewPanel
            // 
            this._imagePreviewPanel.Controls.Add(this.pictureBox1);
            this._imagePreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imagePreviewPanel.Location = new System.Drawing.Point(0, 0);
            this._imagePreviewPanel.Name = "_imagePreviewPanel";
            this._imagePreviewPanel.Size = new System.Drawing.Size(744, 500);
            this._imagePreviewPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _imagePreviewPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}