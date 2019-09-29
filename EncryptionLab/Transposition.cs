using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptionLab
{
    public static class Transposition
    {
        public static string Decode(string value, string key)
            => Code(value, key, (copy, i, indexes, filledGroup) =>
              copy[i] = filledGroup[indexes[i]]);

        public static string Encode(string value, string key)
            => Code(value, key, (copy, i, indexes, filledGroup) =>
              copy[indexes[i]] = filledGroup[i]);

        public static string Code(string value, string key, Func<char[],int,int[],string,char> func)
        {
            var indexes = GetIndexes(key);
            var sb = new StringBuilder();
            foreach (var group in Split(value, key.Length))
            {
                var copyPart = new char[key.Length];
                var enumerable = group as char[] ?? group.ToArray();
                var filledGroup = string.Concat(
                    string.Concat(enumerable),
                    string.Concat(Enumerable.Range(0, key.Length - enumerable.Length).Select(i => '_')));
                for (int i = 0; i < filledGroup.Length; i++)
                {
                    func(copyPart, i, indexes,filledGroup);
                }

                sb = sb.Append(copyPart);
            }

            return sb.ToString();
        }


        private static IEnumerable<IEnumerable<char>> Split(string array, int size)
        {
            for (var i = 0; i < (float)array.Length / size; i++)
            {
                yield return array.Skip(i * size).Take(size);
            }
        }

        internal static int[] GetIndexes(string key)
        {
            var ordered = key.OrderBy(q => q).ToArray();
            var indexes = Enumerable.Range(0, key.Length).Select(i => -999).ToArray();
            for (int i = 0; i < key.Length; i++)
            {
                var foundIndex = Array.IndexOf(ordered, key[i]);
                while (indexes.Any(q => q == foundIndex))
                {
                    foundIndex = Array.IndexOf(ordered, key[i], foundIndex + 1);
                }
                indexes[i] = foundIndex;
            }
            return indexes;
        }
    }
}