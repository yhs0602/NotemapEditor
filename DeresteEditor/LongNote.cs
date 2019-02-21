using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotemapEditor
{
    class LongNote : Note
    {
        public List<RawNote> GetRaws()
        {
            List<RawNote> notes = new List<RawNote>();
            return notes;
        }
        public LongNote(int offset,int endoffset, int line)
        {
            //raws[0]=new RawNote(RawNote.HOLDNOTE,)
        }
        private RawNote[] raws = new RawNote[2];
    }
}
