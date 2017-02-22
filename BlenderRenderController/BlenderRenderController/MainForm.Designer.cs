﻿namespace BlenderRenderController
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.renderChunkButton = new System.Windows.Forms.Button();
            this.blendFileBrowseButton = new System.Windows.Forms.Button();
            this.renderProgressBar = new System.Windows.Forms.ProgressBar();
            this.totalStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startFrameLabel = new System.Windows.Forms.Label();
            this.chunkEndLabel = new System.Windows.Forms.Label();
            this.partsFolderBrowseButton = new System.Windows.Forms.Button();
            this.partsFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.rendererComboBox = new System.Windows.Forms.ComboBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.nextChunkButton = new System.Windows.Forms.Button();
            this.prevChunkButton = new System.Windows.Forms.Button();
            this.totalFrameCountLabel = new System.Windows.Forms.Label();
            this.totalEndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.processCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.renderAllButton = new System.Windows.Forms.Button();
            this.concatenatePartsButton = new System.Windows.Forms.Button();
            this.reloadBlenderDataButton = new System.Windows.Forms.Button();
            this.mixDownButton = new System.Windows.Forms.Button();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autocombineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugShow = new System.Windows.Forms.ToolStripMenuItem();
            this.speToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.visitGithubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isti115ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meTwentyFiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redRaptor93ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDArgsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.infoDurationLabel = new System.Windows.Forms.Label();
            this.infoFramerate = new System.Windows.Forms.TextBox();
            this.infoDuration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.infoNoScenes = new System.Windows.Forms.TextBox();
            this.infoFramesTotal = new System.Windows.Forms.TextBox();
            this.infoActiveScene = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.infoFramesTotalLabel = new System.Windows.Forms.Label();
            this.activeWarn = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.blendFileLabel = new System.Windows.Forms.Label();
            this.chunkLengthLabel = new System.Windows.Forms.Label();
            this.chunkStartLabel = new System.Windows.Forms.Label();
            this.chunkLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chunkStartNumericUpDown = new System.Windows.Forms.TextBox();
            this.chunkEndNumericUpDown = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jendabekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOutputFolderButton = new System.Windows.Forms.Button();
            this.blendFileNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totalStartNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEndNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chunkLengthNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderChunkButton
            // 
            this.renderChunkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderChunkButton.Location = new System.Drawing.Point(21, 75);
            this.renderChunkButton.Name = "renderChunkButton";
            this.renderChunkButton.Size = new System.Drawing.Size(101, 34);
            this.renderChunkButton.TabIndex = 0;
            this.renderChunkButton.Text = "Render Chunk";
            this.toolTip1.SetToolTip(this.renderChunkButton, "Render current segment");
            this.renderChunkButton.UseVisualStyleBackColor = true;
            this.renderChunkButton.Click += new System.EventHandler(this.renderChunkButton_Click);
            // 
            // blendFileBrowseButton
            // 
            this.blendFileBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blendFileBrowseButton.Location = new System.Drawing.Point(486, 72);
            this.blendFileBrowseButton.Name = "blendFileBrowseButton";
            this.blendFileBrowseButton.Size = new System.Drawing.Size(158, 45);
            this.blendFileBrowseButton.TabIndex = 1;
            this.blendFileBrowseButton.Text = "Browse for .blend";
            this.blendFileBrowseButton.UseVisualStyleBackColor = true;
            this.blendFileBrowseButton.Click += new System.EventHandler(this.blendFileBrowseButton_Click);
            // 
            // renderProgressBar
            // 
            this.renderProgressBar.Location = new System.Drawing.Point(36, 622);
            this.renderProgressBar.Name = "renderProgressBar";
            this.renderProgressBar.Size = new System.Drawing.Size(608, 38);
            this.renderProgressBar.Step = 1;
            this.renderProgressBar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.renderProgressBar, "Progress bar");
            // 
            // totalStartNumericUpDown
            // 
            this.totalStartNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStartNumericUpDown.Location = new System.Drawing.Point(36, 238);
            this.totalStartNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.totalStartNumericUpDown.Name = "totalStartNumericUpDown";
            this.totalStartNumericUpDown.Size = new System.Drawing.Size(90, 22);
            this.totalStartNumericUpDown.TabIndex = 2;
            this.toolTip1.SetToolTip(this.totalStartNumericUpDown, "Segment\'s starting frame");
            this.totalStartNumericUpDown.ValueChanged += new System.EventHandler(this.totalStartNumericUpDown_ValueChanged);
            // 
            // startFrameLabel
            // 
            this.startFrameLabel.AutoSize = true;
            this.startFrameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startFrameLabel.Location = new System.Drawing.Point(33, 222);
            this.startFrameLabel.Name = "startFrameLabel";
            this.startFrameLabel.Size = new System.Drawing.Size(61, 13);
            this.startFrameLabel.TabIndex = 6;
            this.startFrameLabel.Text = "Start Frame";
            this.toolTip1.SetToolTip(this.startFrameLabel, "Segment\'s starting frame");
            // 
            // chunkEndLabel
            // 
            this.chunkEndLabel.AutoSize = true;
            this.chunkEndLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chunkEndLabel.Location = new System.Drawing.Point(130, 71);
            this.chunkEndLabel.Name = "chunkEndLabel";
            this.chunkEndLabel.Size = new System.Drawing.Size(58, 13);
            this.chunkEndLabel.TabIndex = 7;
            this.chunkEndLabel.Text = "End Frame";
            this.toolTip1.SetToolTip(this.chunkEndLabel, "Segment\'s end frame");
            this.chunkEndLabel.Click += new System.EventHandler(this.chunkEndLabel_Click);
            // 
            // partsFolderBrowseButton
            // 
            this.partsFolderBrowseButton.Location = new System.Drawing.Point(378, 322);
            this.partsFolderBrowseButton.Name = "partsFolderBrowseButton";
            this.partsFolderBrowseButton.Size = new System.Drawing.Size(106, 31);
            this.partsFolderBrowseButton.TabIndex = 8;
            this.partsFolderBrowseButton.Text = "Change";
            this.partsFolderBrowseButton.UseVisualStyleBackColor = true;
            this.partsFolderBrowseButton.Click += new System.EventHandler(this.partsFolderBrowseButton_Click);
            // 
            // partsFolderPathTextBox
            // 
            this.partsFolderPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsFolderPathTextBox.Location = new System.Drawing.Point(36, 326);
            this.partsFolderPathTextBox.Name = "partsFolderPathTextBox";
            this.partsFolderPathTextBox.Size = new System.Drawing.Size(336, 22);
            this.partsFolderPathTextBox.TabIndex = 3;
            this.partsFolderPathTextBox.TabStop = false;
            this.partsFolderPathTextBox.TextChanged += new System.EventHandler(this.outFolderPathTextBox_TextChanged);
            // 
            // rendererComboBox
            // 
            this.rendererComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendererComboBox.FormattingEnabled = true;
            this.rendererComboBox.Items.AddRange(new object[] {
            "BLENDER_RENDER",
            "CYCLES"});
            this.rendererComboBox.Location = new System.Drawing.Point(486, 237);
            this.rendererComboBox.Name = "rendererComboBox";
            this.rendererComboBox.Size = new System.Drawing.Size(158, 24);
            this.rendererComboBox.TabIndex = 6;
            this.rendererComboBox.Text = "BLENDER_RENDER";
            this.rendererComboBox.SelectedIndexChanged += new System.EventHandler(this.rendererComboBox_SelectedIndexChanged);
            // 
            // progressLabel
            // 
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.progressLabel.Location = new System.Drawing.Point(32, 670);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(54, 20);
            this.progressLabel.TabIndex = 11;
            this.progressLabel.Text = "0/0";
            this.toolTip1.SetToolTip(this.progressLabel, "Progress");
            this.progressLabel.Visible = false;
            // 
            // nextChunkButton
            // 
            this.nextChunkButton.Location = new System.Drawing.Point(74, 39);
            this.nextChunkButton.Name = "nextChunkButton";
            this.nextChunkButton.Size = new System.Drawing.Size(47, 27);
            this.nextChunkButton.TabIndex = 12;
            this.nextChunkButton.Text = ">";
            this.toolTip1.SetToolTip(this.nextChunkButton, "Segment select");
            this.nextChunkButton.UseVisualStyleBackColor = true;
            this.nextChunkButton.Click += new System.EventHandler(this.nextChunkButton_Click);
            // 
            // prevChunkButton
            // 
            this.prevChunkButton.Location = new System.Drawing.Point(21, 39);
            this.prevChunkButton.Name = "prevChunkButton";
            this.prevChunkButton.Size = new System.Drawing.Size(47, 27);
            this.prevChunkButton.TabIndex = 12;
            this.prevChunkButton.Text = "<";
            this.toolTip1.SetToolTip(this.prevChunkButton, "Segment select");
            this.prevChunkButton.UseVisualStyleBackColor = true;
            this.prevChunkButton.Click += new System.EventHandler(this.prevChunkButton_Click);
            // 
            // totalFrameCountLabel
            // 
            this.totalFrameCountLabel.AutoSize = true;
            this.totalFrameCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFrameCountLabel.Location = new System.Drawing.Point(140, 222);
            this.totalFrameCountLabel.Name = "totalFrameCountLabel";
            this.totalFrameCountLabel.Size = new System.Drawing.Size(58, 13);
            this.totalFrameCountLabel.TabIndex = 13;
            this.totalFrameCountLabel.Text = "End Frame";
            this.toolTip1.SetToolTip(this.totalFrameCountLabel, "Project\'s end frame");
            this.totalFrameCountLabel.Click += new System.EventHandler(this.totalFrameCountLabel_Click);
            // 
            // totalEndNumericUpDown
            // 
            this.totalEndNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEndNumericUpDown.Location = new System.Drawing.Point(143, 238);
            this.totalEndNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.totalEndNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.totalEndNumericUpDown.Name = "totalEndNumericUpDown";
            this.totalEndNumericUpDown.Size = new System.Drawing.Size(90, 22);
            this.totalEndNumericUpDown.TabIndex = 3;
            this.toolTip1.SetToolTip(this.totalEndNumericUpDown, "Project\'s end frame");
            this.totalEndNumericUpDown.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.totalEndNumericUpDown.ValueChanged += new System.EventHandler(this.totalEndNumericUpDown_ValueChanged);
            // 
            // processCountNumericUpDown
            // 
            this.processCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCountNumericUpDown.Location = new System.Drawing.Point(402, 238);
            this.processCountNumericUpDown.Name = "processCountNumericUpDown";
            this.processCountNumericUpDown.Size = new System.Drawing.Size(73, 22);
            this.processCountNumericUpDown.TabIndex = 5;
            this.toolTip1.SetToolTip(this.processCountNumericUpDown, "N# of processes. For best results set acording to \r\nhow many logical cores you ha" +
        "ve.");
            this.processCountNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // processCountLabel
            // 
            this.processCountLabel.AutoSize = true;
            this.processCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCountLabel.Location = new System.Drawing.Point(399, 222);
            this.processCountLabel.Name = "processCountLabel";
            this.processCountLabel.Size = new System.Drawing.Size(76, 13);
            this.processCountLabel.TabIndex = 15;
            this.processCountLabel.Text = "Process Count";
            this.toolTip1.SetToolTip(this.processCountLabel, "N# of processes. For best results set acording to ");
            // 
            // renderAllButton
            // 
            this.renderAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderAllButton.Location = new System.Drawing.Point(35, 417);
            this.renderAllButton.Name = "renderAllButton";
            this.renderAllButton.Size = new System.Drawing.Size(168, 61);
            this.renderAllButton.TabIndex = 7;
            this.renderAllButton.Text = "Render All";
            this.toolTip1.SetToolTip(this.renderAllButton, "Render all segments");
            this.renderAllButton.UseVisualStyleBackColor = true;
            this.renderAllButton.Click += new System.EventHandler(this.renderAllButton_Click);
            // 
            // concatenatePartsButton
            // 
            this.concatenatePartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concatenatePartsButton.Location = new System.Drawing.Point(36, 544);
            this.concatenatePartsButton.Name = "concatenatePartsButton";
            this.concatenatePartsButton.Size = new System.Drawing.Size(123, 38);
            this.concatenatePartsButton.TabIndex = 10;
            this.concatenatePartsButton.Text = "Join Chunks";
            this.toolTip1.SetToolTip(this.concatenatePartsButton, "Combine segments in FFmpeg");
            this.concatenatePartsButton.UseVisualStyleBackColor = true;
            this.concatenatePartsButton.Click += new System.EventHandler(this.concatenatePartsButton_Click);
            // 
            // reloadBlenderDataButton
            // 
            this.reloadBlenderDataButton.Location = new System.Drawing.Point(486, 125);
            this.reloadBlenderDataButton.Name = "reloadBlenderDataButton";
            this.reloadBlenderDataButton.Size = new System.Drawing.Size(158, 27);
            this.reloadBlenderDataButton.TabIndex = 17;
            this.reloadBlenderDataButton.Text = "Reload && Reset Form";
            this.toolTip1.SetToolTip(this.reloadBlenderDataButton, "Re-read info from .blend");
            this.reloadBlenderDataButton.UseVisualStyleBackColor = true;
            this.reloadBlenderDataButton.Click += new System.EventHandler(this.reloadBlenderDataButton_Click);
            // 
            // mixDownButton
            // 
            this.mixDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mixDownButton.Location = new System.Drawing.Point(212, 417);
            this.mixDownButton.Name = "mixDownButton";
            this.mixDownButton.Size = new System.Drawing.Size(119, 61);
            this.mixDownButton.TabIndex = 9;
            this.mixDownButton.Text = "Audio Mixdown";
            this.mixDownButton.UseVisualStyleBackColor = true;
            this.mixDownButton.Click += new System.EventHandler(this.MixdownAudio_Click);
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.totalTimeLabel.Location = new System.Drawing.Point(573, 670);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(56, 16);
            this.totalTimeLabel.TabIndex = 19;
            this.totalTimeLabel.Text = "00:00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipsToolStripMenuItem,
            this.autocombineToolStripMenuItem,
            this.debugShow,
            this.speToolStripMenuItem,
            this.visitGithubPageToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "Options";
            this.aboutToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.aboutToolStripMenuItem.ToolTipText = "Extra options";
            // 
            // tipsToolStripMenuItem
            // 
            this.tipsToolStripMenuItem.Checked = true;
            this.tipsToolStripMenuItem.CheckOnClick = true;
            this.tipsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tipsToolStripMenuItem.Name = "tipsToolStripMenuItem";
            this.tipsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tipsToolStripMenuItem.Text = "Tooltips";
            this.tipsToolStripMenuItem.Click += new System.EventHandler(this.tipsToolStripMenuItem_Click);
            // 
            // autocombineToolStripMenuItem
            // 
            this.autocombineToolStripMenuItem.CheckOnClick = true;
            this.autocombineToolStripMenuItem.Name = "autocombineToolStripMenuItem";
            this.autocombineToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.autocombineToolStripMenuItem.Text = "Auto-combine";
            this.autocombineToolStripMenuItem.ToolTipText = "Automatically combine parts when clicking \"Render all\"";
            this.autocombineToolStripMenuItem.Visible = false;
            // 
            // debugShow
            // 
            this.debugShow.CheckOnClick = true;
            this.debugShow.Name = "debugShow";
            this.debugShow.Size = new System.Drawing.Size(164, 22);
            this.debugShow.Text = "Debug menu";
            this.debugShow.Click += new System.EventHandler(this.debugMenuToolStripMenuItem_Click);
            // 
            // speToolStripMenuItem
            // 
            this.speToolStripMenuItem.Name = "speToolStripMenuItem";
            this.speToolStripMenuItem.Size = new System.Drawing.Size(161, 6);
            // 
            // visitGithubPageToolStripMenuItem
            // 
            this.visitGithubPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isti115ToolStripMenuItem,
            this.jendabekToolStripMenuItem,
            this.meTwentyFiveToolStripMenuItem,
            this.redRaptor93ToolStripMenuItem});
            this.visitGithubPageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitGithubPageToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.visitGithubPageToolStripMenuItem.Name = "visitGithubPageToolStripMenuItem";
            this.visitGithubPageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.visitGithubPageToolStripMenuItem.Text = "Visit Github page";
            // 
            // isti115ToolStripMenuItem
            // 
            this.isti115ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isti115ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.isti115ToolStripMenuItem.Name = "isti115ToolStripMenuItem";
            this.isti115ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.isti115ToolStripMenuItem.Text = "Isti115";
            this.isti115ToolStripMenuItem.Click += new System.EventHandler(this.isti115ToolStripMenuItem_Click);
            // 
            // meTwentyFiveToolStripMenuItem
            // 
            this.meTwentyFiveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meTwentyFiveToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.meTwentyFiveToolStripMenuItem.Name = "meTwentyFiveToolStripMenuItem";
            this.meTwentyFiveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.meTwentyFiveToolStripMenuItem.Text = "MeTwentyFive";
            this.meTwentyFiveToolStripMenuItem.Click += new System.EventHandler(this.meTwentyFiveToolStripMenuItem_Click);
            // 
            // redRaptor93ToolStripMenuItem
            // 
            this.redRaptor93ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redRaptor93ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.redRaptor93ToolStripMenuItem.Name = "redRaptor93ToolStripMenuItem";
            this.redRaptor93ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redRaptor93ToolStripMenuItem.Text = "RedRaptor93";
            this.redRaptor93ToolStripMenuItem.Click += new System.EventHandler(this.redRaptor93ToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readmeToolStripMenuItem,
            this.jsonToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.readmeToolStripMenuItem.Text = "Readme";
            this.readmeToolStripMenuItem.ToolTipText = "Open readme (WIP)";
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.jsonToolStripMenuItem.Text = "Json info";
            this.jsonToolStripMenuItem.ToolTipText = "Show contents of Json file";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteJsonToolStripMenuItem,
            this.cMDArgsToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Visible = false;
            // 
            // deleteJsonToolStripMenuItem
            // 
            this.deleteJsonToolStripMenuItem.Name = "deleteJsonToolStripMenuItem";
            this.deleteJsonToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deleteJsonToolStripMenuItem.Text = "Delete json";
            this.deleteJsonToolStripMenuItem.Click += new System.EventHandler(this.deleteJsonToolStripMenuItem_Click);
            // 
            // cMDArgsToolStripMenuItem
            // 
            this.cMDArgsToolStripMenuItem.Name = "cMDArgsToolStripMenuItem";
            this.cMDArgsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cMDArgsToolStripMenuItem.Text = "CMD args";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Active Scene";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.activeWarn.SetToolTip(this.label1, "This program will only render the ACTIVE scene, if you \r\nhave more then one scene" +
        " on your project sure you \r\nsave it with the scene you want OPEN.");
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.Info;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.infoDurationLabel);
            this.infoPanel.Controls.Add(this.infoFramerate);
            this.infoPanel.Controls.Add(this.infoDuration);
            this.infoPanel.Controls.Add(this.label7);
            this.infoPanel.Controls.Add(this.infoNoScenes);
            this.infoPanel.Controls.Add(this.infoFramesTotal);
            this.infoPanel.Controls.Add(this.infoActiveScene);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.infoFramesTotalLabel);
            this.infoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPanel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.infoPanel.Location = new System.Drawing.Point(32, 72);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(434, 80);
            this.infoPanel.TabIndex = 22;
            // 
            // infoDurationLabel
            // 
            this.infoDurationLabel.AutoSize = true;
            this.infoDurationLabel.BackColor = System.Drawing.SystemColors.Info;
            this.infoDurationLabel.Location = new System.Drawing.Point(318, 19);
            this.infoDurationLabel.Name = "infoDurationLabel";
            this.infoDurationLabel.Size = new System.Drawing.Size(67, 13);
            this.infoDurationLabel.TabIndex = 31;
            this.infoDurationLabel.Text = "Length Total";
            // 
            // infoFramerate
            // 
            this.infoFramerate.Cursor = System.Windows.Forms.Cursors.No;
            this.infoFramerate.Location = new System.Drawing.Point(193, 38);
            this.infoFramerate.Name = "infoFramerate";
            this.infoFramerate.ReadOnly = true;
            this.infoFramerate.Size = new System.Drawing.Size(36, 20);
            this.infoFramerate.TabIndex = 30;
            this.infoFramerate.TabStop = false;
            this.infoFramerate.Text = "...";
            this.infoFramerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoDuration
            // 
            this.infoDuration.Cursor = System.Windows.Forms.Cursors.No;
            this.infoDuration.Location = new System.Drawing.Point(321, 38);
            this.infoDuration.Name = "infoDuration";
            this.infoDuration.ReadOnly = true;
            this.infoDuration.Size = new System.Drawing.Size(102, 20);
            this.infoDuration.TabIndex = 30;
            this.infoDuration.TabStop = false;
            this.infoDuration.Text = "...";
            this.infoDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "FPS";
            // 
            // infoNoScenes
            // 
            this.infoNoScenes.BackColor = System.Drawing.SystemColors.Control;
            this.infoNoScenes.Cursor = System.Windows.Forms.Cursors.No;
            this.infoNoScenes.Location = new System.Drawing.Point(144, 38);
            this.infoNoScenes.Name = "infoNoScenes";
            this.infoNoScenes.ReadOnly = true;
            this.infoNoScenes.Size = new System.Drawing.Size(43, 20);
            this.infoNoScenes.TabIndex = 26;
            this.infoNoScenes.TabStop = false;
            this.infoNoScenes.Text = "...";
            this.infoNoScenes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.infoNoScenes, "Number of scenes in project.");
            // 
            // infoFramesTotal
            // 
            this.infoFramesTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.infoFramesTotal.Location = new System.Drawing.Point(235, 38);
            this.infoFramesTotal.Name = "infoFramesTotal";
            this.infoFramesTotal.ReadOnly = true;
            this.infoFramesTotal.Size = new System.Drawing.Size(80, 20);
            this.infoFramesTotal.TabIndex = 30;
            this.infoFramesTotal.TabStop = false;
            this.infoFramesTotal.Text = "...";
            this.infoFramesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infoFramesTotal.TextChanged += new System.EventHandler(this.infoFramesTotal_TextChanged);
            // 
            // infoActiveScene
            // 
            this.infoActiveScene.BackColor = System.Drawing.SystemColors.Control;
            this.infoActiveScene.Cursor = System.Windows.Forms.Cursors.No;
            this.infoActiveScene.Location = new System.Drawing.Point(11, 38);
            this.infoActiveScene.Name = "infoActiveScene";
            this.infoActiveScene.ReadOnly = true;
            this.infoActiveScene.Size = new System.Drawing.Size(126, 20);
            this.infoActiveScene.TabIndex = 25;
            this.infoActiveScene.Text = "...";
            this.infoActiveScene.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activeWarn.SetToolTip(this.infoActiveScene, "This program will only render the ACTIVE scene, if you \r\nhave more then one scene" +
        " on your project sure you \r\nsave it with the scene you want OPEN.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Scenes";
            this.activeWarn.SetToolTip(this.label3, "Number of scenes in project.");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // infoFramesTotalLabel
            // 
            this.infoFramesTotalLabel.AutoSize = true;
            this.infoFramesTotalLabel.BackColor = System.Drawing.SystemColors.Info;
            this.infoFramesTotalLabel.Location = new System.Drawing.Point(232, 19);
            this.infoFramesTotalLabel.Name = "infoFramesTotalLabel";
            this.infoFramesTotalLabel.Size = new System.Drawing.Size(68, 13);
            this.infoFramesTotalLabel.TabIndex = 29;
            this.infoFramesTotalLabel.Text = "Frames Total";
            this.infoFramesTotalLabel.Click += new System.EventHandler(this.infoFramesTotalLabel_Click);
            // 
            // activeWarn
            // 
            this.activeWarn.AutomaticDelay = 1000;
            this.activeWarn.IsBalloon = true;
            this.activeWarn.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.activeWarn.ToolTipTitle = "Caution";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // blendFileLabel
            // 
            this.blendFileLabel.AutoSize = true;
            this.blendFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.blendFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.blendFileLabel.Location = new System.Drawing.Point(20, 41);
            this.blendFileLabel.Name = "blendFileLabel";
            this.blendFileLabel.Size = new System.Drawing.Size(102, 20);
            this.blendFileLabel.TabIndex = 25;
            this.blendFileLabel.Text = "1. Blend File";
            // 
            // chunkLengthLabel
            // 
            this.chunkLengthLabel.AutoSize = true;
            this.chunkLengthLabel.Location = new System.Drawing.Point(249, 222);
            this.chunkLengthLabel.Name = "chunkLengthLabel";
            this.chunkLengthLabel.Size = new System.Drawing.Size(64, 13);
            this.chunkLengthLabel.TabIndex = 13;
            this.chunkLengthLabel.Text = "Chunk Size:";
            // 
            // chunkStartLabel
            // 
            this.chunkStartLabel.AutoSize = true;
            this.chunkStartLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chunkStartLabel.Location = new System.Drawing.Point(130, 27);
            this.chunkStartLabel.Name = "chunkStartLabel";
            this.chunkStartLabel.Size = new System.Drawing.Size(61, 13);
            this.chunkStartLabel.TabIndex = 30;
            this.chunkStartLabel.Text = "Start Frame";
            // 
            // chunkLengthNumericUpDown
            // 
            this.chunkLengthNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chunkLengthNumericUpDown.Location = new System.Drawing.Point(252, 238);
            this.chunkLengthNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.chunkLengthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chunkLengthNumericUpDown.Name = "chunkLengthNumericUpDown";
            this.chunkLengthNumericUpDown.Size = new System.Drawing.Size(86, 22);
            this.chunkLengthNumericUpDown.TabIndex = 4;
            this.chunkLengthNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.chunkLengthNumericUpDown.ValueChanged += new System.EventHandler(this.chunkLengthNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(20, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "4. Output Folder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(20, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "2. Start - End && Chunk Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(20, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "5. Render";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(382, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "3. Render Settings";
            // 
            // chunkStartNumericUpDown
            // 
            this.chunkStartNumericUpDown.Cursor = System.Windows.Forms.Cursors.No;
            this.chunkStartNumericUpDown.Location = new System.Drawing.Point(133, 43);
            this.chunkStartNumericUpDown.Name = "chunkStartNumericUpDown";
            this.chunkStartNumericUpDown.ReadOnly = true;
            this.chunkStartNumericUpDown.Size = new System.Drawing.Size(117, 20);
            this.chunkStartNumericUpDown.TabIndex = 30;
            this.chunkStartNumericUpDown.TabStop = false;
            this.chunkStartNumericUpDown.Text = "...";
            this.chunkStartNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chunkEndNumericUpDown
            // 
            this.chunkEndNumericUpDown.Cursor = System.Windows.Forms.Cursors.No;
            this.chunkEndNumericUpDown.Location = new System.Drawing.Point(133, 87);
            this.chunkEndNumericUpDown.Name = "chunkEndNumericUpDown";
            this.chunkEndNumericUpDown.ReadOnly = true;
            this.chunkEndNumericUpDown.Size = new System.Drawing.Size(117, 20);
            this.chunkEndNumericUpDown.TabIndex = 30;
            this.chunkEndNumericUpDown.TabStop = false;
            this.chunkEndNumericUpDown.Text = "...";
            this.chunkEndNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(20, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "6. Join";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(19, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Current Chunk";
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsedLabel.Location = new System.Drawing.Point(470, 670);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(96, 16);
            this.timeElapsedLabel.TabIndex = 19;
            this.timeElapsedLabel.Text = "Time Elapsed:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.renderChunkButton);
            this.panel1.Controls.Add(this.chunkEndNumericUpDown);
            this.panel1.Controls.Add(this.prevChunkButton);
            this.panel1.Controls.Add(this.chunkStartNumericUpDown);
            this.panel1.Controls.Add(this.nextChunkButton);
            this.panel1.Controls.Add(this.chunkStartLabel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.chunkEndLabel);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(376, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 122);
            this.panel1.TabIndex = 31;
            // 
            // jendabekToolStripMenuItem
            // 
            this.jendabekToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.jendabekToolStripMenuItem.Name = "jendabekToolStripMenuItem";
            this.jendabekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jendabekToolStripMenuItem.Text = "jendabek";
            this.jendabekToolStripMenuItem.Click += new System.EventHandler(this.jendabekToolStripMenuItem_Click);
            // 
            // openOutputFolderButton
            // 
            this.openOutputFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openOutputFolderButton.Location = new System.Drawing.Point(490, 322);
            this.openOutputFolderButton.Name = "openOutputFolderButton";
            this.openOutputFolderButton.Size = new System.Drawing.Size(105, 31);
            this.openOutputFolderButton.TabIndex = 10;
            this.openOutputFolderButton.Text = "Open";
            this.openOutputFolderButton.UseVisualStyleBackColor = true;
            this.openOutputFolderButton.Click += new System.EventHandler(this.openOutputFolderButton_Click);
            // 
            // blendFileNameLabel
            // 
            this.blendFileNameLabel.AutoSize = true;
            this.blendFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.blendFileNameLabel.ForeColor = System.Drawing.Color.Black;
            this.blendFileNameLabel.Location = new System.Drawing.Point(124, 41);
            this.blendFileNameLabel.Name = "blendFileNameLabel";
            this.blendFileNameLabel.Size = new System.Drawing.Size(0, 20);
            this.blendFileNameLabel.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(662, 698);
            this.Controls.Add(this.blendFileNameLabel);
            this.Controls.Add(this.blendFileLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.timeElapsedLabel);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.reloadBlenderDataButton);
            this.Controls.Add(this.mixDownButton);
            this.Controls.Add(this.openOutputFolderButton);
            this.Controls.Add(this.concatenatePartsButton);
            this.Controls.Add(this.processCountLabel);
            this.Controls.Add(this.processCountNumericUpDown);
            this.Controls.Add(this.chunkLengthLabel);
            this.Controls.Add(this.totalFrameCountLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.rendererComboBox);
            this.Controls.Add(this.chunkLengthNumericUpDown);
            this.Controls.Add(this.startFrameLabel);
            this.Controls.Add(this.totalEndNumericUpDown);
            this.Controls.Add(this.partsFolderPathTextBox);
            this.Controls.Add(this.totalStartNumericUpDown);
            this.Controls.Add(this.partsFolderBrowseButton);
            this.Controls.Add(this.renderProgressBar);
            this.Controls.Add(this.blendFileBrowseButton);
            this.Controls.Add(this.renderAllButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(678, 768);
            this.Name = "MainForm";
            this.Text = "Blender Render Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Close);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalStartNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEndNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chunkLengthNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button renderChunkButton;
        private System.Windows.Forms.Button blendFileBrowseButton;
        private System.Windows.Forms.ProgressBar renderProgressBar;
        private System.Windows.Forms.NumericUpDown totalStartNumericUpDown;
        private System.Windows.Forms.Label startFrameLabel;
        private System.Windows.Forms.Label chunkEndLabel;
        private System.Windows.Forms.Button partsFolderBrowseButton;
        private System.Windows.Forms.TextBox partsFolderPathTextBox;
        private System.Windows.Forms.ComboBox rendererComboBox;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button nextChunkButton;
        private System.Windows.Forms.Button prevChunkButton;
        private System.Windows.Forms.Label totalFrameCountLabel;
        private System.Windows.Forms.NumericUpDown totalEndNumericUpDown;
        private System.Windows.Forms.NumericUpDown processCountNumericUpDown;
        private System.Windows.Forms.Label processCountLabel;
        private System.Windows.Forms.Button renderAllButton;
        private System.Windows.Forms.Button concatenatePartsButton;
		private System.Windows.Forms.Button reloadBlenderDataButton;
		private System.Windows.Forms.Button mixDownButton;
		private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox infoNoScenes;
        private System.Windows.Forms.TextBox infoActiveScene;
        private System.Windows.Forms.ToolTip activeWarn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem tipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator speToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
        private System.Windows.Forms.Label blendFileLabel;
        private System.Windows.Forms.ToolStripMenuItem autocombineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugShow;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMDArgsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitGithubPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isti115ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meTwentyFiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redRaptor93ToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown chunkLengthNumericUpDown;
        private System.Windows.Forms.Label chunkLengthLabel;
        private System.Windows.Forms.TextBox infoFramerate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label chunkStartLabel;
        private System.Windows.Forms.TextBox infoDuration;
        private System.Windows.Forms.TextBox infoFramesTotal;
        private System.Windows.Forms.Label infoFramesTotalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label infoDurationLabel;
        private System.Windows.Forms.TextBox chunkStartNumericUpDown;
        private System.Windows.Forms.TextBox chunkEndNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem jendabekToolStripMenuItem;
        private System.Windows.Forms.Button openOutputFolderButton;
        private System.Windows.Forms.Label blendFileNameLabel;
    }
}

