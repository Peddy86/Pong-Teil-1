using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

namespace Pong_Teil_1
{
    public partial class Form1 : Form
    {
        //Die Felder
        //eine Struktur für die Richtung des Balls
        struct Spielball
        {
            //wenn die Richtung true ist geht es nach oben bzw nach rechts, sonstnach unten bzw Links
            public bool richtungX;
            public bool richtungY;
            //für die Berechnung des Bewegungswinkels
            public int winkel;
        }

        //für die Zeichenfläche
        Graphics zeichenflaeche;
        //für das Spielfeld
        Rectangle spielfeldGroesse;
        int spielfeldMaxX, spielfeldMaxY, spielfeldMinX, spielfeldMinY, spielfeldLinienBreite;
        //für den Schläger
        int schlägergroesse;
        //für den Ball
        Spielball ballPosition;
        //zum Zeichnen
        SolidBrush pinsel;
        bool spielPause;
        int aktuelleSpielzeit;
        Font schrift;
        Score spielpunkte;
        //für die Punkteeinstellung
        int punkteMehr, punkteWeniger;
        //für die Veränderung des Winkels
        int winkelZufall;
        Color sonstigeFarben;
        Color hintergrundfarbe;
        
        //Xml Felder
        
        int regBreite;
        int regHoehe;
        int regSchwierigkeitsgrad;

        public Form1()
        {
            InitializeComponent();
            //die Breite der linien
            spielfeldLinienBreite = 10;
            //die Größe des schlägers
            
            
            winkelZufall = 5;
            punkteMehr = 1;
            punkteWeniger = -2;

            regSchwierigkeitsgrad = 2;

            sonstigeFarben = Color.White;
            hintergrundfarbe = Color.Black;

            //erst die Standardwerte dann die zuweisung durch die Methode
            regBreite = 640;
            regHoehe = 480;
            
            LeseEinstellung();
            this.Height = regHoehe;
            this.Width = regBreite;

            if (this.Height == 200)
                schlägergroesse = 30;

            if (this.Height == 480)
                schlägergroesse = 50;

            if (this.Height == 768)
                schlägergroesse = 50;

            if (this.Height != 200 && this.Height != 480 && this.Height != 768)
                schlägergroesse = 60;
                       

            //erst einmal geht der Ball nach rechts und oben  mit dem Winkel null
            ballPosition.richtungX = true;
            ballPosition.richtungY = true;
            //den Pinsel erzeugen
            pinsel = new SolidBrush(Color.Black);
            //die Zeichenfläche beschaffen
            zeichenflaeche = spielfeld.CreateGraphics();
            //das Speilfeld bekommt einen schwarzén hintergrund
            spielfeld.BackColor = Color.Black;
            SetzeSpielfeld();
            NeuerBall();
            //spiel ist angehalten
            spielPause = true;
            //alle Timer deaktivieren
            timerBall.Enabled = false;
            timerSpielzeit.Enabled = false;
            timerPauseZeit.Enabled = false;
            schrift = new Font("Arial", 12, FontStyle.Bold);
            pauseToolStripMenuItem.Enabled = false;
            spielpunkte = new Score();
        }


        //setzt die Einstellung für den Schwierigkeitsgrad
        void setzeEinstellungen(int mehr,int weniger,int winkel)
        {           
            punkteMehr = mehr;
            punkteWeniger = weniger;
            winkelZufall = winkel;
        }

        void ZeichnePunkte(string punkte)
        {
            //zuerst die alte Anzeige überschreiben
            pinsel.Color = spielfeld.BackColor;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 40, 30, 20);

            //in Benutzerdefinierter Schrift
            pinsel.Color = sonstigeFarben;

