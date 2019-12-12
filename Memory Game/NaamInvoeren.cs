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

    public partial class NaamInvoeren : Form
    {
        public static string naamP1 = null;
       
        public NaamInvoeren()
        {
            InitializeComponent();
        }
        private void Naam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }
        /// <summary>
        ///  Een if statement controleert of iemand daadwerkelijk iets heeft ingevuld en geeft indien er niks is ingevuld een error. De ingevulde naam word een string die dan in het speelveld weer aangeroepen kan worden.
        ///  Vervolgens controleren verschillende if statements het thema en veranderen dan de string thema naar de letters van het gewenste thema. Hierna word dit form verstopt en het speelveld geopend.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            //checken of er iets ingevuld is bij textbox 1
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vul een naam in voor speler 1", "Error", MessageBoxButtons.OK);
                return; 
            }

            //naam naar variable
            naamP1 = textBox1.Text;

            
            if (RadioSH.Checked)
            {
                menu.thema = "sh";
            }
            else if (RadioKM.Checked)
            {
                menu.thema = "km";
            }
            else if (RadioKerst.Checked)
            {
                menu.thema = "kerst";
            }



            //speelveld openen
            menu.multiplayergame = false;
            speelveld sp = new speelveld();
            sp.Show();

            //naam invoeren en menu forms sluiten
            this.Hide();

        }
    }
}
