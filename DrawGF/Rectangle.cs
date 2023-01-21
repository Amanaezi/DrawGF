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
        public int Width { get; set; }
        public int Height { get; set; }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brush, X, Y, Width, Height);
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle && 
                Width == rectangle.Width && 
                Height == rectangle.Height; 
        }
    }
}
