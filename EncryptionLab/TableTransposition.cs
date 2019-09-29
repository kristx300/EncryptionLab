using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionLab
{
    public static class TableTransposition
    {
        public static string Decode(string value, string key)
        {
            var result = GenerateArrayBounds(value, key);
            return Decode(value, result.Item1, result.Item2, result.Item3);
        }
        public static string Encode(string value, string key)
        {
            var result = GenerateArrayBounds(value, key);
            return Encode(value, result.Item1, result.Item2, result.Item3);
        }
        public static string Decode(string value, int n, int m, int[] key)
        {
            var chiper = new char[n, m];
            var valIndex = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    chiper[i, j] = value[valIndex];
                    valIndex++;
                    if (valIndex >= value.Length)
                    {
                        break;
                    }
                }
                if (valIndex >= value.Length)
                {
                    break;
                }
            }

            var ans = new char[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int kIndex = 1; kIndex <= key.Length; kIndex++)
                {
                    ans[Array.IndexOf(key, kIndex),i] = chiper[kIndex - 1,i];
                }
            }

            var sb = new StringBuilder();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb = sb.Append(ans[j,i]);
                }
            }
            return sb.ToString();
        }
        public static string Encode(string value,int n, int m, int[] key)
        {
            var chiper = new char[m, n];
            var valIndex = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    chiper[i, j] = value[valIndex];
                    valIndex++;
                    if (valIndex>= value.Length)
                    {
                        break;
                    }
                }
                if (valIndex >= value.Length)
                {
                    break;
                }
            }
            var sb = new StringBuilder();
            for (int i = 1; i <= key.Length; i++)
            {
                for (int mj = 0; mj < m; mj++)
                {
                    sb = sb.Append(chiper[mj,Array.IndexOf(key,i)]);
                }
            }
            return sb.ToString();
        }

        public static Tuple<int, int,int[]> GenerateArrayBounds(string value , string key)
        {
            var columns = value.Length / key.Length;
            var result = Transposition.GetIndexes(key);
            for (int i = 0; i < result.Length; i++)
            {
                result[i]++;
            }
            return new Tuple<int, int, int[]>(key.Length,columns, result);
        }
    }
}
