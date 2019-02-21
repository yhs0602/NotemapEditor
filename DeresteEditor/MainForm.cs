using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(ofd.FileName.Length>0)
            {
                projectFile.pathToMusic = ofd.FileName;
                textBoxFilePath.Text = ofd.FileName;
            }
        }

        ProjectFile projectFile=new ProjectFile();
    }
}
