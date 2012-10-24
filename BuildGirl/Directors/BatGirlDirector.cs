using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl.Directors
{
    class BatGirlDirector
    {
        private GirlStyleBuilder _builder;

        public BatGirlDirector(GirlStyleBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.ClearModel();
            _builder.AddBody();
            _builder.AddBatGirlBody();
        }
    }
}
