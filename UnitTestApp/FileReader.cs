using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UnitTestApp
{
    public class FileReader
    {
        public static List<string> ReadStringsFromFile(string path)
        {
            return File.ReadAllLines(path).ToList();
        }
    }
}
