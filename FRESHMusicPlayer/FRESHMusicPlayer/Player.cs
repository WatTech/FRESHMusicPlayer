﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using ATL.Playlist;
namespace FRESHMusicPlayer
{
    public partial class Player : Form
    {
        public static string filePath = "";
        public static string fileContent = "";
        public static bool playing = false;
        public static bool paused = false;
        private static WaveOutEvent outputDevice;
        private static AudioFileReader audioFile;
        public static int position;
        public static float currentvolume = 1;
        public Player()
        {
            InitializeComponent();
            UserInterface userInterface = new UserInterface();
            userInterface.Show();
            
        }
        // Interaction with other forms
        public static (string Artist, string Title) GetMetadata()
        {
            ATL.Track theTrack = new ATL.Track(filePath);
            return (theTrack.Artist, theTrack.Title);
        }
        // Music Playing Controls
        private static void OnPlaybackStopped(object sender, StoppedEventArgs args) => StopMusic();
        public static string PlayMusic(string path)
        {
            ATL.Track theTrack = new ATL.Track(filePath);
            void PMusic()
            {
                
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }
                if (audioFile == null)
                {

                    audioFile = new AudioFileReader(path);
                    outputDevice.Init(audioFile);
                }
                //nowplaying.Text = $"{theTrack.Artist} - {theTrack.Title}";
                //Text = $"{theTrack.Artist} - {theTrack.Title} | FRESHMusicPlayer";
                outputDevice.Play();
                outputDevice.Volume = currentvolume;
                //moreinfo.Visible = true;
                playing = true;
                
            }
            try
            {
                if (playing != true)
                {
                    PMusic();
                }
                else
                {
                    StopMusic();
                    PMusic();
                }
            }
            catch (System.IO.FileNotFoundException)
            {

                MessageBox.Show("Onee-Chan~~! That's not a valid file path, you BAKA! (or it's not a supported file type!)", "Incorrect file path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Onee-Chan~~! You BAKA! You're supposed to actually put something in the box!", "Nothing typed in file path box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Onee-Chan~! That's not a valid audio file!", "File Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Onee-Chan~! This audio file must be corrupt! I can't play it!", "Format Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Onee-Chan~! FRESHMusicPlayer doesn't support fancy VBR audio files! (or your audio file is corrupt in some way)", "VBR Files Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return $"{theTrack.Artist} - {theTrack.Title}";
        }
        public static void StopMusic()
        {
            if (playing)
                try
                {
                    outputDevice.Dispose();
                    outputDevice = null;
                    audioFile?.Dispose();
                    audioFile = null;
                    playing = false;
                    paused = false;
                    position = 0;
                    
                }
                catch (System.NullReferenceException)
                {
                    //PlayMusic(filePath);

                }


                catch (NAudio.MmException)
                {
                    Console.WriteLine("Things are breaking!");
                    Console.WriteLine(filePath);
                    //MessageBox.Show("ok", "Format Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    outputDevice?.Dispose();
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped; // Does the same initiallisation PlayMusic() does.
                    audioFile = new AudioFileReader(filePath);
                    outputDevice.Init(audioFile);
                    PlayMusic(filePath);
                }
            else PlayMusic(filePath);
        }
        public static void PauseMusic()
        {
            if (!paused) outputDevice?.Pause();
            //playing = false;
            paused = true;
        }// Pauses the music without completely disposing it
        public static void ResumeMusic()
        {
            if (paused) outputDevice?.Play();
            //playing = true;
            paused = false;
        }// Resumes music that has been paused
        public static void UpdateSettings()
        {
            outputDevice.Volume = currentvolume;
        }
        // Other Logic Stuff
        public static string getSongPosition()
        {
            if (playing)
            position += 1;
            string Format(int secs)
            {
                int hours = 0;
                int mins = 0;

                while (secs >= 60)
                {
                    mins++;
                    secs -= 60;
                }

                while (mins >= 60)
                {
                    hours++;
                    mins -= 60;
                }

                string hourStr = hours.ToString(); if (hourStr.Length < 2) hourStr = "0" + hourStr;
                string minStr = mins.ToString(); if (minStr.Length < 2) minStr = "0" + minStr;
                string secStr = secs.ToString(); if (secStr.Length < 2) secStr = "0" + secStr;

                string durStr = "";
                if (hourStr != "00") durStr += hourStr + ":";
                durStr = minStr + ":" + secStr;

                return durStr;
            }
            ATL.Track theTrack = new ATL.Track(filePath);
            return $"{Format(position)} / {Format(theTrack.Duration)}";
        }
        
    }
}