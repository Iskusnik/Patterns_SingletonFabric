﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    public interface IGameApp
    {
        void GenerateInterface(string userInterface);
        string GenerateGraphics(string driver);
    }
}
