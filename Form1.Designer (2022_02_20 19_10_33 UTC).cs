namespace Pong_Teil_1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SpielToolstripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestenlisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EinstellungenToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwierigkeitsgradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehrEinfachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mittelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehrSchwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeld = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.schlaeger = new System.Windows.Forms.Panel();
            this.timerBall = new System.Windows.Forms.Timer(this.components);
            this.timerSpielzeit = new System.Windows.Forms.Timer(this.components);
            this.timerPauseZeit = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.spielfeld.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpielToolstripItem,
            this.EinstellungenToolStripItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SpielToolstripItem
            // 
            this.SpielToolstripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.neuesSpielToolStripMenuItem,
            this.beendenToolStripMenuItem,
            this.bestenlisteToolStripMenuItem});
            this.SpielToolstripItem.Name = "SpielToolstripItem";
            this.SpielToolstripItem.Size = new System.Drawing.Size(44, 20);
            this.SpielToolstripItem.Text = "&Spiel";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pauseToolStripMenuItem.Text = "&Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.neuesSpielToolStripMenuItem.Text = "Neues &Spiel";
            this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.neuesSpielToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // bestenlisteToolStripMenuItem
            // 
            this.bestenlisteToolStripMenuItem.Name = "bestenlisteToolStripMenuItem";
            this.bestenlisteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bestenlisteToolStripMenuItem.Text = "Besten&liste";
            this.bestenlisteToolStripMenuItem.Click += new System.EventHandler(this.bestenlisteToolStripMenuItem_Click);
            // 
            // EinstellungenToolStripItem
            // 
            this.EinstellungenToolStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schwierigkeitsgradToolStripMenuItem,
            this.spielfeldToolStripMenuItem});
            this.EinstellungenToolStripItem.Name = "EinstellungenToolStripItem";
            this.EinstellungenToolStripItem.Size = new System.Drawing.Size(90, 20);
            this.EinstellungenToolStripItem.Text = "&Einstellungen";
            // 
            // schwierigkeitsgradToolStripMenuItem
            // 
            this.schwierigkeitsgradToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sehrEinfachToolStripMenuItem,
            this.einfachToolStripMenuItem,
            this.mittelToolStripMenuItem,
            this.schwerToolStripMenuItem,
            this.sehrSchwerToolStripMenuItem});
            this.schwierigkeitsgradToolStripMenuItem.Name = "schwierigkeitsgradToolStripMenuItem";
            this.schwierigkeitsgradToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.schwierigkeitsgradToolStripMenuItem.Text = "Schwierigkeits&grad";
            // 
            // sehrEinfachToolStripMenuItem
            // 
            this.sehrEinfachToolStripMenuItem.Name = "sehrEinfachToolStripMenuItem";
            this.sehrEinfachToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sehrEinfachToolStripMenuItem.Text = "sehr Einfach";
            this.sehrEinfachToolStripMenuItem.Click += new System.EventHandler(this.sehrEinfachToolStripMenuItem_Click);
            // 
            // einfachToolStripMenuItem
            // 
            this.einfachToolStripMenuItem.Checked = true;
            this.einfachToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.einfachToolStripMenuItem.Name = "einfachToolStripMenuItem";
            this.einfachToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.einfachToolStripMenuItem.Text = "Einfach";
            this.einfachToolStripMenuItem.Click += new System.EventHandler(this.einfachToolStripMenuItem_Click);
            // 
            // mittelToolStripMenuItem
            // 
            this.mittelToolStripMenuItem.Name = "mittelToolStripMenuItem";
            this.mittelToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mittelToolStripMenuItem.Text = "Mittel";
            this.mittelToolStripMenuItem.Click += new System.EventHandler(this.mittelToolStripMenuItem_Click);
            // 
            // schwerToolStripMenuItem
            // 
            this.schwerToolStripMenuItem.Name = "schwerToolStripMenuItem";
            this.schwerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.schwerToolStripMenuItem.Text = "Schwer";
            this.schwerToolStripMenuItem.Click += new System.EventHandler(this.schwerToolStripMenuItem_Click);
            // 
            // sehrSchwerToolStripMenuItem
            // 
            this.sehrSchwerToolStripMenuItem.Name = "sehrSchwerToolStripMenuItem";
            this.sehrSchwerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sehrSchwerToolStripMenuItem.Text = "sehr Schwer";
            this.sehrSchwerToolStripMenuItem.Click += new System.EventHandler(this.sehrSchwerToolStripMenuItem_Click);
            // 
            // spielfeldToolStripMenuItem
            // 
            this.spielfeldToolStripMenuItem.Name = "spielfeldToolStripMenuItem";
            this.spielfeldToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.spielfeldToolStripMenuItem.Text = "Spiel&feld";
            this.spielfeldToolStripMenuItem.Click += new System.EventHandler(this.spielfeldToolStripMenuItem_Click);
            // 
            // spielfeld
            // 
            this.spielfeld.Controls.Add(this.ball);
            this.spielfeld.Controls.Add(this.schlaeger);
            this.spielfeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spielfeld.Location = new System.Drawing.Point(0, 0);
            this.spielfeld.Name = "spielfeld";
            this.spielfeld.Size = new System.Drawing.Size(624, 441);
            this.spielfeld.TabIndex = 1;
            this.spielfeld.Paint += new System.Windows.Forms.PaintEventHandler(this.spielfeld_Paint);
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(291, 291);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(200, 100);
            this.ball.TabIndex = 1;
            // 
            // schlaeger
            // 
            this.schlaeger.Location = new System.Drawing.Point(49, 62);
            this.schlaeger.Name = "schlaeger";
            this.schlaeger.Size = new System.Drawing.Size(200, 100);
            this.schlaeger.TabIndex = 0;
            this.schlaeger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.schlaeger_MouseMove);
            // 
            // timerBall
            // 
            this.timerBall.Enabled = true;
            this.timerBall.Interval = 25;
            this.timerBall.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerSpielzeit
            // 
            this.timerSpielzeit.Enabled = true;
            this.timerSpielzeit.Interval = 120000;
            this.timerSpielzeit.Tick += new System.EventHandler(this.timerSpielzeit_Tick);
            // 
            // timerPauseZeit
            // 
            this.timerPauseZeit.Enabled = true;
            this.timerPauseZeit.Interval = 1000;
            this.timerPauseZeit.Tick += new System.EventHandler(this.timerPauseZeit_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.spielfeld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spielfeld.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SpielToolstripItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Panel spielfeld;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Panel schlaeger;
        private System.Windows.Forms.Timer timerBall;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.Timer timerSpielzeit;
        private System.Windows.Forms.Timer timerPauseZeit;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestenlisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EinstellungenToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem schwierigkeitsgradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielfeldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehrEinfachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mittelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehrSchwerToolStripMenuItem;
    }
}

