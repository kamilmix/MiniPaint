namespace MiniPaint
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLineColor = new System.Windows.Forms.Button();
            this.groupBoxShape = new System.Windows.Forms.GroupBox();
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.radioButtonFillTool = new System.Windows.Forms.RadioButton();
            this.radioButtonEraser = new System.Windows.Forms.RadioButton();
            this.radioButtonElipse = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonCurve = new System.Windows.Forms.RadioButton();
            this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFillColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownLineThick = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCursorPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.buttonFont = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.radioButtonSelect = new System.Windows.Forms.RadioButton();
            this.groupBoxShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineThick)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBoxText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kolor linii";
            // 
            // buttonKolorLinii
            // 
            this.buttonLineColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonLineColor.Location = new System.Drawing.Point(78, 303);
            this.buttonLineColor.Name = "buttonKolorLinii";
            this.buttonLineColor.Size = new System.Drawing.Size(32, 23);
            this.buttonLineColor.TabIndex = 6;
            this.buttonLineColor.UseVisualStyleBackColor = false;
            this.buttonLineColor.Click += new System.EventHandler(this.ButtonLineColor_Click);
            // 
            // groupBoxKsztalt
            // 
            this.groupBoxShape.Controls.Add(this.radioButtonSelect);
            this.groupBoxShape.Controls.Add(this.radioButtonColor);
            this.groupBoxShape.Controls.Add(this.radioButtonText);
            this.groupBoxShape.Controls.Add(this.radioButtonFillTool);
            this.groupBoxShape.Controls.Add(this.radioButtonEraser);
            this.groupBoxShape.Controls.Add(this.radioButtonElipse);
            this.groupBoxShape.Controls.Add(this.radioButtonRectangle);
            this.groupBoxShape.Controls.Add(this.radioButtonLine);
            this.groupBoxShape.Controls.Add(this.radioButtonCurve);
            this.groupBoxShape.Location = new System.Drawing.Point(12, 27);
            this.groupBoxShape.Name = "groupBoxKsztalt";
            this.groupBoxShape.Size = new System.Drawing.Size(99, 244);
            this.groupBoxShape.TabIndex = 5;
            this.groupBoxShape.TabStop = false;
            this.groupBoxShape.Text = "Kształt";
            // 
            // radioButtonKolor
            // 
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.Location = new System.Drawing.Point(8, 182);
            this.radioButtonColor.Name = "radioButtonKolor";
            this.radioButtonColor.Size = new System.Drawing.Size(85, 17);
            this.radioButtonColor.TabIndex = 7;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.Text = "pobierz kolor";
            this.radioButtonColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonColor.UseVisualStyleBackColor = true;
            // 
            // radioButtonTekst
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Location = new System.Drawing.Point(8, 159);
            this.radioButtonText.Name = "radioButtonTekst";
            this.radioButtonText.Size = new System.Drawing.Size(52, 17);
            this.radioButtonText.TabIndex = 6;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.Text = "Tekst";
            this.radioButtonText.UseVisualStyleBackColor = true;
            // 
            // radioButtonWiadro
            // 
            this.radioButtonFillTool.AutoSize = true;
            this.radioButtonFillTool.Location = new System.Drawing.Point(8, 135);
            this.radioButtonFillTool.Name = "radioButtonWiadro";
            this.radioButtonFillTool.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFillTool.TabIndex = 5;
            this.radioButtonFillTool.TabStop = true;
            this.radioButtonFillTool.Text = "Wiadro";
            this.radioButtonFillTool.UseVisualStyleBackColor = true;
            // 
            // radioButtonGumka
            // 
            this.radioButtonEraser.AutoSize = true;
            this.radioButtonEraser.Location = new System.Drawing.Point(8, 112);
            this.radioButtonEraser.Name = "radioButtonGumka";
            this.radioButtonEraser.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEraser.TabIndex = 4;
            this.radioButtonEraser.Text = "Gumka";
            this.radioButtonEraser.UseVisualStyleBackColor = true;
            // 
            // radioButtonElipsa
            // 
            this.radioButtonElipse.AutoSize = true;
            this.radioButtonElipse.Location = new System.Drawing.Point(8, 89);
            this.radioButtonElipse.Name = "radioButtonElipsa";
            this.radioButtonElipse.Size = new System.Drawing.Size(53, 17);
            this.radioButtonElipse.TabIndex = 3;
            this.radioButtonElipse.Text = "Elipsa";
            this.radioButtonElipse.UseVisualStyleBackColor = true;
            // 
            // radioButtonProstokat
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(8, 66);
            this.radioButtonRectangle.Name = "radioButtonProstokat";
            this.radioButtonRectangle.Size = new System.Drawing.Size(70, 17);
            this.radioButtonRectangle.TabIndex = 2;
            this.radioButtonRectangle.Text = "Prostokąt";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonProsta
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(8, 43);
            this.radioButtonLine.Name = "radioButtonProsta";
            this.radioButtonLine.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLine.TabIndex = 1;
            this.radioButtonLine.Text = "Prosta";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrzywa
            // 
            this.radioButtonCurve.AutoSize = true;
            this.radioButtonCurve.Checked = true;
            this.radioButtonCurve.Location = new System.Drawing.Point(8, 20);
            this.radioButtonCurve.Name = "radioButtonKrzywa";
            this.radioButtonCurve.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCurve.TabIndex = 0;
            this.radioButtonCurve.TabStop = true;
            this.radioButtonCurve.Text = "Krzywa";
            this.radioButtonCurve.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRamka
            // 
            this.pictureBoxFrame.Location = new System.Drawing.Point(117, 27);
            this.pictureBoxFrame.Name = "pictureBoxRamka";
            this.pictureBoxFrame.Size = new System.Drawing.Size(451, 251);
            this.pictureBoxFrame.TabIndex = 4;
            this.pictureBoxFrame.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kolor tła";
            // 
            // buttonKolorWypelnienia
            // 
            this.buttonFillColor.BackColor = System.Drawing.Color.Yellow;
            this.buttonFillColor.Location = new System.Drawing.Point(78, 332);
            this.buttonFillColor.Name = "buttonKolorWypelnienia";
            this.buttonFillColor.Size = new System.Drawing.Size(32, 23);
            this.buttonFillColor.TabIndex = 8;
            this.buttonFillColor.UseVisualStyleBackColor = false;
            this.buttonFillColor.Click += new System.EventHandler(this.ButtonFillColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grubość linii";
            // 
            // numericUpDownGruboscLinii
            // 
            this.numericUpDownLineThick.Location = new System.Drawing.Point(78, 277);
            this.numericUpDownLineThick.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLineThick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLineThick.Name = "numericUpDownGruboscLinii";
            this.numericUpDownLineThick.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownLineThick.TabIndex = 11;
            this.numericUpDownLineThick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "Nowy";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.FileOpenMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Zapisz";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.FileSaveMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Zapisz jako...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.FileSaveAsMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.printToolStripMenuItem.Text = "Drukuj...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Zamknij";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.flipToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.editToolStripMenuItem.Text = "Edycja";
            // 
            // cofnijToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.undoToolStripMenuItem.Text = "Cofnij";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // ponówToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "ponówToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.redoToolStripMenuItem.Text = "Ponów";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // obróćToolStripMenuItem
            // 
            this.flipToolStripMenuItem.Name = "obróćToolStripMenuItem";
            this.flipToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.flipToolStripMenuItem.Text = "Obróć";
            this.flipToolStripMenuItem.Click += new System.EventHandler(this.FlipToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.copyToolStripMenuItem.Text = "Kopiuj";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cutToolStripMenuItem.Text = "Wytnij";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.pasteToolStripMenuItem.Text = "Wklej";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "O programie";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // pictureBoxPodglad
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(117, 27);
            this.pictureBoxPreview.Name = "pictureBoxPodglad";
            this.pictureBoxPreview.Size = new System.Drawing.Size(451, 251);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPreview.TabIndex = 12;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBoxPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBoxPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxFrame_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCursorPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
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
            // groupBoxTekst
            // 
            this.groupBoxText.Controls.Add(this.buttonFont);
            this.groupBoxText.Controls.Add(this.button1);
            this.groupBoxText.Controls.Add(this.textBoxText);
            this.groupBoxText.Location = new System.Drawing.Point(11, 361);
            this.groupBoxText.Name = "groupBoxTekst";
            this.groupBoxText.Size = new System.Drawing.Size(99, 100);
            this.groupBoxText.TabIndex = 15;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Tekst";
            this.groupBoxText.Visible = false;
            // 
            // buttonCzcionka
            // 
            this.buttonFont.Location = new System.Drawing.Point(8, 74);
            this.buttonFont.Name = "buttonCzcionka";
            this.buttonFont.Size = new System.Drawing.Size(75, 23);
            this.buttonFont.TabIndex = 2;
            this.buttonFont.Text = "Czcionka";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.ButtonFont_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAddText_Click);
            // 
            // textBoxTekst
            // 
            this.textBoxText.Location = new System.Drawing.Point(7, 19);
            this.textBoxText.Name = "textBoxTekst";
            this.textBoxText.Size = new System.Drawing.Size(86, 20);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.TextChanged += new System.EventHandler(this.TextBoxText_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(11, 467);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(99, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // radioButtonSelect
            // 
            this.radioButtonSelect.AutoSize = true;
            this.radioButtonSelect.Location = new System.Drawing.Point(8, 205);
            this.radioButtonSelect.Name = "radioButtonSelect";
            this.radioButtonSelect.Size = new System.Drawing.Size(66, 17);
            this.radioButtonSelect.TabIndex = 8;
            this.radioButtonSelect.TabStop = true;
            this.radioButtonSelect.Text = "Zaznacz";
            this.radioButtonSelect.UseVisualStyleBackColor = true;
            // 
            // OknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 549);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.pictureBoxFrame);
            this.Controls.Add(this.numericUpDownLineThick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFillColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLineColor);
            this.Controls.Add(this.groupBoxShape);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OknoProgramu";
            this.Text = "MiniPaint wektorowy - niezapisane*";
            this.groupBoxShape.ResumeLayout(false);
            this.groupBoxShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineThick)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLineColor;
        private System.Windows.Forms.GroupBox groupBoxShape;
        private System.Windows.Forms.RadioButton radioButtonElipse;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonCurve;
        private System.Windows.Forms.PictureBox pictureBoxFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFillColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownLineThick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCursorPosition;
        private System.Windows.Forms.RadioButton radioButtonEraser;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonFillTool;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.RadioButton radioButtonColor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton radioButtonSelect;
    }
}

