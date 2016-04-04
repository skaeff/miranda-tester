using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BitmapTester
{
    public class StepCollection
    {
        public StepCollection()
        {
            Collection = new List<Step>();
        }
        [XmlArray("Collection"), XmlArrayItem("Item")]
        public List<Step> Collection { get; set; }
    }

    [Serializable]
    public abstract class Step
    {
        [XmlArray("Collection"), XmlArrayItem("Item")]
        public List<Step> Collection { get; set; }

        public RecognizeSetting setting;

        public StepType Type;
        public string Name;
        public Rectangle Rect;
        public bool Passed;

        [XmlIgnore]
        public Bitmap Screenshot { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Screenshot")]
        public byte[] ScreenshotSerialized
        {
            get
            { // serialize
                if (Screenshot == null) return null;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (var tmp = new Bitmap(Screenshot))
                    {
                        tmp.Save(ms, ImageFormat.Jpeg);
                    }
                    return ms.ToArray();
                }
            }
            set
            { // deserialize
                if (value == null)
                {
                    Screenshot = null;
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(value))
                    {
                        Screenshot = new Bitmap(ms);
                    }
                }
            }
        }
    }

    [Serializable]
    //[XmlInclude(typeof(Step))]
    public class ActionStep:Step
    {
        public ActionStep() { Type = StepType.Action; Collection = new List<Step>(); }
        public Action Action;
        public string Text;
    }

    [Serializable]
    //[XmlInclude(typeof(Step))]
    public class CheckStep : Step
    {
        public CheckStep() { Type = StepType.Check; Collection = new List<Step>(); }
        public string Check;
        public bool IsEng; 
    }

    [Serializable]
    //[XmlInclude(typeof(Step))]
    public class ConditionStep : Step
    {
        public ConditionStep() { Type = StepType.Condition; Collection = new List<Step>(); }
        public bool ConditionTrue;
    }
    [Serializable]
    public enum Action:int
    {
        LeftClick,
        RightClick,
        DoubleClick,
        EnterText
    }
    [Serializable]
    public enum StepType:int
    {
        Action,
        Check,
        Condition
    }
}
