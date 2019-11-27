﻿namespace FRESHMusicPlayer
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAudioFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlaylistFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSongMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleDarkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFRESHMusicPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.importplaylistButton = new System.Windows.Forms.Button();
            this.browsemusicButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.applychangesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.config_Header = new System.Windows.Forms.Label();
            this.configTabs = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.solidcolorradioButton = new System.Windows.Forms.RadioButton();
            this.backgroundradioButton = new System.Windows.Forms.RadioButton();
            this.browsebackButton = new System.Windows.Forms.Button();
            this.defaultbackcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lightradioButton = new System.Windows.Forms.RadioButton();
            this.darkradioButton = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.controlsBox = new System.Windows.Forms.GroupBox();
            this.albumartBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.progressIndicator = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseplayButton = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreSongInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.configTabs.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.controlsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.musicToolStripMenuItem,
            this.editToolStripMenuItem,
            this.configToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuBar.Size = new System.Drawing.Size(648, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAudioFileToolStripMenuItem,
            this.openPlaylistFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openAudioFileToolStripMenuItem
            // 
            this.openAudioFileToolStripMenuItem.Name = "openAudioFileToolStripMenuItem";
            this.openAudioFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openAudioFileToolStripMenuItem.Text = "Open Audio File";
            // 
            // openPlaylistFileToolStripMenuItem
            // 
            this.openPlaylistFileToolStripMenuItem.Name = "openPlaylistFileToolStripMenuItem";
            this.openPlaylistFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openPlaylistFileToolStripMenuItem.Text = "Open Playlist File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSongMetadataToolStripMenuItem,
            this.createPlaylistToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editSongMetadataToolStripMenuItem
            // 
            this.editSongMetadataToolStripMenuItem.Name = "editSongMetadataToolStripMenuItem";
            this.editSongMetadataToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editSongMetadataToolStripMenuItem.Text = "Edit Song Metadata";
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.createPlaylistToolStripMenuItem.Text = "Create Playlist";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackgroundToolStripMenuItem,
            this.toggleDarkModeToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // changeBackgroundToolStripMenuItem
            // 
            this.changeBackgroundToolStripMenuItem.Name = "changeBackgroundToolStripMenuItem";
            this.changeBackgroundToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.changeBackgroundToolStripMenuItem.Text = "Change Background";
            // 
            // toggleDarkModeToolStripMenuItem
            // 
            this.toggleDarkModeToolStripMenuItem.Name = "toggleDarkModeToolStripMenuItem";
            this.toggleDarkModeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.toggleDarkModeToolStripMenuItem.Text = "Toggle Dark Mode";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFRESHMusicPlayerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutFRESHMusicPlayerToolStripMenuItem
            // 
            this.aboutFRESHMusicPlayerToolStripMenuItem.Name = "aboutFRESHMusicPlayerToolStripMenuItem";
            this.aboutFRESHMusicPlayerToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.aboutFRESHMusicPlayerToolStripMenuItem.Text = "About FRESHMusicPlayer";
            this.aboutFRESHMusicPlayerToolStripMenuItem.Click += new System.EventHandler(this.aboutFRESHMusicPlayerToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 358);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(640, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Music";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "import your songs\r\nand stuff!\r\n";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Music";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.importplaylistButton);
            this.groupBox1.Controls.Add(this.browsemusicButton);
            this.groupBox1.Location = new System.Drawing.Point(161, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Music";
            // 
            // importplaylistButton
            // 
            this.importplaylistButton.Location = new System.Drawing.Point(188, 28);
            this.importplaylistButton.Name = "importplaylistButton";
            this.importplaylistButton.Size = new System.Drawing.Size(144, 36);
            this.importplaylistButton.TabIndex = 1;
            this.importplaylistButton.Text = "Import Playlist";
            this.importplaylistButton.UseVisualStyleBackColor = true;
            // 
            // browsemusicButton
            // 
            this.browsemusicButton.Location = new System.Drawing.Point(6, 28);
            this.browsemusicButton.Name = "browsemusicButton";
            this.browsemusicButton.Size = new System.Drawing.Size(176, 78);
            this.browsemusicButton.TabIndex = 0;
            this.browsemusicButton.Text = "Browse...";
            this.browsemusicButton.UseVisualStyleBackColor = true;
            this.browsemusicButton.Click += new System.EventHandler(this.browsemusicButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(640, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Playlists/Albums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.applychangesButton);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.config_Header);
            this.tabPage3.Controls.Add(this.configTabs);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(640, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // applychangesButton
            // 
            this.applychangesButton.Location = new System.Drawing.Point(12, 185);
            this.applychangesButton.Name = "applychangesButton";
            this.applychangesButton.Size = new System.Drawing.Size(139, 36);
            this.applychangesButton.TabIndex = 3;
            this.applychangesButton.Text = "Apply changes!";
            this.applychangesButton.UseVisualStyleBackColor = true;
            this.applychangesButton.Click += new System.EventHandler(this.applychangesButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "customize FMP \r\nto work for you!";
            // 
            // config_Header
            // 
            this.config_Header.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.config_Header.AutoSize = true;
            this.config_Header.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config_Header.Location = new System.Drawing.Point(8, 23);
            this.config_Header.Name = "config_Header";
            this.config_Header.Size = new System.Drawing.Size(97, 30);
            this.config_Header.TabIndex = 1;
            this.config_Header.Text = "Settings";
            // 
            // configTabs
            // 
            this.configTabs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.configTabs.Controls.Add(this.tabPage4);
            this.configTabs.Controls.Add(this.tabPage5);
            this.configTabs.Controls.Add(this.tabPage6);
            this.configTabs.Location = new System.Drawing.Point(153, 3);
            this.configTabs.Name = "configTabs";
            this.configTabs.SelectedIndex = 0;
            this.configTabs.Size = new System.Drawing.Size(491, 222);
            this.configTabs.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(483, 188);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "General";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.checkBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(483, 188);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Appearance";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.solidcolorradioButton);
            this.groupBox3.Controls.Add(this.backgroundradioButton);
            this.groupBox3.Controls.Add(this.browsebackButton);
            this.groupBox3.Controls.Add(this.defaultbackcheckBox);
            this.groupBox3.Location = new System.Drawing.Point(179, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 125);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Background";
            // 
            // solidcolorradioButton
            // 
            this.solidcolorradioButton.AutoSize = true;
            this.solidcolorradioButton.Location = new System.Drawing.Point(19, 22);
            this.solidcolorradioButton.Name = "solidcolorradioButton";
            this.solidcolorradioButton.Size = new System.Drawing.Size(140, 25);
            this.solidcolorradioButton.TabIndex = 4;
            this.solidcolorradioButton.TabStop = true;
            this.solidcolorradioButton.Text = "Use solid color";
            this.solidcolorradioButton.UseVisualStyleBackColor = true;
            // 
            // backgroundradioButton
            // 
            this.backgroundradioButton.AutoSize = true;
            this.backgroundradioButton.Location = new System.Drawing.Point(19, 54);
            this.backgroundradioButton.Name = "backgroundradioButton";
            this.backgroundradioButton.Size = new System.Drawing.Size(204, 25);
            this.backgroundradioButton.TabIndex = 5;
            this.backgroundradioButton.TabStop = true;
            this.backgroundradioButton.Text = "Use background image";
            this.backgroundradioButton.UseVisualStyleBackColor = true;
            // 
            // browsebackButton
            // 
            this.browsebackButton.Location = new System.Drawing.Point(225, 85);
            this.browsebackButton.Name = "browsebackButton";
            this.browsebackButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.browsebackButton.Size = new System.Drawing.Size(75, 27);
            this.browsebackButton.TabIndex = 6;
            this.browsebackButton.Text = "Browse";
            this.browsebackButton.UseVisualStyleBackColor = true;
            // 
            // defaultbackcheckBox
            // 
            this.defaultbackcheckBox.AutoSize = true;
            this.defaultbackcheckBox.Location = new System.Drawing.Point(38, 85);
            this.defaultbackcheckBox.Name = "defaultbackcheckBox";
            this.defaultbackcheckBox.Size = new System.Drawing.Size(182, 25);
            this.defaultbackcheckBox.TabIndex = 7;
            this.defaultbackcheckBox.Text = "Default Background";
            this.defaultbackcheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lightradioButton);
            this.groupBox2.Controls.Add(this.darkradioButton);
            this.groupBox2.Location = new System.Drawing.Point(14, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 127);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Theme";
            // 
            // lightradioButton
            // 
            this.lightradioButton.AutoSize = true;
            this.lightradioButton.Location = new System.Drawing.Point(6, 24);
            this.lightradioButton.Name = "lightradioButton";
            this.lightradioButton.Size = new System.Drawing.Size(115, 25);
            this.lightradioButton.TabIndex = 1;
            this.lightradioButton.TabStop = true;
            this.lightradioButton.Text = "Light Mode";
            this.lightradioButton.UseVisualStyleBackColor = true;
            // 
            // darkradioButton
            // 
            this.darkradioButton.AutoSize = true;
            this.darkradioButton.Location = new System.Drawing.Point(6, 55);
            this.darkradioButton.Name = "darkradioButton";
            this.darkradioButton.Size = new System.Drawing.Size(112, 25);
            this.darkradioButton.TabIndex = 2;
            this.darkradioButton.TabStop = true;
            this.darkradioButton.Text = "Dark Mode";
            this.darkradioButton.UseMnemonic = false;
            this.darkradioButton.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(230, 25);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show song title in title bar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 30);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(483, 188);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "About";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 30);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(640, 324);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Editors";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // controlsBox
            // 
            this.controlsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlsBox.BackColor = System.Drawing.Color.Transparent;
            this.controlsBox.Controls.Add(this.albumartBox);
            this.controlsBox.Controls.Add(this.label3);
            this.controlsBox.Controls.Add(this.infoButton);
            this.controlsBox.Controls.Add(this.progressIndicator);
            this.controlsBox.Controls.Add(this.titleLabel);
            this.controlsBox.Controls.Add(this.stopButton);
            this.controlsBox.Controls.Add(this.pauseplayButton);
            this.controlsBox.Controls.Add(this.volumeBar);
            this.controlsBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.controlsBox.Location = new System.Drawing.Point(0, 285);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.Size = new System.Drawing.Size(648, 97);
            this.controlsBox.TabIndex = 3;
            this.controlsBox.TabStop = false;
            this.controlsBox.Text = "Controls";
            // 
            // albumartBox
            // 
            this.albumartBox.Location = new System.Drawing.Point(10, 21);
            this.albumartBox.Name = "albumartBox";
            this.albumartBox.Size = new System.Drawing.Size(70, 70);
            this.albumartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumartBox.TabIndex = 7;
            this.albumartBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(293, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Volume";
            // 
            // infoButton
            // 
            this.infoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.infoButton.Image = global::FRESHMusicPlayer.Properties.Resources.baseline_info_black_18dp;
            this.infoButton.Location = new System.Drawing.Point(598, 50);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(46, 43);
            this.infoButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.infoButton, "More info about this song");
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // progressIndicator
            // 
            this.progressIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressIndicator.AutoSize = true;
            this.progressIndicator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressIndicator.Location = new System.Drawing.Point(88, 67);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.Size = new System.Drawing.Size(145, 21);
            this.progressIndicator.TabIndex = 3;
            this.progressIndicator.Text = "(nothing playing)";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(86, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(201, 32);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Nothing Playing";
            this.titleLabel.UseMnemonic = false;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Image = global::FRESHMusicPlayer.Properties.Resources.baseline_stop_black_18dp;
            this.stopButton.Location = new System.Drawing.Point(546, 50);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(46, 43);
            this.stopButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.stopButton, "Stop");
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseplayButton
            // 
            this.pauseplayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseplayButton.Image = global::FRESHMusicPlayer.Properties.Resources.baseline_pause_black_18dp;
            this.pauseplayButton.Location = new System.Drawing.Point(494, 50);
            this.pauseplayButton.Name = "pauseplayButton";
            this.pauseplayButton.Size = new System.Drawing.Size(46, 43);
            this.pauseplayButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pauseplayButton, "Pause/Play");
            this.pauseplayButton.UseVisualStyleBackColor = true;
            this.pauseplayButton.Click += new System.EventHandler(this.pauseplayButton_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
            this.volumeBar.LargeChange = 25;
            this.volumeBar.Location = new System.Drawing.Point(359, 14);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(288, 45);
            this.volumeBar.SmallChange = 10;
            this.volumeBar.TabIndex = 5;
            this.volumeBar.TickFrequency = 10;
            this.volumeBar.Value = 100;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            this.volumeBar.MouseHover += new System.EventHandler(this.volumeBar_MouseHover);
            // 
            // progressTimer
            // 
            this.progressTimer.Enabled = true;
            this.progressTimer.Interval = 1000;
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreSongInfoToolStripMenuItem});
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.musicToolStripMenuItem.Text = "Music";
            // 
            // moreSongInfoToolStripMenuItem
            // 
            this.moreSongInfoToolStripMenuItem.Name = "moreSongInfoToolStripMenuItem";
            this.moreSongInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moreSongInfoToolStripMenuItem.Text = "More Song Info";
            this.moreSongInfoToolStripMenuItem.Click += new System.EventHandler(this.moreSongInfoToolStripMenuItem_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(648, 382);
            this.Controls.Add(this.controlsBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserInterface";
            this.Text = "FRESHMusicPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.configTabs.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.controlsBox.ResumeLayout(false);
            this.controlsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox controlsBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label config_Header;
        private System.Windows.Forms.TabControl configTabs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label progressIndicator;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button importplaylistButton;
        private System.Windows.Forms.Button browsemusicButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pauseplayButton;
        private System.Windows.Forms.ToolStripMenuItem openAudioFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPlaylistFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSongMetadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleDarkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutFRESHMusicPlayerToolStripMenuItem;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox defaultbackcheckBox;
        private System.Windows.Forms.Button browsebackButton;
        private System.Windows.Forms.RadioButton backgroundradioButton;
        private System.Windows.Forms.RadioButton solidcolorradioButton;
        private System.Windows.Forms.RadioButton darkradioButton;
        private System.Windows.Forms.RadioButton lightradioButton;
        private System.Windows.Forms.PictureBox albumartBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button applychangesButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreSongInfoToolStripMenuItem;
    }
}