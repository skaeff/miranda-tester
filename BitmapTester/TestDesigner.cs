using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Automation;

namespace BitmapTester
{
    public partial class TestDesigner : Form
    {
        private double ZOOMFACTOR = 1.25;
        private int MINMAX = 5;				
        private int _ZoomFactor;
        private Color _BackColor = Color.Black;

        #region Zooming Methods

        /// <summary>
        /// Make the PictureBox dimensions larger to effect the Zoom.
        /// </summary>
        /// <remarks>Maximum 5 times bigger</remarks>
        private void ZoomIn(PictureBox box, Panel panel)
        {
            if ((box.Width < (MINMAX * panel.Width)) &&
                (box.Height < (MINMAX * panel.Height)))
            {
                box.Width = Convert.ToInt32(box.Width * ZOOMFACTOR);
                box.Height = Convert.ToInt32(box.Height * ZOOMFACTOR);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// Make the PictureBox dimensions smaller to effect the Zoom.
        /// </summary>
        /// <remarks>Minimum 5 times smaller</remarks>
        private void ZoomOut(PictureBox box, Panel panel)
        {
            if ((box.Width > (panel.Width / MINMAX)) &&
                (box.Height > (panel.Height / MINMAX)))
            {
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Width = Convert.ToInt32(box.Width / ZOOMFACTOR);
                box.Height = Convert.ToInt32(box.Height / ZOOMFACTOR);
            }
        }

        #endregion

        public TestDesigner(MainForm parent)
        {
            InitializeComponent();
            cbActionType.DataSource = Enum.GetValues(typeof(Action));
            cbActionType.SelectedIndex = 0;
            _mainForm = parent;

            _ZoomFactor = tbZoomScale.Value;
            cbZoom.Checked = true;
            
        }

        MainForm _mainForm;

        public Bitmap Screen
        {
            get { return pbScreen.Image as Bitmap; }
            set { pbScreen.Image = value; }
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

        private void pbScreen_MouseDown(object sender, MouseEventArgs e)
        {
            // Determine the initial rectangle coordinates...
            RectStartPoint = e.Location;
            Invalidate();
        }

        private void UpdateZoomedImage(MouseEventArgs e)
        {
            if (pbScreen.Image == null)
                return;

            // Calculate the width and height of the portion of the image we want
            // to show in the picZoom picturebox. This value changes when the zoom
            // factor is changed.
            int zoomWidth = picZoom.Width / _ZoomFactor;
            int zoomHeight = picZoom.Height / _ZoomFactor;


            // Calculate the horizontal and vertical midpoints for the crosshair
            // cursor and correct centering of the new image
            int halfWidth = zoomWidth / _ZoomFactor;
            int halfHeight = zoomHeight / _ZoomFactor;

            // Create a new temporary bitmap to fit inside the picZoom picturebox
            Bitmap tempBitmap = new Bitmap(zoomWidth, zoomHeight, PixelFormat.Format24bppRgb);

            // Create a temporary Graphics object to work on the bitmap
            Graphics bmGraphics = Graphics.FromImage(tempBitmap);

            // Clear the bitmap with the selected backcolor
            bmGraphics.Clear(_BackColor);

            // Set the interpolation mode
            bmGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw the portion of the main image onto the bitmap
            // The target rectangle is already known now.
            // Here the mouse position of the cursor on the main image is used to
            // cut out a portion of the main image.

            //var image = GetAreaFromScreen(pictureBox1.ClientRectangle);
            //bmGraphics.DrawImage(image,
            //                     new Rectangle(0, 0, zoomWidth, zoomHeight),
            //                     new Rectangle(e.X - halfWidth, e.Y - halfHeight, zoomWidth, zoomHeight),
            //                     GraphicsUnit.Pixel);


            bmGraphics.DrawImage(pbScreen.Image,
                                 new Rectangle(0, 0, zoomWidth, zoomHeight),
                                 new Rectangle(e.X - halfWidth, e.Y - halfHeight, zoomWidth, zoomHeight),
                                 GraphicsUnit.Pixel);

            // Draw the bitmap on the picZoom picturebox
            picZoom.Image = tempBitmap;

            // Draw a crosshair on the bitmap to simulate the cursor position
            //bmGraphics.DrawLine(Pens.White, halfWidth + 1, halfHeight - 4, halfWidth + 1, halfHeight - 1);
            //bmGraphics.DrawLine(Pens.White, halfWidth + 1, halfHeight + 6, halfWidth + 1, halfHeight + 3);
            //bmGraphics.DrawLine(Pens.White, halfWidth - 4, halfHeight + 1, halfWidth - 1, halfHeight + 1);
            //bmGraphics.DrawLine(Pens.White, halfWidth + 6, halfHeight + 1, halfWidth + 3, halfHeight + 1);

            bmGraphics.DrawLine(Pens.DarkRed, halfWidth, 0, halfWidth, halfHeight * _ZoomFactor);
            bmGraphics.DrawLine(Pens.DarkRed, 0, halfHeight, halfWidth * _ZoomFactor, halfHeight);

            //bmGraphics.DrawLine(Pens.White, zoomWidth, 0, zoomWidth, zoomHeight * 2);
            //bmGraphics.DrawLine(Pens.White, 0, zoomHeight, zoomWidth * 2, zoomHeight);
            //bmGraphics.DrawLine(Pens.White, halfWidth - 4, halfHeight + 1, halfWidth - 1, halfHeight + 1);
            //bmGraphics.DrawLine(Pens.White, halfWidth + 6, halfHeight + 1, halfWidth + 3, halfHeight + 1);

            ////Draw rectangle
            //if (e.Button != MouseButtons.Left)
            //{
            //    _startPoint = Point.Empty;
            //    _startPoint.X = e.X;
            //    _startPoint.Y = e.Y;
            //}

            //if (e.Button == MouseButtons.Left)
            //{
            //    var currentPoint = Point.Empty;
            //    currentPoint.X = e.X;
            //    currentPoint.Y = e.Y;

            //    var begPoint = Point.Empty;

            //    if (currentPoint.X - _startPoint.X > picZoom.Width)
            //        begPoint.X = 0;
            //    else
            //        begPoint.X = currentPoint.X - _startPoint.X;

            //    if (currentPoint.Y - _startPoint.Y > picZoom.Height/2)
            //        begPoint.Y = 0;
            //    else
            //        begPoint.Y = currentPoint.Y - _startPoint.Y;

            //    var rect = new Rectangle(begPoint, new Size(picZoom.Width / 2, picZoom.Height/2));
            //    if (rect != Rectangle.Empty && rect.Width > 0 && rect.Height > 0)
            //    {
            //        bmGraphics.FillRectangle(selectionBrush, rect);
            //    }
            //}

            //if (pictureBox1.Image != null)
            //{
            //    if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
            //    {
            //        bmGraphics.FillRectangle(selectionBrush, Rect);
            //    }
            //}

            // Dispose of the Graphics object
            bmGraphics.Dispose();

            // Refresh the picZoom picturebox to reflect the changes
            picZoom.Refresh();
        }

        private void pbScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (cbZoom.Checked)
                UpdateZoomedImage(e);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnAddStep_Click(object sender, EventArgs e)
        {
            string msg;
            if (!ValidateInput(out msg))
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var parent = trSteps.SelectedNode;
            TreeNodeCollection nodes = null;
            if (parent == null)
                nodes = trSteps.Nodes[0].Nodes;
            else
                nodes = parent.Nodes;

            if (tabControl1.SelectedTab.Text == "Check")
            {
                var step = new CheckStep();
                step.Rect = Rect;
                step.Name = tbStepName.Text;
                step.Check = tbCheckText.Text;
                step.Screenshot = (pbScreen.Image as Bitmap).Clone() as Bitmap;

                step.IsEng = rbEnglish.Checked;

                step.setting.magnify = int.Parse(tbMagnify.Text);
                step.setting.widthIncrease = int.Parse(tbWidthIncrease.Text);
                step.setting.heightIncrease = int.Parse(tbHeightIncrease.Text);

                var node = new TreeNode(step.Name);
                node.Tag = step;
                nodes.Add(node);
            }
            if (tabControl1.SelectedTab.Text == "Action")
            {
                var step = new ActionStep();
                step.Rect = Rect;
                step.Name = tbStepName.Text;
                
                Action status;
                Enum.TryParse<Action>(cbActionType.SelectedValue.ToString(), out status);
                step.Action = status;

                step.Screenshot = (pbScreen.Image as Bitmap).Clone() as Bitmap;

                var node = new TreeNode(step.Name);
                node.Tag = step;
                nodes.Add(node);
            }
            if (tabControl1.SelectedTab.Text == "Condition")
            {
                var step = new ConditionStep();
                step.Rect = Rect;
                step.Name = tbStepName.Text;

                step.Screenshot = (pbScreen.Image as Bitmap).Clone() as Bitmap;

                var node = new TreeNode(step.Name);
                node.Tag = step;
                nodes.Add(node);
            }

            tbCheckText.Text = string.Empty;
            tbStepName.Text = string.Empty;

            trSteps.ExpandAll();
        }

        private bool ValidateInput(out string msg)
        {
            msg = "";
            if (string.IsNullOrEmpty(tbStepName.Text))
            {
                msg = "Step name is empty!";
                return false;
            }

            if (tabControl1.SelectedTab.Text == "Check")
            {    
                if (string.IsNullOrEmpty(tbCheckText.Text))
                {
                    msg = "Check string is empty!";
                    return false;
                }
            }
            if (tabControl1.SelectedTab.Text == "Action")
            {
            }

            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var steps = new StepCollection();
            

            foreach (TreeNode node in trSteps.Nodes[0].Nodes)
            {
                if (node.Tag != null)
                {
                    var step = node.Tag as Step;
                    step.Collection = new List<Step>();

                    AddSteps(node, step.Collection);
                    steps.Collection.Add(step);
                }
                
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(StepCollection), new Type[] { typeof(Step), typeof(ConditionStep), typeof(ActionStep), typeof(CheckStep) });
            StringWriter stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, steps);

            string xml = stringWriter.ToString();
            var file = Application.StartupPath + @"\steps.xml";
            File.WriteAllText(file, xml);
        }

        private void AddSteps(TreeNode root, List<Step> list)
        {
            foreach (TreeNode node in root.Nodes)
            {
                if (node.Tag != null)
                {
                    var step = node.Tag as Step;
                    step.Collection = new List<Step>();
                    AddSteps(node, step.Collection);
                    list.Add(step);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //*
            var file = Application.StartupPath + @"\steps.xml";
            var serializedData = File.ReadAllText(file);

            var xmlSerializer =  new XmlSerializer(typeof(StepCollection), new Type[] { typeof(Step), typeof(ConditionStep), typeof(ActionStep), typeof(CheckStep) });
            var stringReader = new StringReader(serializedData);
            StepCollection steps = (StepCollection)xmlSerializer.Deserialize(stringReader);
            //*/

            trSteps.Nodes.Clear();
            var nodeRoot = trSteps.Nodes.Add("start");

            foreach (var step in steps.Collection)
            {
                var node = new TreeNode(step.Name);
                node.Tag = step;
                
                if (step.Collection.Count > 0)
                {
                    AddNodes(node, step.Collection);
                }
                (node.Tag as Step).Collection.Clear();
                nodeRoot.Nodes.Add(node);
            }

            trSteps.ExpandAll();
        }

        private void AddNodes(TreeNode root, List<Step> list)
        {
            foreach (var step in list)
            {
                var node = new TreeNode(step.Name);
                node.Tag = step;

                if (step.Collection.Count > 0)
                {
                    AddNodes(node, step.Collection);
                }
                (node.Tag as Step).Collection.Clear();
                root.Nodes.Add(node);
            }
        }

        private void trSteps_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var menuItem = trSteps.SelectedNode;

            if (menuItem != null && menuItem.Tag != null)
            {
                var step = menuItem.Tag as Step;

                pbScreen.Image = step.Screenshot;
                tbStepName.Text = step.Name;
                Rect = step.Rect;
                lblRect.Text = Rect.ToString();

                switch (step.Type)
                {
                    case StepType.Action:
                        break;
                    case StepType.Check:
                        tbCheckText.Text = (step as CheckStep).Check;
                        break;
                    case StepType.Condition:
                        break;
                }
            }
        }

        private void TestDesigner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            trSteps.Nodes.Clear();
            var nodeRoot = trSteps.Nodes.Add("start");
            Rect = new Rectangle();

            tbCheckText.Text = string.Empty;
            tbStepName.Text = string.Empty;
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            if (Rect != null && Rect.Width > 0 && Rect.Height > 0 && Screen != null)
            {
                string recognized;
                Bitmap tmp;
                float threshold;

                var bmp = Utils.GetArea(Screen, Rect);
                var setting = new RecognizeSetting();

                setting.magnify = int.Parse(tbMagnify.Text);
                setting.widthIncrease = int.Parse(tbWidthIncrease.Text);
                setting.heightIncrease = int.Parse(tbHeightIncrease.Text);

                if (rbEnglish.Checked)
                    recognized = _mainForm.RecognizeEnText(bmp, out tmp, out threshold, setting);
                else
                    recognized = _mainForm.RecognizeRuText(bmp, out tmp, out threshold, setting);

                tbRecognizedText.Text = (string.IsNullOrEmpty(recognized) ? "" : recognized).Trim();
                pbRecognize.Image = tmp;
                lblThreshold.Text = threshold.ToString();
            }
        }

        private void tbZoomScale_ValueChanged(object sender, EventArgs e)
        {
            _ZoomFactor = tbZoomScale.Value;
            tbZoomScale.Text = string.Format("x{0}", _ZoomFactor);
        }

        private void btnChooseElement_Click(object sender, EventArgs e)
        {
            var f = new ElementFinder(this);
            f.Show();
            Hide();
            
        }

        public string UIAutoText
        {
            get { return tbUIAutoText.Text; }
            set { tbUIAutoText.Text = value; lblRect.Text = Rect.ToString(); }
        }

       
        
    }
}
