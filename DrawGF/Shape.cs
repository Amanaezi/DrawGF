using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawGF
{
    public abstract class Shape
    {
        public Brush Brush { get; set; }

        public abstract void Draw(Graphics g);

        public override bool Equals(object obj)
        {
            return obj is Shape && this.Equals((Shape)obj);
        }
        public bool Equals(Shape shape)
        {
            return shape.Brush == Brush;
        }
    }
}
