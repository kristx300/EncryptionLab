using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionLab
{
    public static class Polyalphabetic
    {
        public static string Encode(string value, string key, char[] alphabet)
            => Code(value, key, alphabet,
                (a, s, word, index) => s[index][Array.IndexOf(a, word)]);
        public static string Decode(string value, string key, char[] alphabet)
            => Code(value, key, alphabet,
                (a, s, word, index) => a[s[index].IndexOf(word)]);

        private static string Code(string value, string key, char[] alphabet,
            Func<char[], string[], char, int,char> func)
        {
            var alphs = GenerateSubAlphabet(alphabet, key);
            var sb = new StringBuilder();
            var index = 0;
            foreach (var word in value)
            {
                sb = sb.Append(func(alphabet, alphs, word,index));
                index++;
                if (index >= key.Length)
                {
                    index = 0;
                }
            }
            return sb.ToString();
        }
        public static string[] GenerateSubAlphabet(char[] alphabet, string key)
        {
            var arrays = new string[key.Length];
            for (int j = 0; j < key.Length; j++)
            {
                var sb = new StringBuilder();

                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] >= key[j])
                    {
                        sb = sb.Append(alphabet[i]);
                    }
                }
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] < key[j])
                    {
                        sb = sb.Append(alphabet[i]);
                    }
                }

                arrays[j] = sb.ToString();
            }

            return arrays;
        }
    }
}
