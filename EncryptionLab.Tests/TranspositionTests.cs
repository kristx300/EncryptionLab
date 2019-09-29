using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncryptionLab;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EncryptionLab.Tests
{
    [TestClass()]
    public class TranspositionTests
    {
        public const string DecodedText = "КОМОВА_ОЛЬГА_СЕМЁНОВНА";
        public const string Key = "БАНАН";
        public const string EncodedText = "ООКМВ_ЛАОЬАСГ_ЕЁОМНВА_Н__";
        [TestMethod()]
        public void DecodeTest()
        {
            var res = Transposition.Decode(EncodedText, Key);
            Assert.AreEqual(DecodedText, res.Substring(0,DecodedText.Length));
        }

        [TestMethod()]
        public void EncodeTest()
        {
            var res = Transposition.Encode(DecodedText, Key);
            Assert.AreEqual(EncodedText,res);
        }
        [TestMethod()]
        public void EncodeTestNumberCase()
        {
            var res = Transposition.Encode("abcd", "2413");
            Assert.AreEqual("cadb", res);
        }
    }
}