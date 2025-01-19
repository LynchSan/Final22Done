namespace buttonsPractice
{
    partial class pyramid
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
            this.labelPyramid = new System.Windows.Forms.Label();
            this.textboxPyramid = new System.Windows.Forms.TextBox();
            this.labelEnterNumPyramid = new System.Windows.Forms.Label();
            this.pyramidButton = new System.Windows.Forms.Button();
            this.labelFullPyramid = new System.Windows.Forms.Label();
            this.labelHalfPyramid = new System.Windows.Forms.Label();
            this.labelInvertedPyramid = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP3 = new System.Windows.Forms.Label();
            this.mainMenuPyramid = new System.Windows.Forms.Button();
            this.exitButtonPyramid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPyramid
            // 
            this.labelPyramid.AutoSize = true;
            this.labelPyramid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPyramid.ForeColor = System.Drawing.Color.Cyan;
            this.labelPyramid.Location = new System.Drawing.Point(272, 53);
            this.labelPyramid.Name = "labelPyramid";
            this.labelPyramid.Size = new System.Drawing.Size(239, 25);
            this.labelPyramid.TabIndex = 2;
            this.labelPyramid.Text = "Welcome to Pyramids";
            // 
            // textboxPyramid
            // 
            this.textboxPyramid.BackColor = System.Drawing.Color.Black;
            this.textboxPyramid.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPyramid.ForeColor = System.Drawing.Color.Lime;
            this.textboxPyramid.Location = new System.Drawing.Point(295, 117);
            this.textboxPyramid.Name = "textboxPyramid";
            this.textboxPyramid.Size = new System.Drawing.Size(186, 27);
            this.textboxPyramid.TabIndex = 17;
            // 
            // labelEnterNumPyramid
            // 
            this.labelEnterNumPyramid.AutoSize = true;
            this.labelEnterNumPyramid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnterNumPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNumPyramid.ForeColor = System.Drawing.Color.Aqua;
            this.labelEnterNumPyramid.Location = new System.Drawing.Point(331, 96);
            this.labelEnterNumPyramid.Name = "labelEnterNumPyramid";
            this.labelEnterNumPyramid.Size = new System.Drawing.Size(123, 18);
            this.labelEnterNumPyramid.TabIndex = 18;
            this.labelEnterNumPyramid.Text = "Enter a number";
            // 
            // pyramidButton
            // 
            this.pyramidButton.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2025_01_11_231149;
            this.pyramidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyramidButton.ForeColor = System.Drawing.Color.Aqua;
            this.pyramidButton.Location = new System.Drawing.Point(334, 150);
            this.pyramidButton.Name = "pyramidButton";
            this.pyramidButton.Size = new System.Drawing.Size(109, 42);
            this.pyramidButton.TabIndex = 22;
            this.pyramidButton.Text = "/\\";
            this.pyramidButton.UseVisualStyleBackColor = true;
            this.pyramidButton.Click += new System.EventHandler(this.pyramidButton_Click);
            // 
            // labelFullPyramid
            // 
            this.labelFullPyramid.AutoSize = true;
            this.labelFullPyramid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFullPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullPyramid.ForeColor = System.Drawing.Color.Aqua;
            this.labelFullPyramid.Location = new System.Drawing.Point(104, 226);
            this.labelFullPyramid.Name = "labelFullPyramid";
            this.labelFullPyramid.Size = new System.Drawing.Size(101, 18);
            this.labelFullPyramid.TabIndex = 23;
            this.labelFullPyramid.Text = "Full Pyramid";
            // 
            // labelHalfPyramid
            // 
            this.labelHalfPyramid.AutoSize = true;
            this.labelHalfPyramid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHalfPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalfPyramid.ForeColor = System.Drawing.Color.Aqua;
            this.labelHalfPyramid.Location = new System.Drawing.Point(331, 226);
            this.labelHalfPyramid.Name = "labelHalfPyramid";
            this.labelHalfPyramid.Size = new System.Drawing.Size(104, 18);
            this.labelHalfPyramid.TabIndex = 24;
            this.labelHalfPyramid.Text = "Half Pyramid";
            // 
            // labelInvertedPyramid
            // 
            this.labelInvertedPyramid.AutoSize = true;
            this.labelInvertedPyramid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInvertedPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvertedPyramid.ForeColor = System.Drawing.Color.Aqua;
            this.labelInvertedPyramid.Location = new System.Drawing.Point(572, 226);
            this.labelInvertedPyramid.Name = "labelInvertedPyramid";
            this.labelInvertedPyramid.Size = new System.Drawing.Size(133, 18);
            this.labelInvertedPyramid.TabIndex = 25;
            this.labelInvertedPyramid.Text = "Inverted Pyramid";
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.ForeColor = System.Drawing.Color.Aqua;
            this.labelP1.Location = new System.Drawing.Point(104, 286);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(35, 18);
            this.labelP1.TabIndex = 26;
            this.labelP1.Text = "Full";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.ForeColor = System.Drawing.Color.Aqua;
            this.labelP2.Location = new System.Drawing.Point(331, 286);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(38, 18);
            this.labelP2.TabIndex = 27;
            this.labelP2.Text = "Half";
            // 
            // labelP3
            // 
            this.labelP3.AutoSize = true;
            this.labelP3.BackColor = System.Drawing.Color.Black;
            this.labelP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP3.ForeColor = System.Drawing.Color.Aqua;
            this.labelP3.Location = new System.Drawing.Point(572, 286);
            this.labelP3.Name = "labelP3";
            this.labelP3.Size = new System.Drawing.Size(67, 18);
            this.labelP3.TabIndex = 28;
            this.labelP3.Text = "Inverted";
            // 
            // mainMenuPyramid
            // 
            this.mainMenuPyramid.BackColor = System.Drawing.Color.Black;
            this.mainMenuPyramid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuPyramid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenuPyramid.Location = new System.Drawing.Point(12, 398);
            this.mainMenuPyramid.Name = "mainMenuPyramid";
            this.mainMenuPyramid.Size = new System.Drawing.Size(47, 40);
            this.mainMenuPyramid.TabIndex = 29;
            this.mainMenuPyramid.Text = "<";
            this.mainMenuPyramid.UseVisualStyleBackColor = false;
            this.mainMenuPyramid.Click += new System.EventHandler(this.mainMenuPyramid_Click);
            // 
            // exitButtonPyramid
            // 
            this.exitButtonPyramid.BackColor = System.Drawing.Color.DarkRed;
            this.exitButtonPyramid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButtonPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtonPyramid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButtonPyramid.Location = new System.Drawing.Point(736, 411);
            this.exitButtonPyramid.Name = "exitButtonPyramid";
            this.exitButtonPyramid.Size = new System.Drawing.Size(52, 27);
            this.exitButtonPyramid.TabIndex = 30;
            this.exitButtonPyramid.Text = "Exit";
            this.exitButtonPyramid.UseVisualStyleBackColor = false;
            this.exitButtonPyramid.Click += new System.EventHandler(this.exitButtonPyramid_Click);
            // 
            // pyramid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2025_01_11_231149;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButtonPyramid);
            this.Controls.Add(this.mainMenuPyramid);
            this.Controls.Add(this.labelP3);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.labelInvertedPyramid);
            this.Controls.Add(this.labelHalfPyramid);
            this.Controls.Add(this.labelFullPyramid);
            this.Controls.Add(this.pyramidButton);
            this.Controls.Add(this.labelEnterNumPyramid);
            this.Controls.Add(this.textboxPyramid);
            this.Controls.Add(this.labelPyramid);
            this.DoubleBuffered = true;
            this.Name = "pyramid";
            this.Text = "pyramid";
            this.Load += new System.EventHandler(this.pyramid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPyramid;
        private System.Windows.Forms.TextBox textboxPyramid;
        private System.Windows.Forms.Label labelEnterNumPyramid;
        private System.Windows.Forms.Button pyramidButton;
        private System.Windows.Forms.Label labelFullPyramid;
        private System.Windows.Forms.Label labelHalfPyramid;
        private System.Windows.Forms.Label labelInvertedPyramid;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP3;
        private System.Windows.Forms.Button mainMenuPyramid;
        private System.Windows.Forms.Button exitButtonPyramid;
    }
}