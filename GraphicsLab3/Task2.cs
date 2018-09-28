using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab3
{
    public partial class Task2 : Form
    {

        Graphics g;
        Bitmap with_border, imge;

        public Task2()
        {
            InitializeComponent();
        }

        public void DrawImage(Bitmap image)
        {
            pictureBox1.Image = image;
            imge = image;
        }
        List<Point> findBorder(int x, int y)
        {
            List<Point> points = new List<Point>();
            var start = imge.GetPixel(x, y);
            var nextPixel = imge.GetPixel(x, y + 1);
            while (equal(start, nextPixel))
            {
                points.Add(new Point(x, y + 1));
                y += 1;
                start = imge.GetPixel(x, y);
                nextPixel = imge.GetPixel(x, y + 1);
            }
            return points;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            var points = findBorder(location.X, location.Y);
            foreach (Point pt in points)
            {
                imge.SetPixel(pt.X, pt.Y, Color.Red);
            }
            pictureBox1.Image = imge;
        }

        bool equal(Color c1, Color c2)
        {
            return (System.Math.Abs(c1.R - c2.R) + System.Math.Abs(c1.G - c2.G) + System.Math.Abs(c1.B - c2.B)) < 30;
        }
    }
}
