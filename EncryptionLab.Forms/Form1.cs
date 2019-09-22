using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionLab.Forms
{
    public partial class Form1 : Form
    {
        private readonly char[] English = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();
        private readonly char[] Russian = Enumerable.Range('а', 'я' - 'а' + 1).Select(i => (char)i).ToArray();
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
            }
        }
    }
}
