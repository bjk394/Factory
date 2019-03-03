using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class S2 : AbsService
    {
        override
        public String provideService()
        {
            String serve = "S2";
      
            return serve;
        }
    }
}
