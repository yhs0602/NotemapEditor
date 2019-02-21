using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotemapEditor
{
    class RawNote
    {
        //int offset;
        int kind;
        int startline; //helps faking
        int endline;    //original position
        int flick;
        int nextline;    //next line (for flick/slide notes)

        //kinds
        public const int NONOTE = 0;
        public const int TABNOTE = 1;
        public const int HOLDNOTE = 2;
        public const int SLIDENOTE = 3;

        //startline should be 1-5
        //fake end line is shown by position

        public const int NOFLICK = 0;
        public  const int LEFTSTART = 1;
        public const int LEFTENDMID = 2;
        public const int RIGHTSTART = 3;
        public const int RIGHTENDMID = 4;

        public static readonly RawNote NONOTENOTE = new RawNote(NONOTE, 0, 0, 0, 0);

        public Boolean IsFlick()
        {
            return flick != NOFLICK;
        }
        
        public override String ToString()
        {
            if (kind == NONOTE)
                return "----";
            return "" + kind + "" + startline + "" + flick + "" + nextline;
        }
        public RawNote(/*int offset,*/ int kind, int startline, int endline, int flick, int nextline)
        {
            //this.offset = offset;
            this.kind = kind;
            this.startline = startline;
            this.endline = endline;
            this.flick = flick;
            this.nextline = nextline;
        }
    }
}
