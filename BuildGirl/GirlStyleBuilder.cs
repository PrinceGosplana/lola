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
            var img = Image.FromFile(@"Images/Girl.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHomeHairBlondy()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Home/top_h.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHairBrown()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/top_f.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHairOrange()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Work/top_w.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHomeTShirt()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Home/tshirt_h.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddEars()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Playgirl/ears.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWaitressMutch()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Waitress/mutch_waitress.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddProtectBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Protect/body_p.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPlaySwimsuit()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Playgirl/swimsuit.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPartyBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Party/body_pa.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWorkBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Work/body_w.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWaitressBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Waitress/body_waitress.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddSexBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Sex/body_f.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddBatGirlBody()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/bat_girl.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddBride()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/bride_dress.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddHomePants()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Home/legs_h.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPlayAccessories()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Playgirl/accessories.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWorkLegs()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Work/legs_w.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddSexLegs()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Sex/legs_f.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddProtectLegs()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Protect/legs_p.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPartyLegs()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Party/legs_pa.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWorkShoes()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Work/shoes_w.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddWaitressShoes()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Waitress/shoes_waitress.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }

        public void AddProtectShoes()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Protect/shoes_p.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void AddPartyShoes()
        {
            var g = Graphics.FromImage(_model.Picture);
            var img = Image.FromFile(@"Images/Party/shoes_pa.png");
            g.DrawImage(img, 0, 0, 283, 709);
            g.Dispose();
        }
        public void ClearModel()
        {
            this._model = new Model();
        }
    }
}
