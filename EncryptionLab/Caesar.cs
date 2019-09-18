using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionLab
{
    public static class Caesar
    {
        public static string Decode(string value, Shift s, int shift, char[] alphabet)
            => Code(value, s == Shift.Left ? Shift.Right : Shift.Left, shift, alphabet);

        public static string Encode(string value, Shift s, int shift, char[] alphabet)
            => Code(value, s, shift, alphabet);

        private static string Code(string value, Shift s, int shift, char[] alphabet)
        {
            var sb = new StringBuilder();
            foreach (var t in value)
            {
                var i = Array.IndexOf(alphabet, t) + (s == Shift.Right ? shift : 1 * -shift);
                sb = sb.Append(alphabet[alphabet.Length < i - 1 ? i - alphabet.Length : i]);
            }
            return sb.ToString();
        }
        public enum Shift
        {
            Left,
            Right
        }
    }
}
