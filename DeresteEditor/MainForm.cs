using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
            if (projectFile.pathToMusic == null || projectFile.pathToMusic.Equals(""))
            {
                MessageBox.Show("You should choose a miusic file");
                return;
            }
            string artist = textBoxArtist.Text;
            if (artist == null || artist.Equals(""))
            {
                MessageBox.Show("You should enter the artist");
                return;
            }
            string name = textBoxSongName.Text;
            if (name == null || name.Equals(""))
            {
                MessageBox.Show("You should enter the song name");
                return;
            }
            string creator = textBoxCreator.Text;
            if (creator == null || creator.Equals(""))
            {
                MessageBox.Show("You should enter the creator");
                return;
            }
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
            string projfolder = @"projects\" + name + @"\";
            Directory.CreateDirectory(projfolder);
            using (StreamWriter file = new StreamWriter(projfolder+@"info.txt"))
            {
                file.WriteLine("#title " + name);
                file.WriteLine("#artist " + artist);
                file.WriteLine("#mobile deresimu");
                file.WriteLine("#easy deleste="+projectFile.easyLevel);
                file.WriteLine("#normal deleste="+projectFile.normalLevel);
                file.WriteLine("#hard deleste="+projectFile.hardLevel);
                file.WriteLine("#apex deleste=" + projectFile.apexLevel);
                file.WriteLine("#tag " + name);
            }
            string destmusic = projfolder + name + Path.GetExtension(projectFile.pathToMusic);
            if (!File.Exists(destmusic))
                File.Copy(projectFile.pathToMusic, destmusic);
            noteFile.Write(projfolder + name + ".notemap2");
            projectFile.lines = lines;
            projectFile.creator = creator;
            projectFile.initialized = true;
            using (FileStream fs = new FileStream(projfolder+"metadata", FileMode.Create))
            {
                // Construct a BinaryFormatter and use it to serialize the data to the stream.
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    formatter.Serialize(fs, projectFile);
                }
                catch (SerializationException f)
                {
                    MessageBox.Show("Failed to save projcet, reason: " + f.Message);
                    return;
                }
            }   
            MessageBox.Show("Project file saved");
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
        NoteFile noteFile=new NoteFile();

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

        private void buttonEditView_Click(object sender, EventArgs e)
        {
            isEditOrView = !isEditOrView;
            buttonEditView.BackgroundImage = isEditOrView ? Properties.Resources.Edit : Properties.Resources.View;
        }
        bool isEditOrView;

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj= e.Graphics;
            int STARTX = 0;
            int ENDX = pictureBox.Size.Width;
            int STARTY = 0;
            int ENDY = pictureBox.Size.Height;
            Pen gridPen = new Pen(Color.White, 1);
            Pen redPen = new Pen(Color.Red,2);
            Brush brush = new SolidBrush(Color.Black);
            graphicsObj.FillRectangle(brush, pictureBox.Bounds);
            //draw origin
            graphicsObj.DrawLine(redPen, STARTX,ENDY - 10, ENDX, ENDY - 10);
            if (projectFile.initialized)
                return;
            int lines = projectFile.lines;
            int deltaX = ENDX / (lines + 1);
            //Draw grid
            for(int x=deltaX;x<ENDX;x+=deltaX)
            {
                graphicsObj.DrawLine(gridPen, deltaX, 0, deltaX, ENDY);
            }
            //Draw panels
            //-0-0-0-0-0-0-
           
            //Draw notes

            //if playing refresh with timer (update grid and note Y

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        private void radioButtonEasy_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonEasy.Checked)
            {
                projectFile.CurrentDifficulty = "easy";
            }
        }

        private void radioButtonHard_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonHard.Checked)
            {
                projectFile.CurrentDifficulty = "hard";
            }
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonNormal.Checked)
            {
                projectFile.CurrentDifficulty = "normal";
            }
        }

        private void radioButtonApex_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonApex.Checked)
            {
                projectFile.CurrentDifficulty = "apex";
            }
        }

        private void numericUpDownLevel_ValueChanged(object sender, EventArgs e)
        {
            projectFile.Level = (int) numericUpDownLevel.Value;
        }


        /*
void LoadData()
{
// Declare the hashtable reference.
Hashtable addresses = null;

// Open the file containing the data that you want to deserialize.
FileStream fs = new FileStream("DataFile.dat", FileMode.Open);
try
{
BinaryFormatter formatter = new BinaryFormatter();

// Deserialize the hashtable from the file and  
// assign the reference to the local variable.
addresses = (Hashtable)formatter.Deserialize(fs);
}
catch (SerializationException e)
{
Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
throw;
}
finally
{
fs.Close();
}

// To prove that the table deserialized correctly,  
// display the key/value pairs. 
foreach (DictionaryEntry de in addresses)
{
Console.WriteLine("{0} lives at {1}.", de.Key, de.Value);
}
}*/
    }
}
