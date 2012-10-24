using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl.Directors
{
    class SexDirector
    {
        private GirlStyleBuilder _builder;

        public SexDirector(GirlStyleBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.ClearModel();
            _builder.AddBody();
            _builder.AddHairBrown();
            _builder.AddSexLegs();
            _builder.AddSexBody();
            _builder.AddWaitressShoes();
        }
    }
}
