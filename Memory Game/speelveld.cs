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
using System.Security.Cryptography;

namespace Memory_Game
{
    public partial class speelveld : Form
    {
        
        int zetp1 = 0; //houdt zetten van speler 1 bij
        int zetp2 = 0; //houdt zetten van speler 2 bij
        int setp1 = 0; //houdt de verzamelde setjes van speler 1 bij
        int setp2 = 0; //houdt de verzamelde setjes van speler 2 bij
        public static bool p1 = true; //houdt bij of speler 1 aan de beurt is
        public static bool p2 = false; //houdt bij of speler 2 aan de beurt is
        PictureBox EersteKlik = null;
        PictureBox TweedeKlik = null;

        public speelveld()
        {
            
            InitializeComponent();
            
        }

        //Zodra de form geladen is dan...
        /// <summary>
        /// Eerst wordt er met een if-statement gecontroleerd of er 1 of 2 namen zijn doorgegeven. En worden de namen weergegeven/ wordt de naam weergegeven. 
        /// Ook wordt de naam van speler1 vetgedrukt om aan te geven dat hij als eerste aan de beurt is. Hierna wordt met nog een if-statement de data van speler 2
        /// niet weergegeven in het geval dat het spel in singleplayer modus is opgestart. Of juist wel in het geval dat het spel in multiplayer is opgestart.
        /// Daarna worden de methodes LoadImages en TimerTijd.Start aangeroepen om het speelveld in te vullen en de timer te starten.      
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speelveld_Load_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(NamenInvoeren.naam2))
            {
                player1.Text = NaamInvoeren.naamP1;
                player2.Text = null;
            }
            else
            {
                player1.Text = null;
                player2.Text = null;

                player1.Text = NamenInvoeren.naam1;
                player1.Font = new Font(player1.Font, FontStyle.Bold);
                player2.Text = NamenInvoeren.naam2;
            }

            
            
                LoadImages();

                TimerTijd.Start();
            if (menu.ladenvansave == true)
            {
                laden();

            }
            

