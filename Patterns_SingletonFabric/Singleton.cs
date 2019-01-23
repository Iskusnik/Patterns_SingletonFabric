using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_SingletonFabric
{
    class Singleton
    {
        private static Singleton instance;

        public int UserCount;
        public string Message;

        private string data;
        public string GlobalData
        {
            get { return data; }
            set { data = value; }
        }

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {

            if (instance == null)
            {
                instance = new Singleton();
                instance.UserCount = 0;
            }
            instance.UserCount++;
            instance.Message = "There are " + instance.UserCount + " users total";
             
            return instance;
        }
        public static void Clear()
        {
            Singleton instance = GetInstance();
            instance.UserCount = 0;
            instance.Message = "Cleared";
        }
    }

}
