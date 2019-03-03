using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    abstract class AbsService : ServiceIF
    {
        public abstract String provideService();
    }
}
