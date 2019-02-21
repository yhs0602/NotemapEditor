namespace NotemapEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddBlock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSongName = new System.Windows.Forms.TextBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCreator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonApex = new System.Windows.Forms.RadioButton();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxLines = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonEditView = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonFlickDown = new System.Windows.Forms.Button();
            this.buttonFlickUp = new System.Windows.Forms.Button();
            this.buttonFlickRight = new System.Windows.Forms.Button();
            this.buttonFlickLeft = new System.Windows.Forms.Button();
            this.buttonNormalNote2 = new System.Windows.Forms.Button();
            this.buttonSlideNote = new System.Windows.Forms.Button();
            this.buttonHoldNote = new System.Windows.Forms.Button();
            this.buttonNormalNote = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.groupBoxDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            this.groupBoxLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.newProjectToolStripMenuItem.Text = "New Project (&N)";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.openToolStripMenuItem.Text = "Open (&O)";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.saveToolStripMenuItem.Text = "Save (&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(286, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // buttonAddBlock
            // 
            this.buttonAddBlock.Location = new System.Drawing.Point(0, 31);
            this.buttonAddBlock.Name = "buttonAddBlock";
            this.buttonAddBlock.Size = new System.Drawing.Size(110, 40);
            this.buttonAddBlock.TabIndex = 2;
            this.buttonAddBlock.Text = "Add Block";
            this.buttonAddBlock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(2, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notes";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Normal Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(925, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Song name";
            // 
            // textBoxSongName
            // 
            this.textBoxSongName.Location = new System.Drawing.Point(956, 60);
            this.textBoxSongName.Name = "textBoxSongName";
            this.textBoxSongName.Size = new System.Drawing.Size(243, 25);
            this.textBoxSongName.TabIndex = 15;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(956, 123);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(243, 25);
            this.textBoxArtist.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(925, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Artist";
            // 
            // textBoxCreator
            // 
            this.textBoxCreator.Location = new System.Drawing.Point(956, 197);
            this.textBoxCreator.Name = "textBoxCreator";
            this.textBoxCreator.Size = new System.Drawing.Size(243, 25);
            this.textBoxCreator.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(925, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Creator";
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.Controls.Add(this.radioButtonApex);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonHard);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonNormal);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonEasy);
            this.groupBoxDifficulty.Location = new System.Drawing.Point(928, 242);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(297, 58);
            this.groupBoxDifficulty.TabIndex = 21;
            this.groupBoxDifficulty.TabStop = false;
            this.groupBoxDifficulty.Text = "Difficulty";
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Location = new System.Drawing.Point(6, 24);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(61, 19);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(73, 24);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(72, 19);
            this.radioButtonNormal.TabIndex = 1;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(151, 24);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(58, 19);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonApex
            // 
            this.radioButtonApex.AutoSize = true;
            this.radioButtonApex.Location = new System.Drawing.Point(213, 24);
            this.radioButtonApex.Name = "radioButtonApex";
            this.radioButtonApex.Size = new System.Drawing.Size(62, 19);
            this.radioButtonApex.TabIndex = 22;
            this.radioButtonApex.TabStop = true;
            this.radioButtonApex.Text = "Apex";
            this.radioButtonApex.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Location = new System.Drawing.Point(1001, 315);
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(198, 25);
            this.numericUpDownLevel.TabIndex = 22;
            this.numericUpDownLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownLevel.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(936, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Level";
            // 
            // groupBoxLines
            // 
            this.groupBoxLines.Controls.Add(this.radioButton6);
            this.groupBoxLines.Controls.Add(this.radioButton5);
            this.groupBoxLines.Controls.Add(this.radioButton4);
            this.groupBoxLines.Controls.Add(this.radioButton3);
            this.groupBoxLines.Controls.Add(this.radioButton2);
            this.groupBoxLines.Controls.Add(this.radioButton1);
            this.groupBoxLines.Location = new System.Drawing.Point(934, 356);
            this.groupBoxLines.Name = "groupBoxLines";
            this.groupBoxLines.Size = new System.Drawing.Size(268, 61);
            this.groupBoxLines.TabIndex = 24;
            this.groupBoxLines.TabStop = false;
            this.groupBoxLines.Text = "Lines";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(48, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(90, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(36, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(132, 24);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(167, 24);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(36, 19);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(207, 24);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(36, 19);
            this.radioButton6.TabIndex = 25;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(936, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Offset";
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.Location = new System.Drawing.Point(996, 426);
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(180, 25);
            this.numericUpDownOffset.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(1185, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(931, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Music File";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(940, 493);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(220, 25);
            this.textBoxFilePath.TabIndex = 29;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(1166, 495);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(73, 22);
            this.buttonBrowse.TabIndex = 30;
            this.buttonBrowse.Text = "Browse..";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonEditView
            // 
            this.buttonEditView.BackgroundImage = global::NotemapEditor.Properties.Resources.Edit;
            this.buttonEditView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditView.Location = new System.Drawing.Point(1108, 553);
            this.buttonEditView.Name = "buttonEditView";
            this.buttonEditView.Size = new System.Drawing.Size(58, 58);
            this.buttonEditView.TabIndex = 33;
            this.buttonEditView.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::NotemapEditor.Properties.Resources.stop;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.Location = new System.Drawing.Point(1024, 549);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(63, 65);
            this.buttonStop.TabIndex = 32;
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::NotemapEditor.Properties.Resources.play;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Location = new System.Drawing.Point(943, 549);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(63, 65);
            this.buttonPlay.TabIndex = 31;
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox.Location = new System.Drawing.Point(220, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(704, 654);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // buttonErase
            // 
            this.buttonErase.BackgroundImage = global::NotemapEditor.Properties.Resources.damage_white;
            this.buttonErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonErase.Location = new System.Drawing.Point(132, 123);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(47, 52);
            this.buttonErase.TabIndex = 12;
            this.buttonErase.UseVisualStyleBackColor = true;
            // 
            // buttonFlickDown
            // 
            this.buttonFlickDown.BackgroundImage = global::NotemapEditor.Properties.Resources.slide_note_down;
            this.buttonFlickDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFlickDown.Location = new System.Drawing.Point(176, 181);
            this.buttonFlickDown.Name = "buttonFlickDown";
            this.buttonFlickDown.Size = new System.Drawing.Size(47, 52);
            this.buttonFlickDown.TabIndex = 11;
            this.buttonFlickDown.UseVisualStyleBackColor = true;
            // 
            // buttonFlickUp
            // 
            this.buttonFlickUp.BackgroundImage = global::NotemapEditor.Properties.Resources.slide_note_up;
            this.buttonFlickUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFlickUp.Location = new System.Drawing.Point(132, 181);
            this.buttonFlickUp.Name = "buttonFlickUp";
            this.buttonFlickUp.Size = new System.Drawing.Size(47, 52);
            this.buttonFlickUp.TabIndex = 10;
            this.buttonFlickUp.UseVisualStyleBackColor = true;
            // 
            // buttonFlickRight
            // 
            this.buttonFlickRight.BackgroundImage = global::NotemapEditor.Properties.Resources.slide_note_right;
            this.buttonFlickRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFlickRight.Location = new System.Drawing.Point(88, 181);
            this.buttonFlickRight.Name = "buttonFlickRight";
            this.buttonFlickRight.Size = new System.Drawing.Size(47, 52);
            this.buttonFlickRight.TabIndex = 9;
            this.buttonFlickRight.UseVisualStyleBackColor = true;
            // 
            // buttonFlickLeft
            // 
            this.buttonFlickLeft.BackgroundImage = global::NotemapEditor.Properties.Resources.slide_note_left;
            this.buttonFlickLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFlickLeft.Location = new System.Drawing.Point(44, 181);
            this.buttonFlickLeft.Name = "buttonFlickLeft";
            this.buttonFlickLeft.Size = new System.Drawing.Size(47, 52);
            this.buttonFlickLeft.TabIndex = 8;
            this.buttonFlickLeft.UseVisualStyleBackColor = true;
            // 
            // buttonNormalNote2
            // 
            this.buttonNormalNote2.BackgroundImage = global::NotemapEditor.Properties.Resources.long_note_white;
            this.buttonNormalNote2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNormalNote2.Location = new System.Drawing.Point(0, 181);
            this.buttonNormalNote2.Name = "buttonNormalNote2";
            this.buttonNormalNote2.Size = new System.Drawing.Size(47, 52);
            this.buttonNormalNote2.TabIndex = 7;
            this.buttonNormalNote2.UseVisualStyleBackColor = true;
            // 
            // buttonSlideNote
            // 
            this.buttonSlideNote.BackgroundImage = global::NotemapEditor.Properties.Resources.trueslide_main;
            this.buttonSlideNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSlideNote.Location = new System.Drawing.Point(88, 123);
            this.buttonSlideNote.Name = "buttonSlideNote";
            this.buttonSlideNote.Size = new System.Drawing.Size(47, 52);
            this.buttonSlideNote.TabIndex = 6;
            this.buttonSlideNote.UseVisualStyleBackColor = true;
            // 
            // buttonHoldNote
            // 
            this.buttonHoldNote.BackgroundImage = global::NotemapEditor.Properties.Resources.long_note_press;
            this.buttonHoldNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHoldNote.Location = new System.Drawing.Point(44, 123);
            this.buttonHoldNote.Name = "buttonHoldNote";
            this.buttonHoldNote.Size = new System.Drawing.Size(47, 52);
            this.buttonHoldNote.TabIndex = 5;
            this.buttonHoldNote.UseVisualStyleBackColor = true;
            // 
            // buttonNormalNote
            // 
            this.buttonNormalNote.BackgroundImage = global::NotemapEditor.Properties.Resources.long_note_white;
            this.buttonNormalNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNormalNote.Location = new System.Drawing.Point(0, 123);
            this.buttonNormalNote.Name = "buttonNormalNote";
            this.buttonNormalNote.Size = new System.Drawing.Size(47, 52);
            this.buttonNormalNote.TabIndex = 3;
            this.buttonNormalNote.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 692);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1251, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 714);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonEditView);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownOffset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxLines);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownLevel);
            this.Controls.Add(this.groupBoxDifficulty);
            this.Controls.Add(this.textBoxCreator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSongName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonFlickDown);
            this.Controls.Add(this.buttonFlickUp);
            this.Controls.Add(this.buttonFlickRight);
            this.Controls.Add(this.buttonFlickLeft);
            this.Controls.Add(this.buttonNormalNote2);
            this.Controls.Add(this.buttonSlideNote);
            this.Controls.Add(this.buttonHoldNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNormalNote);
            this.Controls.Add(this.buttonAddBlock);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NotemapEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            this.groupBoxLines.ResumeLayout(false);
            this.groupBoxLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddBlock;
        private System.Windows.Forms.Button buttonNormalNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHoldNote;
        private System.Windows.Forms.Button buttonSlideNote;
        private System.Windows.Forms.Button buttonFlickRight;
        private System.Windows.Forms.Button buttonFlickLeft;
        private System.Windows.Forms.Button buttonNormalNote2;
        private System.Windows.Forms.Button buttonFlickDown;
        private System.Windows.Forms.Button buttonFlickUp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSongName;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCreator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxDifficulty;
        private System.Windows.Forms.RadioButton radioButtonApex;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxLines;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownOffset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonEditView;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}