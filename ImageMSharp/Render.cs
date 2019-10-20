using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageProcessor;
using ImageMSharp.Filters;

namespace ImageMSharp
{
    class Render
    {

        enum filters{
            Threshold,
            BorderRecon
        }

        private ImageFactory image;
        private String _imagepath;
        private Image _picture;
        public int filter;
        public Render()
        {
            image = new ImageFactory();
        }

        private Effects effect;
        public void compute()
        {
            load();
            image = effect.draw(image);
            picture = image.Image;
        }

        
        public void FilterSelect(int filter)
        {
            switch (filter)
            {
                case (int)filters.Threshold:
                    effect = new Threshold();
                    break;
                case (int)filters.BorderRecon:
                    effect = new BorderRecon();
                    break;

            }
        }

        public String imagepath
        {
            get
            {
                return _imagepath;
            }
            set
            {
                _picture = Image.FromFile(value);
                this._imagepath = value;
            }
        }

        public Image picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;
            }
        }

        public void load()
        {
            if(imagepath != null)
            {
                image.Load(imagepath);
                
            }
            else
            {
                throw new Exception("Image not selected");
            }
        }

        
    }
}
