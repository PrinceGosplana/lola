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
        public void AddBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.Girl, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHomeHairBlondy()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.top_h, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHairBrown()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.top_f, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHairOrange()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.top_p, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHomeTShirt()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.body_h, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddCapMC()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.cap_mc, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddEars()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.ears, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWaitressMutch()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.mutch_waitress, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddProtectBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.body_p, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddMCtBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.body_mc, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPlaySwimsuit()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.swimsuit, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPartyBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.body_pa, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWorkBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.body_w, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWaitressBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.body_waitress, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddSexBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.body_f, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddBatGirlBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.bat_girl, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddBride()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.bride_dress, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHomePants()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.legs_h, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPlayAccessories()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.accessories, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWorkLegs()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.legs_w, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddSexLegs()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.legs_f, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddProtectLegs()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.legs_p, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPartyLegs()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.legs_pa, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddMCscirt()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.scirt_mc, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWorkShoes()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.shoes_w, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWaitressShoes()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.Shoes_waitress, 0, 0, 283, 709);
            g.Dispose();
        }

        public void AddProtectShoes()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.shoes_p, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddMCShoes()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.shoes_mc, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPartyShoes()
        {
            var g = Graphics.FromImage(_model.Picture);
            g.DrawImage(Properties.Resources.shoes_pa, 0, 0, 283, 709);
            g.Dispose();
        }
        public void ClearModel()
        {
            this._model = new Model();
        }
    }
}
