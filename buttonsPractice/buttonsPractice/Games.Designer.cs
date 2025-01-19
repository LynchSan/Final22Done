namespace buttonsPractice
{
    partial class Games
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
            this.gamesButton = new System.Windows.Forms.Button();
            this.pictureRps = new System.Windows.Forms.PictureBox();
            this.rpsButton = new System.Windows.Forms.Button();
            this.mainMenu2 = new System.Windows.Forms.Button();
            this.exitButtonConversion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRps)).BeginInit();
            this.SuspendLayout();
            // 
            // gamesButton
            // 
            this.gamesButton.BackColor = System.Drawing.Color.Black;
            this.gamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesButton.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesButton.ForeColor = System.Drawing.Color.Aqua;
            this.gamesButton.Location = new System.Drawing.Point(254, 97);
            this.gamesButton.Name = "gamesButton";
            this.gamesButton.Size = new System.Drawing.Size(277, 67);
            this.gamesButton.TabIndex = 10;
            this.gamesButton.Text = "WELCOME TO OUR GAMES";
            this.gamesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gamesButton.UseVisualStyleBackColor = false;
            // 
            // pictureRps
            // 
            this.pictureRps.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_25_145801;
            this.pictureRps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureRps.Location = new System.Drawing.Point(329, 170);
            this.pictureRps.Name = "pictureRps";
            this.pictureRps.Size = new System.Drawing.Size(132, 107);
            this.pictureRps.TabIndex = 13;
            this.pictureRps.TabStop = false;
            // 
            // rpsButton
            // 
            this.rpsButton.BackColor = System.Drawing.Color.Black;
            this.rpsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rpsButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpsButton.ForeColor = System.Drawing.Color.Aqua;
            this.rpsButton.Location = new System.Drawing.Point(329, 296);
            this.rpsButton.Name = "rpsButton";
            this.rpsButton.Size = new System.Drawing.Size(132, 26);
            this.rpsButton.TabIndex = 14;
            this.rpsButton.Text = "R/P/S";
            this.rpsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rpsButton.UseVisualStyleBackColor = false;
            this.rpsButton.Click += new System.EventHandler(this.rpsButton_Click);
            // 
            // mainMenu2
            // 
            this.mainMenu2.BackColor = System.Drawing.Color.Black;
            this.mainMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenu2.Location = new System.Drawing.Point(12, 398);
            this.mainMenu2.Name = "mainMenu2";
            this.mainMenu2.Size = new System.Drawing.Size(47, 40);
            this.mainMenu2.TabIndex = 17;
            this.mainMenu2.Text = "<";
            this.mainMenu2.UseVisualStyleBackColor = false;
            this.mainMenu2.Click += new System.EventHandler(this.mainMenu2_Click);
            // 
            // exitButtonConversion
            // 
            this.exitButtonConversion.BackColor = System.Drawing.Color.DarkRed;
            this.exitButtonConversion.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_25_150731;
            this.exitButtonConversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButtonConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButtonConversion.Font = new System.Drawing.Font("OCR A Extended", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtonConversion.ForeColor = System.Drawing.Color.Purple;
            this.exitButtonConversion.Location = new System.Drawing.Point(723, 398);
            this.exitButtonConversion.Name = "exitButtonConversion";
            this.exitButtonConversion.Size = new System.Drawing.Size(65, 40);
            this.exitButtonConversion.TabIndex = 18;
            this.exitButtonConversion.UseVisualStyleBackColor = false;
            this.exitButtonConversion.Click += new System.EventHandler(this.exitButtonConversion_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_25_145210;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButtonConversion);
            this.Controls.Add(this.mainMenu2);
            this.Controls.Add(this.rpsButton);
            this.Controls.Add(this.pictureRps);
            this.Controls.Add(this.gamesButton);
            this.DoubleBuffered = true;
            this.Name = "Games";
            this.Text = "Games";
            ((System.ComponentModel.ISupportInitialize)(this.pictureRps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gamesButton;
        private System.Windows.Forms.PictureBox pictureRps;
        private System.Windows.Forms.Button rpsButton;
        private System.Windows.Forms.Button mainMenu2;
        private System.Windows.Forms.Button exitButtonConversion;
    }
}