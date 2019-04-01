using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp
{
    class main
    {
        static void Main(string[] args)
        {
            SingletonDesignPatterns.Singleton singletoninstance = SingletonDesignPatterns.Singleton.getInstance();

            Console.WriteLine(singletoninstance);

        }
    }
}
