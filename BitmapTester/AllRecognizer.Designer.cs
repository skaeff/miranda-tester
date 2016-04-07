namespace BitmapTester
{
    partial class AllRecognizer
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
            this.pnToolWindow = new System.Windows.Forms.Panel();
            this.tbRecognizedText = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnPrintScreen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRecognizedRects = new System.Windows.Forms.ListBox();
            this.tbMagnify = new System.Windows.Forms.TextBox();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.lblRect = new System.Windows.Forms.Label();
            this.rbRussian = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCoords = new System.Windows.Forms.Label();
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.btnRecognizeAll = new System.Windows.Forms.Button();
            this.pnToolWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnToolWindow
            // 
            this.pnToolWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnToolWindow.Controls.Add(this.btnRecognizeAll);
            this.pnToolWindow.Controls.Add(this.tbRecognizedText);
            this.pnToolWindow.Controls.Add(this.btnRestore);
            this.pnToolWindow.Controls.Add(this.btnFullScreen);
            this.pnToolWindow.Controls.Add(this.btnPrintScreen);
            this.pnToolWindow.Controls.Add(this.label4);
            this.pnToolWindow.Controls.Add(this.lbRecognizedRects);
            this.pnToolWindow.Controls.Add(this.tbMagnify);
            this.pnToolWindow.Controls.Add(this.btnRecognize);
            this.pnToolWindow.Controls.Add(this.rbEnglish);
            this.pnToolWindow.Controls.Add(this.lblRect);
            this.pnToolWindow.Controls.Add(this.rbRussian);
            this.pnToolWindow.Controls.Add(this.btnClose);
            this.pnToolWindow.Controls.Add(this.lblCoords);
            this.pnToolWindow.Location = new System.Drawing.Point(412, 12);
            this.pnToolWindow.Name = "pnToolWindow";
            this.pnToolWindow.Size = new System.Drawing.Size(628, 461);
            this.pnToolWindow.TabIndex = 99;
            this.pnToolWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnToolWindow_MouseDown);
            this.pnToolWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnToolWindow_MouseMove);
            this.pnToolWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnToolWindow_MouseUp);
            // 
            // tbRecognizedText
            // 
            this.tbRecognizedText.Location = new System.Drawing.Point(7, 239);
            this.tbRecognizedText.Multiline = true;
            this.tbRecognizedText.Name = "tbRecognizedText";
            this.tbRecognizedText.Size = new System.Drawing.Size(279, 209);
            this.tbRecognizedText.TabIndex = 29;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(468, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 28;
            this.btnRestore.Text = "restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(387, 3);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(75, 23);
            this.btnFullScreen.TabIndex = 27;
            this.btnFullScreen.Text = "full screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnPrintScreen
            // 
            this.btnPrintScreen.Location = new System.Drawing.Point(7, 8);
            this.btnPrintScreen.Name = "btnPrintScreen";
            this.btnPrintScreen.Size = new System.Drawing.Size(75, 23);
            this.btnPrintScreen.TabIndex = 26;
            this.btnPrintScreen.Text = "print screen";
            this.btnPrintScreen.UseVisualStyleBackColor = true;
            this.btnPrintScreen.Click += new System.EventHandler(this.btnPrintScreen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "magnify";
            // 
            // lbRecognizedRects
            // 
            this.lbRecognizedRects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRecognizedRects.FormattingEnabled = true;
            this.lbRecognizedRects.Location = new System.Drawing.Point(292, 28);
            this.lbRecognizedRects.Name = "lbRecognizedRects";
            this.lbRecognizedRects.Size = new System.Drawing.Size(331, 420);
            this.lbRecognizedRects.TabIndex = 20;
            this.lbRecognizedRects.SelectedIndexChanged += new System.EventHandler(this.lbRecognizedRects_SelectedIndexChanged);
            this.lbRecognizedRects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbRecognizedRects_MouseDoubleClick);
            // 
            // tbMagnify
            // 
            this.tbMagnify.Location = new System.Drawing.Point(98, 92);
            this.tbMagnify.Name = "tbMagnify";
            this.tbMagnify.Size = new System.Drawing.Size(172, 20);
            this.tbMagnify.TabIndex = 24;
            this.tbMagnify.Text = "2";
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(8, 210);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(122, 23);
            this.btnRecognize.TabIndex = 17;
            this.btnRecognize.Text = "recognize rect";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(98, 147);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(58, 17);
            this.rbEnglish.TabIndex = 6;
            this.rbEnglish.Text = "english";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // lblRect
            // 
            this.lblRect.AutoSize = true;
            this.lblRect.Location = new System.Drawing.Point(95, 52);
            this.lblRect.Name = "lblRect";
            this.lblRect.Size = new System.Drawing.Size(35, 13);
            this.lblRect.TabIndex = 9;
            this.lblRect.Text = "label1";
            // 
            // rbRussian
            // 
            this.rbRussian.AutoSize = true;
            this.rbRussian.Checked = true;
            this.rbRussian.Location = new System.Drawing.Point(98, 124);
            this.rbRussian.Name = "rbRussian";
            this.rbRussian.Size = new System.Drawing.Size(58, 17);
            this.rbRussian.TabIndex = 5;
            this.rbRussian.TabStop = true;
            this.rbRussian.Text = "russian";
            this.rbRussian.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(548, 3);
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
            this.lblCoords.Location = new System.Drawing.Point(9, 52);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(62, 13);
            this.lblCoords.TabIndex = 1;
            this.lblCoords.Text = "coordinates";
            // 
            // pbScreen
            // 
            this.pbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbScreen.Location = new System.Drawing.Point(0, 0);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(1284, 670);
            this.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScreen.TabIndex = 100;
            this.pbScreen.TabStop = false;
            this.pbScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.pbScreen_Paint);
            this.pbScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbScreen_MouseDown);
            this.pbScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbScreen_MouseMove);
            // 
            // btnRecognizeAll
            // 
            this.btnRecognizeAll.Location = new System.Drawing.Point(136, 210);
            this.btnRecognizeAll.Name = "btnRecognizeAll";
            this.btnRecognizeAll.Size = new System.Drawing.Size(145, 23);
            this.btnRecognizeAll.TabIndex = 30;
            this.btnRecognizeAll.Text = "recognize all screenshot";
            this.btnRecognizeAll.UseVisualStyleBackColor = true;
            this.btnRecognizeAll.Click += new System.EventHandler(this.btnRecognizeAll_Click);
            // 
            // AllRecognizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 670);
            this.Controls.Add(this.pnToolWindow);
            this.Controls.Add(this.pbScreen);
            this.MaximizeBox = false;
            this.Name = "AllRecognizer";
            this.Text = "AllRecognizer";
            this.pnToolWindow.ResumeLayout(false);
            this.pnToolWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnToolWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMagnify;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbRussian;
        private System.Windows.Forms.Label lblRect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCoords;
        private System.Windows.Forms.ListBox lbRecognizedRects;
        private System.Windows.Forms.Button btnPrintScreen;
        private System.Windows.Forms.PictureBox pbScreen;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.TextBox tbRecognizedText;
        private System.Windows.Forms.Button btnRecognizeAll;
    }
}