using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab3
{
    public partial class Task1 : Form
    {
        private Pen borderPen = new Pen(Color.FromArgb(0, 0, 0));
        private Color fillColor = Color.FromArgb(50, 50, 50);
        private Color paintedСolor;
        //private bool createBorder = false;
        private Point startPixel;
        private Bitmap original;
        private Graphics g;
        private Point[] pointsBorder;
        private ZoomingParametrs zoomingParametrs;

        public Task1(string path)
        {
            InitializeComponent();
            original = (Bitmap)Bitmap.FromFile(path);
            pictureBox1.Image = original;
          //  pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            g = Graphics.FromImage(pictureBox1.Image);
            zoomingParametrs = new ZoomingParametrs(pictureBox1.Image.Size, pictureBox1.ClientSize);
        }

        private void Part1_Click(object sender, EventArgs e)
        {
            part1.BackColor = Color.DimGray;
            part2.BackColor = Color.Silver;
        }

        private void Part2_Click(object sender, EventArgs e)
        {
            part1.BackColor = Color.Silver;
            part2.BackColor = Color.DimGray;
        }

        private void SetFillColor_Click(object sender, EventArgs e)
        {
            fillColor = Color.FromArgb(int.Parse(rFill.Text), int.Parse(gFill.Text), int.Parse(bFill.Text));
            //if (!createBorder)
            //{
            //    guideline.Text = "Выделите границу!";
            //    return;
            //}
            //if (startPixel == null)
            //{
            //    guideline.Text = "Выберите начальный пиксель";
            //    return;
            //}
            //FirstPartFilling();
        }

        void FindBorder(int currPoint,ref List<IGrouping<int, Point>> pl)
        {
            List<Point> l = new List<Point>();
            //  var pl = pointsBorder.ToList().GroupBy(p => p.Y);

            //   foreach (var gr in pl)
            // {
            IEnumerable<IGrouping<int, Point>> t;
            if ((t = pl.Where(x => x.Key == currPoint)).Count() != 0)
            {
                var item = t.First().ToList().OrderBy(p => p.X).Distinct().ToList();
                pl.Remove(pl.Where(x => x.Key == currPoint).First());
                for (int i = 0; i < item.Count() - 1; i++)
                {
                    var pp = item[i];
                    pp.X++;
                    var lastp = pp;
                    while (pp.X < pictureBox1.Width && pp.Y < pictureBox1.Height && pp != item.ToList()[i + 1])
                    {
                        var c = ((Bitmap)pictureBox1.Image).GetPixel(pp.X, pp.Y);
                        if (c != paintedСolor)
                        {
                            l.Add(pp);
                            g.DrawLine(new Pen(fillColor), lastp, new Point(pp.X - 1, pp.Y));
                            while (pp.X < pictureBox1.Width && pp.Y < pictureBox1.Height &&
                                ((Bitmap)pictureBox1.Image).GetPixel(pp.X, pp.Y) != paintedСolor && pp != item.ToList()[i + 1])
                                pp.X++;
                            if (pp.X < pictureBox1.Width && pp.Y < pictureBox1.Height && ((Bitmap)pictureBox1.Image).GetPixel(pp.X, pp.Y) == paintedСolor)
                            {
                                l.Add(new Point(pp.X - 1, pp.Y));
                                lastp = pp;
                            }
                        }
                        pp.X++;
                    }
                    g.DrawLine(new Pen(fillColor), lastp, new Point(pp.X - 1, pp.Y));
                    pictureBox1.Refresh();
                }
            }
            var succ = pl.Where(p=>p.Key > currPoint);
            if (succ.Count() != 0)
                FindBorder(succ.First().Key, ref pl);
            var pred = pl.Where(p => p.Key < currPoint);
            if (pred.Count() != 0)
                FindBorder(pred.Last().Key, ref pl);
        }

        private void FirstPartFilling()
        {
            Point currPoint = startPixel;
            var pl = pointsBorder.ToList().GroupBy(p => p.Y).OrderBy(p=>p.Key).ToList();
            FindBorder(currPoint.Y, ref pl);
            pictureBox1.Refresh();
            //throw new NotImplementedException();
        }

        private void SetColorBorder_Click(object sender, EventArgs e)
        {
            borderPen = new Pen(Color.FromArgb(int.Parse(rBorder.Text), int.Parse(gBorder.Text), int.Parse(bBorder.Text)));
        }

        void pictureBox1_MainPaint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void pictureBox1_BorderPaint(object sender, PaintEventArgs e)
        {
            g.DrawCurve(borderPen, pointsBorder);
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
                FirstPartFilling();
                guideline.Text = "Все готово!";
            }
            //else if (guideline.Text == "Выберите стартовый пиксель заливки...")
            //{
            //    pictureBox1.Paint -= pictureBox1_FillPaint;
            //    pictureBox1.Paint += pictureBox1_MainPaint;
            //    guideline.Text = "Все готово!";
            //}
        }

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (guideline.Text == "Обведите область заливки...")
            {
                pictureBox1.Paint -= pictureBox1_MainPaint;
                pictureBox1.Paint += pictureBox1_BorderPaint;
                pointsBorder = new Point[1] { e.Location };//zoomingParametrs.ConvertPointForPictureBox(pictureBox1.PointToClient(Cursor.Position)) }; 
            }
            else if (guideline.Text == "Выберите стартовый пиксель заливки...")
            {
                pictureBox1.Paint -= pictureBox1_MainPaint;
                pictureBox1.Paint += pictureBox1_FillPaint;
                startPixel = e.Location;//zoomingParametrs.ConvertPointForPictureBox(pictureBox1.PointToClient(Cursor.Position));
                paintedСolor = ((Bitmap)pictureBox1.Image).GetPixel(startPixel.X, startPixel.Y);// ((Bitmap)pictureBox1.Image).GetPixel(Cursor.Position.X, Cursor.Position.Y); 
                var j = ((Bitmap)pictureBox1.Image).GetPixel(startPixel.X, startPixel.Y);
            }
        }

        private void pictureBox1_FillPaint(object sender, PaintEventArgs e)
        {
            FirstPartFilling();
        }

        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (guideline.Text == "Обведите область заливки..." && e.Button == MouseButtons.Left)
            {
                Array.Resize<Point>(ref pointsBorder, pointsBorder.Length + 1);
                pointsBorder[pointsBorder.Length - 1] = e.Location;//zoomingParametrs.ConvertPointForPictureBox(pictureBox1.PointToClient(Cursor.Position));
                if (pointsBorder.Length < 3) return;
                pictureBox1.Refresh();
            }
        }

        class ZoomingParametrs
        {
            private int widthImage;
            private int heightImage;
            private int widthContainer;
            private int heightContainer;
            private float imageRatio;
            private float containerRatio;

            public ZoomingParametrs(Size imageSize, Size containerSize)
            {
                widthImage = imageSize.Width;
                heightImage = imageSize.Height;
                widthContainer = containerSize.Width;
                heightContainer = containerSize.Height;
                imageRatio = widthImage / (float)heightImage; // image W:H ratio
                containerRatio = widthContainer / (float)heightContainer; // container W:H ratio
            }

            public Point ConvertPointForPictureBox(Point p)
            {
              ///  Point p = pictureBox1.PointToClient(point);
                Point unscaled_p = new Point();

                if (imageRatio >= containerRatio)
                {
                    // horizontal image
                    float scaleFactor = widthContainer / (float)widthImage;
                    float scaledHeight = heightImage * scaleFactor;
                    // calculate gap between top of container and top of image
                    float filler = Math.Abs(heightContainer - scaledHeight) / 2;
                    unscaled_p.X = (int)(p.X / scaleFactor);
                    unscaled_p.Y = (int)((p.Y - filler) / scaleFactor);
                }
                else
                {
                    // vertical image
                    float scaleFactor = heightContainer / (float)heightImage;
                    float scaledWidth = widthImage * scaleFactor;
                    float filler = Math.Abs(widthContainer - scaledWidth) / 2;
                    unscaled_p.X = (int)((p.X - filler) / scaleFactor);
                    unscaled_p.Y = (int)(p.Y / scaleFactor);
                }
                return unscaled_p;
            }
        }
        //void FillWithColor(Color color)
        //{
        //    Bitmap bmp;
        //    if (pictureBox1.Image != null)
        //        bmp = new Bitmap(pictureBox1.Image);
        //    else
        //        bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        //    using (Graphics g = Graphics.FromImage(bmp))
        //    {
        //        g.FillPath(new SolidBrush(color), selectionBorder);
        //    }
        //    pictureBox1.Image = bmp;
        //}
    }
}
