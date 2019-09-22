using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionLab
{
    public static class TableTransposition
    {
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
            var sb = new StringBuilder();
            for (int i = 1; i <= key.Length; i++)
            {
                for (int mj = 0; mj < m; mj++)
                {
                    sb = sb.Append(chiper[Array.IndexOf(key, i),mj]);
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
    }
}
