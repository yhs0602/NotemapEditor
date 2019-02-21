using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeresteEditor
{
    class Coord
    {
        int line;
        int offset;
        public Coord(int offset, int line)
        {
            this.offset = offset;
            this.line = line;
        }
    }
}
