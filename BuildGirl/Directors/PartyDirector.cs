using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl.Directors
{
    class PartyDirector
    {
        private GirlStyleBuilder _builder;

        public PartyDirector(GirlStyleBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.ClearModel();
            _builder.AddBody();
            _builder.AddHairBrown();
            _builder.AddPartyLegs();
            _builder.AddPartyBody();
            _builder.AddPartyShoes();
        }
    }
}
