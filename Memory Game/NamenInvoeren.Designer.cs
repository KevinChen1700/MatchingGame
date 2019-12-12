namespace Memory_Game
{
    partial class NamenInvoeren
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RadioSH = new System.Windows.Forms.RadioButton();
            this.RadioKM = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RadioKerst = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Namen_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speler 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speler 2: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 89);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Namen_KeyPress);
            // 
            // RadioSH
            // 
            this.RadioSH.AutoSize = true;
            this.RadioSH.Checked = true;
            this.RadioSH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioSH.Location = new System.Drawing.Point(14, 140);
            this.RadioSH.Name = "RadioSH";
            this.RadioSH.Size = new System.Drawing.Size(103, 20);
            this.RadioSH.TabIndex = 24;
            this.RadioSH.TabStop = true;
            this.RadioSH.Text = "Superhelden";
            this.RadioSH.UseVisualStyleBackColor = true;
            // 
            // RadioKM
            // 
            this.RadioKM.AutoSize = true;
            this.RadioKM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioKM.Location = new System.Drawing.Point(14, 192);
            this.RadioKM.Name = "RadioKM";
            this.RadioKM.Size = new System.Drawing.Size(116, 20);
            this.RadioKM.TabIndex = 23;
            this.RadioKM.Text = "Kledingmerken";
            this.RadioKM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Druk dan op \'Doorgaan\' om het spel te starten.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Voer de namen in en kies een thema.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 91);
            this.button1.TabIndex = 20;
            this.button1.Text = "Doorgaan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RadioKerst
            // 
            this.RadioKerst.AutoSize = true;
            this.RadioKerst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioKerst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RadioKerst.Location = new System.Drawing.Point(14, 166);
            this.RadioKerst.Name = "RadioKerst";
            this.RadioKerst.Size = new System.Drawing.Size(56, 20);
            this.RadioKerst.TabIndex = 19;
            this.RadioKerst.Text = "Kerst";
            this.RadioKerst.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label5.Location = new System.Drawing.Point(11, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kies een thema:";
            // 
            // NamenInvoeren
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 241);
            this.Controls.Add(this.RadioSH);
            this.Controls.Add(this.RadioKM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RadioKerst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NamenInvoeren";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory - Twee spelers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton RadioSH;
        private System.Windows.Forms.RadioButton RadioKM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RadioKerst;
        private System.Windows.Forms.Label label5;
    }
}