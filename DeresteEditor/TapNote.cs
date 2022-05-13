using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotemapEditor
{
    class TapNote : Note
    {
        public List<RawNote> GetRaws()
        {
            List<RawNote> list = new List<RawNote>();
            list.Add(raw);
            return list;
        }
        public TapNote(int line)
        {
            raw = new RawNote(RawNote.TABNOTE, line, line, RawNote.NOFLICK, 0);
        }
        RawNote raw;
    }
}
