using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillColor(Bitmap image, Point rowStart, Point rowEnd, Color col)
        {
            int y = rowStart.Y;
            int x1 = rowStart.X;
            int x2 = rowEnd.X;
            for (int x = x1+1 ; x < x2; ++x)
                image.SetPixel(x, y, col);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)Bitmap.FromFile(textBox1.Text);
            List<Point> border = new List<Point>(); // TODO: get border from image
            border = border.OrderBy(p => p.Y).ThenBy(p => p.X).ToList();
            for (int i = 0; i < border.Count - 1; ++i)
            {
                if (border[i].Y == border[i+1].Y)
                    fillColor(image, border[i], border[i+1], Color.Blue);
            }
        }
    }
}
