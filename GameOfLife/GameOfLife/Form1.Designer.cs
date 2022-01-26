
namespace GameOfLife
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toroidalCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finiteCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNeighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNeighborhoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUniverseSizeTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nextStepToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusInterval = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLivingCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleNeighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleNeighborhoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleHUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel1 = new GameOfLife.GraphicsPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.randomizeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(190, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.saveToolStripMenuItem.Text = "&Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countOptionsToolStripMenuItem,
            this.ShowHUDToolStripMenuItem,
            this.showGridToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.optionsToolStripMenuItem.Text = "&View ";
            // 
            // countOptionsToolStripMenuItem
            // 
            this.countOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toroidalCountToolStripMenuItem,
            this.finiteCountToolStripMenuItem,
            this.showNeighborCountToolStripMenuItem,
            this.showNeighborhoodToolStripMenuItem});
            this.countOptionsToolStripMenuItem.Name = "countOptionsToolStripMenuItem";
            this.countOptionsToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.countOptionsToolStripMenuItem.Text = "Count Options";
            // 
            // toroidalCountToolStripMenuItem
            // 
            this.toroidalCountToolStripMenuItem.Checked = true;
            this.toroidalCountToolStripMenuItem.CheckOnClick = true;
            this.toroidalCountToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toroidalCountToolStripMenuItem.Name = "toroidalCountToolStripMenuItem";
            this.toroidalCountToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.toroidalCountToolStripMenuItem.Text = "Toroidal Count";
            this.toroidalCountToolStripMenuItem.Click += new System.EventHandler(this.toroidalCountToolStripMenuItem_Click);
            // 
            // finiteCountToolStripMenuItem
            // 
            this.finiteCountToolStripMenuItem.CheckOnClick = true;
            this.finiteCountToolStripMenuItem.Name = "finiteCountToolStripMenuItem";
            this.finiteCountToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.finiteCountToolStripMenuItem.Text = "Finite Count";
            this.finiteCountToolStripMenuItem.Click += new System.EventHandler(this.finiteCountToolStripMenuItem_Click);
            // 
            // showNeighborCountToolStripMenuItem
            // 
            this.showNeighborCountToolStripMenuItem.Checked = true;
            this.showNeighborCountToolStripMenuItem.CheckOnClick = true;
            this.showNeighborCountToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showNeighborCountToolStripMenuItem.Name = "showNeighborCountToolStripMenuItem";
            this.showNeighborCountToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.showNeighborCountToolStripMenuItem.Text = "Toggle Neighbor Count";
            this.showNeighborCountToolStripMenuItem.Click += new System.EventHandler(this.showNeighborCountToolStripMenuItem_Click);
            // 
            // showNeighborhoodToolStripMenuItem
            // 
            this.showNeighborhoodToolStripMenuItem.Checked = true;
            this.showNeighborhoodToolStripMenuItem.CheckOnClick = true;
            this.showNeighborhoodToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showNeighborhoodToolStripMenuItem.Name = "showNeighborhoodToolStripMenuItem";
            this.showNeighborhoodToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.showNeighborhoodToolStripMenuItem.Text = "Toggle Neighborhood";
            this.showNeighborhoodToolStripMenuItem.Click += new System.EventHandler(this.showNeighborhoodToolStripMenuItem_Click);
            // 
            // ShowHUDToolStripMenuItem
            // 
            this.ShowHUDToolStripMenuItem.Checked = true;
            this.ShowHUDToolStripMenuItem.CheckOnClick = true;
            this.ShowHUDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowHUDToolStripMenuItem.Name = "ShowHUDToolStripMenuItem";
            this.ShowHUDToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.ShowHUDToolStripMenuItem.Text = "Show HUD";
            this.ShowHUDToolStripMenuItem.Click += new System.EventHandler(this.ShowHUDToolStripMenuItem_Click);
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.Checked = true;
            this.showGridToolStripMenuItem.CheckOnClick = true;
            this.showGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.showGridToolStripMenuItem.Text = "Show Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromSeedToolStripMenuItem,
            this.fromTimeToolStripMenuItem});
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            // 
            // fromSeedToolStripMenuItem
            // 
            this.fromSeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomSeedToolStripMenuItem,
            this.enterSeedToolStripMenuItem});
            this.fromSeedToolStripMenuItem.Name = "fromSeedToolStripMenuItem";
            this.fromSeedToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.fromSeedToolStripMenuItem.Text = "From Seed";
            // 
            // randomSeedToolStripMenuItem
            // 
            this.randomSeedToolStripMenuItem.Name = "randomSeedToolStripMenuItem";
            this.randomSeedToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.randomSeedToolStripMenuItem.Text = "Random Seed";
            this.randomSeedToolStripMenuItem.Click += new System.EventHandler(this.randomSeedToolStripMenuItem_Click);
            // 
            // enterSeedToolStripMenuItem
            // 
            this.enterSeedToolStripMenuItem.Name = "enterSeedToolStripMenuItem";
            this.enterSeedToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.enterSeedToolStripMenuItem.Text = "Enter Seed";
            this.enterSeedToolStripMenuItem.Click += new System.EventHandler(this.enterSeedToolStripMenuItem_Click);
            // 
            // fromTimeToolStripMenuItem
            // 
            this.fromTimeToolStripMenuItem.Name = "fromTimeToolStripMenuItem";
            this.fromTimeToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.fromTimeToolStripMenuItem.Text = "From Time";
            this.fromTimeToolStripMenuItem.Click += new System.EventHandler(this.fromTimeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUniverseSizeTimerToolStripMenuItem,
            this.editBackgroundColorToolStripMenuItem,
            this.editCellColorToolStripMenuItem,
            this.editGridColorToolStripMenuItem,
            this.reloadSettingsToolStripMenuItem,
            this.resetSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // editUniverseSizeTimerToolStripMenuItem
            // 
            this.editUniverseSizeTimerToolStripMenuItem.Name = "editUniverseSizeTimerToolStripMenuItem";
            this.editUniverseSizeTimerToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.editUniverseSizeTimerToolStripMenuItem.Text = "Edit Universe Size/Timer";
            this.editUniverseSizeTimerToolStripMenuItem.Click += new System.EventHandler(this.editUniverseSizeTimerToolStripMenuItem_Click);
            // 
            // editBackgroundColorToolStripMenuItem
            // 
            this.editBackgroundColorToolStripMenuItem.Name = "editBackgroundColorToolStripMenuItem";
            this.editBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.editBackgroundColorToolStripMenuItem.Text = "Edit Background Color";
            this.editBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.editBackgroundColorToolStripMenuItem_Click);
            // 
            // editCellColorToolStripMenuItem
            // 
            this.editCellColorToolStripMenuItem.Name = "editCellColorToolStripMenuItem";
            this.editCellColorToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.editCellColorToolStripMenuItem.Text = "Edit Cell Color";
            // 
            // editGridColorToolStripMenuItem
            // 
            this.editGridColorToolStripMenuItem.Name = "editGridColorToolStripMenuItem";
            this.editGridColorToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.editGridColorToolStripMenuItem.Text = "Edit Grid Color";
            this.editGridColorToolStripMenuItem.Click += new System.EventHandler(this.editGridColorToolStripMenuItem_Click);
            // 
            // reloadSettingsToolStripMenuItem
            // 
            this.reloadSettingsToolStripMenuItem.Name = "reloadSettingsToolStripMenuItem";
            this.reloadSettingsToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.reloadSettingsToolStripMenuItem.Text = "Reload Settings";
            this.reloadSettingsToolStripMenuItem.Click += new System.EventHandler(this.reloadSettingsToolStripMenuItem_Click);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.resetSettingsToolStripMenuItem.Text = "Reset Settings to Default";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.playToolStripButton,
            this.pauseToolStripButton,
            this.nextStepToolStripButton,
            this.toolStripSeparator7,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1133, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // playToolStripButton
            // 
            this.playToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playToolStripButton.Image = global::GameOfLife.Properties.Resources.Run_16x;
            this.playToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playToolStripButton.Name = "playToolStripButton";
            this.playToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.playToolStripButton.Text = "0";
            this.playToolStripButton.Click += new System.EventHandler(this.playToolStripButton_Click);
            // 
            // pauseToolStripButton
            // 
            this.pauseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseToolStripButton.Image = global::GameOfLife.Properties.Resources.Pause_grey_16x;
            this.pauseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseToolStripButton.Name = "pauseToolStripButton";
            this.pauseToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.pauseToolStripButton.Text = "&Pause";
            this.pauseToolStripButton.Click += new System.EventHandler(this.pauseToolStripButton_Click);
            // 
            // nextStepToolStripButton
            // 
            this.nextStepToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextStepToolStripButton.Image = global::GameOfLife.Properties.Resources.PlayStep_16x;
            this.nextStepToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextStepToolStripButton.Name = "nextStepToolStripButton";
            this.nextStepToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.nextStepToolStripButton.Text = "&NextStep";
            this.nextStepToolStripButton.Click += new System.EventHandler(this.nextStepToolStripButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusInterval,
            this.toolStripStatusLabelLivingCells});
            this.statusStrip1.Location = new System.Drawing.Point(0, 812);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1133, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // toolStripStatusInterval
            // 
            this.toolStripStatusInterval.Name = "toolStripStatusInterval";
            this.toolStripStatusInterval.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabelLivingCells
            // 
            this.toolStripStatusLabelLivingCells.Name = "toolStripStatusLabelLivingCells";
            this.toolStripStatusLabelLivingCells.Size = new System.Drawing.Size(109, 20);
            this.toolStripStatusLabelLivingCells.Text = "Living Cells = 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleNeighborhoodToolStripMenuItem,
            this.toggleNeighborCountToolStripMenuItem,
            this.toggleGridToolStripMenuItem,
            this.toggleHUDToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.playToolStripMenuItem,
            this.nextStepToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 172);
            // 
            // toggleNeighborCountToolStripMenuItem
            // 
            this.toggleNeighborCountToolStripMenuItem.CheckOnClick = true;
            this.toggleNeighborCountToolStripMenuItem.Name = "toggleNeighborCountToolStripMenuItem";
            this.toggleNeighborCountToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.toggleNeighborCountToolStripMenuItem.Text = "Toggle Neighbor Count";
            this.toggleNeighborCountToolStripMenuItem.Click += new System.EventHandler(this.showNeighborCountToolStripMenuItem_Click);
            // 
            // toggleGridToolStripMenuItem
            // 
            this.toggleGridToolStripMenuItem.Name = "toggleGridToolStripMenuItem";
            this.toggleGridToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.toggleGridToolStripMenuItem.Text = "Toggle Grid";
            this.toggleGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // toggleNeighborhoodToolStripMenuItem
            // 
            this.toggleNeighborhoodToolStripMenuItem.Name = "toggleNeighborhoodToolStripMenuItem";
            this.toggleNeighborhoodToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.toggleNeighborhoodToolStripMenuItem.Text = "Toggle Neighborhood";
            this.toggleNeighborhoodToolStripMenuItem.Click += new System.EventHandler(this.showNeighborhoodToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripButton_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripButton_Click);
            // 
            // nextStepToolStripMenuItem
            // 
            this.nextStepToolStripMenuItem.Name = "nextStepToolStripMenuItem";
            this.nextStepToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.nextStepToolStripMenuItem.Text = "Next Step";
            this.nextStepToolStripMenuItem.Click += new System.EventHandler(this.nextStepToolStripButton_Click);
            // 
            // toggleHUDToolStripMenuItem
            // 
            this.toggleHUDToolStripMenuItem.Name = "toggleHUDToolStripMenuItem";
            this.toggleHUDToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.toggleHUDToolStripMenuItem.Text = "Toggle HUD";
            this.toggleHUDToolStripMenuItem.Click += new System.EventHandler(this.ShowHUDToolStripMenuItem_Click);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 55);
            this.graphicsPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(1133, 757);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 838);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Game Of Life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton playToolStripButton;
        private System.Windows.Forms.ToolStripButton pauseToolStripButton;
        private System.Windows.Forms.ToolStripButton nextStepToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripMenuItem toroidalCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finiteCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNeighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNeighborhoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowHUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUniverseSizeTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusInterval;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLivingCells;
        private System.Windows.Forms.ToolStripMenuItem editBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGridColorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toggleNeighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleNeighborhoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextStepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleHUDToolStripMenuItem;
    }
}

