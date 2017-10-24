using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Net.Sgoliver.NRtfTree.Core;
using NUnit.Framework;

namespace Net.Sgoliver.NRtfTree.Test
{
    [TestFixture]
    class PlainTextTest
    {
        [Test]
        public void ConvertToPlainText()
        {
            RtfTree tree = new RtfTree();

            int res = tree.LoadRtfFile(FilePathHelper.GetFilePath("testdocs\\plaintext-test.rtf"));

            StreamReader sr = new StreamReader(FilePathHelper.GetFilePath("testdocs\\plaintext-result.txt"));
            string doctext1 = sr.ReadToEnd();
            sr.Close();

            Assert.AreEqual(tree.Text, doctext1);
        }

    }
}
