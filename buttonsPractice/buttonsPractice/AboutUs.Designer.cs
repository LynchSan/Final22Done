namespace buttonsPractice
{
    partial class AboutUs
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
            this.exitButtonMain = new System.Windows.Forms.Button();
            this.mainMenu2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButtonMain
            // 
            this.exitButtonMain.BackColor = System.Drawing.Color.DarkRed;
            this.exitButtonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButtonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtonMain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButtonMain.Location = new System.Drawing.Point(736, 411);
            this.exitButtonMain.Name = "exitButtonMain";
            this.exitButtonMain.Size = new System.Drawing.Size(52, 27);
            this.exitButtonMain.TabIndex = 9;
            this.exitButtonMain.Text = "Exit";
            this.exitButtonMain.UseVisualStyleBackColor = false;
            this.exitButtonMain.Click += new System.EventHandler(this.exitButtonMain_Click);
            // 
            // mainMenu2
            // 
            this.mainMenu2.BackColor = System.Drawing.Color.Black;
            this.mainMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenu2.Location = new System.Drawing.Point(12, 411);
            this.mainMenu2.Name = "mainMenu2";
            this.mainMenu2.Size = new System.Drawing.Size(31, 32);
            this.mainMenu2.TabIndex = 12;
            this.mainMenu2.Text = "<";
            this.mainMenu2.UseVisualStyleBackColor = false;
            this.mainMenu2.Click += new System.EventHandler(this.mainMenu2_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::buttonsPractice.Properties.Resources.aboutUs;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu2);
            this.Controls.Add(this.exitButtonMain);
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButtonMain;
        private System.Windows.Forms.Button mainMenu2;
    }
}