using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageMSharp.Libs;
using MetroFramework;
namespace ImageMSharp
{
    interface Effects
    {
        Image draw(Image image);
        void formsetup();
        void formdispose();
       
    }
}
