using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tesseract;
using AForge.Imaging.Filters;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Serialization;
using System.IO;

namespace BitmapTester
{
    public partial class MainForm : Form
    {
        KeyboardHook hook = new KeyboardHook();
        int hookId;
        private TesseractEngine _engineRus;
        private TesseractEngine _engineEng;
        public MainForm()
        {
            InitializeComponent();
            //_engine = new TesseractEngine(Application.StartupPath + @"\tessdata-master", "eng", EngineMode.Default);
            _engineRus = new TesseractEngine(@"./tessdata", "rus", EngineMode.Default);
            _engineEng = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
            //_engineEng.SetVariable("tessedit_char_whitelist", ".,0123456789");

            // register the event that is fired after the key press.
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hookId = hook.RegisterHotKey(BitmapTester.ModifierKeys.Shift, Keys.Escape);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            hook.UnregisterHotKey(hookId);
        }

        TestDesigner _testDesigner;
        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            var bmp = Utils.GetScreenshot();
            if (_testDesigner == null)
                _testDesigner = new TestDesigner(this);

            _testDesigner.Screen = bmp;
            _testDesigner.FormBorderStyle = FormBorderStyle.None;
            _testDesigner.WindowState = FormWindowState.Maximized;
            _testDesigner.Show();
            _testDesigner.BringToFront();
            _testDesigner.Activate();
        }

        

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            try
            {

                var list = (ListBox)sender;

                // This is your selected item
                var item = list.SelectedItem.ToString();

                var i1 = item.Substring(item.IndexOf("{") + 1);//, item.Length);
                i1 = i1.Substring(0, i1.IndexOf("}"));

                var data = i1.Split(',');

                rect = new Rectangle(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]));
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
            IntPtr desktopPtr = GetDC(IntPtr.Zero);
            Graphics g = Graphics.FromHdc(desktopPtr);

            SolidBrush b = new SolidBrush(Color.White);
            var pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, rect);
            //g.FillRectangle(b, rect);
            

            g.Dispose();
            ReleaseDC(IntPtr.Zero, desktopPtr);
        }

        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        private void btnShowDesigner_Click(object sender, EventArgs e)
        {
            if (_testDesigner == null)
                _testDesigner = new TestDesigner(this);

            WindowState = FormWindowState.Minimized;

            _testDesigner.FormBorderStyle = FormBorderStyle.None;
            _testDesigner.WindowState = FormWindowState.Maximized;
            _testDesigner.Show();
            _testDesigner.BringToFront();
            _testDesigner.Activate();
        }

        private void btnRunTest_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            lvResult.Items.Clear();

            var file = Application.StartupPath + @"\steps.xml";
            var serializedData = File.ReadAllText(file);

            var xmlSerializer = new XmlSerializer(typeof(StepCollection), new Type[] { typeof(Step), typeof(ConditionStep), typeof(ActionStep), typeof(CheckStep) });
            var stringReader = new StringReader(serializedData);
            StepCollection steps = (StepCollection)xmlSerializer.Deserialize(stringReader);

            RunTests(steps.Collection);
            
        }

        private void RunTests(List<Step> list)
        {
            foreach (var step in list)
            {
                var bmp = Utils.GetAreaFromScreen(step.Rect);
                if (step.Type == StepType.Check)
                {
                    var recognized = "";
                    //recognized = RecognizeEnText(bmp);
                    float threshold;
                    Bitmap tmp;

                    var setting = step.setting;
                    
                    if((step as CheckStep).IsEng)
                        recognized = RecognizeEnText(bmp, out tmp, out threshold, setting);//TODO magnify
                    else
                        recognized = RecognizeRuText(bmp, out tmp, out threshold, setting);//TODO magnify
                    
                    recognized = recognized.Trim();

                    var res = new Result();
                    res.step = step;
                    res.bmpResult = bmp;
                    res.recognized = recognized;
                    res.bmpForRecognition = tmp;

                    if (recognized.ToLower() == (step as CheckStep).Check.ToLower())
                    {
                        res.passed = true;
                        var item = new ListViewItem(res.step.Name + "..." + res.passed.ToString());
                        item.Tag = res;
                        lvResult.Items.Add(item);
                        if (step.Collection.Count > 0)
                        {
                            RunTests(step.Collection);
                        }
                    }
                    else
                    {
                        res.passed = false;
                        var item = new ListViewItem(res.step.Name + "..." + res.passed.ToString());
                        item.Tag = res;
                        lvResult.Items.Add(item);
                    }
                   
                }
                if (step.Type == StepType.Action)
                {
                    UserInterop.DoMouseClick(step.Rect, (step as ActionStep).Action);
                    Thread.Sleep(1000);
                    
                    var res = new Result();
                    res.step = step;
                    res.bmpResult = bmp;
                    var item = new ListViewItem(res.step.Name + "..." + (res.step as ActionStep).Action);
                    item.Tag = res;
                    lvResult.Items.Add(item);
                    if (step.Collection.Count > 0)
                    {
                        RunTests(step.Collection);
                    }
                    
                }

            }
        }


        
        public string RecognizeText(Bitmap source, out Bitmap temp, TesseractEngine engine, out float threshold, RecognizeSetting setting)
        {
            threshold = 0;
            temp = source.Clone() as Bitmap; //Clone image to keep original image
            try
            {
                var seq = new FiltersSequence();

                /*
                {
                    seq.Add(Grayscale.CommonAlgorithms.RMY);
                    seq.Add(new ResizeBilinear(source.Width * n, source.Height * n));
                }
                //*/
                //*
                {
                    //seq.Add(new ConservativeSmoothing());
                    seq.Add(new ResizeBilinear(source.Width * (setting.magnify + setting.widthIncrease), source.Height * (setting.magnify + setting.heightIncrease)));

                    seq.Add(new Grayscale(0.2126, 0.7152, 0.0722));
                    //seq.Add(Grayscale.CommonAlgorithms.BT709);
                    
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

                using (var page = engine.Process(temp, PageSegMode.SingleLine))
                {
                    var text = page.GetText();
                    var conf = page.GetMeanConfidence();

                    threshold = conf;

                    //Ex.Report(new Exception(text));
                    //if (conf < 0.8)
                    //    return "none";
                    return text;
                }

            }
            catch (Exception e)
            {
                Trace.TraceError(e.ToString());
                //Ex.Report(e);
                return "";
            }
        }
        public string RecognizeRuText(Bitmap source, out Bitmap temp, out float threshold, RecognizeSetting magnifyNumber)
        {
            return RecognizeText(source, out temp, _engineRus, out threshold, magnifyNumber);
        }
        public string RecognizeEnText(Bitmap source, out Bitmap temp, out float threshold, RecognizeSetting magnifyNumber)
        {
            return RecognizeText(source, out temp, _engineEng, out threshold, magnifyNumber);
        }

        private void lvResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = lvResult.SelectedItems[0];
            if (item!= null && item.Tag != null)
            {
                var res = item.Tag as Result;
                pbExpected.Image = Utils.GetArea(res.step.Screenshot, res.step.Rect);
                pbCheck.Image = res.bmpResult;
                pbForRecognition.Image = res.bmpForRecognition;
                lblRecognizedText.Text = res.recognized;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //UserInterop.DoMouseClick(new Rectangle(618, 401, 64, 31), Action.LeftClick);
            //UserInterop.DoMouseClick(new Rectangle(100, 100, 64, 31), Action.LeftClick);
        }

        private void btnShowAllDesigner_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            var f = new AllRecognizer();
            f.Show();
            f.Activate();
        }
    }
}
