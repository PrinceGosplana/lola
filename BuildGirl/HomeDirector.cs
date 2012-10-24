using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildGirl
{
    class HomeDirector
    {
        public GirlStyleBuilder builder;

        public HomeDirector(GirlStyleBuilder _builder)
        {
            this.builder = _builder;
        }

        public void Construct()
        {
            builder.AddHomeHair();
        }
    }
}
