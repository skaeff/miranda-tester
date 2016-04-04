using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;

namespace BitmapTester
{
    public class Utils
    {
        public static Bitmap GetScreenshot()
        {

            Bitmap bmpScreenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                            Screen.PrimaryScreen.Bounds.Height);
            
            using (Graphics g = Graphics.FromImage(bmpScreenCapture))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                    Screen.PrimaryScreen.Bounds.Y,
                                    0, 0,
                                    bmpScreenCapture.Size,
                                    CopyPixelOperation.SourceCopy);
            }

            return bmpScreenCapture;
            
            
        }

        public static Bitmap GetAreaFromScreen(Rectangle area)
        {
            Thread.Sleep(0);

            var rect = new Rectangle(area.X, area.Y, area.Width, area.Height);

            var bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
           

            using (var g = Graphics.FromImage(bmp))
                g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);

            return bmp;
        }

        public static Bitmap GetArea(Bitmap bmp, Rectangle rect)
        {
            //var newBmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            //Graphics g = Graphics.FromImage(bmp);

            var crop = new Crop(rect);
            var newBmp = crop.Apply(bmp);
            return newBmp;
        }

        public static Bitmap CropImage(Bitmap source, Rectangle section)
        {
            // An empty bitmap which will hold the cropped image
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(source, section.X, section.Y, section, GraphicsUnit.Pixel);

            return bmp;
        }

    }
}
