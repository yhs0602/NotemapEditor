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
        public NoteFile(String name)
        {
            this.name = name;
            bits = 8;
            width = 5;
        }
        public void SetBits()
        {

        }
        public void AddTapNote(int offset, int line)
        {
            int blockindex = offset / bits;
            int blockoffset = offset % bits;
            if(blockindex+1>blocks.Count)
            {
                int toadd = blockindex-blocks.Count+1;
                for(int i=0;i<toadd;i++)
                {
                    AddBlock();
                }
            }
            blocks[blockindex].SetNote(blockoffset, line, new TapNote(line).GetRaws()[0]);
        }
        //자동으로->add block로 늘어나는 5*무한 표 필요
        //(위치)->노트 매핑 필요
        //이후 위치에 따라 정렬 후  차례대로 기록한다.

        private void AddBlock()
        {
            blocks.Add(new Block(bits,width));
        }
        private List<Block> blocks = new List<Block>();

        public void Write()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"out.txt"))
            {
                foreach(Block block in blocks)
                {
                    file.Write(block.ToString());
                }
            }

        }
    }
}
