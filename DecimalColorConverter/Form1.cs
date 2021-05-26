using System;
using System.Windows.Forms;

namespace DecimalColorConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] myColor = { colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B };
                hexTxt.Text = Convert.ToHexString(myColor);
                decText.Text = Convert.ToInt32(hexTxt.Text, 16).ToString();
            }
        }
    }
}
