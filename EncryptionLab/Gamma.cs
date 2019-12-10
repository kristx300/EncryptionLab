using System;

namespace EncryptionLab
{
    public class Gamma
    {
        private static readonly char[] alphabetGamma =
        {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п',
            'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', ' ', '0', '1', '2', '3',
            '4', '5', '6', '7', '8', '9'
        };

        public static string Encode(string data, string key)
        {
            data = data.ToLower();
            key = key.ToLower();
            var ans = new char[data.Length];
            for (var i = 0; i < data.Length; i++)
            {
                var t = Array.IndexOf(alphabetGamma, data[i]) + 1;
                var g = Array.IndexOf(alphabetGamma, key[i % key.Length]) + 1;
                var tgmodn =
                    (t - g + alphabetGamma.Length)
                    % alphabetGamma.Length;
                if (tgmodn == 0)
                    tgmodn++;
                ans[i] = alphabetGamma[tgmodn - 1];
            }
            return new string(ans);
        }

        public static string Decode(string data, string key)
        {
            data = data.ToLower();
            key = key.ToLower();
            var ans = new char[data.Length];
            for (var i = 0; i < data.Length; i++)
            {
                var t = Array.IndexOf(alphabetGamma, data[i]) + 1;
                var g = Array.IndexOf(alphabetGamma, key[i % key.Length]) + 1;
                var tgmodn =
                    (t + g)
                    % alphabetGamma.Length;
                if (tgmodn == 0)
                    tgmodn++;
                ans[i] = alphabetGamma[tgmodn - 1];
            }
            return new string(ans);
        }
    }
}