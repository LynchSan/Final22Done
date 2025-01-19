namespace buttonsPractice
{
    partial class Rps
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
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.mainMenu2 = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.outcome = new System.Windows.Forms.Label();
            this.labelAiscore = new System.Windows.Forms.Label();
            this.buttonDebug = new System.Windows.Forms.Button();
            this.pictureBoxAipick = new System.Windows.Forms.PictureBox();
            this.exitButtonConversion = new System.Windows.Forms.Button();
            this.pictureBoxAi = new System.Windows.Forms.PictureBox();
            this.pictureScissor = new System.Windows.Forms.PictureBox();
            this.paperImage = new System.Windows.Forms.PictureBox();
            this.pictureRock = new System.Windows.Forms.PictureBox();
            this.playerPickedLabel = new System.Windows.Forms.Label();
            this.aiPickedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAipick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRock)).BeginInit();
            this.SuspendLayout();
            // 
            // rockButton
            // 
            this.rockButton.BackColor = System.Drawing.Color.Black;
            this.rockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rockButton.Enabled = false;
            this.rockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rockButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockButton.ForeColor = System.Drawing.Color.Aqua;
            this.rockButton.Location = new System.Drawing.Point(146, 351);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(97, 25);
            this.rockButton.TabIndex = 12;
            this.rockButton.Text = "ROCK";
            this.rockButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rockButton.UseVisualStyleBackColor = false;
            this.rockButton.Visible = false;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.BackColor = System.Drawing.Color.Black;
            this.paperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paperButton.Enabled = false;
            this.paperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paperButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.paperButton.Location = new System.Drawing.Point(342, 351);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(97, 25);
            this.paperButton.TabIndex = 16;
            this.paperButton.Text = "PAPER";
            this.paperButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.paperButton.UseVisualStyleBackColor = false;
            this.paperButton.Visible = false;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.BackColor = System.Drawing.Color.Black;
            this.scissorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scissorButton.Enabled = false;
            this.scissorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scissorButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorButton.ForeColor = System.Drawing.Color.Yellow;
            this.scissorButton.Location = new System.Drawing.Point(538, 351);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(97, 25);
            this.scissorButton.TabIndex = 17;
            this.scissorButton.Text = "SCISSOR";
            this.scissorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scissorButton.UseVisualStyleBackColor = false;
            this.scissorButton.Visible = false;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
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
            this.mainMenu2.TabIndex = 19;
            this.mainMenu2.Text = "<";
            this.mainMenu2.UseVisualStyleBackColor = false;
            this.mainMenu2.Click += new System.EventHandler(this.mainMenu2_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Black;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Red;
            this.playButton.Location = new System.Drawing.Point(362, 399);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(61, 24);
            this.playButton.TabIndex = 21;
            this.playButton.Text = "PLAY";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelScore.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.labelScore.Location = new System.Drawing.Point(12, 22);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(74, 17);
            this.labelScore.TabIndex = 22;
            this.labelScore.Text = "SCORE:";
            // 
            // outcome
            // 
            this.outcome.AutoSize = true;
            this.outcome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outcome.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcome.ForeColor = System.Drawing.Color.Lime;
            this.outcome.Location = new System.Drawing.Point(359, 22);
            this.outcome.Name = "outcome";
            this.outcome.Size = new System.Drawing.Size(52, 17);
            this.outcome.TabIndex = 23;
            this.outcome.Text = "NONE";
            this.outcome.Visible = false;
            // 
            // labelAiscore
            // 
            this.labelAiscore.AutoSize = true;
            this.labelAiscore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAiscore.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAiscore.ForeColor = System.Drawing.Color.Red;
            this.labelAiscore.Location = new System.Drawing.Point(651, 22);
            this.labelAiscore.Name = "labelAiscore";
            this.labelAiscore.Size = new System.Drawing.Size(107, 17);
            this.labelAiscore.TabIndex = 24;
            this.labelAiscore.Text = "AI SCORE:";
            // 
            // buttonDebug
            // 
            this.buttonDebug.BackColor = System.Drawing.Color.Black;
            this.buttonDebug.Enabled = false;
            this.buttonDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDebug.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDebug.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDebug.Location = new System.Drawing.Point(12, 342);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(63, 34);
            this.buttonDebug.TabIndex = 26;
            this.buttonDebug.Text = "Cheat";
            this.buttonDebug.UseVisualStyleBackColor = false;
            this.buttonDebug.Visible = false;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // pictureBoxAipick
            // 
            this.pictureBoxAipick.BackColor = System.Drawing.Color.Magenta;
            this.pictureBoxAipick.BackgroundImage = global::buttonsPractice.Properties.Resources.hand;
            this.pictureBoxAipick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAipick.Location = new System.Drawing.Point(396, 51);
            this.pictureBoxAipick.Name = "pictureBoxAipick";
            this.pictureBoxAipick.Size = new System.Drawing.Size(244, 183);
            this.pictureBoxAipick.TabIndex = 25;
            this.pictureBoxAipick.TabStop = false;
            // 
            // exitButtonConversion
            // 
            this.exitButtonConversion.BackColor = System.Drawing.Color.DarkRed;
            this.exitButtonConversion.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_25_150731;
            this.exitButtonConversion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButtonConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButtonConversion.Font = new System.Drawing.Font("OCR A Extended", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtonConversion.ForeColor = System.Drawing.Color.Purple;
            this.exitButtonConversion.Location = new System.Drawing.Point(723, 399);
            this.exitButtonConversion.Name = "exitButtonConversion";
            this.exitButtonConversion.Size = new System.Drawing.Size(65, 40);
            this.exitButtonConversion.TabIndex = 20;
            this.exitButtonConversion.UseVisualStyleBackColor = false;
            this.exitButtonConversion.Click += new System.EventHandler(this.exitButtonConversion_Click);
            // 
            // pictureBoxAi
            // 
            this.pictureBoxAi.BackColor = System.Drawing.Color.Magenta;
            this.pictureBoxAi.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_25_153350;
            this.pictureBoxAi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAi.Location = new System.Drawing.Point(146, 51);
            this.pictureBoxAi.Name = "pictureBoxAi";
            this.pictureBoxAi.Size = new System.Drawing.Size(244, 183);
            this.pictureBoxAi.TabIndex = 18;
            this.pictureBoxAi.TabStop = false;
            this.pictureBoxAi.Click += new System.EventHandler(this.pictureBoxAi_Click);
            // 
            // pictureScissor
            // 
            this.pictureScissor.BackColor = System.Drawing.Color.Yellow;
            this.pictureScissor.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_25_152827;
            this.pictureScissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureScissor.Location = new System.Drawing.Point(538, 259);
            this.pictureScissor.Name = "pictureScissor";
            this.pictureScissor.Size = new System.Drawing.Size(97, 74);
            this.pictureScissor.TabIndex = 15;
            this.pictureScissor.TabStop = false;
            // 
            // paperImage
            // 
            this.paperImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.paperImage.BackgroundImage = global::buttonsPractice.Properties.Resources.Paper;
            this.paperImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paperImage.Location = new System.Drawing.Point(342, 259);
            this.paperImage.Name = "paperImage";
            this.paperImage.Size = new System.Drawing.Size(97, 74);
            this.paperImage.TabIndex = 14;
            this.paperImage.TabStop = false;
            // 
            // pictureRock
            // 
            this.pictureRock.BackColor = System.Drawing.Color.Cyan;
            this.pictureRock.BackgroundImage = global::buttonsPractice.Properties.Resources.Screenshot_2024_12_25_152822;
            this.pictureRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureRock.Location = new System.Drawing.Point(146, 259);
            this.pictureRock.Name = "pictureRock";
            this.pictureRock.Size = new System.Drawing.Size(97, 74);
            this.pictureRock.TabIndex = 13;
            this.pictureRock.TabStop = false;
            // 
            // playerPickedLabel
            // 
            this.playerPickedLabel.AutoSize = true;
            this.playerPickedLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playerPickedLabel.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPickedLabel.ForeColor = System.Drawing.Color.Lime;
            this.playerPickedLabel.Location = new System.Drawing.Point(22, 170);
            this.playerPickedLabel.Name = "playerPickedLabel";
            this.playerPickedLabel.Size = new System.Drawing.Size(118, 17);
            this.playerPickedLabel.TabIndex = 27;
            this.playerPickedLabel.Text = "Your pick:";
            // 
            // aiPickedLabel
            // 
            this.aiPickedLabel.AutoSize = true;
            this.aiPickedLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aiPickedLabel.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiPickedLabel.ForeColor = System.Drawing.Color.Lime;
            this.aiPickedLabel.Location = new System.Drawing.Point(646, 170);
            this.aiPickedLabel.Name = "aiPickedLabel";
            this.aiPickedLabel.Size = new System.Drawing.Size(96, 17);
            this.aiPickedLabel.TabIndex = 28;
            this.aiPickedLabel.Text = "AI pick:";
            // 
            // Rps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aiPickedLabel);
            this.Controls.Add(this.playerPickedLabel);
            this.Controls.Add(this.buttonDebug);
            this.Controls.Add(this.pictureBoxAipick);
            this.Controls.Add(this.labelAiscore);
            this.Controls.Add(this.outcome);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.exitButtonConversion);
            this.Controls.Add(this.mainMenu2);
            this.Controls.Add(this.pictureBoxAi);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.pictureScissor);
            this.Controls.Add(this.paperImage);
            this.Controls.Add(this.pictureRock);
            this.Controls.Add(this.rockButton);
            this.DoubleBuffered = true;
            this.Name = "Rps";
            this.Text = "Rps";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAipick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.PictureBox pictureRock;
        private System.Windows.Forms.PictureBox paperImage;
        private System.Windows.Forms.PictureBox pictureScissor;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.PictureBox pictureBoxAi;
        private System.Windows.Forms.Button mainMenu2;
        private System.Windows.Forms.Button exitButtonConversion;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label outcome;
        private System.Windows.Forms.Label labelAiscore;
        private System.Windows.Forms.PictureBox pictureBoxAipick;
        public System.Windows.Forms.Button buttonDebug;
        private System.Windows.Forms.Label playerPickedLabel;
        private System.Windows.Forms.Label aiPickedLabel;
    }
}