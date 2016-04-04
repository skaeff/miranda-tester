using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Automation;
using System.Runtime.InteropServices;
using System.Threading;

namespace BitmapTester
{
    public partial class ElementFinder : Form
    {
        [DllImport("oleacc.dll", EntryPoint = "AccessibleObjectFromPoint", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int AccessibleObjectFromPoint(Point pt, ref Accessibility.IAccessible ppacc, ref object pvarChild);//(IntPtr hWnd);

        TestDesigner _parent;
        public ElementFinder(TestDesigner form)
        {
            InitializeComponent();
            _parent = form;
            var pt = Cursor.Position;
            windowFinder1.CoordsChanged += new EventHandler<MouseEventArgs>(windowFinder1_CoordsChanged);
            windowFinder1.StartSelect += new EventHandler(windowFinder1_StartSelect);
            windowFinder1.EndSelect += new EventHandler(windowFinder1_EndSelect);
        }

        void windowFinder1_EndSelect(object sender, EventArgs e)
        {
            //if (cbHideForm.Checked)
            //{
            //    Show();
            //}
        }

        void windowFinder1_StartSelect(object sender, EventArgs e)
        {
            //if (cbHideForm.Checked)
            //{
            //    Hide();
            //}
        }

        void windowFinder1_CoordsChanged(object sender, MouseEventArgs e)
        {
            lblCoords.Text = e.X + "," + e.Y;
            /*
            Accessibility.IAccessible acc = null;
            object obj = new object();
            AccessibleObjectFromPoint(new Point(e.X, e.Y), ref acc, ref obj);
            //*/

            var el = AutomationElement.FromPoint(new System.Windows.Point(e.X, e.Y));
            lblObjectName.Text = el.Current.Name;
            lblObjectRect.Text = el.Current.BoundingRectangle.ToString();
            var r = el.Current.BoundingRectangle;

            Rect = new Rectangle((int)r.X, (int)r.Y, (int)r.Width, (int)r.Height);
            CheckString = el.Current.Name;
        }

        public Rectangle Rect;
        public string CheckString;
        private void ElementFinder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Thread.Sleep(1000);
            var bmp = Utils.GetScreenshot();
            _parent.Screen = bmp;
            _parent.Show();
            _parent.BringToFront();
            _parent.Activate();
            
            _parent.Rect = Rect;
            _parent.UIAutoText = CheckString;
        }
    }
}
