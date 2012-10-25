using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl.Directors
{
    class MerryChristmasDirector
    {
        public GirlStyleBuilder _builder;

        public MerryChristmasDirector (GirlStyleBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.ClearModel();
            _builder.GetProduct();
            _builder.AddBody();
            _builder.AddHairBrown();
            _builder.AddCapMC();
            _builder.AddMCtBody();
            _builder.AddMCscirt();
            _builder.AddMCShoes();
        }
    }
}
