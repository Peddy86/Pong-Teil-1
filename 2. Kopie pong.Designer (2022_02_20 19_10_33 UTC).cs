namespace Pong_Teil_1
{
    partial class EinstellungenDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.radioButton640 = new System.Windows.Forms.RadioButton();
            this.radioButton1024 = new System.Windows.Forms.RadioButton();
            this.radioButton360 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSpielFarben = new System.Windows.Forms.Button();
            this.buttonRahmenFarbe = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMax);
            this.groupBox1.Controls.Add(this.radioButton640);
            this.groupBox1.Controls.Add(this.radioButton1024);
            this.groupBox1.Controls.Add(this.radioButton360);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Größe";
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Location = new System.Drawing.Point(225, 27);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMax.TabIndex = 3;
            this.radioButtonMax.Text = "Maximal";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            // 
            // radioButton640
            // 
            this.radioButton640.AutoSize = true;
            this.radioButton640.Location = new System.Drawing.Point(77, 27);
            this.radioButton640.Name = "radioButton640";
            this.radioButton640.Size = new System.Drawing.Size(65, 17);
            this.radioButton640.TabIndex = 2;
            this.radioButton640.Text = "640*480";
            this.radioButton640.UseVisualStyleBackColor = true;
            // 
            // radioButton1024
            // 
            this.radioButton1024.AutoSize = true;
            this.radioButton1024.Location = new System.Drawing.Point(148, 27);
            this.radioButton1024.Name = "radioButton1024";
            this.radioButton1024.Size = new System.Drawing.Size(71, 17);
            this.radioButton1024.TabIndex = 1;
            this.radioButton1024.Text = "1024*768";
            this.radioButton1024.UseVisualStyleBackColor = true;
            // 
            // radioButton360
            // 
            this.radioButton360.AutoSize = true;
            this.radioButton360.Location = new System.Drawing.Point(6, 27);
            this.radioButton360.Name = "radioButton360";
            this.radioButton360.Size = new System.Drawing.Size(65, 17);
            this.radioButton360.TabIndex = 0;
            this.radioButton360.Text = "320*200";
            this.radioButton360.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(18, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Übernehmen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonSpielFarben);
            this.groupBox2.Controls.Add(this.buttonRahmenFarbe);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Farben";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spielfeld";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rahmen";
            // 
            // buttonSpielFarben
            // 
            this.buttonSpielFarben.Location = new System.Drawing.Point(77, 59);
            this.buttonSpielFarben.Name = "buttonSpielFarben";
            this.buttonSpielFarben.Size = new System.Drawing.Size(31, 23);
            this.buttonSpielFarben.TabIndex = 1;
            this.buttonSpielFarben.Text = "...";
            this.buttonSpielFarben.UseVisualStyleBackColor = true;
            this.buttonSpielFarben.Click += new System.EventHandler(this.buttonSpielFarben_Click);
            // 
            // buttonRahmenFarbe
            // 
            this.buttonRahmenFarbe.Location = new System.Drawing.Point(77, 19);
            this.buttonRahmenFarbe.Name = "buttonRahmenFarbe";
            this.buttonRahmenFarbe.Size = new System.Drawing.Size(31, 23);
            this.buttonRahmenFarbe.TabIndex = 0;
            this.buttonRahmenFarbe.Text = "...";
            this.buttonRahmenFarbe.UseVisualStyleBackColor = true;
            this.buttonRahmenFarbe.Click += new System.EventHandler(this.buttonRahmenFarbe_Click);
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(160, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 95);
            this.listBox1.TabIndex = 4;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // EinstellungenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 284);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EinstellungenDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spielfeld";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EinstellungenDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.RadioButton radioButton640;
        private System.Windows.Forms.RadioButton radioButton1024;
        private System.Windows.Forms.RadioButton radioButton360;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSpielFarben;
        private System.Windows.Forms.Button buttonRahmenFarbe;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ListBox listBox1;
    }
}