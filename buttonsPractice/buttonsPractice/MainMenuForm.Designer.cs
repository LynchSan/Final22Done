namespace buttonsPractice
{
    partial class MainMenuForm
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
            this.welcomeText = new System.Windows.Forms.Label();
            this.pictureArithmetic = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.operationsButton = new System.Windows.Forms.Button();
            this.pictureGames = new System.Windows.Forms.PictureBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButtonMain = new System.Windows.Forms.Button();
            this.gamesButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Button();
            this.pictureCs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArithmetic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCs)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ForeColor = System.Drawing.Color.Aqua;
            this.welcomeText.Location = new System.Drawing.Point(239, 23);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(304, 27);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "WELCOME TO MAIN MENU";
            this.welcomeText.Click += new System.EventHandler(this.welcomeText_Click);
            // 
            // pictureArithmetic
            // 
            this.pictureArithmetic.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_07_214115;
            this.pictureArithmetic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureArithmetic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureArithmetic.Location = new System.Drawing.Point(500, 89);
            this.pictureArithmetic.Name = "pictureArithmetic";
            this.pictureArithmetic.Size = new System.Drawing.Size(143, 103);
            this.pictureArithmetic.TabIndex = 1;
            this.pictureArithmetic.TabStop = false;
            this.pictureArithmetic.Click += new System.EventHandler(this.pictureArithmetic_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkRed;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logoutButton.Location = new System.Drawing.Point(700, 381);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(88, 27);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // operationsButton
            // 
            this.operationsButton.BackColor = System.Drawing.Color.Black;
            this.operationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.operationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsButton.ForeColor = System.Drawing.Color.Aqua;
            this.operationsButton.Location = new System.Drawing.Point(524, 226);
            this.operationsButton.Name = "operationsButton";
            this.operationsButton.Size = new System.Drawing.Size(101, 26);
            this.operationsButton.TabIndex = 4;
            this.operationsButton.Text = "Operations";
            this.operationsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.operationsButton.UseVisualStyleBackColor = false;
            this.operationsButton.Click += new System.EventHandler(this.operationsButton_Click);
            // 
            // pictureGames
            // 
            this.pictureGames.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_25_143935;
            this.pictureGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureGames.Location = new System.Drawing.Point(137, 89);
            this.pictureGames.Name = "pictureGames";
            this.pictureGames.Size = new System.Drawing.Size(139, 103);
            this.pictureGames.TabIndex = 5;
            this.pictureGames.TabStop = false;
            this.pictureGames.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(74)))));
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.aboutButton.Location = new System.Drawing.Point(24, 411);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(92, 27);
            this.aboutButton.TabIndex = 7;
            this.aboutButton.Text = "About us";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButtonMain
            // 
            this.exitButtonMain.BackColor = System.Drawing.Color.DarkRed;
            this.exitButtonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButtonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtonMain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButtonMain.Location = new System.Drawing.Point(721, 414);
            this.exitButtonMain.Name = "exitButtonMain";
            this.exitButtonMain.Size = new System.Drawing.Size(52, 27);
            this.exitButtonMain.TabIndex = 8;
            this.exitButtonMain.Text = "Exit";
            this.exitButtonMain.UseVisualStyleBackColor = false;
            this.exitButtonMain.Click += new System.EventHandler(this.exitButtonMain_Click);
            // 
            // gamesButton
            // 
            this.gamesButton.BackColor = System.Drawing.Color.Black;
            this.gamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesButton.ForeColor = System.Drawing.Color.Aqua;
            this.gamesButton.Location = new System.Drawing.Point(152, 226);
            this.gamesButton.Name = "gamesButton";
            this.gamesButton.Size = new System.Drawing.Size(101, 26);
            this.gamesButton.TabIndex = 9;
            this.gamesButton.Text = "Games";
            this.gamesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gamesButton.UseVisualStyleBackColor = false;
            this.gamesButton.Click += new System.EventHandler(this.gamesButton_Click);
            // 
            // csButton
            // 
            this.csButton.BackColor = System.Drawing.Color.SlateBlue;
            this.csButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.csButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csButton.ForeColor = System.Drawing.Color.Transparent;
            this.csButton.Location = new System.Drawing.Point(329, 336);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(118, 26);
            this.csButton.TabIndex = 10;
            this.csButton.Text = "All About C#";
            this.csButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.csButton.UseVisualStyleBackColor = false;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            // 
            // pictureCs
            // 
            this.pictureCs.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_25_144439;
            this.pictureCs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCs.Location = new System.Drawing.Point(329, 173);
            this.pictureCs.Name = "pictureCs";
            this.pictureCs.Size = new System.Drawing.Size(118, 117);
            this.pictureCs.TabIndex = 11;
            this.pictureCs.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_07_212509;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureCs);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.gamesButton);
            this.Controls.Add(this.exitButtonMain);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.pictureGames);
            this.Controls.Add(this.operationsButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.pictureArithmetic);
            this.Controls.Add(this.welcomeText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "MainMenuForm";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArithmetic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.PictureBox pictureArithmetic;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button operationsButton;
        private System.Windows.Forms.PictureBox pictureGames;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButtonMain;
        private System.Windows.Forms.Button gamesButton;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.PictureBox pictureCs;
    }
}