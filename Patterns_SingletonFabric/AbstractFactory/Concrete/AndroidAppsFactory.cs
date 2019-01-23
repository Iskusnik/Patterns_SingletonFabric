using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    class AndroidAppsFactory : IAppsAbstractFabric
    {

        public ITable CreateTable()
        {
            return new AndroidTable();
        }

        public IToolbar CreateToolbar()
        {
            return new AndroidToolbar();
        }
        
    }
}
