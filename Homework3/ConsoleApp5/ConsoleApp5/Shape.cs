using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Shape
    {
        abstract public double GetArea();
        abstract public bool IsLegal();

    }
    class Rectangle : Shape
    {
        public double Height { set; get; }
        public double Width { set; get; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override bool IsLegal()
        {
            return Width > 0 && Height > 0;
        }
    }
    class Square : Rectangle
    {
        public Square(double width) : base(width, width) { }

        public override bool IsLegal()
        {
            return Width == Height && Width > 0 && Height > 0;
        }
    }
    class Triangle : Shape
    {
        private double Bottom { set; get; }
        private double Height { set; get; }
        public Triangle(double bottom, double height)
        {
            Bottom = bottom;
            Height = height;
        }
        public override double GetArea()
        {
            return (Bottom * Height) / 2;
        }
        public override bool IsLegal()
        {
            return Bottom > 0 && Height > 0;
        }

    }
}
