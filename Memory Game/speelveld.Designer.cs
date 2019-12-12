namespace Memory_Game
{
    partial class speelveld
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(speelveld));
            this.TimerTijd = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Timer_speelveld = new System.Windows.Forms.Label();
            this.setsp2 = new System.Windows.Forms.Label();
            this.p2zetlabel = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.setsp1 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetbutton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.imageListsuperhelden = new System.Windows.Forms.ImageList(this.components);
            this.imageListerst = new System.Windows.Forms.ImageList(this.components);
            this.imageListkledingmerken = new System.Windows.Forms.ImageList(this.components);
            this.p1zetlabel = new System.Windows.Forms.Label();
            this.p1zet = new System.Windows.Forms.Label();
            this.p2zet = new System.Windows.Forms.Label();
            this.p2set = new System.Windows.Forms.Label();
            this.p1set = new System.Windows.Forms.Label();
            this.ScoreP2 = new System.Windows.Forms.Label();
            this.ScoreP1 = new System.Windows.Forms.Label();
            this.ScoreP1Num = new System.Windows.Forms.Label();
            this.ScoreP2Num = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerTijd
            // 
            this.TimerTijd.Interval = 1000;
            this.TimerTijd.Tick += new System.EventHandler(this.TimerTijd_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 550);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // Timer_speelveld
            // 
            this.Timer_speelveld.AutoSize = true;
            this.Timer_speelveld.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_speelveld.Location = new System.Drawing.Point(272, 14);
            this.Timer_speelveld.Name = "Timer_speelveld";
            this.Timer_speelveld.Size = new System.Drawing.Size(26, 29);
            this.Timer_speelveld.TabIndex = 30;
            this.Timer_speelveld.Text = "0";
            // 
            // setsp2
            // 
            this.setsp2.AutoSize = true;
            this.setsp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.setsp2.Location = new System.Drawing.Point(404, 14);
            this.setsp2.Name = "setsp2";
            this.setsp2.Size = new System.Drawing.Size(51, 17);
            this.setsp2.TabIndex = 29;
            this.setsp2.Text = "Setjes:";
            // 
            // p2zetlabel
            // 
            this.p2zetlabel.AutoSize = true;
            this.p2zetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p2zetlabel.Location = new System.Drawing.Point(492, 35);
            this.p2zetlabel.Name = "p2zetlabel";
            this.p2zetlabel.Size = new System.Drawing.Size(33, 17);
            this.p2zetlabel.TabIndex = 28;
            this.p2zetlabel.Text = "Zet:";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.player2.Location = new System.Drawing.Point(492, 14);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(56, 17);
            this.player2.TabIndex = 27;
            this.player2.Text = "Player2";
            // 
            // setsp1
            // 
            this.setsp1.AutoSize = true;
            this.setsp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.setsp1.Location = new System.Drawing.Point(83, 14);
            this.setsp1.Name = "setsp1";
            this.setsp1.Size = new System.Drawing.Size(51, 17);
            this.setsp1.TabIndex = 26;
            this.setsp1.Text = "Setjes:";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.player1.Location = new System.Drawing.Point(22, 14);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(54, 16);
            this.player1.TabIndex = 24;
            this.player1.Text = "Player1";
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(10, 630);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 23);
            this.resetbutton.TabIndex = 32;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(485, 630);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 33;
            this.exit.Text = "Afsluiten";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.afsluiten2_Click);
            // 
            // imageListsuperhelden
            // 
            this.imageListsuperhelden.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListsuperhelden.ImageStream")));
            this.imageListsuperhelden.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListsuperhelden.Images.SetKeyName(0, "img1.jpg");
            this.imageListsuperhelden.Images.SetKeyName(1, "img2.jpg");
            this.imageListsuperhelden.Images.SetKeyName(2, "img3.jpg");
            this.imageListsuperhelden.Images.SetKeyName(3, "img4.jpg");
            this.imageListsuperhelden.Images.SetKeyName(4, "img5.jpg");
            this.imageListsuperhelden.Images.SetKeyName(5, "img6.jpg");
            this.imageListsuperhelden.Images.SetKeyName(6, "img7.jpg");
            this.imageListsuperhelden.Images.SetKeyName(7, "img8.jpg");
            // 
            // imageListerst
            // 
            this.imageListerst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListerst.ImageStream")));
            this.imageListerst.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListerst.Images.SetKeyName(0, "1.png");
            this.imageListerst.Images.SetKeyName(1, "2.png");
            this.imageListerst.Images.SetKeyName(2, "3.png");
            this.imageListerst.Images.SetKeyName(3, "4.png");
            this.imageListerst.Images.SetKeyName(4, "5.png");
            this.imageListerst.Images.SetKeyName(5, "6.png");
            this.imageListerst.Images.SetKeyName(6, "7.png");
            this.imageListerst.Images.SetKeyName(7, "8.png");
            // 
            // imageListkledingmerken
            // 
            this.imageListkledingmerken.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListkledingmerken.ImageStream")));
            this.imageListkledingmerken.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListkledingmerken.Images.SetKeyName(0, "gucci.png");
            this.imageListkledingmerken.Images.SetKeyName(1, "mango.png");
            this.imageListkledingmerken.Images.SetKeyName(2, "oilily.png");
            this.imageListkledingmerken.Images.SetKeyName(3, "ralphlauren.png");
            this.imageListkledingmerken.Images.SetKeyName(4, "soliver.png");
            this.imageListkledingmerken.Images.SetKeyName(5, "tommy_hilfiger.png");
            this.imageListkledingmerken.Images.SetKeyName(6, "WE.png");
            this.imageListkledingmerken.Images.SetKeyName(7, "zara.png");
            // 
            // p1zetlabel
            // 
            this.p1zetlabel.AutoSize = true;
            this.p1zetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p1zetlabel.Location = new System.Drawing.Point(22, 35);
            this.p1zetlabel.Name = "p1zetlabel";
            this.p1zetlabel.Size = new System.Drawing.Size(33, 17);
            this.p1zetlabel.TabIndex = 36;
            this.p1zetlabel.Text = "Zet:";
            // 
            // p1zet
            // 
            this.p1zet.AutoSize = true;
            this.p1zet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p1zet.Location = new System.Drawing.Point(57, 35);
            this.p1zet.Name = "p1zet";
            this.p1zet.Size = new System.Drawing.Size(16, 17);
            this.p1zet.TabIndex = 35;
            this.p1zet.Text = "0";
            // 
            // p2zet
            // 
            this.p2zet.AutoSize = true;
            this.p2zet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p2zet.Location = new System.Drawing.Point(531, 35);
            this.p2zet.Name = "p2zet";
            this.p2zet.Size = new System.Drawing.Size(16, 17);
            this.p2zet.TabIndex = 37;
            this.p2zet.Text = "0";
            // 
            // p2set
            // 
            this.p2set.AutoSize = true;
            this.p2set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p2set.Location = new System.Drawing.Point(461, 13);
            this.p2set.Name = "p2set";
            this.p2set.Size = new System.Drawing.Size(16, 17);
            this.p2set.TabIndex = 38;
            this.p2set.Text = "0";
            // 
            // p1set
            // 
            this.p1set.AutoSize = true;
            this.p1set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.p1set.Location = new System.Drawing.Point(140, 13);
            this.p1set.Name = "p1set";
            this.p1set.Size = new System.Drawing.Size(16, 17);
            this.p1set.TabIndex = 39;
            this.p1set.Text = "0";
            // 
            // ScoreP2
            // 
            this.ScoreP2.AutoSize = true;
            this.ScoreP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ScoreP2.Location = new System.Drawing.Point(404, 35);
            this.ScoreP2.Name = "ScoreP2";
            this.ScoreP2.Size = new System.Drawing.Size(53, 17);
            this.ScoreP2.TabIndex = 40;
            this.ScoreP2.Text = "Score: ";
            // 
            // ScoreP1
            // 
            this.ScoreP1.AutoSize = true;
            this.ScoreP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ScoreP1.Location = new System.Drawing.Point(83, 35);
            this.ScoreP1.Name = "ScoreP1";
            this.ScoreP1.Size = new System.Drawing.Size(53, 17);
            this.ScoreP1.TabIndex = 41;
            this.ScoreP1.Text = "Score: ";
            // 
            // ScoreP1Num
            // 
            this.ScoreP1Num.AutoSize = true;
            this.ScoreP1Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ScoreP1Num.Location = new System.Drawing.Point(140, 35);
            this.ScoreP1Num.Name = "ScoreP1Num";
            this.ScoreP1Num.Size = new System.Drawing.Size(16, 17);
            this.ScoreP1Num.TabIndex = 42;
            this.ScoreP1Num.Text = "0";
            // 
            // ScoreP2Num
            // 
            this.ScoreP2Num.AutoSize = true;
            this.ScoreP2Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ScoreP2Num.Location = new System.Drawing.Point(461, 35);
            this.ScoreP2Num.Name = "ScoreP2Num";
            this.ScoreP2Num.Size = new System.Drawing.Size(16, 17);
            this.ScoreP2Num.TabIndex = 43;
            this.ScoreP2Num.Text = "0";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(248, 630);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 44;
            this.save.Text = "Opslaan";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Saveknop_Click);
            // 
            // speelveld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 665);
            this.Controls.Add(this.save);
            this.Controls.Add(this.ScoreP2Num);
            this.Controls.Add(this.ScoreP1Num);
            this.Controls.Add(this.ScoreP1);
            this.Controls.Add(this.ScoreP2);
            this.Controls.Add(this.p1set);
            this.Controls.Add(this.p2set);
            this.Controls.Add(this.p2zet);
            this.Controls.Add(this.p1zetlabel);
            this.Controls.Add(this.p1zet);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Timer_speelveld);
            this.Controls.Add(this.setsp2);
            this.Controls.Add(this.p2zetlabel);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.setsp1);
            this.Controls.Add(this.player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "speelveld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory -  Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.speelveld_FormClosing);
            this.Load += new System.EventHandler(this.speelveld_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerTijd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Timer_speelveld;
        private System.Windows.Forms.Label setsp2;
        private System.Windows.Forms.Label p2zetlabel;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label setsp1;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ImageList imageListsuperhelden;
        private System.Windows.Forms.ImageList imageListerst;
        private System.Windows.Forms.ImageList imageListkledingmerken;
        private System.Windows.Forms.Label p1zetlabel;
        private System.Windows.Forms.Label p1zet;
        private System.Windows.Forms.Label p2zet;
        private System.Windows.Forms.Label p2set;
        private System.Windows.Forms.Label p1set;
        private System.Windows.Forms.Label ScoreP2;
        private System.Windows.Forms.Label ScoreP1;
        private System.Windows.Forms.Label ScoreP1Num;
        private System.Windows.Forms.Label ScoreP2Num;
        private System.Windows.Forms.Button save;
    }
}