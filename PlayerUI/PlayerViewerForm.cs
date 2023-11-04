using NAudio.Wave;
using PlayerUI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class PlayerViewerForm : Form
    {

        private Mp3FileReader mp3 = null;
        private WaveOut output = null;
        private float volume;
        private static Random rand = new Random();
        string randFile;

        Rectangle originalFormSize;
        Rectangle playButtonOriginalSize;
        Rectangle timeSliderOriginalSize;
        Rectangle volumeSliderOriginalSize;
        Rectangle audioTitleOriginalSize;

        private static List<string> playableAudio = new List<string>(Directory.GetFiles("C:\\Users\\danie\\Music\\Audio", "*.mp3"));

        public PlayerViewerForm()
        {
            InitializeComponent();

            List<string> files = new List<string>(Directory.GetFiles("C:\\Users\\danie\\Music\\Audio", "*.mp3"));
            string buttonName;
            int y = 0;

            foreach (string file in files)
            {
                Button button = new Button();

                //sets button properties
                buttonName = file.Replace("C:\\Users\\danie\\Music\\Audio\\", string.Empty)
                    .Replace(".mp3", string.Empty)
                    .Replace("y2mate.is - ", string.Empty);

                button.Location = new Point(0, y);
                button.Width = playlist.Width;
                button.Height = 50;

                y += button.Height;

                button.FlatStyle = FlatStyle.Standard;

                button.Dock = DockStyle.Top;

                button.ForeColor = Color.WhiteSmoke;
                button.Text = buttonName;

                button.Click += PlayAudio;

                playlist.Controls.Add(button);

                //plays audio
                void PlayAudio(object sender, EventArgs e)
                {
                    DisposeWave();

                    mp3 = new Mp3FileReader(file);
                    output = new WaveOut();
                    output.Init(mp3);
                    output.Volume = (float)volumeSlider.Value / 100; //sets the volume to the value of volumeSlider currently
                    output.Play();
                    playButton.BackgroundImage = Resources.Played;

                    setUI(file);
                }
            }
        }

        private void PlayerViewerForm_Load(object sender, EventArgs e)
        {
            PlayRandomAudio();
            output.Pause();
            playButton.BackgroundImage = Resources.Paused;

            playlist.Height = Height - 39;

            originalFormSize = new Rectangle(Location.X, Location.Y, Width, Height);
            playButtonOriginalSize = new Rectangle(playButton.Location.X, playButton.Location.Y, playButton.Width, playButton.Height);
            timeSliderOriginalSize = new Rectangle(timeSlider.Location.X, timeSlider.Location.Y, timeSlider.Width, timeSlider.Height);
            volumeSliderOriginalSize = new Rectangle(volumeSlider.Location.X, volumeSlider.Location.Y, volumeSlider.Width, volumeSlider.Height);
            audioTitleOriginalSize = new Rectangle(audioTitle.Location.X, audioTitle.Location.Y, audioTitle.Width, audioTitle.Height);
        }


        private void playButton_Click(object sender, EventArgs e)
        {
            if (output == null) return;

            if (output.PlaybackState == PlaybackState.Playing)
            {
                output.Pause();
                playButton.BackgroundImage = Resources.Paused;
            }
            else
            {
                output.Play();
                playButton.BackgroundImage = Resources.Played;
            }


        }

        private void PlayerViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

        //volume
        private void volumeSlider_Scroll(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            volume = (float)volumeSlider.Value / 100;
            if (output == null) return;
            output.Volume = volume;
        }

        //timeslider
        private void timeSlider_Scroll(object sender, EventArgs e)
        {
            output.Stop();
            mp3.Position = timeSlider.Value * mp3.WaveFormat.AverageBytesPerSecond;
        }
        private void currentDurationTimer_Tick(object sender, EventArgs e)
        {
            if (output == null) return;

            currentDuration.Text = ToTimeFormat((int)mp3.CurrentTime.TotalSeconds);
            timeSlider.Value = (int)mp3.CurrentTime.TotalSeconds;
        }

        private void timeSlider_MouseUp(object sender, MouseEventArgs e)
        {
            if (output == null) return;

            output.Play();

        }

        private void DetectAudioEnd_Tick(object sender, EventArgs e)
        {
            if (output != null)
                if (timeSlider.Value == timeSlider.Maximum)
                {
                    PlayRandomAudio();
                }
        }
        bool open = false; //whether or not the playlist is open
        private void hidePlaylistButton_Click(object sender, EventArgs e)
        {


            if (open) //closes playlist
            {
                hidePlaylistButton.Text = ">";
                hidePlaylistButton.Location = new Point(0);

                playlist.Visible = false;
                open = false;
            }
            else //opens playlist
            {
                hidePlaylistButton.Text = "<";
                hidePlaylistButton.Location = new Point(playlist.Width);

                playlist.Visible = true;
                open = true;
            }

        }

        private void PlayerViewerForm_Resize(object sender, EventArgs e)
        {
            playlist.Height = Height - 39;

            ResizeCenterControl(playButtonOriginalSize, playButton);
            ResizeTrackBar(timeSliderOriginalSize, timeSlider);
            ResizeTrackBar(volumeSliderOriginalSize, volumeSlider);
            CenterLabel(audioTitleOriginalSize, audioTitle);

            currentDuration.Location = new Point(timeSlider.Location.X - currentDuration.Width, timeSlider.Location.Y);
            totalDuration.Location = new Point(timeSlider.Location.X + timeSlider.Width, timeSlider.Location.Y);

        }


        //functions---------------------------------------------------

        /// <summary>
        /// Method <c>DisposeWave</c> Disposes of remaining audio
        /// </summary>
        public void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }

            if (mp3 != null)
            {
                mp3.Dispose();
                mp3 = null;
            }
        }

        /// <summary>
        /// plays random audio from path when called
        /// </summary
        private void PlayRandomAudio()
        {
            DisposeWave();

            randFile = playableAudio[rand.Next(playableAudio.Count)];

            mp3 = new Mp3FileReader(randFile);
            output = new WaveOut();
            output.Init(mp3);
            output.Volume = (float)volumeSlider.Value / 100;
            output.Play();

            playButton.BackgroundImage = Resources.Played;

            setUI(randFile);

            playButton.Enabled = true;
            currentDurationTimer.Enabled = true;
            detectAudioEnd.Enabled = true;

            playableAudio.Remove(randFile);

            if (playableAudio.Count == 0)
            {
                playableAudio = new List<string>(Directory.GetFiles("C:\\Users\\danie\\Music\\Audio", "*.mp3"));
            }
        }

        /// <summary>
        /// Converts seconds into "0:00" format
        /// <param name="seconds"></param>
        /// </summary>
        /// <returns>string</returns>
        private string ToTimeFormat(int seconds)
        {
            if (seconds % 60 < 10) { return $"{seconds / 60}:0{seconds % 60}"; }
            else { return $"{seconds / 60}:{seconds % 60}"; }
        }



        private void setUI(string file)
        {
            audioTitle.Text = file.Replace("C:\\Users\\danie\\Music\\Audio\\", string.Empty)
                .Replace(".mp3", string.Empty)
                .Replace("y2mate.is - ", string.Empty);

            totalDuration.Text = ToTimeFormat((int)mp3.TotalTime.TotalSeconds);

            timeSlider.Maximum = (int)mp3.TotalTime.TotalSeconds;

            audioTitle.Location = new Point(playButton.Location.X + (playButton.Width / 2) - (audioTitle.Width / 2), 76); //centers the page with difference between half of form and title width

            audioTitleOriginalSize = new Rectangle(audioTitle.Location.X, audioTitle.Location.Y, audioTitle.Width, audioTitle.Height);
        }

        private void ResizeCenterControl(Rectangle r, Control c)
        {
            float xRatio = (float)Width / originalFormSize.Width;
            float yRatio = (float)Height / originalFormSize.Height;

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height / yRatio);

            float sizeRatio = (float)newWidth / newHeight / 2 + 0.5f;
            Size newSize = new Size((int)(r.Width * (float)sizeRatio), (int)(r.Height * (float)sizeRatio));

            int newX = (Width / 2) - (newSize.Width / 2 + 10);
            int newY = (Height / 2) - (newSize.Height / 2 + 20);
            Point newLocation = new Point(newX, newY);

            c.Size = newSize;
            c.Location = newLocation;
        }

        private void ResizeTrackBar(Rectangle r, Control c)
        {
            float xRatio = (float)Width / originalFormSize.Width;
            float yRatio = (float)Height / originalFormSize.Height;

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            c.Width = newWidth;
            c.Height = newHeight;
            c.Location = new Point(newX, newY);
        }

        private void CenterLabel(Rectangle r, Control c)
        {
            float yRatio = (float)Height / originalFormSize.Height;

            int newX = Width / 2 - r.Width / 2 - 10;
            int newY = (int)(r.Y * yRatio);

            c.Location = new Point(newX, newY);
        }
    }
}

