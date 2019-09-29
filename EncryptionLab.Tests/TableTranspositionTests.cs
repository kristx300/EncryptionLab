using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncryptionLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionLab.Tests
{
    [TestClass()]
    public class TableTranspositionTests
    {
        public const string DecodedText = "ГРУЗИТЕ_АПЕЛЬСИНЫ_БОЧКАХ";
        public readonly int[] Key = { 5, 8, 1, 3, 7, 4, 6, 2 };
        public const string KeyString = "etacgdfb";
        public const string EncodedText = "УЕБ_НХЗЛОТСКГАЫЕИАИЬЧРП_";
        public const int N = 8;
        public const int M = 3;
        [TestMethod()]
        public void DecodeTest()
        {
            var res = TableTransposition.Decode(EncodedText, N, M, Key);

            Assert.AreEqual(DecodedText, res);
        }

        [TestMethod()]
        public void EncodeTest()
        {
            var res = TableTransposition.Encode(DecodedText, N, M, Key);

            Assert.AreEqual(EncodedText, res);
        }
        [TestMethod()]
        public void DecodeTestAlt()
        {
            var res = TableTransposition.Decode(EncodedText, KeyString);

            Assert.AreEqual(DecodedText, res);
        }

        [TestMethod()]
        public void EncodeTestAlt()
        {
            var res = TableTransposition.Encode(DecodedText, KeyString);

            Assert.AreEqual(EncodedText, res);
        }

        [TestMethod]
        public void GenerateArrayBounds()
        {
            var res = TableTransposition.GenerateArrayBounds(DecodedText, KeyString);

            Assert.AreEqual(N, res.Item1);
            Assert.AreEqual(M, res.Item2);
            Assert.AreEqual(Key.Length,res.Item3.Length);
            for (int i = 0; i < Key.Length; i++)
            {
                Assert.AreEqual(Key[i],res.Item3[i]);
            }
        }
    }
}