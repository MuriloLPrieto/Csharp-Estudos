using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAbstrato
{
    internal class Rectangle : Shape
    {

        public double Height { get; set; }
        public double Width { get; set; }
        
        public Rectangle(double height, double width ,Color color) : base(color) 
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
