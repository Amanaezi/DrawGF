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

        readonly Random random = new Random();

        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brush, X, Y, random.Next(10, 100), random.Next(10, 100));
        }

        public override bool Equals(object obj)
        {
            return obj is Circle && this.Equals((Circle)obj);
        }
        public bool Equals(Circle circle)
        {
            return circle.X == X && circle.Y == Y;
        }
    }
}
