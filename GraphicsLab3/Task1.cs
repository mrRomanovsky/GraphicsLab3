using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab3
{
    public partial class Task1 : Form
    {
        private string ppath;
        private Pen borderPen = new Pen(Color.FromArgb(0, 0, 0), (float)1);
        private Color fillColor = Color.FromArgb(50, 50, 50);
        private Color paintedСolor;
        private bool isPart2 = false;
        private Point startPixel;
        private Bitmap original;
        private Graphics g;
        private List<Point> pointsBorder = new List<Point>();
        private List<System.Windows.Forms.Control> part1Components;
        private List<System.Windows.Forms.Control> part2Components;

        public Task1(string path)
        {
            part1Components = new List<Control>();
            part2Components = new List<Control>();
            InitializeComponent();
            ppath = path;
            original = (Bitmap)Bitmap.FromFile(path);
            pictureBox1.Image = original;
            g = Graphics.FromImage(pictureBox1.Image);
        }

        #region part2
        private Bitmap pic2;
        private string ppath2;
        Graphics g2;

        private void Part2_Click(object sender, EventArgs e)
        {
            isPart2 = true;
            part1.BackColor = Color.Silver;
            part2.BackColor = Color.DimGray;
            foreach (var item in part1Components)
            {
                item.Enabled = false;
                item.Visible = false;
            }
            foreach (var item in part2Components)
            {
                item.Enabled = true;
                item.Visible = true;
            }
            original = (Bitmap)Bitmap.FromFile(ppath);
            pictureBox1.Image = original;
            g = Graphics.FromImage(pictureBox1.Image);
            guideline.Text = "Введите путь к файлу заливки...";
            this.Refresh();
        }

        private void setPathToPic_Click(object sender, EventArgs e)
        {
            ppath2 = textBoxPathToPic.Text;
            pic2 =  (Bitmap)Bitmap.FromFile(ppath2);
            guideline.Text = "Обведите область заливки...";
        }

        void FillPartSecond(Point p, ref List<IGrouping<int, Point>> pl)
        {
            var zp = new Point(-1, -1);
            IEnumerable<IGrouping<int, Point>> t;
            if (p.X < 0 || p.Y < 0 || p.X > pictureBox1.Width || p.Y > pictureBox1.Height || ((Bitmap)pictureBox1.Image).GetPixel(p.X, p.Y) != paintedСolor)
                return;
            var lb = FindLeftBorder(p);
            Point rb = zp;
            var pp = lb;
            pp.X++;
            Point lastP = zp;
            if (pp.X < pictureBox1.Width && pp.Y < pictureBox1.Height && ((Bitmap)pictureBox1.Image).GetPixel(pp.X, pp.Y) == paintedСolor)
                lastP = pp;
            while (pp.X < pictureBox1.Width && pp.Y < pictureBox1.Height && pp != rb && ((Bitmap)pictureBox1.Image).GetPixel(pp.X, pp.Y) == paintedСolor)//|| ((Bitmap)pictureBox1.Image).GetPixel(pp.X, pp.Y) != borderPen.Color))//
            {
                original.SetPixel(pp.X, pp.Y, pic2.GetPixel(pp.X % pic2.Width, pp.Y % pic2.Height));
                pp.X++;
            }
            pictureBox1.Refresh();
            while (lastP != new Point(pp.X - 1, pp.Y))
            {
                if (lastP.Y + 1 < pictureBox1.Height)
                    FillPartSecond(new Point(lastP.X, lastP.Y + 1), ref pl);
                if (lastP.Y - 1 > 0)
                    FillPartSecond(new Point(lastP.X, lastP.Y - 1), ref pl);
                lastP.X++;
            }
        }

        #endregion

        #region part1
        private void Part1_Click(object sender, EventArgs e)
        {
            isPart2 = false;
            part1.BackColor = Color.DimGray;
            part2.BackColor = Color.Silver;
            foreach (var item in part2Components)
            {
                item.Enabled = false;
                item.Visible = false;
            }
            foreach (var item in part1Components)
            {
                item.Enabled = true;
                item.Visible = true;
            }
            original = (Bitmap)Bitmap.FromFile(ppath);
            pictureBox1.Image = original;
            g = Graphics.FromImage(pictureBox1.Image);
            guideline.Text = "Обведите область заливки...";
            this.Refresh();
        }

        private void SetFillColor_Click(object sender, EventArgs e)
        {
            fillColor = Color.FromArgb(int.Parse(rFill.Text), int.Parse(gFill.Text), int.Parse(bFill.Text));
        }

        private Point FindLeftBorder(Point p)
        {
            while (p.X > 0 && ((Bitmap)pictureBox1.Image).GetPixel(p.X, p.Y) == paintedСolor)
                p.X--;

            return p;
        }

        void FillPartFirst(Point p, ref List<IGrouping<int, Point>> pl)
        {
            var zp = new Point(-1, -1);
            IEnumerable<IGrouping<int, Point>> t;
            if (p.X < 0 || p.Y < 0 || p.X > pictureBox1.Width || p.Y > pictureBox1.Height || ((Bitmap)pictureBox1.Image).GetPixel(p.X, p.Y) != paintedСolor)
                return;
            var lb = FindLeftBorder(p);
            Point rb = zp;
            var pp = lb;
            pp.X++;
            Point lastP = zp;
            if (pp.X < pictureBox1.Width && pp.Y < pictureBox1.Height && ((Bitmap)pictureBox1.Image).GetPixel(pp.X, pp.Y) == paintedСolor)
                lastP = pp;
            while (pp.X < pictureBox1.Width && pp.Y < pictureBox1.Height && pp != rb && ((Bitmap)pictureBox1.Image).GetPixel(pp.X, pp.Y) == paintedСolor)//|| ((Bitmap)pictureBox1.Image).GetPixel(pp.X, pp.Y) != borderPen.Color))//
                pp.X++;
            if (lastP != zp)
                g.DrawLine(new Pen(fillColor), lastP, new Point(pp.X - 1, pp.Y));
            pictureBox1.Refresh();
            while (lastP != new Point(pp.X - 1, pp.Y))
            {
                if (lastP.Y + 1 < pictureBox1.Height)
                    FillPartFirst(new Point(lastP.X, lastP.Y + 1), ref pl);
                if (lastP.Y - 1 > 0)
                    FillPartFirst(new Point(lastP.X, lastP.Y - 1), ref pl);
                lastP.X++;
            }
        }
        #endregion

        private void Fill()
        {
            Point currPoint = startPixel;
            if (paintedСolor == fillColor)
                return;
            var pl = pointsBorder.ToList().GroupBy(p => p.Y).OrderBy(p => p.Key).ToList();
            if (!isPart2)
                FillPartFirst(startPixel, ref pl);
            else
                FillPartSecond(startPixel, ref pl);
            pictureBox1.Refresh();
        }

        private void SetColorBorder_Click(object sender, EventArgs e)
        {
            borderPen = new Pen(Color.FromArgb(int.Parse(rBorder.Text), int.Parse(gBorder.Text), int.Parse(bBorder.Text)));
        }

        void pictureBox1_MainPaint(object sender, PaintEventArgs e)
        {
        }

        void pictureBox1_BorderPaint(object sender, PaintEventArgs e)
        {
            if (pointsBorder.Count() < 2)
            {
                guideline.Text = "Обведите область заливки...";
                return;
            }
            g.DrawCurve(borderPen, pointsBorder.ToArray());
        }

        void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (guideline.Text == "Обведите область заливки...")
            {
                pictureBox1.Paint -= pictureBox1_BorderPaint;
                pictureBox1.Paint += pictureBox1_MainPaint;
                guideline.Text = "Выберите стартовый пиксель заливки...";
                return;
            }
            if (guideline.Text == "Выберите стартовый пиксель заливки...")
            {
                pictureBox1.Paint -= pictureBox1_FillPaint;
                pictureBox1.Paint += pictureBox1_MainPaint;
                guideline.Text = "Заливка...";
                this.Refresh();
                Fill();
                guideline.Text = "Обведите область заливки...";
                this.Refresh();

            }
        }

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (guideline.Text == "Обведите область заливки...")
            {
                pictureBox1.Paint -= pictureBox1_MainPaint;
                pictureBox1.Paint += pictureBox1_BorderPaint;
                pointsBorder = new List<Point> { e.Location };
            }
            else if (guideline.Text == "Выберите стартовый пиксель заливки...")
            {
                pictureBox1.Paint -= pictureBox1_MainPaint;
                pictureBox1.Paint += pictureBox1_FillPaint;
                startPixel = e.Location;
                paintedСolor = ((Bitmap)pictureBox1.Image).GetPixel(startPixel.X, startPixel.Y);
                var j = ((Bitmap)pictureBox1.Image).GetPixel(startPixel.X, startPixel.Y);
            }
        }

        private void pictureBox1_FillPaint(object sender, PaintEventArgs e)
        {
            Fill();
        }

        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (guideline.Text == "Обведите область заливки..." && (e.Button == MouseButtons.Left))
            {
                int newY = e.Location.Y;
                int oldY = pointsBorder.Last().Y;
                int newX = e.Location.X;
                int oldX = pointsBorder.Last().X;
                if (Math.Abs(newY - oldY) > 1)
                {

                    int minY, maxY;
                    int minX, maxX;
                    if (newY < oldY)
                    {
                        minY = newY;
                        maxY = oldY;
                    }
                    else
                    {
                        minY = oldY;
                        maxY = newY;
                    }
                    if (newX < oldX)
                    {
                        minX = newX;
                        maxX = oldX;
                    }
                    else
                    {
                        minX = oldX;
                        maxX = newX;
                    }

                    while (minY < maxY)
                    {
                        pointsBorder.Add(new Point((minX + maxX) / 2, minY + 1));
                        ++minX;
                        ++minY;
                    }
                }
                pointsBorder.Add(e.Location);
                if (pointsBorder.Count < 3) return;
                pictureBox1.Refresh();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            original = (Bitmap)Bitmap.FromFile(ppath);
            pictureBox1.Image = original;
            g = Graphics.FromImage(pictureBox1.Image);
            if (!isPart2)
                guideline.Text = "Обведите область заливки...";
            else
                guideline.Text = "Введите путь к файлу заливки...";
            this.Refresh();
        }
    }

    public struct PixelData
    {
        public byte blue;
        public byte green;
        public byte red;
    }
}
