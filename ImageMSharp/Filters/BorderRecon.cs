using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using ImageProcessor.Imaging.Filters.EdgeDetection;

namespace ImageMSharp.Filters
{
    class BorderRecon:Effects
    {
        public ImageFactory draw(ImageFactory image)
        {
            Laplacian5X5EdgeFilter filter = new Laplacian5X5EdgeFilter();
            ImageFactory newimage = image.DetectEdges(filter);
            return newimage;

        }
    }
}
