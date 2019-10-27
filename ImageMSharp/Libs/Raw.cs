using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMSharp.Libs;
using System.Drawing;
using System.IO;

namespace ImageMSharp.Libs
{
    class Raw
    {
        String pathfile;
        public Raw(String pathname)
        {
            FileStream file = new FileStream(pathname, FileMode.Open);
        }

    }
}
