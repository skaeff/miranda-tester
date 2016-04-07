using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Tesseract;
using System.Diagnostics;
using AForge.Imaging.Filters;

namespace BitmapTester
{
    public partial class AllRecognizer : Form
    {
        private TesseractEngine _engineRus;
        private TesseractEngine _engineEng;
        public AllRecognizer()
        {
            InitializeComponent();
            _engineRus = new TesseractEngine(@"./tessdata", "rus", EngineMode.Default);
            _engineEng = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool _recognizeRect = false;
        private void btnRecognize_Click(object sender, EventArgs e)
        {
            //pbScreen.ClientSize
            if (pbScreen.Image == null)
            {
                MessageBox.Show("No screenshot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Rect == null || Rect.Width == 0 || Rect.Height == 0)
            {
                MessageBox.Show("No rectangle selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (WindowState != FormWindowState.Maximized)
            {
                MessageBox.Show("Works only in Fullscreen. Use 'Fullscreen' button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _recognizeRect = true;
            var lines = new List<string>();


            var bmp = Utils.GetArea(pbScreen.Image as Bitmap, Rect);

            Bitmap tmp;
            float tr;
            if (rbEnglish.Checked)
                lines = RecognizeEnText(bmp, out tmp, out tr, int.Parse(tbMagnify.Text));
            else
                lines = RecognizeRuText(bmp, out tmp, out tr, int.Parse(tbMagnify.Text));

            lbRecognizedRects.Items.Clear();
            lbRecognizedRects.Items.AddRange(lines.ToArray());
            
        }

        public List<string> RecognizeText(Bitmap source, out Bitmap temp, TesseractEngine engine, out float threshold, int magnifyNumber)
        {
            threshold = 0;
            temp = source.Clone() as Bitmap; //Clone image to keep original image
            try
            {
                var seq = new FiltersSequence();

                var n = magnifyNumber;//10;// _magnifyNumber;

                /*
                {
                    seq.Add(Grayscale.CommonAlgorithms.RMY);
                    seq.Add(new ResizeBilinear(source.Width * n, source.Height * n));
                }
                //*/
                //*
                {
                    seq.Add(new ResizeBilinear(source.Width * (n), source.Height * n));

                    seq.Add(new Grayscale(0.2126, 0.7152, 0.0722));
                    //seq.Add(Grayscale.CommonAlgorithms.RMY);
                    seq.Add(new OtsuThreshold());
                    //seq.Add(new SISThreshold());
                    seq.Add(new Threshold(100));

                    //seq.Add(new HistogramEqualization());
                    //seq.Add(new Invert());
                    //seq.Add(new ResizeNearestNeighbor(source.Width * _magnifyNumber, source.Height * _magnifyNumber));
                    //seq.Add(new ResizeBicubic(source.Width * _magnifyNumber, source.Height * _magnifyNumber));
                }
                //*/


                temp = seq.Apply(source); // Apply filters on source image

                var lines = new List<string>();
                using (var page = engine.Process(temp, PageSegMode.AutoOnly))
                {
                    var iter = page.GetIterator();
                    iter.Begin();
                    do
                    {
                        var text = iter.GetText(PageIteratorLevel.Block);
                        if (string.IsNullOrEmpty(text))
                            text = "";
                        else
                            text = text.Trim();

                        Rect rc = new Rect();
                        var rectStr = "";
                        if (iter.TryGetBoundingBox(PageIteratorLevel.Block, out rc))
                        {
                            int x1 = rc.X1;
                            int y1 = rc.Y1;
                            if (_recognizeRect)
                            {
                                x1 = x1 + Rect.X * n;
                                y1 = y1 + Rect.Y * n;
                            }
                            rectStr = "{" + x1 + "," + y1 + "," + rc.Width + "," + rc.Height + "}";
                        }
                        else
                        {
                            rectStr = "{0,0,0,0}";
                        }
                        lines.Add(text + rectStr);
                    } while (iter.Next(PageIteratorLevel.Block));
                    
                    iter.Dispose();
                }

                return lines;

            }
            catch (Exception e)
            {
                Trace.TraceError(e.ToString());
                //Ex.Report(e);
                return new List<string>();
            }
        }
        public List<string> RecognizeRuText(Bitmap source, out Bitmap temp, out float threshold, int magnifyNumber)
        {
            return RecognizeText(source, out temp, _engineRus, out threshold, magnifyNumber);
        }
        public List<string> RecognizeEnText(Bitmap source, out Bitmap temp, out float threshold, int magnifyNumber)
        {
            return RecognizeText(source, out temp, _engineEng, out threshold, magnifyNumber);
        }

        private void btnPrintScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(1000);
            var bmp = Utils.GetScreenshot();
            pbScreen.Image = bmp;

            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;

            Show();
            Activate();

        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
        }

        bool clicked = false;
        private int iOldX;
        private int iOldY;
        private int iClickX;
        private int iClickY;
        private Point ConvertFromChildToForm(int x, int y, Control control)
        {
            Point p = new Point(x, y);
            control.Location = p;
            return p;
        }
        private void pnToolWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = ConvertFromChildToForm(e.X, e.Y, pnToolWindow);
                iOldX = p.X;
                iOldY = p.Y;
                iClickX = e.X;
                iClickY = e.Y;
                clicked = true;
            }
        }

        private void pnToolWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                Point p = new Point(); // New Coordinate
                p.X = e.X + pnToolWindow.Left;
                p.Y = e.Y + pnToolWindow.Top;
                pnToolWindow.Left = p.X - iClickX;
                pnToolWindow.Top = p.Y - iClickY;
            }
        }

        private void pnToolWindow_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }


        private Point RectStartPoint;
        public Rectangle Rect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        private void pbScreen_Paint(object sender, PaintEventArgs e)
        {
            // Draw the rectangle...
            if (pbScreen.Image != null)
            {
                if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                {
                    e.Graphics.FillRectangle(selectionBrush, Rect);
                }
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void lbRecognizedRects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbRecognizedRects.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                DisplayItem();
            }
        }

        private void lbRecognizedRects_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayItem();
        }

