using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class ShapeFactory
    {
        public Shape CreateShape(string type)
        {
            return type switch
            {
                "circle" => new Circle(),
                "rectangle" => new Rectangle(),
                _ => throw new ArgumentException("Unknown shape")
            };
        }
    }

}
