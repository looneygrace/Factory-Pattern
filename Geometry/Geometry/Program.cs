using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory picture = new ShapeFactory();
            ShapeType l = ShapeType.LINE;
            ShapeType c = ShapeType.CIRCLE;
            ShapeType r = ShapeType.RECTANGLE;
            ShapeType t = ShapeType.TRIANGLE;
            
            Console.WriteLine("Line-->");
            picture.getShape(l);
            Console.WriteLine("Circle-->");
            picture.getShape(c);
            Console.WriteLine("Rectangle-->");
            picture.getShape(r);
            Console.WriteLine("Triangle-->");
            picture.getShape(t);
            Console.ReadKey();
        }
    }
}
