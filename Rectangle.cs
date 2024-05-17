using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Rectangle
    {
        private int Length;
        private int Width;

        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }

        public Rectangle(int length, int width)
            {
                Length = length;
                Width = width;
            }

        public Rectangle(int length)
        {
            Length = length;
            Width = 1;
        }


        public int getLength() { return Length; }
        public int getWidth() { return Width; }

        public void setLength(int length) { Length = length; }
        public void setWidth(int width) { Width = width; }

        public int CalculateArea() { return Length * Width; }
        public int CalculatePerimeter() { return 2 * (Length + Width); }
    }
}
