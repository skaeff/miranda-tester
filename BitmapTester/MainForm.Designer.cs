namespace BitmapTester
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowDesigner = new System.Windows.Forms.Button();
            this.btnRunTest = new System.Windows.Forms.Button();
            this.lvResult = new System.Windows.Forms.ListView();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.pbExpected = new System.Windows.Forms.PictureBox();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblExpected = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbForRecognition = new System.Windows.Forms.PictureBox();
            this.lblRecognizedText = new System.Windows.Forms.Label();
            this.btnShowAllDesigner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForRecognition)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowDesigner
            // 
            this.btnShowDesigner.Location = new System.Drawing.Point(13, 13);
            this.btnShowDesigner.Name = "btnShowDesigner";
            this.btnShowDesigner.Size = new System.Drawing.Size(147, 23);
            this.btnShowDesigner.TabIndex = 3;
            this.btnShowDesigner.Text = "show designer";
            this.btnShowDesigner.UseVisualStyleBackColor = true;
            this.btnShowDesigner.Click += new System.EventHandler(this.btnShowDesigner_Click);
            // 
            // btnRunTest
            // 
            this.btnRunTest.Location = new System.Drawing.Point(13, 52);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(75, 23);
            this.btnRunTest.TabIndex = 4;
            this.btnRunTest.Text = "run test";
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // lvResult
            // 
            this.lvResult.Location = new System.Drawing.Point(212, 12);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(360, 170);
            this.lvResult.TabIndex = 5;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.List;
            this.lvResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvResult_MouseDoubleClick);
            // 
            // pbCheck
            // 
            this.pbCheck.Location = new System.Drawing.Point(581, 49);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(110, 26);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheck.TabIndex = 6;
            this.pbCheck.TabStop = false;
            // 
            // pbExpected
            // 
            this.pbExpected.Location = new System.Drawing.Point(581, 105);
            this.pbExpected.Name = "pbExpected";
            this.pbExpected.Size = new System.Drawing.Size(107, 30);
            this.pbExpected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExpected.TabIndex = 7;
            this.pbExpected.TabStop = false;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(578, 33);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(37, 13);
            this.lblCheck.TabIndex = 8;
            this.lblCheck.Text = "check";
            // 
            // lblExpected
            // 
            this.lblExpected.AutoSize = true;
            this.lblExpected.Location = new System.Drawing.Point(578, 82);
            this.lblExpected.Name = "lblExpected";
            this.lblExpected.Size = new System.Drawing.Size(51, 13);
            this.lblExpected.TabIndex = 9;
            this.lblExpected.Text = "expected";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(13, 159);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "for recognition";
            // 
            // pbForRecognition
            // 
            this.pbForRecognition.Location = new System.Drawing.Point(581, 171);
            this.pbForRecognition.Name = "pbForRecognition";
            this.pbForRecognition.Size = new System.Drawing.Size(239, 82);
            this.pbForRecognition.TabIndex = 11;
            this.pbForRecognition.TabStop = false;
            // 
            // lblRecognizedText
            // 
            this.lblRecognizedText.AutoSize = true;
            this.lblRecognizedText.Location = new System.Drawing.Point(578, 13);
            this.lblRecognizedText.Name = "lblRecognizedText";
            this.lblRecognizedText.Size = new System.Drawing.Size(79, 13);
            this.lblRecognizedText.TabIndex = 13;
            this.lblRecognizedText.Text = "recognized text";
            // 
            // btnShowAllDesigner
            // 
            this.btnShowAllDesigner.Location = new System.Drawing.Point(13, 201);
            this.btnShowAllDesigner.Name = "btnShowAllDesigner";
            this.btnShowAllDesigner.Size = new System.Drawing.Size(147, 23);
            this.btnShowAllDesigner.TabIndex = 14;
            this.btnShowAllDesigner.Text = "show All designer";
            this.btnShowAllDesigner.UseVisualStyleBackColor = true;
            this.btnShowAllDesigner.Click += new System.EventHandler(this.btnShowAllDesigner_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 269);
            this.Controls.Add(this.btnShowAllDesigner);
            this.Controls.Add(this.lblRecognizedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbForRecognition);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblExpected);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.pbExpected);
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.btnRunTest);
            this.Controls.Add(this.btnShowDesigner);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForRecognition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowDesigner;
        private System.Windows.Forms.Button btnRunTest;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.PictureBox pbExpected;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblExpected;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbForRecognition;
        private System.Windows.Forms.Label lblRecognizedText;
        private System.Windows.Forms.Button btnShowAllDesigner;
    }
}

