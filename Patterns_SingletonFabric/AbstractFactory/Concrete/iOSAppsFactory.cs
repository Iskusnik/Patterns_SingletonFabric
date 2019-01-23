using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    class iOSAppsFactory : IAppsAbstractFabric
    {
        public ITable CreateTable()
        {
            return new iOSTable();
        }

        public IToolbar CreateToolbar()
        {
            return new iOSToolbar();
        }
    }
}
