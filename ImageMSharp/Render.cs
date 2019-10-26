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
    public class Render
    {

        enum filters{
            Threshold,
            BorderRecon,
            GreyScale
        }

        private filters filtr;

        private Image image;
        private String _imagepath;
        private Image _picture;
        private Image original;
        private int _filter;
   

        private Effects effect;

 
        public Render(String path)
        {
            imagepath = path;
        }
        public void compute()
        {
            FilterSelect(filter);
            image = effect.draw(image);
            picture = image;
        }

        
        public void FilterSelect(int filter)
        {
            switch (filter)
            {
                case (int) filters.Threshold:
                    effect = new Threshold();
                    break;
                case (int) filters.BorderRecon:
                    effect = new BorderRecon();
                    break;

                case (int) filters.GreyScale:
                    effect = new GreyScale();
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
                original = picture;
                image = new Bitmap(value);
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
        public void reset()
        {
            this.picture = this.original;
        }

        public int filter
        {
            get
            {
                return this._filter;
            }
            set
            {
                _filter = value;
            }
        }
    }
}
