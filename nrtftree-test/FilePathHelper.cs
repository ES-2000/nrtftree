using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Net.Sgoliver.NRtfTree.Test
{
    class FilePathHelper
    {
        public static string GetFilePath(string aPath)
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", string.Empty), aPath);
        }
    }
}
