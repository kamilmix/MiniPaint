namespace MiniPaintWektorowo
{
    partial class OknoProgramu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoProgramu));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKolorLinii = new System.Windows.Forms.Button();
            this.groupBoxKsztalt = new System.Windows.Forms.GroupBox();
            this.radioButtonGumka = new System.Windows.Forms.RadioButton();
            this.radioButtonElipsa = new System.Windows.Forms.RadioButton();
            this.radioButtonProstokat = new System.Windows.Forms.RadioButton();
            this.radioButtonProsta = new System.Windows.Forms.RadioButton();
            this.radioButtonKrzywa = new System.Windows.Forms.RadioButton();
            this.pictureBoxRamka = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKolorWypelnienia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownGruboscLinii = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obróćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxPodglad = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCursorPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonWiadro = new System.Windows.Forms.RadioButton();
            this.groupBoxKsztalt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRamka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGruboscLinii)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPodglad)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kolor linii";
            // 
            // buttonKolorLinii
            // 
            this.buttonKolorLinii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonKolorLinii.Location = new System.Drawing.Point(79, 225);
            this.buttonKolorLinii.Name = "buttonKolorLinii";
            this.buttonKolorLinii.Size = new System.Drawing.Size(32, 23);
            this.buttonKolorLinii.TabIndex = 6;
            this.buttonKolorLinii.UseVisualStyleBackColor = false;
            this.buttonKolorLinii.Click += new System.EventHandler(this.buttonKolorLinii_Click);
            // 
            // groupBoxKsztalt
            // 
            this.groupBoxKsztalt.Controls.Add(this.radioButtonWiadro);
            this.groupBoxKsztalt.Controls.Add(this.radioButtonGumka);
            this.groupBoxKsztalt.Controls.Add(this.radioButtonElipsa);
            this.groupBoxKsztalt.Controls.Add(this.radioButtonProstokat);
            this.groupBoxKsztalt.Controls.Add(this.radioButtonProsta);
            this.groupBoxKsztalt.Controls.Add(this.radioButtonKrzywa);
            this.groupBoxKsztalt.Location = new System.Drawing.Point(12, 27);
            this.groupBoxKsztalt.Name = "groupBoxKsztalt";
            this.groupBoxKsztalt.Size = new System.Drawing.Size(99, 166);
            this.groupBoxKsztalt.TabIndex = 5;
            this.groupBoxKsztalt.TabStop = false;
            this.groupBoxKsztalt.Text = "Kształt";
            // 
            // radioButtonGumka
            // 
            this.radioButtonGumka.AutoSize = true;
            this.radioButtonGumka.Location = new System.Drawing.Point(8, 112);
            this.radioButtonGumka.Name = "radioButtonGumka";
            this.radioButtonGumka.Size = new System.Drawing.Size(59, 17);
            this.radioButtonGumka.TabIndex = 4;
            this.radioButtonGumka.Text = "Gumka";
            this.radioButtonGumka.UseVisualStyleBackColor = true;
            // 
            // radioButtonElipsa
            // 
            this.radioButtonElipsa.AutoSize = true;
            this.radioButtonElipsa.Location = new System.Drawing.Point(8, 89);
            this.radioButtonElipsa.Name = "radioButtonElipsa";
            this.radioButtonElipsa.Size = new System.Drawing.Size(53, 17);
            this.radioButtonElipsa.TabIndex = 3;
            this.radioButtonElipsa.Text = "Elipsa";
            this.radioButtonElipsa.UseVisualStyleBackColor = true;
            // 
            // radioButtonProstokat
            // 
            this.radioButtonProstokat.AutoSize = true;
            this.radioButtonProstokat.Location = new System.Drawing.Point(8, 66);
            this.radioButtonProstokat.Name = "radioButtonProstokat";
            this.radioButtonProstokat.Size = new System.Drawing.Size(70, 17);
            this.radioButtonProstokat.TabIndex = 2;
            this.radioButtonProstokat.Text = "Prostokąt";
            this.radioButtonProstokat.UseVisualStyleBackColor = true;
            // 
            // radioButtonProsta
            // 
            this.radioButtonProsta.AutoSize = true;
            this.radioButtonProsta.Location = new System.Drawing.Point(8, 43);
            this.radioButtonProsta.Name = "radioButtonProsta";
            this.radioButtonProsta.Size = new System.Drawing.Size(55, 17);
            this.radioButtonProsta.TabIndex = 1;
            this.radioButtonProsta.Text = "Prosta";
            this.radioButtonProsta.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrzywa
            // 
            this.radioButtonKrzywa.AutoSize = true;
            this.radioButtonKrzywa.Checked = true;
            this.radioButtonKrzywa.Location = new System.Drawing.Point(8, 20);
            this.radioButtonKrzywa.Name = "radioButtonKrzywa";
            this.radioButtonKrzywa.Size = new System.Drawing.Size(59, 17);
            this.radioButtonKrzywa.TabIndex = 0;
            this.radioButtonKrzywa.TabStop = true;
            this.radioButtonKrzywa.Text = "Krzywa";
            this.radioButtonKrzywa.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRamka
            // 
            this.pictureBoxRamka.Location = new System.Drawing.Point(117, 27);
            this.pictureBoxRamka.Name = "pictureBoxRamka";
            this.pictureBoxRamka.Size = new System.Drawing.Size(451, 251);
            this.pictureBoxRamka.TabIndex = 4;
            this.pictureBoxRamka.TabStop = false;
            this.pictureBoxRamka.Click += new System.EventHandler(this.pictureBoxRamka_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kolor tła";
            // 
            // buttonKolorWypelnienia
            // 
            this.buttonKolorWypelnienia.BackColor = System.Drawing.Color.Yellow;
            this.buttonKolorWypelnienia.Location = new System.Drawing.Point(79, 254);
            this.buttonKolorWypelnienia.Name = "buttonKolorWypelnienia";
            this.buttonKolorWypelnienia.Size = new System.Drawing.Size(32, 23);
            this.buttonKolorWypelnienia.TabIndex = 8;
            this.buttonKolorWypelnienia.UseVisualStyleBackColor = false;
            this.buttonKolorWypelnienia.Click += new System.EventHandler(this.buttonKolorWypelnienia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grubość linii";
            // 
            // numericUpDownGruboscLinii
            // 
            this.numericUpDownGruboscLinii.Location = new System.Drawing.Point(79, 199);
            this.numericUpDownGruboscLinii.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownGruboscLinii.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGruboscLinii.Name = "numericUpDownGruboscLinii";
            this.numericUpDownGruboscLinii.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownGruboscLinii.TabIndex = 11;
            this.numericUpDownGruboscLinii.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.fileOpenMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.fileSaveMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.fileSaveAsMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj...";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.ponówToolStripMenuItem,
            this.obróćToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.wklejToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // ponówToolStripMenuItem
            // 
            this.ponówToolStripMenuItem.Name = "ponówToolStripMenuItem";
            this.ponówToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.ponówToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ponówToolStripMenuItem.Text = "Ponów";
            this.ponówToolStripMenuItem.Click += new System.EventHandler(this.ponówToolStripMenuItem_Click);
            // 
            // obróćToolStripMenuItem
            // 
            this.obróćToolStripMenuItem.Name = "obróćToolStripMenuItem";
            this.obróćToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.obróćToolStripMenuItem.Text = "Obróć";
            this.obróćToolStripMenuItem.Click += new System.EventHandler(this.obrocToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            // 
            // pictureBoxPodglad
            // 
            this.pictureBoxPodglad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPodglad.Location = new System.Drawing.Point(117, 27);
            this.pictureBoxPodglad.Name = "pictureBoxPodglad";
            this.pictureBoxPodglad.Size = new System.Drawing.Size(451, 251);
            this.pictureBoxPodglad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPodglad.TabIndex = 12;
            this.pictureBoxPodglad.TabStop = false;
            this.pictureBoxPodglad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxPodglad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBoxPodglad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRamka_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCursorPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(619, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCursorPosition
            // 
            this.toolStripStatusLabelCursorPosition.Name = "toolStripStatusLabelCursorPosition";
            this.toolStripStatusLabelCursorPosition.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabelCursorPosition.Text = "X: 0 Y: 0";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // radioButtonWiadro
            // 
            this.radioButtonWiadro.AutoSize = true;
            this.radioButtonWiadro.Location = new System.Drawing.Point(8, 135);
            this.radioButtonWiadro.Name = "radioButtonWiadro";
            this.radioButtonWiadro.Size = new System.Drawing.Size(59, 17);
            this.radioButtonWiadro.TabIndex = 5;
            this.radioButtonWiadro.TabStop = true;
            this.radioButtonWiadro.Text = "Wiadro";
            this.radioButtonWiadro.UseVisualStyleBackColor = true;
            // 
            // OknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 412);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBoxPodglad);
            this.Controls.Add(this.pictureBoxRamka);
            this.Controls.Add(this.numericUpDownGruboscLinii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKolorWypelnienia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKolorLinii);
            this.Controls.Add(this.groupBoxKsztalt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OknoProgramu";
            this.Text = "MiniPaint wektorowy";
            this.groupBoxKsztalt.ResumeLayout(false);
            this.groupBoxKsztalt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRamka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGruboscLinii)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPodglad)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKolorLinii;
        private System.Windows.Forms.GroupBox groupBoxKsztalt;
        private System.Windows.Forms.RadioButton radioButtonElipsa;
        private System.Windows.Forms.RadioButton radioButtonProstokat;
        private System.Windows.Forms.RadioButton radioButtonProsta;
        private System.Windows.Forms.RadioButton radioButtonKrzywa;
        private System.Windows.Forms.PictureBox pictureBoxRamka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKolorWypelnienia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownGruboscLinii;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obróćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxPodglad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCursorPosition;
        private System.Windows.Forms.RadioButton radioButtonGumka;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem ponówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonWiadro;
    }
}

