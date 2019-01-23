using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    class AndroidTable : ITable
    {
        private int[,] Cells;

        public void FillTable(int[,] cells)
        {
            Cells = cells;
        }
        
        public void GenerateTable()
        {
            Console.WriteLine("Таблица сгенерирована");
        }

        public void PrintTable()
        {

            Console.WriteLine("Таблица под Android:");
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < Cells.GetLength(1); j++)
                    Console.Write(" {0}", Cells[i, j]);
            }
        }

    }
}
