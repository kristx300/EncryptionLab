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

        public static string Decode(string value, int shift, char[] alphabet)
            => Code(value, shift < 0 ? Shift.Right : Shift.Left, Math.Abs(shift), alphabet);

        public static string Encode(string value, int shift, char[] alphabet)
            => Code(value, shift > 0 ? Shift.Right : Shift.Left, Math.Abs(shift), alphabet);
        private static string Code(string value, Shift s, int shift, char[] alphabet)
        {
            var sb = new StringBuilder();
            foreach (var t in value)
            {
                var i = Array.IndexOf(alphabet, t) + (s == Shift.Right ? shift : -1 * shift);
                var r = Math.Abs(i) % alphabet.Length;
                if (r == 0)
                {
                    r = i;
                }
                if (r < 0)
                {
                    r = alphabet.Length - r -1;
                }
                else if (r > alphabet.Length)
                {
                    r -= alphabet.Length -1;
                }
                sb = sb.Append(alphabet[r]);
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