            //die Einstellung für die Schrift werden beim setzen des Spielfeldes gesetzt
            zeichenflaeche.DrawString(punkte, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 40));
        }

        void ZeichneZeit(string restzeit)
        {
            //zuerst die alte anzeige überschreiben
            pinsel.Color = spielfeld.BackColor;

            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 20, 30, 20);

            //in Benutzerdefinierter schrift
            pinsel.Color = sonstigeFarben;

            //die Auszeichnungen für die Schrift werden beim erstellen des Spielfeldes gesetzt
            zeichenflaeche.DrawString(restzeit, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 20));
        }

        bool NeuesSpiel()
        {

            spielpunkte.LoeschePunkte();
            ZeichnePunkte("0");

            bool ergebnis = false;

            if(MessageBox.Show("Neues Spiel Starten","Neues Spiel",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                EinstellungenToolStripItem.Enabled = false;
                pauseToolStripMenuItem.Enabled = true;
                //Spielzeit neu setzen
                aktuelleSpielzeit = 120;
                //alles neu Zeichnen
                ZeichneSpielfeld();
                NeuerBall();
                ZeichneZeit(Convert.ToString(aktuelleSpielzeit));
                ergebnis = true;
            }
            return ergebnis;
        }

        void SetzeSpielfeld()
        {
            spielfeldGroesse = spielfeld.ClientRectangle;
            //die minimal und maximale Ränder festlegen dabei werden die Lininen Berücksichtigt
            spielfeldMaxX = spielfeldGroesse.Right - spielfeldLinienBreite;
            //den Linken Rand verschieben wir um einen Pixel nach rechts
            spielfeldMinX = spielfeldGroesse.Left + spielfeldLinienBreite + 1;
            spielfeldMaxY = spielfeldGroesse.Bottom - spielfeldLinienBreite;
            spielfeldMinY = spielfeldGroesse.Top + spielfeldLinienBreite;
        }

        void ZeichneSpielfeld()
        {
            //weiße Begrenzungen
            pinsel.Color = sonstigeFarben;
            //ein Rechteck oben
            zeichenflaeche.FillRectangle(pinsel, 0, 12, spielfeldMaxX, spielfeldLinienBreite+12);
            //eine Rechts
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX, 0, spielfeldLinienBreite, spielfeldLinienBreite + spielfeldMaxY);
            //und noch eins unten
            zeichenflaeche.FillRectangle(pinsel, 0, spielfeldMaxY, spielfeldMaxX, spielfeldLinienBreite);
            //damit es nicht Langweilig aussieht eine graue Linie in der Mitte
            pinsel.Color = Color.Gray;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX / 2, spielfeldMinY+24, spielfeldLinienBreite, spielfeldMaxY-34);
        }

        private void spielfeld_Paint(object sender, PaintEventArgs e)
        {
            ZeichneSpielfeld();
            ZeichneZeit(Convert.ToString(aktuelleSpielzeit));
        }

        private void schlaeger_MouseMove(object sender, MouseEventArgs e)
        {
            if (spielPause == true)
                return;

            if (e.Button == MouseButtons.Left )
                ZeichneSchläger(e.Y + schlaeger.Top);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int neuX = 0, neuY = 0;

            //abhängig von der Bewegungsrichtung die Koordinate neu setzen
            if (ballPosition.richtungX == true)
                neuX = ball.Left + 10;
            else
                neuX = ball.Left - 10;

            if (ballPosition.richtungY == true)
                neuY = ball.Top - ballPosition.winkel;
            else
                neuY = ball.Top + ballPosition.winkel;

            //den Ball neu Zeichnen
            ZeichneBall(new Point(neuX, neuY));
        }

        private void timerPauseZeit_Tick(object sender, EventArgs e)
        {
            //eine Sekunde abziehen
            aktuelleSpielzeit = aktuelleSpielzeit - 1;
            //die restzeitausegeben
            ZeichneZeit(Convert.ToString(aktuelleSpielzeit));
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //erst einmal Prüfen wir den Status, läuft das Spiel
            if(spielPause == false)
            {
                //alle Timer anhalten
                timerBall.Enabled = false;
                timerSpielzeit.Enabled = false;
                timerPauseZeit.Enabled = false;

                //die Markierung im Menu einschalten
                pauseToolStripMenuItem.Checked = true;

                //den Text in der Titelleiste ändern
                this.Text = "Pong - Das Spiel ist angehalten!";
                spielPause = true;
            }
            else
            {
                //den Intervall für die verbleibende Spielzeit setzen
                timerSpielzeit.Interval = aktuelleSpielzeit * 1000;
                //alle timer wieder an
                timerBall.Enabled = true;
                timerSpielzeit.Enabled = true;
                timerPauseZeit.Enabled = true;

                //die Markierung im Menu ausschalten
                pauseToolStripMenuItem.Checked = false;

                //den Text in der Titelleiste ändern
                this.Text = "Pong";
                spielPause = false;
            }
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //läuft das Spiel
            if(spielPause==false)
            {
                pauseToolStripMenuItem_Click(sender, e);

                //den Dialog anzeigen lassen
                NeuesSpiel();

                //und weiterspielen
                pauseToolStripMenuItem_Click(sender, e);
            }

            //wenn kein Spiel läuft, starten wir ein neues, wenn im Dialog auf ja geklickt wurde
            if(NeuesSpiel()==true)
                pauseToolStripMenuItem_Click(sender, e);
        }

        private void timerSpielzeit_Tick(object sender, EventArgs e)
        {
            timerBall.Enabled = false;
            timerSpielzeit.Enabled = false;
            timerPauseZeit.Enabled = false;

            //nachsehen ob ein Eintag in der Bestenliste erfolgen kann
            if (spielpunkte.NeuerEintrag()==true)
            {
                //den Ball und den Schläger Verstecken
                ball.Hide();
                schlaeger.Hide();
                              

                //die Liste ausgeben
                spielpunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);

                //fünf sekunden warten
                System.Threading.Thread.Sleep(5000);

                //die Zeichenfläschen löschen
                zeichenflaeche.Clear(spielfeld.BackColor);

                //Ball und Schläger wieder anzeigen
                schlaeger.Show();
                ball.Show();
            }

            pauseToolStripMenuItem_Click(sender,e);

            MessageBox.Show("Die Zeit ist um", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (NeuesSpiel() == true)
                //das Spiel fortsetzen
                pauseToolStripMenuItem_Click(sender, e);
            else
                //sonst beenden
                beendenToolStripMenuItem_Click(sender, e);
        }

        private void sehrEinfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setzeEinstellungen(3, -3, 10);
            timerBall.Interval = 50;
            schlägergroesse = schlägergroesse + 15; 
            sehrEinfachToolStripMenuItem.Checked = true;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            regSchwierigkeitsgrad = 1;
        }

        private void einfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setzeEinstellungen( 1, -2, 5);
            timerBall.Interval = 35;
            schlägergroesse = schlägergroesse +10;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = true;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            regSchwierigkeitsgrad = 2;
        }

        private void mittelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setzeEinstellungen(2, -4, 10);
            timerBall.Interval = 25;            
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = true;
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            regSchwierigkeitsgrad = 3;
        }

        private void schwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setzeEinstellungen(2, -6, 15);
            timerBall.Interval = 20;
            schlägergroesse = schlägergroesse - 5;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = true;
            sehrEinfachToolStripMenuItem.Checked = false;
            regSchwierigkeitsgrad = 4;
        }

        private void sehrSchwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setzeEinstellungen(3, -10, 30);
            timerBall.Interval = 18;
            schlägergroesse = schlägergroesse - 5;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = true;
            regSchwierigkeitsgrad = 5;
        }

        private void spielfeldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


            Point neueGroesse = new Point();
            EinstellungenDialog neueWerte = new EinstellungenDialog(spielfeldMaxX,sonstigeFarben,hintergrundfarbe);
            
            //wenn EinstellungDialog über die Übernehmen-Schaltfläsche beendet wird
            if (neueWerte.ShowDialog() == DialogResult.OK)
            {
                //die neue Größe holen
                neueGroesse = neueWerte.LiefereWert();
                //EinstellungDialog schließen
                neueWerte.Close();

                //setzen der neuen Farben
                hintergrundfarbe = neueWerte.LiefereHintergrund();
                sonstigeFarben = neueWerte.LiefereFarbe();

                
                spielfeld.BackColor = hintergrundfarbe;
                //das Formular ändern
                this.Width = neueGroesse.X;
                this.Height = neueGroesse.Y;

                //neu ausrichten
                this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
                this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

                //Die Zeichenfläche neu beschaffen
                zeichenflaeche = spielfeld.CreateGraphics();

                //Spielfeld neu setzen
                SetzeSpielfeld();

                //altes Spielfeld löschen
                zeichenflaeche.Clear(spielfeld.BackColor);

                //einen neuen Ball und einen neuen Schläger zeichen
                NeuerBall();

                //Geschwindikeit vom Ball und größe des Schlägers varieert durch die Größe des Spielfeldes
                if (neueGroesse.X == 360)
                {
                    schlägergroesse = schlägergroesse - 15;
                    timerBall.Interval = timerBall.Interval + 8;
                }

                if (neueGroesse.X == 1024)
                {
                    schlägergroesse = schlägergroesse + 20;
                    timerBall.Interval = timerBall.Interval - 7;
                }

                if (neueGroesse.X == Screen.PrimaryScreen.Bounds.Width)
                {
                    schlägergroesse = schlägergroesse + 30;
                    timerBall.Interval = timerBall.Interval - 12;
                }

                //und ein neues Spielfeld
                ZeichneSpielfeld();
            }
        }
        
        private void bestenlisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zum unterscheiden zwischeneinem laufendenund einen nicht gestarteten Spiel
            bool weiter = false;

            //läuft ein Spiel? Dann erst mal Pausieren
            if (spielPause==false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                weiter = true;
            }

            //den Ball und den Schläger Verstecken
            ball.Hide();
            schlaeger.Hide();

            //die Liste ausgeben
            spielpunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);

            //7 sekunden warten
            System.Threading.Thread.Sleep(7000);

            //die Zeichenfläschen löschen
            zeichenflaeche.Clear(spielfeld.BackColor);

            //Ball und Schläger wieder anzeigen
            schlaeger.Show();
            ball.Show();

            if (weiter == true)
                pauseToolStripMenuItem_Click(sender, e);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SchreibeEinstellung();
        }

        //setze die Position des Balls
        void ZeichneBall(Point position)
        {
            Random zufall = new Random();
            ball.Location = position;
            //wenn der Ball rechts aufstöst ändern wir die Richtung 
            if ((position.X + 10) >= spielfeldMaxX)
                ballPosition.richtungX = false;
            //stöst er oben oder unten an
            if ((position.Y >= spielfeldMaxY-12))
                ballPosition.richtungY = true;
            else
                if (position.Y <= spielfeldMinY+24)
                ballPosition.richtungY = false;


            //ist er wieder Links, prüfen wir, ob der Schläger in der nähe ist
            if ((position.X == spielfeldMinX) && ((schlaeger.Top <= position.Y) && (schlaeger.Bottom >= position.Y)))
            {
                if (ballPosition.richtungX == false)
                    //ein Punkt dazu und die Punkte ausgeben
                    ZeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteMehr)));

                //die Richtung nach Rechts ändrn
                ballPosition.richtungX = true;
                //und den Winkel
                ballPosition.winkel = zufall.Next(winkelZufall);
            }

            //ist der Ball hinter dem Schläger
            if (position.X < spielfeldMinX)
            {
                //5 Punkte abziehen und ausgeben
                ZeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteWeniger)));
                System.Threading.Thread.Sleep(1000);
                //und alles von vorne
                ZeichneBall(new Point(spielfeldMinX, position.Y));
                ballPosition.richtungX = true;
            }
        }

        //setzt die Y-Postion des Schlägers
        void ZeichneSchläger(int y)
        {
            //befindet sich der Schläger im Speilfeld?
            if(((y + schlägergroesse) < spielfeldMaxY) && (y > spielfeldMinY+24))
                schlaeger.Top = y;
        }

        //Setzt die Einstellung für einen neuen Ball und einen neuen Schläger
        void NeuerBall()
        {
            //die Größe des Balles
            ball.Width = 10;
            ball.Height = 10;
            //die Größe des Schlägers
            schlaeger.Width = spielfeldLinienBreite;
            schlaeger.Height = schlägergroesse;

            //beide panels erhalten die gewählte Farbe<<<<<<<<<<<<<<<<<<<<<<<<<<<
            ball.BackColor = sonstigeFarben;
            schlaeger.BackColor = sonstigeFarben;

            //den schläger links an den Rand Postionieren
            schlaeger.Left = 2;

            //ungefähr in die Mitte
            ZeichneSchläger((spielfeldMaxY / 2) - (schlägergroesse / 2));
            //der Ball kommt vor dem Schläger in die Mitte
            ZeichneBall(new Point(spielfeldMinX, spielfeldMaxY / 2));
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        void SchreibeEinstellung()     //Einsendeaufgabe
        {
            using (RegistryKey regSchluessel = Registry.CurrentUser.CreateSubKey("Software\\Pong"))
            {
                regSchluessel.SetValue("breite", Convert.ToString(this.Width));
                regSchluessel.SetValue("hoehe", Convert.ToString(this.Height));
                regSchluessel.SetValue("wert", Convert.ToString(regSchwierigkeitsgrad));                
            }
            
        }

        void LeseEinstellung()     //Einsendeaufgabe
        {
            //den Schlüssel HKEY_CURRENT_USER\SOFTWARE\RegistryDemo öffnen
            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software\\Pong"))
            {
                //wenn der Schlüssel nicht vorhanden ist 
                if (regSchluessel != null)
                {                   
                    regHoehe = Convert.ToInt32(regSchluessel.GetValue("hoehe"));
                    regBreite = Convert.ToInt32(regSchluessel.GetValue("breite"));
                    regSchwierigkeitsgrad = Convert.ToInt32(regSchluessel.GetValue("wert"));                    
                }
            }

            switch (regSchwierigkeitsgrad)
            {
                case 1:                    
                    sehrEinfachToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;

                case 2:
                    einfachToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;

                case 3:
                    mittelToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;

                case 4:
                    schwerToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;

                case 5:
                    sehrEinfachToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;
            }               
        }
    }
}
