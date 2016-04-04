using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace WindowFinder
{
    [DefaultEvent("WindowHandleChanged")]
    [ToolboxBitmap(typeof(ResourceFinder), "WindowFinder.Resources.WindowFinder.bmp")]
    //[Designer(typeof(WindowFinderDesigner))]
    public sealed partial class WindowFinder : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowFinder"/> class.
        /// </summary>
        public WindowFinder()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            SetStyle(ControlStyles.FixedWidth, true);
            SetStyle(ControlStyles.FixedHeight, true);
            SetStyle(ControlStyles.StandardClick, false);
            SetStyle(ControlStyles.StandardDoubleClick, false);
            SetStyle(ControlStyles.Selectable, false);

            picTarget.Size = new Size(31, 28);
            Size = picTarget.Size;
        }
        public event EventHandler<MouseEventArgs> CoordsChanged;
        public event EventHandler StartSelect;
        public event EventHandler EndSelect;

        #region Event Handler Methods

        /// <summary>
        /// Handles the Load event of the WindowFinder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void WindowFinder_Load(object sender, System.EventArgs e)
        {
            this.Size = picTarget.Size;
            try
            {
                // Load cursors
                Assembly assembly = Assembly.GetExecutingAssembly();
                cursorTarget = new Cursor(assembly.GetManifestResourceStream("WindowFinder.curTarget.cur"));
                bitmapFind = new Bitmap(assembly.GetManifestResourceStream("WindowFinder.bmpFind.bmp"));
                bitmapFinda = new Bitmap(assembly.GetManifestResourceStream("WindowFinder.bmpFinda.bmp"));
            }
            catch(Exception x)
            {
                // Show error
                MessageBox.Show(this, "Failed to load resources.\n\n" + x.ToString(), "WindowFinder");

                // Attempt to use backup cursor
                if(cursorTarget == null)
                    cursorTarget = Cursors.Cross;
            }


            // Set default values
            picTarget.Image = bitmapFind;
        }

        /// <summary>
        /// Handles the MouseDown event of the picTarget control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void picTarget_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (StartSelect != null)
                StartSelect(this, EventArgs.Empty);

            // Set capture image and cursor
            picTarget.Image = bitmapFinda;
            picTarget.Cursor = cursorTarget;

            // Set capture
            Win32.SetCapture(picTarget.Handle);

            // Begin targeting
            isTargeting = true;
            targetWindow = IntPtr.Zero;
        }

        /// <summary>
        /// Handles the MouseMove event of the picTarget control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void picTarget_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Win32.POINTAPI pt;

            // TODO: Draw border around EVERY window

            pt.x = e.X;
            pt.y = e.Y;
            Win32.ClientToScreen(picTarget.Handle, ref pt);

            // Make sure targeting before highlighting windows
            if(!isTargeting)
                return;

            X = e.X;
            Y = e.Y;

            if (CoordsChanged != null)
                CoordsChanged(this, new MouseEventArgs(MouseButtons.None, 0, pt.x, pt.y, 0));
        }

        /// <summary>
        /// Handles the MouseUp event of the picTarget control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void picTarget_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            IntPtr hWnd;
            IntPtr hTemp;

            // End targeting
            isTargeting = false;

            // Unhighlight window
            if(targetWindow != IntPtr.Zero)
                Win32.HighlightWindow(targetWindow);
            targetWindow = IntPtr.Zero;

            // Reset capture image and cursor
            picTarget.Cursor = Cursors.Default;
            picTarget.Image = bitmapFind;

            // Get screen coords from client coords and window handle
            X = e.X;
            Y = e.Y;


            Win32.POINTAPI pt;

            pt.x = e.X;
            pt.y = e.Y;
            Win32.ClientToScreen(picTarget.Handle, ref pt);

            if (CoordsChanged != null)
                CoordsChanged(this, new MouseEventArgs(MouseButtons.None, 0, pt.x, pt.y, 0));

            // Release capture
            Win32.SetCapture(IntPtr.Zero);

            if (EndSelect != null)
                EndSelect(this, EventArgs.Empty);
        }

        #endregion


        public int X;
        public int Y;
        private bool isTargeting = false;
        private Cursor cursorTarget = null;
        private Bitmap bitmapFind = null;
        private Bitmap bitmapFinda = null;
        private IntPtr targetWindow = IntPtr.Zero;
        private IntPtr windowHandle = IntPtr.Zero;
        private string windowHandleText = string.Empty;
        private string windowClass = string.Empty;
        private string windowText = string.Empty;
        private bool isWindowUnicode = false;
        private string windowCharset = string.Empty;
    }
}
