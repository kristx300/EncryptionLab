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
    public class PolyalphabeticTests
    {
        public readonly char[] English = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();
        public readonly char[] Russian = Enumerable.Range('а', 'я' - 'а' + 1).Select(i => (char)i).ToArray();
        public const string DecodedText = "hello";
        public const string Key = "null";
        public const string EncodedText = "uywwb";
        [TestMethod()]
        public void DecodeTest()
        {
            var res = Polyalphabetic.Decode(EncodedText, Key, English);
            Assert.AreEqual(DecodedText, res);
        }

        [TestMethod()]
        public void EncodeTest()
        {
            var res = Polyalphabetic.Encode(DecodedText, Key, English);
            Assert.AreEqual(EncodedText,res);
        }

        [TestMethod()]
        public void GenerateSubAlphabetTest()
        {
            var result = Polyalphabetic.GenerateSubAlphabet(English, "null");
            Debug.Write(JsonConvert.SerializeObject(result,Formatting.Indented));
        }
    }
}