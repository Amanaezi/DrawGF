using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGF
{
    public partial class Form1 : Form
    {
        const int SHAPES = 6;
        readonly Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Shape[] shape = new Shape[SHAPES];

            for (int i = 0; i < SHAPES; i++)
            {
                if (i % 2 == 0)
                {
                    shape[i] = new Circle() { Brush = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))), X = rnd.Next(50, 1400), Y = rnd.Next(10, 800), Width = rnd.Next(10, 100), Height = rnd.Next(10, 100) };
                }
                else
                {
                    shape[i] = new Rectangle() { Brush = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))), X = rnd.Next(50, 1400), Y = rnd.Next(10, 800), Width = rnd.Next(10, 100), Height = rnd.Next(10, 100) };
                }
            }

            for (int i = 0; i < SHAPES; i++)
            {
                shape[i].Draw(g);
            }
        }
    }
}
