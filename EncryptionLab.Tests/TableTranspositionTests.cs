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
    }
}