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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.radioButtonApex = new System.Windows.Forms.RadioButton();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxLines = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.buttonRemoveBlock = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
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
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            resources.ApplyResources(this.newProjectToolStripMenuItem, "newProjectToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            // 
            // buttonAddBlock
            // 
            resources.ApplyResources(this.buttonAddBlock, "buttonAddBlock");
            this.buttonAddBlock.Name = "buttonAddBlock";
            this.buttonAddBlock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Normal Note";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxSongName
            // 
            resources.ApplyResources(this.textBoxSongName, "textBoxSongName");
            this.textBoxSongName.Name = "textBoxSongName";
            // 
            // textBoxArtist
            // 
            resources.ApplyResources(this.textBoxArtist, "textBoxArtist");
            this.textBoxArtist.Name = "textBoxArtist";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxCreator
            // 
            resources.ApplyResources(this.textBoxCreator, "textBoxCreator");
            this.textBoxCreator.Name = "textBoxCreator";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // groupBoxDifficulty
            // 
            resources.ApplyResources(this.groupBoxDifficulty, "groupBoxDifficulty");
            this.groupBoxDifficulty.Controls.Add(this.radioButtonApex);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonHard);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonNormal);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonEasy);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.TabStop = false;
            // 
            // radioButtonApex
            // 
            resources.ApplyResources(this.radioButtonApex, "radioButtonApex");
            this.radioButtonApex.Name = "radioButtonApex";
            this.radioButtonApex.TabStop = true;
            this.radioButtonApex.UseVisualStyleBackColor = true;
            // 
            // radioButtonHard
            // 
            resources.ApplyResources(this.radioButtonHard, "radioButtonHard");
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            resources.ApplyResources(this.radioButtonNormal, "radioButtonNormal");
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            resources.ApplyResources(this.radioButtonEasy, "radioButtonEasy");
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLevel
            // 
            resources.ApplyResources(this.numericUpDownLevel, "numericUpDownLevel");
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBoxLines
            // 
            resources.ApplyResources(this.groupBoxLines, "groupBoxLines");
            this.groupBoxLines.Controls.Add(this.radioButton6);
            this.groupBoxLines.Controls.Add(this.radioButton5);
            this.groupBoxLines.Controls.Add(this.radioButton4);
            this.groupBoxLines.Controls.Add(this.radioButton3);
            this.groupBoxLines.Controls.Add(this.radioButton2);
            this.groupBoxLines.Controls.Add(this.radioButton1);
            this.groupBoxLines.Name = "groupBoxLines";
            this.groupBoxLines.TabStop = false;
            // 
            // radioButton6
            // 
            resources.ApplyResources(this.radioButton6, "radioButton6");
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            resources.ApplyResources(this.radioButton5, "radioButton5");
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // numericUpDownOffset
            // 
            resources.ApplyResources(this.numericUpDownOffset, "numericUpDownOffset");
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBoxFilePath
            // 
            resources.ApplyResources(this.textBoxFilePath, "textBoxFilePath");
            this.textBoxFilePath.Name = "textBoxFilePath";
            // 
            // buttonBrowse
            // 
            resources.ApplyResources(this.buttonBrowse, "buttonBrowse");
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonEditView
            // 
            resources.ApplyResources(this.buttonEditView, "buttonEditView");
            this.buttonEditView.BackgroundImage = global::NotemapEditor.Properties.Resources.Edit;
            this.buttonEditView.Name = "buttonEditView";
            this.buttonEditView.UseVisualStyleBackColor = true;
            this.buttonEditView.Click += new System.EventHandler(this.buttonEditView_Click);
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.BackgroundImage = global::NotemapEditor.Properties.Resources.stop;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            resources.ApplyResources(this.buttonPlay, "buttonPlay");
            this.buttonPlay.BackgroundImage = global::NotemapEditor.Properties.Resources.play;
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // buttonErase
            // 
            this.buttonErase.BackgroundImage = global::NotemapEditor.Properties.Resources.damage_white;
            resources.ApplyResources(this.buttonErase, "buttonErase");
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.UseVisualStyleBackColor = true;
            // 
            // buttonFlickDown
            // 
            this.buttonFlickDown.BackgroundImage = global::NotemapEditor.Properties.Resources.slide_note_down;
            resources.ApplyResources(this.buttonFlickDown, "buttonFlickDown");
            this.buttonFlickDown.Name = "buttonFlickDown";
            this.buttonFlickDown.UseVisualStyleBackColor = true;
            // 
            // buttonFlickUp
            // 
            this.buttonFlickUp.BackgroundImage = global::NotemapEditor.Properties.Resources.slide_note_up;
            resources.ApplyResources(this.buttonFlickUp, "buttonFlickUp");
            this.buttonFlickUp.Name = "buttonFlickUp";
            this.buttonFlickUp.UseVisualStyleBackColor = true;
            // 
            // buttonFlickRight
            // 
            this.buttonFlickRight.BackgroundImage = global::NotemapEditor.Properties.Resources.slide_note_right;
            resources.ApplyResources(this.buttonFlickRight, "buttonFlickRight");
            this.buttonFlickRight.Name = "buttonFlickRight";
            this.buttonFlickRight.UseVisualStyleBackColor = true;
            // 
            // buttonFlickLeft
            // 
            this.buttonFlickLeft.BackgroundImage = global::NotemapEditor.Properties.Resources.slide_note_left;
            resources.ApplyResources(this.buttonFlickLeft, "buttonFlickLeft");
            this.buttonFlickLeft.Name = "buttonFlickLeft";
            this.buttonFlickLeft.UseVisualStyleBackColor = true;
            // 
            // buttonNormalNote2
            // 
            this.buttonNormalNote2.BackgroundImage = global::NotemapEditor.Properties.Resources.long_note_white;
            resources.ApplyResources(this.buttonNormalNote2, "buttonNormalNote2");
            this.buttonNormalNote2.Name = "buttonNormalNote2";
            this.buttonNormalNote2.UseVisualStyleBackColor = true;
            // 
            // buttonSlideNote
            // 
            this.buttonSlideNote.BackgroundImage = global::NotemapEditor.Properties.Resources.trueslide_main;
            resources.ApplyResources(this.buttonSlideNote, "buttonSlideNote");
            this.buttonSlideNote.Name = "buttonSlideNote";
            this.buttonSlideNote.UseVisualStyleBackColor = true;
            // 
            // buttonHoldNote
            // 
            this.buttonHoldNote.BackgroundImage = global::NotemapEditor.Properties.Resources.long_note_press;
            resources.ApplyResources(this.buttonHoldNote, "buttonHoldNote");
            this.buttonHoldNote.Name = "buttonHoldNote";
            this.buttonHoldNote.UseVisualStyleBackColor = true;
            // 
            // buttonNormalNote
            // 
            this.buttonNormalNote.BackgroundImage = global::NotemapEditor.Properties.Resources.long_note_white;
            resources.ApplyResources(this.buttonNormalNote, "buttonNormalNote");
            this.buttonNormalNote.Name = "buttonNormalNote";
            this.buttonNormalNote.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // buttonRemoveBlock
            // 
            resources.ApplyResources(this.buttonRemoveBlock, "buttonRemoveBlock");
            this.buttonRemoveBlock.Name = "buttonRemoveBlock";
            this.buttonRemoveBlock.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemoveBlock);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
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
        private System.Windows.Forms.Button buttonRemoveBlock;
    }
}