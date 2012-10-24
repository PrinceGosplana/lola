using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl.Directors
{
    class ProtectDirector
    {
         private GirlStyleBuilder _builder;

        public ProtectDirector(GirlStyleBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.ClearModel();
            _builder.AddBody();
            _builder.AddHairOrange();
            _builder.AddProtectBody();
            _builder.AddProtectLegs();
            _builder.AddProtectShoes();
        }
    }
}
