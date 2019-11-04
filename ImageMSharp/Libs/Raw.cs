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
        Bitmap image;
       
        public Raw(String pathname)
        {
            FileStream img = File.OpenRead(pathname);
           

        }

        public Image getImage()
        {
            return image;
        }

    }
}
