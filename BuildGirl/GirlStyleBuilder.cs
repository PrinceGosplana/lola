using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BuildGirl
{
    interface IBuilder
    {
        //private Model model;
        Model GetProduct();
    }
    class GirlStyleBuilder : IBuilder
    {
        private Model _model;
        public GirlStyleBuilder()
        {
            _model = new Model();
        }
        public Model GetProduct()
        {
            return _model;
        }
        public void AddHomeHair()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Image.FromFile("Resources/Girl.png"),0,0);
            g.Dispose();
        }
        public void ClearModel()
        {
            this._model = new Model();
        }
    }
}
