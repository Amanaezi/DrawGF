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
        readonly Graphics g;
        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Shape[] shape = new Shape[6];

            for (int i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    shape[i] = new Circle() { Brush = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))), X = rnd.Next(50, 1400), Y = rnd.Next(10, 800) };
                }
                else
                {
                    shape[i] = new Rectangle() { Brush = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))), X = rnd.Next(50, 1400), Y = rnd.Next(10, 800) };
                }
            }

            for (int i = 0; i < 6; i++)
            {
                shape[i].Draw(g);
            }
        }
    }
}
