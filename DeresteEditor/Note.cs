using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotemapEditor
{
    interface Note
    {
        List<RawNote> GetRaws();
    }
}
