using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{

    //Интерфейс абстрактной фабрики
    public interface IAppsAbstractFabric
    {
        IGameApp CreateGameApp();

        IWorkApp CreateWorkApp();
    }
  }
