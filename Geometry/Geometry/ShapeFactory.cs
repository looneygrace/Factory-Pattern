using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class ShapeFactory
    {
        void getShape(ShapeType type)
        {
            
            if (type == ShapeType.LINE)
            {
                IGeometricShape shape = new Line();
                shape.draw();
            }
            else if(type == ShapeType.CIRCLE){
                IGeometricShape shape = new Circle();
                shape.draw();
            }
            else if(type == ShapeType.RECTANGLE)
            {
                IGeometricShape shape = new Rectangle();
                shape.draw();
            }
            else if(type == ShapeType.TRIANGLE)
            {
                Console.WriteLine("NO TRIANGLES");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

    }
    enum ShapeType
    {
        LINE,
        CIRCLE,
        RECTANGLE,
        TRIANGLE
    }
    class Line : IGeometricShape
    {
        void IGeometricShape.draw()
        {
            Console.WriteLine("_______________________________");
        }

    }
    class Circle : IGeometricShape
    {
        void IGeometricShape.draw()
        {
            Console.WriteLine("I am a circle");
        }
    }
    class Rectangle : IGeometricShape
    {
        void IGeometricShape.draw()
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|                                |");
            Console.WriteLine("|________________________________|");
        }

    }
}

    