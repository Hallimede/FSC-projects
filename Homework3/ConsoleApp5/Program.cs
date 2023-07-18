using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    
    class CreateShape
    {
        public static Shape Factory(int shapeNum)
        {
            Shape shape;
            Random rd = new Random();
            switch (shapeNum)
            {
                case 1:
                    shape = new Rectangle(10*rd.NextDouble(), 10 * rd.NextDouble());
                    Console.WriteLine(shape.ToString());
                    break;
                case 2:
                    shape = new Square(10 * rd.NextDouble());
                    Console.WriteLine(shape.ToString());
                    break;
                case 3:
                    shape = new Triangle(10 * rd.NextDouble(), 10 * rd.NextDouble());
                    Console.WriteLine(shape.ToString());
                    break;
                default:
                    shape = null;
                    Console.WriteLine(shape.ToString());
                    break;
            }
            return shape;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            Shape []shapes = new Shape[10];
            for(int i = 0; i < 10; i++)
            {
                shapes[i] = CreateShape.Factory(rd.Next(1, 3));
            }

            double sumArea=0.0;
            foreach (Shape shape in shapes)
                sumArea += shape.GetArea();
            Console.WriteLine(sumArea);
        }
    }
}
