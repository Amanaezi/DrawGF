using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawGF
{
    public class Circle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brush, X, Y, Width, Height);
        }

        public override bool Equals(object obj)
        {
            return obj is Circle && this.Equals((Circle)obj);
        }
        public bool Equals(Circle circle)
        {
            return circle.Width == Width && circle.Height == Height;
        }
    }
}
