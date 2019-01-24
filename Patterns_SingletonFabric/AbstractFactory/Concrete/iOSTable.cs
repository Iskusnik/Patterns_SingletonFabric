using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    class iOSTable : ITable
    {
        private string[,] Cells;

        public void FillTable(int[,] cells)
        {
            Cells = new string[cells.GetLength(0), cells.GetLength(1)];

            for (int i = 0; i < Cells.GetLength(0); i++)
                for (int j = 0; j < Cells.GetLength(1); j++)
                    Cells[i, j] = cells[i, j].ToString();

            PrintTable();
        }

        public void GenerateTable()
        {
            Console.WriteLine("Таблица сгенерирована");
        }

        public void PrintTable()
        {

            Console.WriteLine("Таблица под iOS:");
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < Cells.GetLength(1); j++)
                    Console.Write(Cells[i, j] + "...");
            }
        }
    }
}
