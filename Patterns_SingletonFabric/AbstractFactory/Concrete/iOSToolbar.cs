﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    class iOSToolbar : IToolbar
    {
        public void FillText(string text)
        {
            Console.WriteLine("ToolbariOS: {0}", text);
        }

        public void GenerateBar()
        {
            Console.WriteLine(".....'\'Toolbar сгенерирован'/'.....");
        }
    }
}
