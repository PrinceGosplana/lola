using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BuildGirl
{
    class Model
    {
        public Image Picture;
        public Model()
        {
            Picture = new Bitmap(283, 709);
            Graphics.FromImage(Picture).Clear(Color.Transparent);
        }
    }
}
