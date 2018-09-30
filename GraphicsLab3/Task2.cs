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

        Bitmap imge;
        Color baseColor;

        public Task2()
        {
            InitializeComponent();
        }

        public void DrawImage(Bitmap image)
        {
            pictureBox1.Image = image;
            imge = image;
        }

        Point getNewPoint(int dot, Point p)
        {
            if (dot == 7)
                return new Point(p.X + 1, p.Y + 1);
            else if (dot == 6)
                return new Point(p.X, p.Y + 1);
            else if (dot == 5)
                return new Point(p.X - 1, p.Y + 1);
            else if (dot == 4)
                return new Point(p.X - 1, p.Y);
            else if (dot == 3)
                return new Point(p.X - 1, p.Y - 1);
            else if (dot == 2)
                return new Point(p.X, p.Y - 1);
            else if (dot == 1)
                return new Point(p.X + 1, p.Y - 1);
            else
                return new Point(p.X + 1, p.Y);
        }

        List<Point> findBorder(int x, int y)
        {
            List<Point> points = new List<Point>();
            var start = imge.GetPixel(x, y);
            var nextPixel = imge.GetPixel(x, y + 1);

            baseColor = start;

            while (equal(start, nextPixel))
            {
                y += 1;
                start = imge.GetPixel(x, y);
                nextPixel = imge.GetPixel(x, y + 1);
            }

            int dir = 8;
            int prevDir = dir;
            Point startPoint = new Point(x, y + 1);
            Point nextPoint = startPoint;
            while (true)
            {
                dir += dir - 2 < 0 ? 6 : -2;
                while (true)
                {
                    nextPoint = getNewPoint(dir, startPoint);
                    if (equal(imge.GetPixel(nextPoint.X, nextPoint.Y), baseColor))
                    {
                        startPoint = nextPoint;
                        break;
                    }
                    else
                        dir += 1;
                   dir = dir % 8;
                }
                if (points.Any(pt => (pt.X == startPoint.X && pt.Y == startPoint.Y)))
                    break;
                else
                {
                    points.Add(startPoint);
                    prevDir = dir;
                }
            }
             return points;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            List<Point> points = findAllBorders(location);
            var imgeClone = (Bitmap)imge.Clone();
            foreach (Point pt in points)
                imgeClone.SetPixel(pt.X, pt.Y, Color.Red);
            pictureBox1.Image = imgeClone;
        }

        private List<Point> findAllBorders(Point location)
        {
            var points = findBorder(location.X, location.Y);

            var checkPoints = points.OrderByDescending(p => p.Y).ToArray();

            for (var i = 0; i < checkPoints.Length; i++)
            {
                var first = checkPoints[i];
                var second = first;

                var temp = checkPoints.Where(y => y.Y == first.Y).ToArray();
                foreach (var x in temp)
                    if (x.X > second.X)
                        second = x;

                if (first.Y == second.Y)
                {
                    if (second.X < first.X) Swap(ref first, ref second);

                    var prevPixel = baseColor;

                    for (var j = first.X; j < second.X - 1; j++)
                    {
                        var pixel = imge.GetPixel(j, first.Y);
                        var nextPixel = imge.GetPixel(j + 1, first.Y);
                        if (!equal(pixel, baseColor) && equal(nextPixel, baseColor) || equal(pixel, baseColor) && !equal(nextPixel, baseColor))
                            points.Add(new Point(j, first.Y));
                        if (equal(pixel, baseColor))
                            continue;
                    }
                }
            }

            checkPoints = points.OrderByDescending(p => p.X).ToArray();
            for (var i = 0; i < checkPoints.Length; i++)
            {
                var first = checkPoints[i];
                var second = first;
                var temp = checkPoints.Where(y => y.X == first.X).ToArray();
                foreach (var x in temp)
                    if (x.Y > second.Y)
                        second = x;

                if (first.X == second.X)
                {
                    if (second.Y < first.Y) Swap(ref first, ref second);

                    var prevPixel = baseColor;

                    for (var j = first.Y; j < second.Y - 1; j++)
                    {
                        var pixel = imge.GetPixel(first.X, j);
                        var nextPixel = imge.GetPixel(first.X, j + 1);
                        if (!equal(pixel, baseColor) && equal(nextPixel, baseColor) || equal(pixel, baseColor) && !equal(nextPixel, baseColor))
                            points.Add(new Point(first.X, j));
                        if (equal(pixel, baseColor))
                            continue;
                    }
                }
            }
            return points;
        }

        bool equal(Color c1, Color c2)
        {
            return (System.Math.Abs(c1.R - c2.R) + System.Math.Abs(c1.G - c2.G) + System.Math.Abs(c1.B - c2.B)) < 100;
        }
    }
}
