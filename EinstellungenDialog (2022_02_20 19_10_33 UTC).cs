using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Teil_1
{
    public partial class EinstellungenDialog : Form
    {
        Color hintergrundfarbe;
        Color sonstigesFarbe;
        Graphics vorschauBild;
        Pen stift;
        
        

        public EinstellungenDialog(int groesse, Color sonstiges, Color hintergrund)
        {
            InitializeComponent();

            //die Größe aus der Variablen SpielfeldMaxX wird hier übergeben um als Wegweiser für die Radiobuttons zu dienen CSHP11C Aufgabe1<<<<<<
            if (groesse == 334)
                radioButton360.Checked = true;
            if (groesse == 614)
                radioButton640.Checked = true;
            if (groesse == 998)
                radioButton1024.Checked = true;
            if (groesse != 334 && groesse != 614 && groesse != 998)
                radioButtonMax.Checked = true;

            //setzen der Farben
            hintergrundfarbe = hintergrund;
            sonstigesFarbe = sonstiges;                             
        }

        //Methode die den ausgewählten Wert zurückliefert
        public Point LiefereWert()
        {
            Point rueckgabe = new Point(0,0);
            
            if (radioButton360.Checked == true)            
                rueckgabe = new Point(360, 200);
               
            if (radioButton640.Checked == true)            
                rueckgabe = new Point(640, 480);
               
            if (radioButton1024.Checked == true)            
                rueckgabe = new Point(1024, 768);
              
            if (radioButtonMax.Checked == true)            
                rueckgabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
               
            return rueckgabe;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        //Rahmenfarbe bestimmen und inder Vorschau verändern<<<<<<<<<<
        private void buttonRahmenFarbe_Click(object sender, EventArgs e)
        {
            //den Dialog zur Farbauswahl anzeigen lassen
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //ausgewählte Farbe setzen
                sonstigesFarbe = colorDialog1.Color;

                stift.Color = sonstigesFarbe;
                
                stift.Width = 15;

                //Rahmen
                vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Left, Vorschau_panel.ClientRectangle.Top, Vorschau_panel.ClientRectangle.Right, Vorschau_panel.ClientRectangle.Top);
                vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Right, Vorschau_panel.ClientRectangle.Top, Vorschau_panel.ClientRectangle.Width, Vorschau_panel.ClientRectangle.Height);
                vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Width, Vorschau_panel.ClientRectangle.Height, Vorschau_panel.ClientRectangle.Left, Vorschau_panel.ClientRectangle.Height);

                //ändern der stärke des stiftes
                stift.Width = 4;
                //Schläger
                vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Left + 15, (Vorschau_panel.ClientRectangle.Height / 2) + 10, Vorschau_panel.ClientRectangle.Left + 15, (Vorschau_panel.ClientRectangle.Height / 2) - 10);

                //Ball
                vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Left + 25, (Vorschau_panel.ClientRectangle.Height / 2) + 2, Vorschau_panel.ClientRectangle.Left + 25, (Vorschau_panel.ClientRectangle.Height / 2) - 2);

                //Hintergrund
                Vorschau_panel.BackColor = hintergrundfarbe;
            }
            
        }

        //Hintergrundfarbe verändern <<<<<
        private void buttonSpielFarben_Click(object sender, EventArgs e)
        {
            //den Dialog zur Farbauswahl anzeigen lassen
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                //ausgewählte Farbe setzen
                hintergrundfarbe = colorDialog2.Color;

                //Hintergrund
                Vorschau_panel.BackColor = hintergrundfarbe;
            }
        }

        //liefern der beiden Farben<<<<<<<<<<<<
        public Color LiefereHintergrund()
        {
            return hintergrundfarbe;
        }

        public Color LiefereFarbe()
        {
            return sonstigesFarbe;
        }

        private void EinstellungenDialog_Load(object sender, EventArgs e)
        {
            vorschauBild = Vorschau_panel.CreateGraphics();

            //weißer Sift
            stift = new Pen(sonstigesFarbe);                           
        }


        private void Vorschau_panel_Paint(object sender, PaintEventArgs e)
        {
            stift.Width = 15;

            //Rahmen
            vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Left, Vorschau_panel.ClientRectangle.Top, Vorschau_panel.ClientRectangle.Right, Vorschau_panel.ClientRectangle.Top);
            vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Right, Vorschau_panel.ClientRectangle.Top, Vorschau_panel.ClientRectangle.Width, Vorschau_panel.ClientRectangle.Height);
            vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Width, Vorschau_panel.ClientRectangle.Height,Vorschau_panel.ClientRectangle.Left,Vorschau_panel.ClientRectangle.Height);

            //ändern der stärke des stiftes
            stift.Width = 4;
            //Schläger
            vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Left+15, (Vorschau_panel.ClientRectangle.Height/2)+10, Vorschau_panel.ClientRectangle.Left + 15, (Vorschau_panel.ClientRectangle.Height / 2)-10);

            //Ball
            vorschauBild.DrawLine(stift, Vorschau_panel.ClientRectangle.Left + 25, (Vorschau_panel.ClientRectangle.Height / 2) + 2, Vorschau_panel.ClientRectangle.Left + 25, (Vorschau_panel.ClientRectangle.Height / 2) - 2);

            //Hintergrund
            Vorschau_panel.BackColor = hintergrundfarbe;
            
        }
    }
}
