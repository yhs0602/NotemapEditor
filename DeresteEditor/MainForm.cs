using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace NotemapEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //projectFile = new ProjectFile("", "No title", "artist", "deleste", "tag");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string artist = textBoxArtist.Text;
            string name = textBoxSongName.Text;
            string creator = textBoxCreator.Text;
            string difficulty = "easy";
            int lines = 1;
            int level = 20;
            int offset = 0;
            if (radioButtonEasy.Checked)
            {
                difficulty = "easy";
            }
            else if (radioButtonNormal.Checked)
            {
                difficulty = "normal";
            }
            else if (radioButtonHard.Checked)
            {
                difficulty = "hard";
            }
            else if (radioButtonApex.Checked)
            {
                difficulty = "apex";
            }
            if (radioButton1.Checked)
            {
                lines = 1;
            }
            else if (radioButton2.Checked)
            {
                lines = 2;
            }
            else if (radioButton3.Checked)
            {
                lines = 3;
            }
            else if (radioButton4.Checked)
            {
                lines = 4;
            }
            else if (radioButton5.Checked)
            {
                lines = 5;
            }
            else if (radioButton6.Checked)
            {
                lines = 6;
            }
            level = (int)numericUpDownLevel.Value;
            offset = (int)numericUpDownOffset.Value;
            projectFile.title = name;
            projectFile.artist = artist;

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files (*.mp3;*.wav)|*.mp3;*.wav";
            ofd.ShowDialog();
            if (ofd.FileName.Length > 0)
            {
                projectFile.pathToMusic = ofd.FileName;
                textBoxFilePath.Text = ofd.FileName;
            }
        }

        ProjectFile projectFile = new ProjectFile();

        private void MainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //add note
            int line = 0;
            switch (e.KeyCode)
            {
                case Keys.D1:
                    line = 1;
                    break;
                case Keys.D2:
                    line = 2;
                    break;
                case Keys.D3:
                    line = 3;
                    break;
                case Keys.D4:
                    line = 4;
                    break;
                case Keys.D5:
                    line = 5;
                    break;
                case Keys.D6:
                    line = 6;
                    break;
                default:
                    return;
            }
            int flick = RawNote.NOFLICK;
            if (Keyboard.IsKeyDown(Key.Left))
            {
                flick = RawNote.LEFTSTART;
            }
            else if (Keyboard.IsKeyDown(Key.Right))
            {
                flick = RawNote.RIGHTSTART;
            }
            else if (Keyboard.IsKeyDown(Key.Up))
            {
                flick = RawNote.UPSTART;
            }
            else if (Keyboard.IsKeyDown(Key.Down))
            {
                flick = RawNote.DOWNSTART;
            }
            
        }

        private void MainForm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //finish long note
            int line = 0;
            switch (e.KeyCode)
            {
                case Keys.D1:
                    line = 1;
                    break;
                case Keys.D2:
                    line = 2;
                    break;
                case Keys.D3:
                    line = 3;
                    break;
                case Keys.D4:
                    line = 4;
                    break;
                case Keys.D5:
                    line = 5;
                    break;
                case Keys.D6:
                    line = 6;
                    break;
                default:
                    return;
            }
        }
    }
}
