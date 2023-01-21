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

        public int Radius { get; set; }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brush, X, Y, Radius, Radius);
        }

        public override bool Equals(object obj)
        {
            return obj is Circle circle && 
                Radius == circle.Radius;
        }
    }
}
