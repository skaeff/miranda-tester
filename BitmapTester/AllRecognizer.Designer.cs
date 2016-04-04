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
            this.cbZoom = new System.Windows.Forms.CheckBox();
            this.tbZoomScale = new System.Windows.Forms.TrackBar();
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMagnify = new System.Windows.Forms.TextBox();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbRussian = new System.Windows.Forms.RadioButton();
            this.lblRect = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCoords = new System.Windows.Forms.Label();
            this.lbRecognizedRects = new System.Windows.Forms.ListBox();
            this.btnPrintScreen = new System.Windows.Forms.Button();
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.pnToolWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoomScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnToolWindow
            // 
            this.pnToolWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnToolWindow.Controls.Add(this.btnRestore);
            this.pnToolWindow.Controls.Add(this.btnFullScreen);
            this.pnToolWindow.Controls.Add(this.btnPrintScreen);
            this.pnToolWindow.Controls.Add(this.label4);
            this.pnToolWindow.Controls.Add(this.lbRecognizedRects);
            this.pnToolWindow.Controls.Add(this.tbMagnify);
            this.pnToolWindow.Controls.Add(this.cbZoom);
            this.pnToolWindow.Controls.Add(this.tbZoomScale);
            this.pnToolWindow.Controls.Add(this.picZoom);
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
            // cbZoom
            // 
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "magnify";
            // 
            // tbMagnify
            // 
            this.tbMagnify.Location = new System.Drawing.Point(100, 254);
            this.tbMagnify.Name = "tbMagnify";
            this.tbMagnify.Size = new System.Drawing.Size(172, 20);
            this.tbMagnify.TabIndex = 24;
            this.tbMagnify.Text = "5";
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(197, 337);
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
            this.rbEnglish.Location = new System.Drawing.Point(100, 309);
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
            this.rbRussian.Location = new System.Drawing.Point(100, 286);
            this.rbRussian.Name = "rbRussian";
            this.rbRussian.Size = new System.Drawing.Size(58, 17);
            this.rbRussian.TabIndex = 5;
            this.rbRussian.TabStop = true;
            this.rbRussian.Text = "russian";
            this.rbRussian.UseVisualStyleBackColor = true;
            // 
            // lblRect
            // 
            this.lblRect.AutoSize = true;
            this.lblRect.Location = new System.Drawing.Point(400, 8);
            this.lblRect.Name = "lblRect";
            this.lblRect.Size = new System.Drawing.Size(35, 13);
            this.lblRect.TabIndex = 9;
            this.lblRect.Text = "label1";
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
            this.lblCoords.Location = new System.Drawing.Point(314, 8);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(62, 13);
            this.lblCoords.TabIndex = 1;
            this.lblCoords.Text = "coordinates";
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
            this.lbRecognizedRects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbRecognizedRects_MouseDoubleClick);
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
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(7, 425);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(75, 23);
            this.btnFullScreen.TabIndex = 27;
            this.btnFullScreen.Text = "full screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(88, 425);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 28;
            this.btnRestore.Text = "restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // AllRecognizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 670);
            this.Controls.Add(this.pnToolWindow);
            this.Controls.Add(this.pbScreen);
            this.Name = "AllRecognizer";
            this.Text = "AllRecognizer";
            this.pnToolWindow.ResumeLayout(false);
            this.pnToolWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoomScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnToolWindow;
        private System.Windows.Forms.CheckBox cbZoom;
        private System.Windows.Forms.TrackBar tbZoomScale;
        private System.Windows.Forms.PictureBox picZoom;
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
    }
}