            //Als er niet met 2 spelers gespeeld wordt, maak dan de labels van speler 2 onzichtbaar
            if (menu.multiplayergame == false)
            {
                setsp2.Visible = false;
                p2set.Visible = false;
                p2zetlabel.Visible = false;
                p2zet.Visible = false;
                ScoreP2.Visible = false;
                ScoreP2Num.Visible = false;
            }else if (menu.multiplayergame == true)
            {
                setsp2.Visible = true;
                p2set.Visible = true;
                p2zetlabel.Visible = true;
                p2zet.Visible = true;

            }
        }


        /// <summary>
        /// Eerst wordt er een willekeurig nummer gegeneerd wat later weer wordt gebruikt om de kaarten te husselen. Vervolgens wordt een array gedeclareerd om de pictureboxes op te vullen.
        /// Deze array wordt door een while loop gevuld met plaatjes uit het hiervoor gekozen thema. Daarna wordt een nieuwe array gedeclareerd die wordt gevuld met de vorige array maar deze 
        /// keer gesorteerd op een willekeurig nummer dat in het begin van de methode is gegenereerd. Als laatst komt een foreach loop die elke picturebox met een kaart uit de RandomKaarten array vult.
        /// </summary>
        private void LoadImages()
        {
            
            //TableLayoutPanel cellen creeren en vullen
            int Row = 4;
            int Colum = 4;
            int TotalCells = Row * Colum;
            tableLayoutPanel1.RowCount = Row;
            tableLayoutPanel1.ColumnCount = Colum;
            
            for (int c = 0; c < TotalCells; c++) {
                    tableLayoutPanel1.Controls.Add(new PictureBox() {
                    Dock = DockStyle.Fill,
                    Size = new Size(130,130)
                });
            }


            Random kaart = new Random(); //random number generator
            string[] kaarten = new string[16];
            int i = 0;
            int z = 1;
            //populeer de array met 2 van elke kaart, gebaseerd op geselecteerde thema
            while (i < 16)
            {
                kaarten[i] = menu.thema + Convert.ToString(z);
                i++;
                kaarten[i] = menu.thema + Convert.ToString(z);
                i++;
                z++;
            }
            i = 0;
            //shuffle de array!
            string[] RandomKaarten = kaarten.OrderBy(x => kaart.Next()).ToArray();
            //en voeg dan aan de descriptie van de picturebox de afbeelding naam toe, zodat we die later kunnen uitlezen en gebruiken.
            

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                
                PictureBox box = control as PictureBox;
                if (box != null)
                {
                    box.Click += new EventHandler(pictureBox1_Click);
                    box.AccessibleDescription = RandomKaarten[i];
                }
                i++;
            }

        }
        /// <summary>
        /// Start een schone nieuwe versie van het zelfde form en sluit de oude.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            //menu.ladenvansave = false;
            if (menu.ladenvansave == true) {
                if (string.IsNullOrEmpty(player2.Text))
                {
                    NaamInvoeren.naamP1 = player1.Text;
                }
                else {
                    NamenInvoeren.naam1 = player1.Text;
                    NamenInvoeren.naam2 = player2.Text;
                }
                menu.ladenvansave = false;
                }
            if (MessageBox.Show("Weet je zeker dat je wilt resetten?", "Reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                speelveld NewForm = new speelveld();
                NewForm.Show();
                Dispose();
            }

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); //timer stoppen
            EersteKlik.Image = null;
            TweedeKlik.Image = null;
            EersteKlik = null;
            TweedeKlik = null;
        }

        

        int seconden;
        int scoreP1 = 100;
        int scoreP2 = 100;
        /// <summary>
        /// Bij elke duizend ticks van de timer komt er één bij de variabele seconden. Die vervolgens wordt gebruikt om de juiste tijd op de timer weer te geven.
        /// </summary>
        private void TimerTijd_Tick(object sender, EventArgs e)
        {
            seconden++;
            scoreP1 = scoreP1 - 1;
            scoreP2 = scoreP2 - 1;
            ScoreP1Num.Text = Convert.ToString(scoreP1);
            ScoreP2Num.Text = Convert.ToString(scoreP2);
            Timer_speelveld.Text = seconden.ToString();
       

            
        }

        /// <summary>
        /// De methode begint met een if-statement die zorgt dat je niet meer kaartjes kan omdraaien dan timer1 toelaat. Daarna komt er een stukje dat er voor zorgt dat als je op een picturebox klikt je de juiste informatie
        /// aan het programma doorgeeft. Hierna volgen weer een serie if-statements. Eerst wordt er gekeken of de picturebox waar op geklikt is wel data bevat (dus niet al is omgedraaid). Als de picturebox data bevat wordt 
        /// deze in een aparte variabele opgeslagen en vervolgens met je tweede klik vergeleken. Als ze allebei hetzelfde zijn blijven ze staan en anders worden ze weer omgedraaid. Vervolgens wordt er gecontroleerd of er
        /// 1 of 2 spelers zijn. Als er maar 1 speler is word er 1 bij de variabele die het aantal zetten bijhoud. Bij 2 spelers wordt er eerst nog gecontroleerd of het de beurt van speler-1 of 2 is en wordt vervolgens hetzelfde
        /// gedaan als het 1 speler spel, maar dan voor de correcte speler die op dat moment aan de beurt is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            //wat te doen als er geklikt word op 1 van de picture boxes
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
                return;

            PictureBox pictureboxklik = sender as PictureBox;

            object O = Properties.Resources.ResourceManager.GetObject(pictureboxklik.AccessibleDescription);
            pictureboxklik.Image = (Image)O;

            if (pictureboxklik != null)
            {

                if (pictureboxklik == EersteKlik)
                {
                    return;
                }

                if (EersteKlik == null)
                {
                    EersteKlik = pictureboxklik;
                    return;
                }else if (TweedeKlik == null) {
                    TweedeKlik = pictureboxklik;

                    if (menu.multiplayergame == true) //multiplayer
                    {
                        if (p1 == true)
                        {
                            if (EersteKlik.AccessibleDescription == TweedeKlik.AccessibleDescription) //een set voor p1
                            {
                                scoreP1 = scoreP1 + 20;
                                ScoreP1Num.Text = Convert.ToString(scoreP1); //bij een goede set + 20;
                                setp1++;
                                p1set.Text = Convert.ToString(setp1);
                            }
                            else
                            {
                                zetp1++;
                                p1zet.Text = Convert.ToString(zetp1);
                                p1 = false;
                                p2 = true;
                                player1.Font = new Font(player1.Font, FontStyle.Regular);
                                player2.Font = new Font(player1.Font, FontStyle.Bold);
                                scoreP1 = scoreP1 - 10;
                            }
                        }
                        else if (p2 == true)
                        {
                            if (EersteKlik.AccessibleDescription == TweedeKlik.AccessibleDescription) //een set voor p2
                            {
                                scoreP2 = scoreP2 + 20;
                                ScoreP2Num.Text = Convert.ToString(scoreP2);
                                setp2++;
                                p2set.Text = Convert.ToString(setp2);
                            }
                            else
                            {
                                zetp2++;
                                p2zet.Text = Convert.ToString(zetp2);
                                p2 = false;
                                p1 = true;
                                player2.Font = new Font(player1.Font, FontStyle.Regular);
                                player1.Font = new Font(player1.Font, FontStyle.Bold);
                                scoreP2 = scoreP2 - 10; // - 10 punten bij geen set
                            }
                           
                        }

                        //multiplayer gewonnen melding
                        if (setp1 + setp2 == 8)
                        {
                            TimerTijd.Stop(); //tijd stoppen als P1 of P2 gewonnen heeft.

                            if (scoreP1 > scoreP2) //speler 1 gewonnen
                            {
                                //het opslaan van de highscore

                                //opslaan van beide scores met de winnaar
                                using (StreamWriter sw = new StreamWriter(@"highscore.txt", true))
                                {
                                    sw.WriteLine("Winnaar: " + NamenInvoeren.naam1 + ": " + scoreP1.ToString());
                                    sw.WriteLine("Verloren: " + NamenInvoeren.naam2 + ": " + scoreP2.ToString());
                                }

                                //order file leegmaken
                                File.WriteAllText("order.txt", String.Empty);
                                    using (StreamWriter sw = new StreamWriter(@"score.txt", true))
                                    {

                                        sw.WriteLine(NamenInvoeren.naam1 + " " + scoreP1.ToString()); //naam en score naar tekstbestand schrijven

                                    }
                                    //sorteren van hoog naar laag
                                    string[] scores = File.ReadAllLines("score.txt");
                                    var orderedScores = scores.OrderByDescending(x => int.Parse(x.Split(' ')[1]));

                                    foreach (var score in orderedScores)
                                    {
                                        using (StreamWriter order = new StreamWriter(@"order.txt", true)) //gesorteerde inhoud naar order.txt schrijven
                                        {
                                            order.WriteLine(score);
                                        }
                                    }


                                    if (MessageBox.Show("Het spel is afgelopen, " + NamenInvoeren.naam1 + " heeft gewonnen, wil je opnieuw spelen? ", "Spel Afgelopen", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        speelveld NewForm = new speelveld();
                                        NewForm.Show();
                                        Dispose();
                                }

                                    else //nee
                                    {
                                    // speelveld afsluiten
                                    this.Hide();
                                    }
                                }

                                //speler 2 gewonnen
                             if (scoreP2 > scoreP1)
                            {
                                //het opslaan van de highscore

                                //opslaan van beide scores met de winnaar
                                using (StreamWriter sw = new StreamWriter(@"highscore.txt", true))
                                {
                                    sw.WriteLine("Winnaar: " + NamenInvoeren.naam2 + ": " + scoreP2.ToString());
                                    sw.WriteLine("Verloren: " + NamenInvoeren.naam1 + ": " + scoreP1.ToString());
                                }

                                //order file leegmaken
                                File.WriteAllText("order.txt", String.Empty);
                                using (StreamWriter sw = new StreamWriter(@"score.txt", true))
                                {
                                    sw.WriteLine(NamenInvoeren.naam2 + " " + scoreP2.ToString()); //naam en score naar tekstbestand schrijven
                                }
                                //sorteren van hoog naar laag
                                string[] scores = File.ReadAllLines("score.txt");
                                var orderedScores = scores.OrderByDescending(x => int.Parse(x.Split(' ')[1]));

                                foreach (var score in orderedScores)
                                {
                                    using (StreamWriter order = new StreamWriter(@"order.txt", true)) //gesorteerde inhoud naar order.txt schrijven
                                    {
                                        order.WriteLine(score);
                                    }

                                }
                                //score opgeslagen


                                if (MessageBox.Show("Het spel is afgelopen, " + NamenInvoeren.naam2 + " heeft gewonnen, wil je opnieuw spelen? ", "Spel Afgelopen", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {                                    
                                        speelveld NewForm = new speelveld();
                                        NewForm.Show();
                                        Dispose();
                                }

                                    else //nee
                                    {
                                    // speelveld afsluiten
                                    this.Hide();
                                    }

                                }
                            }
                    }else{
                        zetp1++;
                        p1zet.Text = Convert.ToString(zetp1);
                    }
                }


               



                //twee dezelfde plaatjes gedraaid houden
                if (EersteKlik.AccessibleDescription == TweedeKlik.AccessibleDescription)
                {
                    if(menu.multiplayergame == false) //singleplayer
                    {
                        scoreP1 = scoreP1 + 20;
                        ScoreP1Num.Text = Convert.ToString(scoreP1);
                        setp1++;
                        p1set.Text = Convert.ToString(setp1);
                        //singeplayer gewonnen
                        if (setp1 == 8)
                        {
                            TimerTijd.Stop();

                            //het opslaan van de highscore
                            //opslaan naar tekstbestand met naam en score en wie gewonnen heeft.
                            using(StreamWriter sw = new StreamWriter(@"highscore.txt", true))
                            {
                                sw.WriteLine("Gewonnen: " + NaamInvoeren.naamP1 + ": " + scoreP1.ToString());

                            }

                            //order file leegmaken
                            File.WriteAllText("order.txt", String.Empty);
                            using (StreamWriter sw = new StreamWriter(@"score.txt", true))
                            {
                                sw.WriteLine(NaamInvoeren.naamP1 + " " + scoreP1.ToString()); //naam en score naar tekstbestand schrijven
                            }
                            //sorteren van hoog naar laag
                            string[] scores = File.ReadAllLines("score.txt");
                            var orderedScores = scores.OrderByDescending(x => int.Parse(x.Split(' ')[1]));

                            foreach (var score in orderedScores)
                            {
                                using (StreamWriter order = new StreamWriter(@"order.txt", true)) //gesorteerde inhoud naar order.txt schrijven
                                {
                                    order.WriteLine(score);
                                }

                            }
                            //score opgeslagen


                            if (MessageBox.Show("Gefeliciteerd " + NaamInvoeren.naamP1 + ", je tijd was " + seconden.ToString() + " seconden. \nJe score was: " + scoreP1.ToString() + "\n" + "Wil je opnieuw spelen?", "Spel Afgelopen", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                speelveld NewForm = new speelveld();
                                NewForm.Show();
                                Dispose();
                            }
                            else //gebruiker klikt op "nee"
                            {
                                //speelveld afsluiten
                                this.Close();
                            }


                        } //einde singleplayer

                    }
                    EersteKlik.Enabled = false;
                    TweedeKlik.Enabled = false;
                    EersteKlik = null;
                    TweedeKlik = null;
                }

                else if (menu.multiplayergame == false)
                {
                    timer1.Start();
                    scoreP1 = scoreP1 - 10;
                }
                else { timer1.Start(); }
            }
        }
        public static void EncryptFile(string file, string skey)
        {
            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);


                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        using (ICryptoTransform encryptor = aes.CreateEncryptor(key, IV))
                        {
                            using (StreamReader reader = new StreamReader(fs))
                            {
                                string content = reader.ReadToEnd();
                                fs.SetLength(0);
                                using (CryptoStream cs = new CryptoStream(fs, encryptor, CryptoStreamMode.Write))
                                {
                                    using (StreamWriter writer = new StreamWriter(cs))
                                    {
                                        writer.Write(content);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // failed to encrypt file
            }
        }
        public static void DecryptFile(string file, string skey)
        {

            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

                    byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        using (ICryptoTransform decryptor = aes.CreateDecryptor(key, IV))
                        {
                            using (CryptoStream cs = new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
                            {
                                using (StreamReader reader = new StreamReader(cs))
                                {
                                    using (StreamWriter writer = new StreamWriter(fs))
                                    {
                                        string content = reader.ReadToEnd();
                                        fs.SetLength(0);
                                        writer.Write(content);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // failed to decrypt file
            }
        }
        private void Saveknop_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter tw = new StreamWriter("memory.sav");
                tw.WriteLine(menu.multiplayergame);
                foreach (Control control in tableLayoutPanel1.Controls) //data van kaartjes slaat hij op
                {
                    PictureBox box = control as PictureBox;

                    tw.WriteLine(box.AccessibleDescription);
                }



                foreach (Control control in tableLayoutPanel1.Controls) // Opslaan van de omgedraaide kaartjes.

                {
                    PictureBox box = control as PictureBox;

                    if (box.Enabled == false)
                    {
                        tw.WriteLine("set");
                    }
                    else
                    {
                        tw.WriteLine("geenset");
                    }
                }
                tw.WriteLine(player1.Text);
                tw.WriteLine(player2.Text);
                tw.WriteLine(seconden);
                tw.WriteLine(zetp1);
                tw.WriteLine(zetp2);
                tw.WriteLine(setp1);
                tw.WriteLine(setp2);
                tw.WriteLine(scoreP1);
                tw.WriteLine(scoreP2);
                tw.WriteLine(p1);

                tw.Close();
                EncryptFile("memory.sav", "1234512345678976");

                if (MessageBox.Show("Spel opgeslagen. Wil je het spel afsluiten?", "Afsluiten", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public void laden()
        {
            DecryptFile("memory.sav", "1234512345678976");
            try
            {
                TextReader tr = new StreamReader("memory.sav");
                tr.ReadLine();
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    PictureBox box = control as PictureBox;

                    box.AccessibleDescription = tr.ReadLine();

                }
                foreach (PictureBox box in tableLayoutPanel1.Controls)
                {


                    if (tr.ReadLine() == "set")
                    {

                        object O = Properties.Resources.ResourceManager.GetObject(box.AccessibleDescription);
                        box.Image = (Image)O;
                        EersteKlik = box;
                        TweedeKlik = box;

                        EersteKlik.Enabled = false;
                        TweedeKlik.Enabled = false;
                        EersteKlik = null;
                        TweedeKlik = null;

                    }


                }

                string naam1 = tr.ReadLine();
                string naam2 = tr.ReadLine();
                seconden = Convert.ToInt16(tr.ReadLine());
                zetp1 = Convert.ToInt16(tr.ReadLine());
                zetp2 = Convert.ToInt16(tr.ReadLine());
                setp1 = Convert.ToInt16(tr.ReadLine());
                setp2 = Convert.ToInt16(tr.ReadLine());
                scoreP1= Convert.ToInt16(tr.ReadLine());
                scoreP2= Convert.ToInt16(tr.ReadLine());
                if (tr.ReadLine()=="true")
                { p1 = true; p2 = false; }
                else
                { p1 = false; p2 = true; }
                

                tr.Close();
                EncryptFile("memory.sav", "1234512345678976");

                p1zet.Text =Convert.ToString( zetp1);
                p2zet.Text = Convert.ToString(zetp2);
                p1set.Text = Convert.ToString(setp1);
                p2set.Text = Convert.ToString(setp2);
                player1.Text = naam1;
                player2.Text = naam2;
                if (string.IsNullOrEmpty(naam2))
                {
                    menu.multiplayergame = false;
                    NaamInvoeren.naamP1 = naam1;
                }
                else {
                    menu.multiplayergame = true;
                    NamenInvoeren.naam1 = naam1;
                    NamenInvoeren.naam2 = naam2;
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        /// <summary>
        /// Sluit het programma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afsluiten2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet je zeker dat je wilt afsluiten?", "Afsluiten", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }



        private void speelveld_FormClosing(object sender, FormClosingEventArgs e)
        {
            player1.Text = null;
            player2.Text = null;
            NaamInvoeren.naamP1 = "";
            NamenInvoeren.naam1 = "";
            NamenInvoeren.naam2 = "";
            menu.multiplayergame = false;
            menu.ladenvansave = false;


            }
    }

}
