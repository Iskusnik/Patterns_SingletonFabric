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

        static void Main(string[] args)
        {
            InstanceExample();
        }
    }
}
