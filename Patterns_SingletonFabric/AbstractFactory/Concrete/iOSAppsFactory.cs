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
            throw new NotImplementedException();
        }

        public IToolbar CreateToolbar()
        {
            throw new NotImplementedException();
        }
    }
}
