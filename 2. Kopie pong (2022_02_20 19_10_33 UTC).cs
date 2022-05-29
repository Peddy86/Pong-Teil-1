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
        

        public EinstellungenDialog(int groesse)
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
            hintergrundfarbe = Color.Black;
            sonstigesFarbe = Color.White;
                 
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

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Pen boxStift = new Pen(sonstigesFarbe);            
            boxStift.Width = 10;

            //den Hintergrund zeichnen
            e.DrawBackground();

            //den Rand
            e.Graphics.DrawRectangle(boxStift, e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height+78);

            //der Schläger
            boxStift.Width = 4;
            e.Graphics.DrawLine(boxStift, e.Bounds.Left + 15, (e.Bounds.Top / 2) + 45, e.Bounds.Left + 15, (e.Bounds.Top / 2) + 65);

            //der Ball
            e.Graphics.DrawLine(boxStift, e.Bounds.Left + 25, (e.Bounds.Top / 2) + 52, e.Bounds.Left + 25, (e.Bounds.Top / 2) + 56);

            listBox1.BackColor = hintergrundfarbe;
        }

        private void buttonRahmenFarbe_Click(object sender, EventArgs e)
        {
            //den Dialog zur Farbauswahl anzeigen lassen
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //ausgewählte Farbe setzen
                sonstigesFarbe = colorDialog1.Color;                           
            }
        }

        private void buttonSpielFarben_Click(object sender, EventArgs e)
        {
            //den Dialog zur Farbauswahl anzeigen lassen
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                //ausgewählte Farbe setzen
                hintergrundfarbe = colorDialog2.Color;
            }
        }

        public Color LiefereHintergrund()
        {
            return hintergrundfarbe;
        }

        private void EinstellungenDialog_Load(object sender, EventArgs e)
        {
            
        }
    }
}
