using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    public interface IWorkApp
    {
        void GenerateInterface(string userInterface);
        string GenerateFunctions(string[] specs);
    }
}
