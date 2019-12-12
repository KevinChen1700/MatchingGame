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
    public partial class NamenInvoeren : Form
    {
        public static string naam1 = null;
        public static string naam2 = null;
       
        public NamenInvoeren()
        {
            InitializeComponent();
            
        }
        private void Namen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }
        /// <summary>
        /// Eerst word er gecontroleerd of er daadwerkelijk iets bij naam 1 & 2 is ingevuld. Als er niks is ingevuld komt er een messagebox die zegt dat je dit wel moet doen. Daarna worden de ingevulde namen in een string gezet
        /// zodat deze in het speelveld kunnen worden gebruikt. Hierna word met verschillende if statements en een radio button de string thema aangepast zodat het speelveld word gevuld met het juiste thema. Vervolgens word het
        /// form speelveld geopend, het form NamenInvoeren onzichtbaar gemaakt en doorgegeven dat het spel in multiplayer moet worden opgestart.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //checken of bij beide textboxen iets ingevuld is
            //textbox 1
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vul een naam in voor speler 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            //textbox 2 checken
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vul een naam in voor speler 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            
            //namen van de spelers naar textbox
            naam1 = textBox1.Text; 
            naam2 = textBox2.Text;
            
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
            //na het opslaan van de namen in de variabelen wordt het speelveld geopend
            menu.multiplayergame = true;
            speelveld speelveld = new speelveld();
            speelveld.Show();
            this.Hide(); // na het openen van het speelveld worden de naam popup en het menu gesloten

        }


    }
}
