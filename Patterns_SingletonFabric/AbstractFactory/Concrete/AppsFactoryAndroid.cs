using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    class AppsFactoryAndroid : IAppsAbstractFabric
    {
        public IGameApp CreateGameApp()
        {
            throw new NotImplementedException();
        }

        public IWorkApp CreateWorkApp()
        {
            throw new NotImplementedException();
        }
    }
}
