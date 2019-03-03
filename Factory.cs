using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class Factory : FactoryIF
    {
        //override
        public ServiceIF createService(String str)
        {
            Type t = Type.GetType("Factory." + str);
            object o = Activator.CreateInstance(t);
            ServiceIF s = (ServiceIF)o;
            return s;
        }
    }
}
