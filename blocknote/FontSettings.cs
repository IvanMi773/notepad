using System;
using System.Drawing;
using System.Windows.Forms;

namespace blocknote
{
    public partial class FontSettings : Form
    {
        public int fontSize = 0;
        public FontStyle fs = FontStyle.Regular;

        public FontSettings()
        {
            InitializeComponent();

            fontBox.SelectedItem = fontBox.Items[0];
            styleBox.SelectedItem = styleBox.Items[0];
        }

        private void OnFontChanged(object sender, EventArgs e)
        {
            ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), ExampleText.Font.Style);
            fontSize = int.Parse(fontBox.SelectedItem.ToString());
        }

        private void OnStyleChanged(object sender, EventArgs e)
        {
            switch (styleBox.SelectedItem.ToString())
            {
                case "звичайний":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Regular);
                    break;

                case "жирний":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Bold);
                    break;

                case "курсив":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontBox.SelectedItem.ToString()), FontStyle.Italic);
                    break;
            }

            fs = ExampleText.Font.Style;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
