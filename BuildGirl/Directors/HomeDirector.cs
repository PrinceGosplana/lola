using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl
{
    class HomeDirector
    {
        public GirlStyleBuilder _builder;

        public HomeDirector(GirlStyleBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.ClearModel();
            _builder.GetProduct();
            _builder.AddBody();
            _builder.AddHomeHairBlondy();
            _builder.AddHomeTShirt();
            _builder.AddHomePants();
        }
    }
}
