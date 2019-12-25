using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsaEds
{
    public partial class Signature : Form
    {

        /// <summary>
        /// Провайдер шифрования RSA
        /// </summary>
        private RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        public Signature()
        {
            InitializeComponent();
            //Получение новых сгенерированных ключей
            //Ключ с закрытыми данными параметр true
            var pub = rsa.ToXmlString(true);
            /*
            RSAParameters field	Contains	                Corresponding PKCS #1 field
            D	                d, the private exponent	    privateExponent
            DP	                d mod (p - 1)	            exponent1
            DQ	                d mod (q - 1)	            exponent2
            Exponent	        e, the public exponent	    publicExponent
            InverseQ	        (InverseQ)(q) = 1 mod p	    coefficient
            Modulus	            n	                        modulus
            P	                p	                        prime1
            Q	                q	                        prime2
             */
            //Вывод ключей на форму
            keys.Text = pub;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Каждый первый символ слов текста М, содержащих букву О 
            var textM = textBox.Text;
            //Разделяем текст по пробелу
            var textMSplittedByWords = textM.Split(' ');
            var sb = new StringBuilder();
            foreach (var item in textMSplittedByWords)
            {
                //Переводим в нижний регистр и проверяем содержит ли букву о
                if (item.ToLower().Contains('о'))
                {
                    //Добавляем в текст
                    sb = sb.Append(item[0]);
                }
            }
            var digText = sb.ToString();
            digest.Text = digText;
            // используя хэш – функцию Нi=(Hi-1+Mi)2 mod n. Вектор инициализации H0 следует выбирать самостоятельно.
            List<int> hashCode = new List<int>();
            hashCode.Add(1);
            for (int i = 0; i < digText.Length; i++)
            {
                hashCode.Add((int)(Math.Pow((int)hashCode.LastOrDefault() + (int)digText[i], 2) % digText.Length));
            }
            //Объединяем с сепаратором пробелом
            hash.Text = string.Join(" ", hashCode.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hash.Text))
            {
                MessageBox.Show("Дайджест пустой");
                return;
            }
            //Чистаем с формы ключи в формате XML
            rsa.FromXmlString(keys.Text);
            //Шифруем
            var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(hash.Text), false);
            //Получаем читаемый текст
            encrypt.Text = Convert.ToBase64String(bytes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hash.Text))
            {
                MessageBox.Show("Дайджест пустой");
                return;
            }
            //Чистаем с формы ключи в формате XML
            rsa.FromXmlString(keys.Text);
            //Дешифруем
            var bytes = rsa.Decrypt(Convert.FromBase64String(encrypt.Text), false);
            //Получаем строку
            decrypt.Text = Encoding.UTF8.GetString(bytes);
        }
    }

}
