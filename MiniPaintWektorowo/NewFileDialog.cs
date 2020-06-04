using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class NewFileDialog : Form
    {
        public NewFileDialog()
        {
            InitializeComponent();
        }
        private void ColorBox_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = colorDialog.Color;
            }
        }

        public Size ImageSize
        {
            get { return new Size((int)widthBox.Value, (int)heightBox.Value); }
        }


        public Color ImageBackColor
        {
            get { return colorBox.BackColor; }
        }
    }
}
