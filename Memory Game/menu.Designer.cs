namespace Memory_Game
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.singleplayer = new System.Windows.Forms.Button();
            this.multiplayer = new System.Windows.Forms.Button();
            this.hervatten = new System.Windows.Forms.Button();
            this.highscore = new System.Windows.Forms.Button();
            this.afsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleplayer
            // 
            this.singleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.singleplayer.Image = ((System.Drawing.Image)(resources.GetObject("singleplayer.Image")));
            this.singleplayer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.singleplayer.Location = new System.Drawing.Point(12, 15);
            this.singleplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.singleplayer.Name = "singleplayer";
            this.singleplayer.Size = new System.Drawing.Size(167, 154);
            this.singleplayer.TabIndex = 0;
            this.singleplayer.Text = "Één speler";
            this.singleplayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.singleplayer.UseVisualStyleBackColor = true;
            this.singleplayer.Click += new System.EventHandler(this.singleplayer_Click);
            // 
            // multiplayer
            // 
            this.multiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.multiplayer.Image = ((System.Drawing.Image)(resources.GetObject("multiplayer.Image")));
            this.multiplayer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiplayer.Location = new System.Drawing.Point(197, 15);
            this.multiplayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiplayer.Name = "multiplayer";
            this.multiplayer.Size = new System.Drawing.Size(167, 154);
            this.multiplayer.TabIndex = 1;
            this.multiplayer.Text = "Twee spelers";
            this.multiplayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.multiplayer.UseVisualStyleBackColor = true;
            this.multiplayer.Click += new System.EventHandler(this.multiplayer_Click);
            // 
            // hervatten
            // 
            this.hervatten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hervatten.Location = new System.Drawing.Point(15, 183);
            this.hervatten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hervatten.Name = "hervatten";
            this.hervatten.Size = new System.Drawing.Size(349, 92);
            this.hervatten.TabIndex = 2;
            this.hervatten.Text = "Hervatten";
            this.hervatten.UseVisualStyleBackColor = true;
            this.hervatten.Click += new System.EventHandler(this.hervatten_Click);
            // 
            // highscore
            // 
            this.highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.highscore.Location = new System.Drawing.Point(15, 292);
            this.highscore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(167, 154);
            this.highscore.TabIndex = 3;
            this.highscore.Text = "Highscores";
            this.highscore.UseVisualStyleBackColor = true;
            this.highscore.Click += new System.EventHandler(this.highscore_Click);
            // 
            // afsluiten
            // 
            this.afsluiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.afsluiten.Location = new System.Drawing.Point(195, 292);
            this.afsluiten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.afsluiten.Name = "afsluiten";
            this.afsluiten.Size = new System.Drawing.Size(167, 154);
            this.afsluiten.TabIndex = 4;
            this.afsluiten.Text = "Afsluiten";
            this.afsluiten.UseVisualStyleBackColor = true;
            this.afsluiten.Click += new System.EventHandler(this.afsluiten_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 459);
            this.Controls.Add(this.afsluiten);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.hervatten);
            this.Controls.Add(this.multiplayer);
            this.Controls.Add(this.singleplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory - Hoofdmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleplayer;
        private System.Windows.Forms.Button multiplayer;
        private System.Windows.Forms.Button hervatten;
        private System.Windows.Forms.Button highscore;
        private System.Windows.Forms.Button afsluiten;
    }
}

