using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawGF
{
    class Rectangle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        readonly Random random = new Random();
        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brush, X, Y, random.Next(10, 100), random.Next(10, 100));
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle && this.Equals((Rectangle)obj);
        }
        public bool Equals(Rectangle rectangle)
        {
            return rectangle.X == X && rectangle.Y == Y;
        }
    }
}
