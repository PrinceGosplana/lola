using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl.Directors
{
    class PlaygirlDirector
    {
        private GirlStyleBuilder _builder;

        public PlaygirlDirector(GirlStyleBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.ClearModel();
            _builder.AddBody();
            _builder.AddHairBrown();
            _builder.AddEars();
            _builder.AddPlaySwimsuit();
            _builder.AddPlayAccessories();
            _builder.AddWorkShoes();
        }
    }
}
