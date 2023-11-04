namespace PlayerUI
{
    partial class PlayerViewerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerViewerForm));
            this.totalDuration = new System.Windows.Forms.Label();
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.appTitle = new System.Windows.Forms.Label();
            this.currentDurationTimer = new System.Windows.Forms.Timer(this.components);
            this.timeSlider = new System.Windows.Forms.TrackBar();
            this.detectAudioEnd = new System.Windows.Forms.Timer(this.components);
            this.audioTitle = new System.Windows.Forms.Label();
            this.playlist = new System.Windows.Forms.Panel();
            this.currentDuration = new System.Windows.Forms.Label();
            this.hidePlaylistButton = new System.Windows.Forms.Button();
            this.playButton = new PlayerUI.PlayButton();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // totalDuration
            // 
            this.totalDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalDuration.AutoSize = true;
            this.totalDuration.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.totalDuration.Location = new System.Drawing.Point(636, 366);
            this.totalDuration.Name = "totalDuration";
            this.totalDuration.Size = new System.Drawing.Size(28, 13);
            this.totalDuration.TabIndex = 8;
            this.totalDuration.Text = "0:00";
            // 
            // volumeSlider
            // 
            this.volumeSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volumeSlider.Location = new System.Drawing.Point(743, 208);
            this.volumeSlider.Maximum = 100;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeSlider.Size = new System.Drawing.Size(45, 231);
            this.volumeSlider.SmallChange = 2;
            this.volumeSlider.TabIndex = 11;
            this.volumeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeSlider.Value = 50;
            this.volumeSlider.Scroll += new System.EventHandler(this.volumeSlider_Scroll);
            // 
            // appTitle
            // 
            this.appTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.ForeColor = System.Drawing.Color.White;
            this.appTitle.Location = new System.Drawing.Point(670, 9);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(118, 38);
            this.appTitle.TabIndex = 12;
            this.appTitle.Text = "Monkify";
            // 
            // currentDurationTimer
            // 
            this.currentDurationTimer.Interval = 1000;
            this.currentDurationTimer.Tick += new System.EventHandler(this.currentDurationTimer_Tick);
            // 
            // timeSlider
            // 
            this.timeSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeSlider.Location = new System.Drawing.Point(173, 366);
            this.timeSlider.Maximum = 0;
            this.timeSlider.Name = "timeSlider";
            this.timeSlider.Size = new System.Drawing.Size(463, 45);
            this.timeSlider.TabIndex = 13;
            this.timeSlider.TickFrequency = 0;
            this.timeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.timeSlider.Scroll += new System.EventHandler(this.timeSlider_Scroll);
            this.timeSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timeSlider_MouseUp);
            // 
            // detectAudioEnd
            // 
            this.detectAudioEnd.Interval = 2000;
            this.detectAudioEnd.Tick += new System.EventHandler(this.DetectAudioEnd_Tick);
            // 
            // audioTitle
            // 
            this.audioTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.audioTitle.AutoSize = true;
            this.audioTitle.BackColor = System.Drawing.Color.Transparent;
            this.audioTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioTitle.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.audioTitle.Location = new System.Drawing.Point(816, 94);
            this.audioTitle.Name = "audioTitle";
            this.audioTitle.Size = new System.Drawing.Size(72, 29);
            this.audioTitle.TabIndex = 14;
            this.audioTitle.Text = "label2";
            this.audioTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playlist
            // 
            this.playlist.AutoScroll = true;
            this.playlist.Location = new System.Drawing.Point(0, 0);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(139, 405);
            this.playlist.TabIndex = 16;
            this.playlist.Visible = false;
            // 
            // currentDuration
            // 
            this.currentDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentDuration.AutoSize = true;
            this.currentDuration.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.currentDuration.Location = new System.Drawing.Point(145, 366);
            this.currentDuration.Name = "currentDuration";
            this.currentDuration.Size = new System.Drawing.Size(28, 13);
            this.currentDuration.TabIndex = 18;
            this.currentDuration.Text = "0:00";
            // 
            // hidePlaylistButton
            // 
            this.hidePlaylistButton.FlatAppearance.BorderSize = 0;
            this.hidePlaylistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hidePlaylistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hidePlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePlaylistButton.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.hidePlaylistButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hidePlaylistButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.hidePlaylistButton.Location = new System.Drawing.Point(0, 0);
            this.hidePlaylistButton.Name = "hidePlaylistButton";
            this.hidePlaylistButton.Size = new System.Drawing.Size(31, 74);
            this.hidePlaylistButton.TabIndex = 17;
            this.hidePlaylistButton.Text = ">";
            this.hidePlaylistButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hidePlaylistButton.UseVisualStyleBackColor = true;
            this.hidePlaylistButton.Click += new System.EventHandler(this.hidePlaylistButton_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.playButton.BackgroundImage = global::PlayerUI.Properties.Resources.Paused;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Enabled = false;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(335, 162);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(126, 126);
            this.playButton.TabIndex = 15;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // PlayerViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.totalDuration);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.audioTitle);
            this.Controls.Add(this.currentDuration);
            this.Controls.Add(this.hidePlaylistButton);
            this.Controls.Add(this.timeSlider);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "PlayerViewerForm";
            this.Text = "Monkify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerViewerForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayerViewerForm_Load);
            this.Resize += new System.EventHandler(this.PlayerViewerForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalDuration;
        private System.Windows.Forms.TrackBar volumeSlider;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Timer currentDurationTimer;
        private System.Windows.Forms.TrackBar timeSlider;
        private System.Windows.Forms.Timer detectAudioEnd;
        private System.Windows.Forms.Label audioTitle;
        private PlayButton playButton;
        private System.Windows.Forms.Panel playlist;
        private System.Windows.Forms.Button hidePlaylistButton;
        private System.Windows.Forms.Label currentDuration;
    }
}

