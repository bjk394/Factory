using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class S3 : AbsService
    {
        override
        public String provideService()
        {
            String serve = "S3";

            return serve;
        }
    }
}
