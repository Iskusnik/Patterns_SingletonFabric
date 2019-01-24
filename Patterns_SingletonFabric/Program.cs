using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Patterns_SingletonFabric
{
    class Program
    {

        public static void InstanceExample()
        {
            Console.WriteLine("Первый запуск");
            InstancePreview();
            Singleton.Clear();


            Console.WriteLine("\nВторой запуск");
            InstancePreview(3, 0);
            Singleton.Clear();

            Thread.Sleep(1000);
            Console.WriteLine();
        }

        public static void InstancePreview(int n = 3, int sleepTime = 1000)
        {
            Singleton instance = Singleton.GetInstance();
            Console.WriteLine(instance.Message);
            for (int i = 0; i < n; i++)
            {

                Thread thread = new Thread(InstanceJob);
                thread.Start();
                //Проблема параллельности - необходим контроль доступа к ресурсам
                Thread.Sleep(sleepTime);
            }

            Console.WriteLine(instance.UserCount);
        }

        public static void InstanceJob()
        {
            Singleton instance = Singleton.GetInstance();
            Console.WriteLine(instance.Message);
        }

        public static void UseAppsFactory()
        {
            AndroidTest();
            iOSTest();
        }
        public static void AndroidTest()
        {
            Console.WriteLine("AndroidFactory");

            AndroidAppsFactory androidFactory = new AndroidAppsFactory();

            TestToolbar(androidFactory.CreateToolbar());
            TestTable(androidFactory.CreateTable());

            Console.WriteLine();
        }
        public static void iOSTest()
        {
            Console.WriteLine("iOSFactory");

            iOSAppsFactory iOSFactory = new iOSAppsFactory();

            TestToolbar(iOSFactory.CreateToolbar());
            TestTable(iOSFactory.CreateTable());

            Console.WriteLine();
        }


        static int[,] testArray = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        static string testString = "12345";
        public static void TestToolbar(IToolbar toolbar)
        {
            toolbar.GenerateBar();
            toolbar.FillText(testString);
        }
        public static void TestTable(ITable table)
        {
            table.GenerateTable();
            table.FillTable(testArray);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Паттерн Одиночка:");
            InstanceExample();

            Console.WriteLine("Паттерн Абстрактная фабрика:");
            UseAppsFactory();
        }
    }
}
