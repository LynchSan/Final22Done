namespace buttonsPractice
{
    partial class Looping
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
            this.labelLoop = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelEnterSoN = new System.Windows.Forms.Label();
            this.textboxSoN = new System.Windows.Forms.TextBox();
            this.getsumButton = new System.Windows.Forms.Button();
            this.mainMenuConversion = new System.Windows.Forms.Button();
            this.exitButtonOperations = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelFactorial = new System.Windows.Forms.Label();
            this.labelEnterNumFactorial = new System.Windows.Forms.Label();
            this.textboxFactorial = new System.Windows.Forms.TextBox();
            this.factorialButton = new System.Windows.Forms.Button();
            this.labelNested = new System.Windows.Forms.Label();
            this.nestedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoop
            // 
            this.labelLoop.AutoSize = true;
            this.labelLoop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoop.ForeColor = System.Drawing.Color.Cyan;
            this.labelLoop.Location = new System.Drawing.Point(276, 44);
            this.labelLoop.Name = "labelLoop";
            this.labelLoop.Size = new System.Drawing.Size(226, 25);
            this.labelLoop.TabIndex = 1;
            this.labelLoop.Text = "Welcome to Looping";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.SystemColors.Control;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.Color.Cyan;
            this.labelTemp.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelTemp.Location = new System.Drawing.Point(88, 125);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(79, 18);
            this.labelTemp.TabIndex = 2;
            this.labelTemp.Text = "Sum of N";
            // 
            // labelEnterSoN
            // 
            this.labelEnterSoN.AutoSize = true;
            this.labelEnterSoN.BackColor = System.Drawing.SystemColors.Control;
            this.labelEnterSoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterSoN.ForeColor = System.Drawing.Color.Cyan;
            this.labelEnterSoN.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelEnterSoN.Location = new System.Drawing.Point(68, 154);
            this.labelEnterSoN.Name = "labelEnterSoN";
            this.labelEnterSoN.Size = new System.Drawing.Size(123, 18);
            this.labelEnterSoN.TabIndex = 7;
            this.labelEnterSoN.Text = "Enter a number";
            // 
            // textboxSoN
            // 
            this.textboxSoN.BackColor = System.Drawing.Color.Black;
            this.textboxSoN.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSoN.ForeColor = System.Drawing.Color.Lime;
            this.textboxSoN.Location = new System.Drawing.Point(38, 175);
            this.textboxSoN.Name = "textboxSoN";
            this.textboxSoN.Size = new System.Drawing.Size(186, 27);
            this.textboxSoN.TabIndex = 8;
            // 
            // getsumButton
            // 
            this.getsumButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getsumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getsumButton.ForeColor = System.Drawing.Color.Cyan;
            this.getsumButton.Location = new System.Drawing.Point(71, 208);
            this.getsumButton.Name = "getsumButton";
            this.getsumButton.Size = new System.Drawing.Size(109, 42);
            this.getsumButton.TabIndex = 9;
            this.getsumButton.Text = "Get Sum";
            this.getsumButton.UseVisualStyleBackColor = false;
            this.getsumButton.Click += new System.EventHandler(this.getsumButton_Click);
            // 
            // mainMenuConversion
            // 
            this.mainMenuConversion.BackColor = System.Drawing.Color.Black;
            this.mainMenuConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuConversion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenuConversion.Location = new System.Drawing.Point(12, 398);
            this.mainMenuConversion.Name = "mainMenuConversion";
            this.mainMenuConversion.Size = new System.Drawing.Size(47, 40);
            this.mainMenuConversion.TabIndex = 11;
            this.mainMenuConversion.Text = "<";
            this.mainMenuConversion.UseVisualStyleBackColor = false;
            this.mainMenuConversion.Click += new System.EventHandler(this.mainMenuConversion_Click);
            // 
            // exitButtonOperations
            // 
            this.exitButtonOperations.BackColor = System.Drawing.Color.DarkRed;
            this.exitButtonOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButtonOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtonOperations.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButtonOperations.Location = new System.Drawing.Point(736, 411);
            this.exitButtonOperations.Name = "exitButtonOperations";
            this.exitButtonOperations.Size = new System.Drawing.Size(52, 27);
            this.exitButtonOperations.TabIndex = 12;
            this.exitButtonOperations.Text = "Exit";
            this.exitButtonOperations.UseVisualStyleBackColor = false;
            this.exitButtonOperations.Click += new System.EventHandler(this.exitButtonOperations_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResult.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.Lime;
            this.labelResult.Location = new System.Drawing.Point(68, 360);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(74, 17);
            this.labelResult.TabIndex = 13;
            this.labelResult.Text = "RESULT";
            // 
            // labelFactorial
            // 
            this.labelFactorial.AutoSize = true;
            this.labelFactorial.BackColor = System.Drawing.SystemColors.Control;
            this.labelFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactorial.ForeColor = System.Drawing.Color.Cyan;
            this.labelFactorial.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelFactorial.Location = new System.Drawing.Point(337, 125);
            this.labelFactorial.Name = "labelFactorial";
            this.labelFactorial.Size = new System.Drawing.Size(111, 18);
            this.labelFactorial.TabIndex = 14;
            this.labelFactorial.Text = "Factorial of N";
            // 
            // labelEnterNumFactorial
            // 
            this.labelEnterNumFactorial.AutoSize = true;
            this.labelEnterNumFactorial.BackColor = System.Drawing.SystemColors.Control;
            this.labelEnterNumFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNumFactorial.ForeColor = System.Drawing.Color.Cyan;
            this.labelEnterNumFactorial.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelEnterNumFactorial.Location = new System.Drawing.Point(337, 154);
            this.labelEnterNumFactorial.Name = "labelEnterNumFactorial";
            this.labelEnterNumFactorial.Size = new System.Drawing.Size(123, 18);
            this.labelEnterNumFactorial.TabIndex = 15;
            this.labelEnterNumFactorial.Text = "Enter a number";
            // 
            // textboxFactorial
            // 
            this.textboxFactorial.BackColor = System.Drawing.Color.Black;
            this.textboxFactorial.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxFactorial.ForeColor = System.Drawing.Color.Lime;
            this.textboxFactorial.Location = new System.Drawing.Point(304, 175);
            this.textboxFactorial.Name = "textboxFactorial";
            this.textboxFactorial.Size = new System.Drawing.Size(186, 27);
            this.textboxFactorial.TabIndex = 16;
            // 
            // factorialButton
            // 
            this.factorialButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.factorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorialButton.ForeColor = System.Drawing.Color.Cyan;
            this.factorialButton.Location = new System.Drawing.Point(340, 208);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(109, 42);
            this.factorialButton.TabIndex = 17;
            this.factorialButton.Text = "Factorial";
            this.factorialButton.UseVisualStyleBackColor = false;
            this.factorialButton.Click += new System.EventHandler(this.factorialButton_Click);
            // 
            // labelNested
            // 
            this.labelNested.AutoSize = true;
            this.labelNested.BackColor = System.Drawing.SystemColors.Control;
            this.labelNested.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNested.ForeColor = System.Drawing.Color.Cyan;
            this.labelNested.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelNested.Location = new System.Drawing.Point(624, 175);
            this.labelNested.Name = "labelNested";
            this.labelNested.Size = new System.Drawing.Size(61, 18);
            this.labelNested.TabIndex = 18;
            this.labelNested.Text = "Nested";
            // 
            // nestedButton
            // 
            this.nestedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nestedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nestedButton.ForeColor = System.Drawing.Color.Cyan;
            this.nestedButton.Location = new System.Drawing.Point(601, 208);
            this.nestedButton.Name = "nestedButton";
            this.nestedButton.Size = new System.Drawing.Size(109, 42);
            this.nestedButton.TabIndex = 21;
            this.nestedButton.Text = "Pyramid";
            this.nestedButton.UseVisualStyleBackColor = false;
            this.nestedButton.Click += new System.EventHandler(this.nestedButton_Click);
            // 
            // Looping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_24_134032;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nestedButton);
            this.Controls.Add(this.labelNested);
            this.Controls.Add(this.factorialButton);
            this.Controls.Add(this.textboxFactorial);
            this.Controls.Add(this.labelEnterNumFactorial);
            this.Controls.Add(this.labelFactorial);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.exitButtonOperations);
            this.Controls.Add(this.mainMenuConversion);
            this.Controls.Add(this.getsumButton);
            this.Controls.Add(this.textboxSoN);
            this.Controls.Add(this.labelEnterSoN);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelLoop);
            this.Name = "Looping";
            this.Text = "Looping";
            this.Load += new System.EventHandler(this.Looping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoop;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelEnterSoN;
        private System.Windows.Forms.TextBox textboxSoN;
        private System.Windows.Forms.Button getsumButton;
        private System.Windows.Forms.Button mainMenuConversion;
        private System.Windows.Forms.Button exitButtonOperations;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelFactorial;
        private System.Windows.Forms.Label labelEnterNumFactorial;
        private System.Windows.Forms.TextBox textboxFactorial;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.Label labelNested;
        private System.Windows.Forms.Button nestedButton;
    }
}