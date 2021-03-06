﻿using ATL;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using FRESHMusicPlayer.Handlers;
namespace FRESHMusicPlayer
{
    public partial class SongInfo : Form
    {
        public SongInfo()
        {
            InitializeComponent();
            Track track = new Track(Player.filePath);
            songtitleText.Text = $"{track.Artist} - {track.Title}";
            albumText.Text = $"Album - {track.Album}";
            genreText.Text = $"Genre - {track.Genre}";
            yearText.Text = $"Year - {track.Year.ToString()}";
            trackText.Text = $"Track #{track.TrackNumber}";
            discText.Text = $"Disc #{track.DiscNumber}";
            bitrateText.Text = $"Bitrate - {track.Bitrate.ToString()}kbps";
            IList<ATL.PictureInfo> embeddedPictures = track.EmbeddedPictures;
            Graphics g = pictureBox1.CreateGraphics();
            toolTip1.SetToolTip(songtitleText, $"{track.Artist} - {track.Title}");
            toolTip1.SetToolTip(albumText, track.Album);
            foreach (ATL.PictureInfo pic in embeddedPictures)
            {
                pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(pic.PictureData));
            }
            if (Properties.Settings.Default.Appearance_DarkMode) ThemeHandler.SetColors(this, (44, 47, 51), (255, 255, 255), Color.Black, Color.White); else ThemeHandler.SetColors(this, (4, 160, 219), (255, 255, 255), Color.White, Color.Black);
        }

        private void SongInfo_FormClosing(object sender, FormClosingEventArgs e) => pictureBox1.Dispose();

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            Track track = new Track(Player.filePath);
            IList<ATL.PictureInfo> embeddedPictures = track.EmbeddedPictures;
            foreach (PictureInfo pic in embeddedPictures)
            {
                Image x = Image.FromStream(new System.IO.MemoryStream(pic.PictureData));
                x.Save(System.IO.Path.GetTempPath() + "FMPalbumart.png", ImageFormat.Png);
                System.Diagnostics.Process.Start(System.IO.Path.GetTempPath() + "FMPalbumart.png");
            }

              
        }
    }
}
