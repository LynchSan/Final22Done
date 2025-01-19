namespace buttonsPractice
{
    partial class ConversionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelMetric = new System.Windows.Forms.Label();
            this.labelNumtoWord = new System.Windows.Forms.Label();
            this.labelCFK = new System.Windows.Forms.Label();
            this.textboxCFK = new System.Windows.Forms.TextBox();
            this.labelEnterCFK = new System.Windows.Forms.Label();
            this.convertTempButton = new System.Windows.Forms.Button();
            this.mainMenuConversion = new System.Windows.Forms.Button();
            this.exitButtonConversion = new System.Windows.Forms.Button();
            this.labelMetricEnterNum = new System.Windows.Forms.Label();
            this.labelNtoWEnterNum = new System.Windows.Forms.Label();
            this.textboxMetric = new System.Windows.Forms.TextBox();
            this.textboxNtoW = new System.Windows.Forms.TextBox();
            this.metricButton = new System.Windows.Forms.Button();
            this.numtowordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(262, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Conversion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.SystemColors.Control;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.Color.Cyan;
            this.labelTemp.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelTemp.Location = new System.Drawing.Point(37, 149);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(194, 18);
            this.labelTemp.TabIndex = 1;
            this.labelTemp.Text = "Temperature Conversion";
            // 
            // labelMetric
            // 
            this.labelMetric.AutoSize = true;
            this.labelMetric.BackColor = System.Drawing.SystemColors.Control;
            this.labelMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetric.ForeColor = System.Drawing.Color.Cyan;
            this.labelMetric.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelMetric.Location = new System.Drawing.Point(334, 149);
            this.labelMetric.Name = "labelMetric";
            this.labelMetric.Size = new System.Drawing.Size(115, 18);
            this.labelMetric.TabIndex = 2;
            this.labelMetric.Text = "      Metric      ";
            // 
            // labelNumtoWord
            // 
            this.labelNumtoWord.AutoSize = true;
            this.labelNumtoWord.BackColor = System.Drawing.SystemColors.Control;
            this.labelNumtoWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumtoWord.ForeColor = System.Drawing.Color.Cyan;
            this.labelNumtoWord.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelNumtoWord.Location = new System.Drawing.Point(589, 149);
            this.labelNumtoWord.Name = "labelNumtoWord";
            this.labelNumtoWord.Size = new System.Drawing.Size(151, 18);
            this.labelNumtoWord.TabIndex = 3;
            this.labelNumtoWord.Text = "Numbers to Words";
            // 
            // labelCFK
            // 
            this.labelCFK.AutoSize = true;
            this.labelCFK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCFK.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCFK.ForeColor = System.Drawing.Color.Lime;
            this.labelCFK.Location = new System.Drawing.Point(59, 354);
            this.labelCFK.Name = "labelCFK";
            this.labelCFK.Size = new System.Drawing.Size(74, 17);
            this.labelCFK.TabIndex = 4;
            this.labelCFK.Text = "RESULT";
            // 
            // textboxCFK
            // 
            this.textboxCFK.BackColor = System.Drawing.Color.Black;
            this.textboxCFK.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCFK.ForeColor = System.Drawing.Color.Lime;
            this.textboxCFK.Location = new System.Drawing.Point(45, 210);
            this.textboxCFK.Name = "textboxCFK";
            this.textboxCFK.Size = new System.Drawing.Size(186, 27);
            this.textboxCFK.TabIndex = 5;
            this.textboxCFK.TextChanged += new System.EventHandler(this.textboxCFK_TextChanged);
            // 
            // labelEnterCFK
            // 
            this.labelEnterCFK.AutoSize = true;
            this.labelEnterCFK.BackColor = System.Drawing.SystemColors.Control;
            this.labelEnterCFK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterCFK.ForeColor = System.Drawing.Color.Cyan;
            this.labelEnterCFK.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelEnterCFK.Location = new System.Drawing.Point(74, 189);
            this.labelEnterCFK.Name = "labelEnterCFK";
            this.labelEnterCFK.Size = new System.Drawing.Size(123, 18);
            this.labelEnterCFK.TabIndex = 6;
            this.labelEnterCFK.Text = "Enter a number";
            // 
            // convertTempButton
            // 
            this.convertTempButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.convertTempButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertTempButton.ForeColor = System.Drawing.Color.Cyan;
            this.convertTempButton.Location = new System.Drawing.Point(77, 255);
            this.convertTempButton.Name = "convertTempButton";
            this.convertTempButton.Size = new System.Drawing.Size(109, 42);
            this.convertTempButton.TabIndex = 7;
            this.convertTempButton.Text = "Convert Temperature";
            this.convertTempButton.UseVisualStyleBackColor = false;
            this.convertTempButton.Click += new System.EventHandler(this.convertTempButton_Click);
            // 
            // mainMenuConversion
            // 
            this.mainMenuConversion.BackColor = System.Drawing.Color.Black;
            this.mainMenuConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuConversion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenuConversion.Location = new System.Drawing.Point(6, 398);
            this.mainMenuConversion.Name = "mainMenuConversion";
            this.mainMenuConversion.Size = new System.Drawing.Size(47, 40);
            this.mainMenuConversion.TabIndex = 10;
            this.mainMenuConversion.Text = "<";
            this.mainMenuConversion.UseVisualStyleBackColor = false;
            this.mainMenuConversion.Click += new System.EventHandler(this.mainMenuConversion_Click);
            // 
            // exitButtonConversion
            // 
            this.exitButtonConversion.BackColor = System.Drawing.Color.DarkRed;
            this.exitButtonConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButtonConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtonConversion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButtonConversion.Location = new System.Drawing.Point(736, 411);
            this.exitButtonConversion.Name = "exitButtonConversion";
            this.exitButtonConversion.Size = new System.Drawing.Size(52, 27);
            this.exitButtonConversion.TabIndex = 11;
            this.exitButtonConversion.Text = "Exit";
            this.exitButtonConversion.UseVisualStyleBackColor = false;
            this.exitButtonConversion.Click += new System.EventHandler(this.exitButtonConversion_Click);
            // 
            // labelMetricEnterNum
            // 
            this.labelMetricEnterNum.AutoSize = true;
            this.labelMetricEnterNum.BackColor = System.Drawing.SystemColors.Control;
            this.labelMetricEnterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetricEnterNum.ForeColor = System.Drawing.Color.Cyan;
            this.labelMetricEnterNum.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelMetricEnterNum.Location = new System.Drawing.Point(334, 189);
            this.labelMetricEnterNum.Name = "labelMetricEnterNum";
            this.labelMetricEnterNum.Size = new System.Drawing.Size(123, 18);
            this.labelMetricEnterNum.TabIndex = 12;
            this.labelMetricEnterNum.Text = "Enter a number";
            // 
            // labelNtoWEnterNum
            // 
            this.labelNtoWEnterNum.AutoSize = true;
            this.labelNtoWEnterNum.BackColor = System.Drawing.SystemColors.Control;
            this.labelNtoWEnterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNtoWEnterNum.ForeColor = System.Drawing.Color.Cyan;
            this.labelNtoWEnterNum.Image = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_08_2131591;
            this.labelNtoWEnterNum.Location = new System.Drawing.Point(603, 191);
            this.labelNtoWEnterNum.Name = "labelNtoWEnterNum";
            this.labelNtoWEnterNum.Size = new System.Drawing.Size(123, 18);
            this.labelNtoWEnterNum.TabIndex = 13;
            this.labelNtoWEnterNum.Text = "Enter a number";
            // 
            // textboxMetric
            // 
            this.textboxMetric.BackColor = System.Drawing.Color.Black;
            this.textboxMetric.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMetric.ForeColor = System.Drawing.Color.Lime;
            this.textboxMetric.Location = new System.Drawing.Point(307, 212);
            this.textboxMetric.Name = "textboxMetric";
            this.textboxMetric.Size = new System.Drawing.Size(186, 27);
            this.textboxMetric.TabIndex = 14;
            // 
            // textboxNtoW
            // 
            this.textboxNtoW.BackColor = System.Drawing.Color.Black;
            this.textboxNtoW.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxNtoW.ForeColor = System.Drawing.Color.Lime;
            this.textboxNtoW.Location = new System.Drawing.Point(572, 212);
            this.textboxNtoW.Name = "textboxNtoW";
            this.textboxNtoW.Size = new System.Drawing.Size(186, 27);
            this.textboxNtoW.TabIndex = 15;
            // 
            // metricButton
            // 
            this.metricButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricButton.ForeColor = System.Drawing.Color.Cyan;
            this.metricButton.Location = new System.Drawing.Point(348, 255);
            this.metricButton.Name = "metricButton";
            this.metricButton.Size = new System.Drawing.Size(109, 42);
            this.metricButton.TabIndex = 16;
            this.metricButton.Text = "Convert Metric";
            this.metricButton.UseVisualStyleBackColor = false;
            this.metricButton.Click += new System.EventHandler(this.metricButton_Click);
            // 
            // numtowordButton
            // 
            this.numtowordButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numtowordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numtowordButton.ForeColor = System.Drawing.Color.Cyan;
            this.numtowordButton.Location = new System.Drawing.Point(617, 255);
            this.numtowordButton.Name = "numtowordButton";
            this.numtowordButton.Size = new System.Drawing.Size(109, 42);
            this.numtowordButton.TabIndex = 17;
            this.numtowordButton.Text = "Convert Number";
            this.numtowordButton.UseVisualStyleBackColor = false;
            this.numtowordButton.Click += new System.EventHandler(this.numtowordButton_Click);
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2025_01_19_202112;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numtowordButton);
            this.Controls.Add(this.metricButton);
            this.Controls.Add(this.textboxNtoW);
            this.Controls.Add(this.textboxMetric);
            this.Controls.Add(this.labelNtoWEnterNum);
            this.Controls.Add(this.labelMetricEnterNum);
            this.Controls.Add(this.exitButtonConversion);
            this.Controls.Add(this.mainMenuConversion);
            this.Controls.Add(this.convertTempButton);
            this.Controls.Add(this.labelEnterCFK);
            this.Controls.Add(this.textboxCFK);
            this.Controls.Add(this.labelCFK);
            this.Controls.Add(this.labelNumtoWord);
            this.Controls.Add(this.labelMetric);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ConversionForm";
            this.Text = "ConversionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelMetric;
        private System.Windows.Forms.Label labelNumtoWord;
        private System.Windows.Forms.Label labelCFK;
        private System.Windows.Forms.TextBox textboxCFK;
        private System.Windows.Forms.Label labelEnterCFK;
        private System.Windows.Forms.Button convertTempButton;
        private System.Windows.Forms.Button mainMenuConversion;
        private System.Windows.Forms.Button exitButtonConversion;
        private System.Windows.Forms.Label labelMetricEnterNum;
        private System.Windows.Forms.Label labelNtoWEnterNum;
        private System.Windows.Forms.TextBox textboxMetric;
        private System.Windows.Forms.TextBox textboxNtoW;
        private System.Windows.Forms.Button metricButton;
        private System.Windows.Forms.Button numtowordButton;
    }
}