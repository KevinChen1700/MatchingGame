using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class NaamInvoerenP1 : Form
    {
       public static string naaminvoeren = "";
        public NaamInvoerenP1()
        {
             
            InitializeComponent();
            
        }

        private void NaamInvoerenP1_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //naam opslaan in variable
            naaminvoeren = textBox1.Text;

        //opent een één speler spel
        speelveld sp = new speelveld();
            sp.Show();
            //naam invoeren en menu forms sluiten
            this.Hide();
        }
    }
}
