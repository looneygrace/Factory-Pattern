using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class ShapeFactory
    {

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
    class Triangle : IGeometricShape
    {
        void IGeometricShape.draw()
        {
            Console.WriteLine("              /\\");
            Console.WriteLine("             /  \\");
            Console.WriteLine("            /    \\");
            Console.WriteLine("           /      \\");
            Console.WriteLine("          /        \\");
            Console.WriteLine("         /          \\"); 
            Console.WriteLine("        /            \\"); 
            Console.WriteLine("       /              \\");
            Console.WriteLine("      /                \\");
            Console.WriteLine("     /                  \\");
            Console.WriteLine("    /                    \\");
            Console.WriteLine("   /                      \\");
            Console.WriteLine("  /                        \\");
            Console.WriteLine(" /                          \\");
            Console.WriteLine("/____________________________\\");
        }
    }
}

    