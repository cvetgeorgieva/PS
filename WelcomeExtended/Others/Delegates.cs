using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Others
{
    internal class Delegates
    {
        public static readonly ILogger logger = Logger.Helper.GetLogger("Hello");
        public static void Log(string error) 
        {
            logger.LogError(error); 
        }
        
        public static void Log2(string error)
        {
            Console.WriteLine("-DELEGATES -");
            Console.WriteLine($"{error}");
            Console.WriteLine("-DELEGATES -");
        }

        public delegate void ActionOnError(string message);
    }
}
