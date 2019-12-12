using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Memory_Game
{
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            if (File.Exists("order.txt"))
            {
                var first10Lines = string.Join("\r\n", File.ReadLines("order.txt").Take(10)); //laadt alleen de eerste 10 regels van het bestand.

                richTextBox1.Text = first10Lines;
            }
            else
            {
                MessageBox.Show("Er zijn nog geen opgeslagen highscores!", "Error", MessageBoxButtons.OK);
            }
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
