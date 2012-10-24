using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl
{
    class WorkDirector
    {
        private GirlStyleBuilder _builder;

        public WorkDirector(GirlStyleBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.ClearModel();
            _builder.AddBody();
            _builder.AddHairOrange();
            _builder.AddWorkBody();
            _builder.AddWorkShoes();
            _builder.AddWorkLegs();
        }
    }
}
