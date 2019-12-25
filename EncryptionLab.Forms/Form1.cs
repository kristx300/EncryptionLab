using System;
using System.Windows.Forms;

namespace EncryptionLab.Forms
{
    public partial class Form1 : Form
    {
        private readonly char[] English = new[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '_',
        };

        private readonly char[] Russian = new[]
        {
            'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н',
            'о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь',
            'э','ю','я',' ','1','2','3','4','5','6','7','8','9','0','_',
        };

        public Form1()
        {
            InitializeComponent();
        }

        private char[] GetAlphabet()
        {
            switch (alphabetBox.SelectedIndex)
            {
                case 0:
                    return English;

                case 1:
                    return Russian;
            }

            return English;
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            switch (methodBox.SelectedIndex)
            {
                case 0:
                    int.TryParse(keyBox.Text, out var key);
                    resultBox.Text = Caesar.Encode(valueBox.Text, key, GetAlphabet());
                    break;

                case 1:
                    resultBox.Text = Polyalphabetic.Encode(valueBox.Text, keyBox.Text, GetAlphabet());
                    break;

                case 2:
                    resultBox.Text = Transposition.Encode(valueBox.Text, keyBox.Text);
                    break;

                case 3:
                    resultBox.Text = TableTransposition.Encode(valueBox.Text, keyBox.Text);
                    break;

                case 4:
                    resultBox.Text = Gamma.Encode(valueBox.Text, keyBox.Text);
                    break;
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            switch (methodBox.SelectedIndex)
            {
                case 0:
                    int.TryParse(keyBox.Text, out var key);
                    resultBox.Text = Caesar.Decode(valueBox.Text, key, GetAlphabet());
                    break;

                case 1:
                    resultBox.Text = Polyalphabetic.Decode(valueBox.Text, keyBox.Text, GetAlphabet());
                    break;

                case 2:
                    resultBox.Text = Transposition.Decode(valueBox.Text, keyBox.Text);
                    break;

                case 3:
                    resultBox.Text = TableTransposition.Decode(valueBox.Text, keyBox.Text);
                    break;

                case 4:
                    resultBox.Text = Gamma.Decode(valueBox.Text, keyBox.Text);
                    break;
            }
        }
    }
}