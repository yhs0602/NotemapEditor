using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeresteEditor
{
    class Block
    {
        RawNote[][] notes;
        public Block(int bits, int width)
        {
            notes = new RawNote[bits][];
            for(int i=0;i<notes.Length;++i)
            {
                notes[i] = new RawNote[width];
                for(int j=0;j<width;++j)
                {
                    notes[i][j] = RawNote.NONOTENOTE;
                }
            }
        }
        public void SetNote(int roffset, int line, RawNote note)
        {
            notes[roffset][line] = note;
        }
        
        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < notes.Length ;++i)
            {
                sb.Append("#");
                for(int j=0;j<notes[i].Length;++j)
                {
                    sb.Append(" ");
                    sb.Append(notes[i][j].ToString());
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
