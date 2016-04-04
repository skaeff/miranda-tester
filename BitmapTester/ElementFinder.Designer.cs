namespace BitmapTester
{
    partial class ElementFinder
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
            this.windowFinder1 = new WindowFinder.WindowFinder();
            this.lblCoords = new System.Windows.Forms.Label();
            this.lblObjectName = new System.Windows.Forms.Label();
            this.lblObjectRect = new System.Windows.Forms.Label();
            this.cbHideForm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // windowFinder1
            // 
            this.windowFinder1.Location = new System.Drawing.Point(24, 89);
            this.windowFinder1.Name = "windowFinder1";
            this.windowFinder1.Size = new System.Drawing.Size(31, 28);
            this.windowFinder1.TabIndex = 0;
            // 
            // lblCoords
            // 
            this.lblCoords.AutoSize = true;
            this.lblCoords.Location = new System.Drawing.Point(21, 13);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(35, 13);
            this.lblCoords.TabIndex = 1;
            this.lblCoords.Text = "label1";
            // 
            // lblObjectName
            // 
            this.lblObjectName.AutoSize = true;
            this.lblObjectName.Location = new System.Drawing.Point(21, 37);
            this.lblObjectName.Name = "lblObjectName";
            this.lblObjectName.Size = new System.Drawing.Size(35, 13);
            this.lblObjectName.TabIndex = 2;
            this.lblObjectName.Text = "label1";
            // 
            // lblObjectRect
            // 
            this.lblObjectRect.AutoSize = true;
            this.lblObjectRect.Location = new System.Drawing.Point(21, 64);
            this.lblObjectRect.Name = "lblObjectRect";
            this.lblObjectRect.Size = new System.Drawing.Size(35, 13);
            this.lblObjectRect.TabIndex = 3;
            this.lblObjectRect.Text = "label1";
            // 
            // cbHideForm
            // 
            this.cbHideForm.AutoSize = true;
            this.cbHideForm.Location = new System.Drawing.Point(24, 128);
            this.cbHideForm.Name = "cbHideForm";
            this.cbHideForm.Size = new System.Drawing.Size(69, 17);
            this.cbHideForm.TabIndex = 4;
            this.cbHideForm.Text = "hide form";
            this.cbHideForm.UseVisualStyleBackColor = true;
            this.cbHideForm.Visible = false;
            // 
            // ElementFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 157);
            this.Controls.Add(this.cbHideForm);
            this.Controls.Add(this.lblObjectRect);
            this.Controls.Add(this.lblObjectName);
            this.Controls.Add(this.lblCoords);
            this.Controls.Add(this.windowFinder1);
            this.Name = "ElementFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElementFinder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElementFinder_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowFinder.WindowFinder windowFinder1;
        private System.Windows.Forms.Label lblCoords;
        private System.Windows.Forms.Label lblObjectName;
        private System.Windows.Forms.Label lblObjectRect;
        private System.Windows.Forms.CheckBox cbHideForm;
    }
}