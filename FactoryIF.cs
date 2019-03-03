using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    interface FactoryIF
    {
        ServiceIF createService(String str);
    }
}
