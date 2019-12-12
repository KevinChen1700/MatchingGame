namespace Memory_Game
{
    partial class NaamInvoeren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaamInvoeren));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioKerst = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RadioKM = new System.Windows.Forms.RadioButton();
            this.RadioSH = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Naam_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kies een thema:";
            // 
            // RadioKerst
            // 
            this.RadioKerst.AutoSize = true;
            this.RadioKerst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioKerst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioKerst.Location = new System.Drawing.Point(12, 160);
            this.RadioKerst.Name = "RadioKerst";
            this.RadioKerst.Size = new System.Drawing.Size(56, 20);
            this.RadioKerst.TabIndex = 10;
            this.RadioKerst.Text = "Kerst";
            this.RadioKerst.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 91);
            this.button1.TabIndex = 11;
            this.button1.Text = "Doorgaan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Voer je naam in en kies een thema.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Druk dan op \'Doorgaan\' om het spel te starten.";
            // 
            // RadioKM
            // 
            this.RadioKM.AutoSize = true;
            this.RadioKM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioKM.Location = new System.Drawing.Point(12, 186);
            this.RadioKM.Name = "RadioKM";
            this.RadioKM.Size = new System.Drawing.Size(116, 20);
            this.RadioKM.TabIndex = 14;
            this.RadioKM.Text = "Kledingmerken";
            this.RadioKM.UseVisualStyleBackColor = true;
            // 
            // RadioSH
            // 
            this.RadioSH.AutoSize = true;
            this.RadioSH.Checked = true;
            this.RadioSH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioSH.Location = new System.Drawing.Point(12, 134);
            this.RadioSH.Name = "RadioSH";
            this.RadioSH.Size = new System.Drawing.Size(103, 20);
            this.RadioSH.TabIndex = 15;
            this.RadioSH.TabStop = true;
            this.RadioSH.Text = "Superhelden";
            this.RadioSH.UseVisualStyleBackColor = true;
            // 
            // NaamInvoeren
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 241);
            this.Controls.Add(this.RadioSH);
            this.Controls.Add(this.RadioKM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RadioKerst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NaamInvoeren";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory - Één speler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioKerst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RadioKM;
        private System.Windows.Forms.RadioButton RadioSH;
    }
}