        void DisplayItem()
        {
            var txt = lbRecognizedRects.SelectedItem.ToString();

            tbRecognizedText.Text = txt;

            txt = Reverse(txt);
            txt = txt.Substring(0, txt.IndexOf('{'));
            txt = Reverse(txt);
            txt = txt.Substring(0, txt.Length - 1);
            var data = txt.Split(',');

            int n = int.Parse(tbMagnify.Text);
            var rect = new Rectangle(int.Parse(data[0]) / n, int.Parse(data[1]) / n, int.Parse(data[2]) / n, int.Parse(data[3]) / n);

            
            Rect = rect;

            lblRect.Text = Rect.ToString();
            //MessageBox.Show(lbRecognizedRects.SelectedItem.ToString());
            Invalidate();
            pbScreen.Invalidate();
            pbScreen.Refresh();
        }

        private void pbScreen_MouseDown(object sender, MouseEventArgs e)
        {
            // Determine the initial rectangle coordinates...
            RectStartPoint = e.Location;
            Invalidate();
        }

        private void pbScreen_MouseMove(object sender, MouseEventArgs e)
        {
            //if (cbZoom.Checked)
            //    UpdateZoomedImage(e);

            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
            pbScreen.Invalidate();

            lblRect.Text = Rect.ToString();
        }

        private void btnRecognizeAll_Click(object sender, EventArgs e)
        {
            if (pbScreen.Image == null)
            {
                MessageBox.Show("No screenshot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _recognizeRect = false;
            var lines = new List<string>();

            Bitmap tmp;
            float tr;
            if (rbEnglish.Checked)
                lines = RecognizeEnText(pbScreen.Image as Bitmap, out tmp, out tr, int.Parse(tbMagnify.Text));
            else
                lines = RecognizeRuText(pbScreen.Image as Bitmap, out tmp, out tr, int.Parse(tbMagnify.Text));

            lbRecognizedRects.Items.Clear();
            lbRecognizedRects.Items.AddRange(lines.ToArray());
            
        }

    }
}
