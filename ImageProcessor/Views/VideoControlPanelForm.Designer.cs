namespace ImageProcessor
{
    partial class VideoControlPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoControlPanelForm));
            this._videoControlPanelTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this._playButton = new System.Windows.Forms.Button();
            this._pauseButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this._videoControlPanelTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // _videoControlPanelTableLayout
            // 
            this._videoControlPanelTableLayout.ColumnCount = 5;
            this._videoControlPanelTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._videoControlPanelTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._videoControlPanelTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._videoControlPanelTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._videoControlPanelTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._videoControlPanelTableLayout.Controls.Add(this._playButton, 2, 0);
            this._videoControlPanelTableLayout.Controls.Add(this._pauseButton, 3, 0);
            this._videoControlPanelTableLayout.Controls.Add(this._stopButton, 1, 0);
            this._videoControlPanelTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._videoControlPanelTableLayout.Location = new System.Drawing.Point(0, 0);
            this._videoControlPanelTableLayout.Name = "_videoControlPanelTableLayout";
            this._videoControlPanelTableLayout.RowCount = 1;
            this._videoControlPanelTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._videoControlPanelTableLayout.Size = new System.Drawing.Size(596, 57);
            this._videoControlPanelTableLayout.TabIndex = 0;
            // 
            // _playButton
            // 
            this._playButton.BackgroundImage = global::ImageProcessor.Properties.Resources.play_128;
            this._playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._playButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._playButton.Location = new System.Drawing.Point(271, 3);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(54, 51);
            this._playButton.TabIndex = 0;
            this._playButton.UseVisualStyleBackColor = true;
            this._playButton.Click += new System.EventHandler(this.ClickPlayButton);
            // 
            // _pauseButton
            // 
            this._pauseButton.BackgroundImage = global::ImageProcessor.Properties.Resources.pause_128;
            this._pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pauseButton.Location = new System.Drawing.Point(331, 3);
            this._pauseButton.Name = "_pauseButton";
            this._pauseButton.Size = new System.Drawing.Size(54, 51);
            this._pauseButton.TabIndex = 1;
            this._pauseButton.UseVisualStyleBackColor = true;
            this._pauseButton.Click += new System.EventHandler(this.ClickPauseButton);
            // 
            // _stopButton
            // 
            this._stopButton.BackgroundImage = global::ImageProcessor.Properties.Resources.stop_128;
            this._stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._stopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stopButton.Location = new System.Drawing.Point(211, 3);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(54, 51);
            this._stopButton.TabIndex = 2;
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this.ClickStopButton);
            // 
            // VideoControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 57);
            this.Controls.Add(this._videoControlPanelTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoControlPanelForm";
            this.Text = "Video Control Panel";
            this._videoControlPanelTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _videoControlPanelTableLayout;
        private System.Windows.Forms.Button _playButton;
        private System.Windows.Forms.Button _pauseButton;
        private System.Windows.Forms.Button _stopButton;
    }
}