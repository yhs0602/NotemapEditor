using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotemapEditor
{
    class NoteFile
    {
        String name;
        public int bits
        {
            get;
            set;
        }
        public int width
        {
             get;
             set;
         }
        public NoteFile(/*String name*/)
        {
            //this.name = name;
            bits = 8;
            width = 5;
        }
        public void SetBits()
        {

        }
        public void AddTapNote(int offset, int line)
        {
            int blockindex, blockoffset;
            GetBlockAndOffsetAndAdjustCapacity(offset, out blockindex, out blockoffset);
            blocks[blockindex].SetNote(blockoffset, line, new TapNote(line).GetRaws()[0]);
        }

        public void AddLongNote(int offset1, int offset2, int line)
        {
            int blockindex1, blockoffset1;
            GetBlockAndOffsetAndAdjustCapacity(offset1, out blockindex1, out blockoffset1);
            int blockindex2, blockoffset2;
            GetBlockAndOffsetAndAdjustCapacity(offset2, out blockindex2, out blockoffset2);
            blocks[blockindex1].SetNote(blockoffset1, line, new RawNote(RawNote.HOLDNOTE,line,line,RawNote.NOFLICK,line));
            blocks[blockindex2].SetNote(blockoffset2, line, new RawNote(RawNote.HOLDNOTE, line, line, RawNote.NOFLICK, 0));
        }

        public void AddFlickNote(int offset, int line, int type)
        {
            int blockindex, blockoffset;
            GetBlockAndOffsetAndAdjustCapacity(offset, out blockindex, out blockoffset);
            blocks[blockindex].SetNote(blockoffset, line, new RawNote(RawNote.TABNOTE, line, line, type, 0));
        }

        public void AddLongNoteStart(int offset, int line)
        {
            int blockindex;
            int blockoffset;
            GetBlockAndOffsetAndAdjustCapacity(offset, out blockindex, out blockoffset);
            blocks[blockindex].SetNote(blockoffset, line, new RawNote(RawNote.HOLDNOTE, line, line, RawNote.NOFLICK, 100));
        }

        public void AddLongNoteEnd(int offset, int line, int flick)
        {
            int blockindex;
            int blockoffset;
            GetBlockAndOffsetAndAdjustCapacity(offset, out blockindex, out blockoffset);
            blocks[blockindex].SetNote(blockoffset, line, new RawNote(RawNote.HOLDNOTE, line, line, flick, 0));
            //backward connect

            int laststart = offset - 1;
            while(laststart>=0&&GetNote(laststart,line).GetNextLine()!=100)
            {
                laststart--;
            }
            ConnectNotes(laststart, line, line);
        }

        public RawNote GetNote(int offset, int line)
        {
            int blockindex;
            int blockoffset;
            GetBlockAndOffsetAndAdjustCapacity(offset, out blockindex, out blockoffset);
            return blocks[blockindex].GetNote(blockoffset, line);
        }
        public void ConnectNotes(int offset1, int line1, int line2)
        {
            int blockoffset1, blockindex1;
            //int blockoffset2, blockindex2;
            GetBlockAndOffsetAndAdjustCapacity(offset1, out blockindex1, out blockoffset1);
            //GetBlockAndOffsetAndAdjustCapacity(offset2, out blockindex2, out blockoffset2);
            blocks[blockindex1].GetNote(blockoffset1, line1).SetNextLine(line2);
        }

        private void GetBlockAndOffsetAndAdjustCapacity(int offset, out int blockindex, out int blockoffset)
        {
            blockindex = offset / bits;
            blockoffset = offset % bits;
            if (blockindex + 1 > blocks.Count)
            {
                int toadd = blockindex - blocks.Count + 1;
                for (int i = 0; i < toadd; i++)
                {
                    AddBlock();
                }
            }
        }

        //자동으로->add block로 늘어나는 5*무한 표 필요
        //(위치)->노트 매핑 필요
        //이후 위치에 따라 정렬 후  차례대로 기록한다.

        private void AddBlock()
        {
            blocks.Add(new Block(bits,width));
        }
        private List<Block> blocks = new List<Block>();

        public void Write(string path)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(path))
            {
                foreach(Block block in blocks)
                {
                    file.Write(block.ToString());
                }
            }

        }
    }
}
