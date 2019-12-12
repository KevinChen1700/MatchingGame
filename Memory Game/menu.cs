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
    public partial class menu : Form
    {
        public static bool ladenvansave = false;
        public static bool multiplayergame = false;
        public menu()
        {
            InitializeComponent();
        }

        public static string thema = "sh";  //sh/kerst/km

        /// <summary>
        /// Sluit de applicatie als iemand op de knop drukt en vervolgens deze actie bevestigt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afsluiten_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet je zeker dat je wilt afsluiten?", "Afsluiten", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Opent een ander form waarmee mensen hun naam kunnen invullen en een thema kunnen kiezen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void singleplayer_Click(object sender, EventArgs e)
        {
            //opent naam popup
            NaamInvoeren naampopup = new NaamInvoeren();
            naampopup.Show();
        }
        /// <summary>
        /// Opent een ander form waarmee mensen hun naam kunnen invullen en een thema kunnen kiezen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multiplayer_Click(object sender, EventArgs e)
        {
            //opent popup voor het ingeven van de namen
            NamenInvoeren namenpopup = new NamenInvoeren();
            namenpopup.Show();
        }

        private void hervatten_Click(object sender, EventArgs e)
        {
            try
            {
                speelveld speelveld = new speelveld();



                TextReader tr = new StreamReader("memory.sav");

                if (tr.ReadLine() == "True") { multiplayergame = true; }

                tr.Close();
                ladenvansave = true;


                speelveld.Show();
            }
            catch(FileNotFoundException)
            { MessageBox.Show("Er is geen opgeslagen spel gevonden","Foutmelding"); }

            }

        private void highscore_Click(object sender, EventArgs e)
        {
            HighScore HS = new HighScore();
            HS.Show();
        }
    }

    }

