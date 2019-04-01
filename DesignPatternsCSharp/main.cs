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
            //Singleton Design Pattern
            SingletonDesignPatterns.Singleton singletoninstance = SingletonDesignPatterns.Singleton.getInstance();
            Console.WriteLine(singletoninstance);

            //Factory Design Pattern
            FactoryDesignPatterns.ShapeFactory sf = new FactoryDesignPatterns.ShapeFactory();
            FactoryDesignPatterns.Shape shape1 = sf.getShape("Circle");
            shape1.draw();

        }
    }
}
