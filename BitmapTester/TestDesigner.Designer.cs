namespace BitmapTester
{
    partial class TestDesigner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("start");
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnToolWindow = new System.Windows.Forms.Panel();
            this.cbZoom = new System.Windows.Forms.CheckBox();
            this.tbZoomScale = new System.Windows.Forms.TrackBar();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCheck = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRecognizedText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.pbRecognize = new System.Windows.Forms.PictureBox();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbRussian = new System.Windows.Forms.RadioButton();
            this.tbCheckText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.tpAction = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbActionType = new System.Windows.Forms.ComboBox();
            this.tpUIAutomation = new System.Windows.Forms.TabPage();
            this.tbUIAutoText = new System.Windows.Forms.TextBox();
            this.btnChooseElement = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblStepName = new System.Windows.Forms.Label();
            this.tbStepName = new System.Windows.Forms.TextBox();
            this.btnAddStep = new System.Windows.Forms.Button();
            this.trSteps = new System.Windows.Forms.TreeView();
            this.lblRect = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCoords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMagnify = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWidthIncrease = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHeightIncrease = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnToolWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoomScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecognize)).BeginInit();
            this.tpAction.SuspendLayout();
            this.tpUIAutomation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbScreen
            // 
            this.pbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbScreen.Location = new System.Drawing.Point(0, 0);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(1427, 740);
            this.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScreen.TabIndex = 97;
            this.pbScreen.TabStop = false;
            this.pbScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.pbScreen_Paint);
            this.pbScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbScreen_MouseDown);
            this.pbScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbScreen_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnToolWindow);
            this.panel1.Controls.Add(this.pbScreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 740);
            this.panel1.TabIndex = 98;
            // 
            // pnToolWindow
            // 
            this.pnToolWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnToolWindow.Controls.Add(this.cbZoom);
            this.pnToolWindow.Controls.Add(this.tbZoomScale);
            this.pnToolWindow.Controls.Add(this.picZoom);
            this.pnToolWindow.Controls.Add(this.btnClear);
            this.pnToolWindow.Controls.Add(this.tabControl1);
            this.pnToolWindow.Controls.Add(this.btnLoad);
            this.pnToolWindow.Controls.Add(this.lblStepName);
            this.pnToolWindow.Controls.Add(this.tbStepName);
            this.pnToolWindow.Controls.Add(this.btnAddStep);
            this.pnToolWindow.Controls.Add(this.trSteps);
            this.pnToolWindow.Controls.Add(this.lblRect);
            this.pnToolWindow.Controls.Add(this.btnSave);
            this.pnToolWindow.Controls.Add(this.btnClose);
            this.pnToolWindow.Controls.Add(this.lblCoords);
            this.pnToolWindow.Location = new System.Drawing.Point(466, 57);
            this.pnToolWindow.Name = "pnToolWindow";
            this.pnToolWindow.Size = new System.Drawing.Size(737, 605);
            this.pnToolWindow.TabIndex = 98;
            this.pnToolWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnToolWindow_MouseDown);
            this.pnToolWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnToolWindow_MouseMove);
            this.pnToolWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnToolWindow_MouseUp);
            // 
            // cbZoom
            // 
            this.cbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZoom.AutoSize = true;
            this.cbZoom.Location = new System.Drawing.Point(150, 41);
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(53, 17);
            this.cbZoom.TabIndex = 19;
            this.cbZoom.Text = "Zoom";
            this.cbZoom.UseVisualStyleBackColor = true;
            // 
            // tbZoomScale
            // 
            this.tbZoomScale.LargeChange = 1;
            this.tbZoomScale.Location = new System.Drawing.Point(150, 64);
            this.tbZoomScale.Maximum = 6;
            this.tbZoomScale.Minimum = 2;
            this.tbZoomScale.Name = "tbZoomScale";
            this.tbZoomScale.Size = new System.Drawing.Size(104, 45);
            this.tbZoomScale.TabIndex = 18;
            this.tbZoomScale.Value = 2;
            this.tbZoomScale.ValueChanged += new System.EventHandler(this.tbZoomScale_ValueChanged);
            // 
            // picZoom
            // 
            this.picZoom.Location = new System.Drawing.Point(7, 41);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(137, 112);
            this.picZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picZoom.TabIndex = 17;
            this.picZoom.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(219, 576);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCheck);
            this.tabControl1.Controls.Add(this.tpAction);
            this.tabControl1.Controls.Add(this.tpUIAutomation);
            this.tabControl1.Location = new System.Drawing.Point(3, 185);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(295, 356);
            this.tabControl1.TabIndex = 15;
            // 
            // tpCheck
            // 
            this.tpCheck.Controls.Add(this.label6);
            this.tpCheck.Controls.Add(this.tbHeightIncrease);
            this.tpCheck.Controls.Add(this.label5);
            this.tpCheck.Controls.Add(this.tbWidthIncrease);
            this.tpCheck.Controls.Add(this.label4);
            this.tpCheck.Controls.Add(this.tbMagnify);
            this.tpCheck.Controls.Add(this.label2);
            this.tpCheck.Controls.Add(this.tbRecognizedText);
            this.tpCheck.Controls.Add(this.label3);
            this.tpCheck.Controls.Add(this.lblThreshold);
            this.tpCheck.Controls.Add(this.pbRecognize);
            this.tpCheck.Controls.Add(this.btnRecognize);
            this.tpCheck.Controls.Add(this.rbEnglish);
            this.tpCheck.Controls.Add(this.rbRussian);
            this.tpCheck.Controls.Add(this.tbCheckText);
            this.tpCheck.Controls.Add(this.lblText);
            this.tpCheck.Location = new System.Drawing.Point(4, 22);
            this.tpCheck.Name = "tpCheck";
            this.tpCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheck.Size = new System.Drawing.Size(287, 330);
            this.tpCheck.TabIndex = 0;
            this.tpCheck.Text = "Check";
            this.tpCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "recognized text";
            // 
            // tbRecognizedText
            // 
            this.tbRecognizedText.Location = new System.Drawing.Point(97, 217);
            this.tbRecognizedText.Name = "tbRecognizedText";
            this.tbRecognizedText.ReadOnly = true;
            this.tbRecognizedText.Size = new System.Drawing.Size(172, 20);
            this.tbRecognizedText.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "threshold";
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(95, 243);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(0, 13);
            this.lblThreshold.TabIndex = 20;
            // 
            // pbRecognize
            // 
            this.pbRecognize.Location = new System.Drawing.Point(98, 177);
            this.pbRecognize.Name = "pbRecognize";
            this.pbRecognize.Size = new System.Drawing.Size(171, 34);
            this.pbRecognize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecognize.TabIndex = 18;
            this.pbRecognize.TabStop = false;
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(12, 177);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(75, 23);
            this.btnRecognize.TabIndex = 17;
            this.btnRecognize.Text = "recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(97, 55);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(58, 17);
            this.rbEnglish.TabIndex = 6;
            this.rbEnglish.Text = "english";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbRussian
            // 
            this.rbRussian.AutoSize = true;
            this.rbRussian.Checked = true;
            this.rbRussian.Location = new System.Drawing.Point(97, 32);
            this.rbRussian.Name = "rbRussian";
            this.rbRussian.Size = new System.Drawing.Size(58, 17);
            this.rbRussian.TabIndex = 5;
            this.rbRussian.TabStop = true;
            this.rbRussian.Text = "russian";
            this.rbRussian.UseVisualStyleBackColor = true;
            // 
            // tbCheckText
            // 
            this.tbCheckText.Location = new System.Drawing.Point(97, 6);
            this.tbCheckText.Name = "tbCheckText";
            this.tbCheckText.Size = new System.Drawing.Size(144, 20);
            this.tbCheckText.TabIndex = 3;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(8, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(71, 13);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "expected text";
            // 
            // tpAction
            // 
            this.tpAction.Controls.Add(this.label1);
            this.tpAction.Controls.Add(this.cbActionType);
            this.tpAction.Location = new System.Drawing.Point(4, 22);
            this.tpAction.Name = "tpAction";
            this.tpAction.Padding = new System.Windows.Forms.Padding(3);
            this.tpAction.Size = new System.Drawing.Size(287, 198);
            this.tpAction.TabIndex = 1;
            this.tpAction.Text = "Action";
            this.tpAction.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "action";
            // 
            // cbActionType
            // 
            this.cbActionType.FormattingEnabled = true;
            this.cbActionType.Location = new System.Drawing.Point(77, 13);
            this.cbActionType.Name = "cbActionType";
            this.cbActionType.Size = new System.Drawing.Size(121, 21);
            this.cbActionType.TabIndex = 0;
            // 
            // tpUIAutomation
            // 
            this.tpUIAutomation.Controls.Add(this.tbUIAutoText);
            this.tpUIAutomation.Controls.Add(this.btnChooseElement);
            this.tpUIAutomation.Location = new System.Drawing.Point(4, 22);
            this.tpUIAutomation.Name = "tpUIAutomation";
            this.tpUIAutomation.Padding = new System.Windows.Forms.Padding(3);
            this.tpUIAutomation.Size = new System.Drawing.Size(287, 198);
            this.tpUIAutomation.TabIndex = 2;
            this.tpUIAutomation.Text = "UIAutomation";
            this.tpUIAutomation.UseVisualStyleBackColor = true;
            // 
            // tbUIAutoText
            // 
            this.tbUIAutoText.Location = new System.Drawing.Point(97, 37);
            this.tbUIAutoText.Name = "tbUIAutoText";
            this.tbUIAutoText.Size = new System.Drawing.Size(184, 20);
            this.tbUIAutoText.TabIndex = 1;
            // 
            // btnChooseElement
            // 
            this.btnChooseElement.Location = new System.Drawing.Point(6, 6);
            this.btnChooseElement.Name = "btnChooseElement";
            this.btnChooseElement.Size = new System.Drawing.Size(109, 23);
            this.btnChooseElement.TabIndex = 0;
            this.btnChooseElement.Text = "choose element";
            this.btnChooseElement.UseVisualStyleBackColor = true;
            this.btnChooseElement.Click += new System.EventHandler(this.btnChooseElement_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(84, 576);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblStepName
            // 
            this.lblStepName.AutoSize = true;
            this.lblStepName.Location = new System.Drawing.Point(15, 162);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(56, 13);
            this.lblStepName.TabIndex = 13;
            this.lblStepName.Text = "step name";
            // 
            // tbStepName
            // 
            this.tbStepName.Location = new System.Drawing.Point(104, 159);
            this.tbStepName.Name = "tbStepName";
            this.tbStepName.Size = new System.Drawing.Size(171, 20);
            this.tbStepName.TabIndex = 12;
            // 
            // btnAddStep
            // 
            this.btnAddStep.Location = new System.Drawing.Point(3, 547);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(156, 23);
            this.btnAddStep.TabIndex = 11;
            this.btnAddStep.Text = "add step to selected node";
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // trSteps
            // 
            this.trSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trSteps.HideSelection = false;
            this.trSteps.Location = new System.Drawing.Point(304, 41);
            this.trSteps.Name = "trSteps";
            treeNode1.Name = "Node0";
            treeNode1.Text = "start";
            this.trSteps.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.trSteps.Size = new System.Drawing.Size(428, 558);
            this.trSteps.TabIndex = 10;
            this.trSteps.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trSteps_NodeMouseDoubleClick);
            // 
            // lblRect
            // 
            this.lblRect.AutoSize = true;
            this.lblRect.Location = new System.Drawing.Point(101, 15);
            this.lblRect.Name = "lblRect";
            this.lblRect.Size = new System.Drawing.Size(35, 13);
            this.lblRect.TabIndex = 9;
            this.lblRect.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(3, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(657, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCoords
            // 
            this.lblCoords.AutoSize = true;
            this.lblCoords.Location = new System.Drawing.Point(15, 15);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(62, 13);
            this.lblCoords.TabIndex = 1;
            this.lblCoords.Text = "coordinates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "magnify";
            // 
            // tbMagnify
            // 
            this.tbMagnify.Location = new System.Drawing.Point(96, 97);
            this.tbMagnify.Name = "tbMagnify";
            this.tbMagnify.Size = new System.Drawing.Size(172, 20);
            this.tbMagnify.TabIndex = 24;
            this.tbMagnify.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "width increase";
            // 
            // tbWidthIncrease
            // 
            this.tbWidthIncrease.Location = new System.Drawing.Point(96, 123);
            this.tbWidthIncrease.Name = "tbWidthIncrease";
            this.tbWidthIncrease.Size = new System.Drawing.Size(172, 20);
            this.tbWidthIncrease.TabIndex = 26;
            this.tbWidthIncrease.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "height increase";
            // 
            // tbHeightIncrease
            // 
            this.tbHeightIncrease.Location = new System.Drawing.Point(97, 149);
            this.tbHeightIncrease.Name = "tbHeightIncrease";
            this.tbHeightIncrease.Size = new System.Drawing.Size(172, 20);
            this.tbHeightIncrease.TabIndex = 28;
            this.tbHeightIncrease.Text = "0";
            // 
            // TestDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 740);
            this.Controls.Add(this.panel1);
            this.Name = "TestDesigner";
            this.Text = "TestDesigner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestDesigner_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnToolWindow.ResumeLayout(false);
            this.pnToolWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoomScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpCheck.ResumeLayout(false);
            this.tpCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecognize)).EndInit();
            this.tpAction.ResumeLayout(false);
            this.tpAction.PerformLayout();
            this.tpUIAutomation.ResumeLayout(false);
            this.tpUIAutomation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCoords;
        private System.Windows.Forms.Panel pnToolWindow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbCheckText;
        private System.Windows.Forms.Label lblRect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddStep;
        private System.Windows.Forms.TreeView trSteps;
        private System.Windows.Forms.Label lblStepName;
        private System.Windows.Forms.TextBox tbStepName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCheck;
        private System.Windows.Forms.TabPage tpAction;
        private System.Windows.Forms.TabPage tpUIAutomation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbActionType;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbRussian;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pbRecognize;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.CheckBox cbZoom;
        private System.Windows.Forms.TrackBar tbZoomScale;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRecognizedText;
        private System.Windows.Forms.Button btnChooseElement;
        private System.Windows.Forms.TextBox tbUIAutoText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMagnify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbHeightIncrease;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWidthIncrease;
    }
}