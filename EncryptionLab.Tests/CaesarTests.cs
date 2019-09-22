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
    public class CaesarTests
    {
        public readonly char[] English = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();
        public const string DecodedText = "hello";
        public const string EncodedText = "mjqqt";
        public const string Left = "cbggj";
        [TestMethod()]
        public void DecodeTest()
        {
            var result = Caesar.Decode(EncodedText, Caesar.Shift.Right, 5, English);
            Assert.AreEqual(DecodedText, result);
            result = Caesar.Decode(Left, Caesar.Shift.Left, 5, English);
            Assert.AreEqual(DecodedText, result);
        }

        [TestMethod]
        public void EncodeTest()
        {
            var result = Caesar.Encode(DecodedText, Caesar.Shift.Right, 5, English);
            Assert.AreEqual(EncodedText, result);
            result = Caesar.Encode(DecodedText, Caesar.Shift.Left, 5, English);
            Assert.AreEqual(Left, result);
        }
    }
}