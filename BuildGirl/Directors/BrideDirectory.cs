using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl.Directors
{
    class BrideDirectory
    {
        private GirlStyleBuilder _builder;

        public BrideDirectory(GirlStyleBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.ClearModel();
            _builder.AddBody();
            _builder.AddHomeHairBlondy();
            _builder.AddBride();
        }
    }
}
