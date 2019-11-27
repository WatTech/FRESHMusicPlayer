﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRESHMusicPlayer
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
            ApplySettings();
        }
        // Because closing UserInterface doesn't close the main fore and therefore the application, 
        // this function does that job for us :)
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
 // Communication with other forms
        public void UpdateGUI()
        {
            titleLabel.Text = "Nothing Playing";
            Text = "FRESHMusicPlayer";
            progressIndicator.Text = "(nothing playing)";
            Player.position = 0;
        }
// BUTTONS
        private void browsemusicButton_Click(object sender, EventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())

            {
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    Player.filePath = selectFileDialog.FileName;
                    Player.PlayMusic(Player.filePath);
                    var metadata = Player.GetMetadata();
                    titleLabel.Text = $"{metadata.Artist} - {metadata.Title}";
                    Text = $"{metadata.Artist} - {metadata.Title} | FRESHMusicPlayer";
                    Player.playing = true;
                    getAlbumArt();
                }
                
            }
        }

        private void pauseplayButton_Click(object sender, EventArgs e)
        {
            if (!Player.paused)
            {
                
                pauseplayButton.Image = Properties.Resources.baseline_play_arrow_black_18dp;
                Player.PauseMusic();
            }
            else
            {
                
                pauseplayButton.Image = Properties.Resources.baseline_pause_black_18dp;
                Player.ResumeMusic();
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            Player.StopMusic();
            Player.playing = false;
        }
        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            Player.currentvolume = (float)volumeBar.Value / 100.0f;
            if (Player.playing) Player.UpdateSettings();
            //
        }
        private void infoButton_Click(object sender, EventArgs e)
        {
            SongInfo songInfo = new SongInfo();
            songInfo.ShowDialog();
        }
        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (Player.playing & !Player.paused) progressIndicator.Text = Player.getSongPosition(); 
            else if (!Player.paused) UpdateGUI();
        }
// MENU BAR
        // MUSIC
        private void moreSongInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SongInfo songInfo = new SongInfo();
            songInfo.ShowDialog();
        }
        // HELP
        private void aboutFRESHMusicPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

// LOGIC
        public void getAlbumArt()
        {
            ATL.Track theTrack = new ATL.Track(Player.filePath);
            IList<ATL.PictureInfo> embeddedPictures = theTrack.EmbeddedPictures;
            Graphics g = albumartBox.CreateGraphics();
            g.Clear(volumeBar.BackColor); // The background color of the volume bar should be the same as the highlight color of the UI
            albumartBox.Image?.Dispose(); // Clear resources used by the previous image
            foreach (ATL.PictureInfo pic in embeddedPictures)
            {
                albumartBox.Image = Image.FromStream(new System.IO.MemoryStream(pic.PictureData));
            }
        }
        private void volumeBar_MouseHover(object sender, EventArgs e) => toolTip1.SetToolTip(volumeBar, $"{volumeBar.Value.ToString()}%");
        // SETTINGS
        public void ApplySettings()
        {
            if (Properties.Settings.Default.Appearance_DarkMode)
            {
                BackColor = Color.FromArgb(44, 47, 51);
                volumeBar.BackColor = Color.FromArgb(44, 47, 51); // Handles highlight colors
                ForeColor = Color.White;
                // Welcome to the point where we get to repetitive code that would make any experienced programmer want to die.
                tabPage1.BackColor = Color.Black;tabPage2.BackColor = Color.Black;tabPage3.BackColor = Color.Black;tabPage4.BackColor = Color.Black; tabPage5.BackColor = Color.Black; tabPage6.BackColor = Color.Black;
                browsemusicButton.ForeColor = Color.Black;importplaylistButton.ForeColor = Color.Black;applychangesButton.ForeColor = Color.Black;browsebackButton.ForeColor = Color.Black;
                groupBox1.ForeColor = Color.White;groupBox2.ForeColor = Color.White;groupBox3.ForeColor = Color.White;
                menuBar.BackColor = Color.Black;menuBar.ForeColor = Color.White;
            }
        }
        private void applychangesButton_Click(object sender, EventArgs e)
        {
            if (darkradioButton.Checked) Properties.Settings.Default.Appearance_DarkMode = true; else Properties.Settings.Default.Appearance_DarkMode = false;
            if (backgroundradioButton.Checked) Properties.Settings.Default.Appearance_ImageDefault = true; else Properties.Settings.Default.Appearance_ImageDefault = false;
            Properties.Settings.Default.Save();
            ApplySettings();
        }

        
    }
    
}