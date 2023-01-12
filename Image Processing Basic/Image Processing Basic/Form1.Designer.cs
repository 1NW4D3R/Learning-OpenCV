namespace Image_Processing_Basic
{
    partial class Form1
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
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.BackColor = System.Drawing.Color.MidnightBlue;
            this.picOriginal.Location = new System.Drawing.Point(12, 71);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(500, 500);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picResult.BackColor = System.Drawing.Color.MidnightBlue;
            this.picResult.Location = new System.Drawing.Point(518, 71);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(500, 500);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 594);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(375, 594);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 3;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(578, 594);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(75, 23);
            this.btnNegative.TabIndex = 4;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(943, 594);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(301, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(425, 55);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Image Processing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Checkerboard Invert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Image Processing Basic";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
    }
}

