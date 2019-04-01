using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatterns
{
    class ShapeFactory
    {
        public Shape getShape(string shape)
        {
            if (shape == null) return null;
            if (String.Equals(shape, "circle", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            else if (String.Equals(shape, "square", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            else if (String.Equals(shape, "rectangle", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }
            return null;
        }
    }
}
