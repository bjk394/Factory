using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class S1 : AbsService
    {
        override
        public String provideService()
        {
            String serve = "S1";
          
            return serve;
        }
    }
}
