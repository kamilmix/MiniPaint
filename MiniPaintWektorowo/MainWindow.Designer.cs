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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLineColor = new System.Windows.Forms.Button();
            this.groupBoxShape = new System.Windows.Forms.GroupBox();
            this.radioButtonSelect = new System.Windows.Forms.RadioButton();
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radioButtonFillTool = new System.Windows.Forms.RadioButton();
            this.radioButtonEraser = new System.Windows.Forms.RadioButton();
            this.radioButtonElipse = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonCurve = new System.Windows.Forms.RadioButton();
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
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineThick)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kolor linii";
            // 
            // buttonLineColor
            // 
            this.buttonLineColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonLineColor.Location = new System.Drawing.Point(61, 45);
            this.buttonLineColor.Name = "buttonLineColor";
            this.buttonLineColor.Size = new System.Drawing.Size(32, 23);
            this.buttonLineColor.TabIndex = 6;
            this.buttonLineColor.UseVisualStyleBackColor = false;
            this.buttonLineColor.Click += new System.EventHandler(this.ButtonLineColor_Click);
            // 
            // groupBoxShape
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
            this.groupBoxShape.Name = "groupBoxShape";
            this.groupBoxShape.Size = new System.Drawing.Size(99, 251);
            this.groupBoxShape.TabIndex = 5;
            this.groupBoxShape.TabStop = false;
            this.groupBoxShape.Text = "Narzędzia";
            // 
            // radioButtonSelect
            // 
            this.radioButtonSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSelect.AutoSize = true;
            this.radioButtonSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.radioButtonSelect.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonSelect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonSelect.Image = global::MiniPaintWektorowo.Properties.Resources.pointer;
            this.radioButtonSelect.Location = new System.Drawing.Point(52, 151);
            this.radioButtonSelect.Name = "radioButtonSelect";
            this.radioButtonSelect.Size = new System.Drawing.Size(40, 40);
            this.radioButtonSelect.TabIndex = 8;
            this.radioButtonSelect.TabStop = true;
            this.radioButtonSelect.UseVisualStyleBackColor = true;
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.radioButtonColor.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonColor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonColor.Image = global::MiniPaintWektorowo.Properties.Resources.color_picker;
            this.radioButtonColor.Location = new System.Drawing.Point(8, 199);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(40, 40);
            this.radioButtonColor.TabIndex = 7;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonColor.UseVisualStyleBackColor = true;
            // 
            // radioButtonText
            // 
            this.radioButtonText.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonText.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.radioButtonText.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonText.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonText.ImageKey = "text.bmp";
            this.radioButtonText.ImageList = this.imageList1;
            this.radioButtonText.Location = new System.Drawing.Point(8, 151);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(40, 40);
            this.radioButtonText.TabIndex = 6;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Red;
            this.imageList1.Images.SetKeyName(0, "brush.bmp");
            this.imageList1.Images.SetKeyName(1, "ellipse.bmp");
            this.imageList1.Images.SetKeyName(2, "eraser.bmp");
            this.imageList1.Images.SetKeyName(3, "fill.bmp");
            this.imageList1.Images.SetKeyName(4, "line.bmp");
            this.imageList1.Images.SetKeyName(5, "pencil.bmp");
            this.imageList1.Images.SetKeyName(6, "rectangle.bmp");
            this.imageList1.Images.SetKeyName(7, "text.bmp");
            // 
            // radioButtonFillTool
            // 
            this.radioButtonFillTool.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFillTool.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.radioButtonFillTool.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonFillTool.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonFillTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonFillTool.ImageKey = "fill.bmp";
            this.radioButtonFillTool.ImageList = this.imageList1;
            this.radioButtonFillTool.Location = new System.Drawing.Point(8, 106);
            this.radioButtonFillTool.Name = "radioButtonFillTool";
            this.radioButtonFillTool.Size = new System.Drawing.Size(40, 40);
            this.radioButtonFillTool.TabIndex = 5;
            this.radioButtonFillTool.TabStop = true;
            this.radioButtonFillTool.UseVisualStyleBackColor = true;
            // 
            // radioButtonEraser
            // 
            this.radioButtonEraser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonEraser.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.radioButtonEraser.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonEraser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonEraser.ImageKey = "eraser.bmp";
            this.radioButtonEraser.ImageList = this.imageList1;
            this.radioButtonEraser.Location = new System.Drawing.Point(52, 60);
            this.radioButtonEraser.Name = "radioButtonEraser";
            this.radioButtonEraser.Size = new System.Drawing.Size(40, 40);
            this.radioButtonEraser.TabIndex = 4;
            this.radioButtonEraser.UseVisualStyleBackColor = true;
            // 
            // radioButtonElipse
            // 
            this.radioButtonElipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonElipse.AutoSize = true;
            this.radioButtonElipse.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.radioButtonElipse.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonElipse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonElipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonElipse.Image = global::MiniPaintWektorowo.Properties.Resources.ellipse1;
            this.radioButtonElipse.Location = new System.Drawing.Point(53, 106);
            this.radioButtonElipse.Name = "radioButtonElipse";
            this.radioButtonElipse.Size = new System.Drawing.Size(40, 40);
            this.radioButtonElipse.TabIndex = 3;
            this.radioButtonElipse.UseVisualStyleBackColor = true;
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRectangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.radioButtonRectangle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonRectangle.ImageKey = "rectangle.bmp";
            this.radioButtonRectangle.ImageList = this.imageList1;
            this.radioButtonRectangle.Location = new System.Drawing.Point(8, 60);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(40, 40);
            this.radioButtonRectangle.TabIndex = 2;
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.radioButtonLine.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonLine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonLine.ImageKey = "line.bmp";
            this.radioButtonLine.ImageList = this.imageList1;
            this.radioButtonLine.Location = new System.Drawing.Point(49, 19);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(40, 40);
            this.radioButtonLine.TabIndex = 1;
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonCurve
            // 
            this.radioButtonCurve.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCurve.Checked = true;
            this.radioButtonCurve.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.radioButtonCurve.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonCurve.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonCurve.ImageKey = "pencil.bmp";
            this.radioButtonCurve.ImageList = this.imageList1;
            this.radioButtonCurve.Location = new System.Drawing.Point(8, 19);
            this.radioButtonCurve.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonCurve.Name = "radioButtonCurve";
            this.radioButtonCurve.Size = new System.Drawing.Size(40, 40);
            this.radioButtonCurve.TabIndex = 0;
            this.radioButtonCurve.TabStop = true;
            this.radioButtonCurve.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kolor tła";
            // 
            // buttonFillColor
            // 
            this.buttonFillColor.BackColor = System.Drawing.Color.Yellow;
            this.buttonFillColor.Location = new System.Drawing.Point(61, 74);
            this.buttonFillColor.Name = "buttonFillColor";
            this.buttonFillColor.Size = new System.Drawing.Size(32, 23);
            this.buttonFillColor.TabIndex = 8;
            this.buttonFillColor.UseVisualStyleBackColor = false;
            this.buttonFillColor.Click += new System.EventHandler(this.ButtonFillColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rozmiar";
            // 
            // numericUpDownLineThick
            // 
            this.numericUpDownLineThick.Location = new System.Drawing.Point(61, 19);
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
            this.numericUpDownLineThick.Name = "numericUpDownLineThick";
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
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "Plik";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "Nowy";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.FileOpenMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Zapisz";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.FileSaveMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Zapisz jako...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.FileSaveAsMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.printToolStripMenuItem.Text = "Drukuj...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Zamknij";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.flipToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.editToolStripMenuItem.Text = "Edycja";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.undoToolStripMenuItem.Text = "Cofnij";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.redoToolStripMenuItem.Text = "Ponów";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // flipToolStripMenuItem
            // 
            this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            this.flipToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.flipToolStripMenuItem.Text = "Obróć";
            this.flipToolStripMenuItem.Click += new System.EventHandler(this.FlipToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.copyToolStripMenuItem.Text = "Kopiuj";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cutToolStripMenuItem.Text = "Wytnij";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.pasteToolStripMenuItem.Text = "Wklej";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "O programie";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCursorPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1099, 22);
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
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.buttonFont);
            this.groupBoxText.Controls.Add(this.button1);
            this.groupBoxText.Controls.Add(this.textBoxText);
            this.groupBoxText.Location = new System.Drawing.Point(12, 483);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(99, 100);
            this.groupBoxText.TabIndex = 15;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Tekst";
            this.groupBoxText.Visible = false;
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(8, 74);
            this.buttonFont.Name = "buttonFont";
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
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(7, 19);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(86, 20);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.TextChanged += new System.EventHandler(this.TextBoxText_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(4, 19);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(89, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(117, 27);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(451, 251);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPreview.TabIndex = 12;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBoxPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBoxPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxFrame_MouseUp);
            // 
            // pictureBoxFrame
            // 
            this.pictureBoxFrame.Location = new System.Drawing.Point(117, 27);
            this.pictureBoxFrame.Name = "pictureBoxFrame";
            this.pictureBoxFrame.Size = new System.Drawing.Size(451, 251);
            this.pictureBoxFrame.TabIndex = 4;
            this.pictureBoxFrame.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonLineColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonFillColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownLineThick);
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 119);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Właściwości";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(12, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 72);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Powiększenie";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.pictureBoxFrame);
            this.Controls.Add(this.groupBoxShape);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MiniPaint - niezapisane*";
            this.groupBoxShape.ResumeLayout(false);
            this.groupBoxShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineThick)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

