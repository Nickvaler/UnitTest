using System;
using System.IO;
using System.Reflection;

namespace UnitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileCreator.CreateFile();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "data.txt");
            var a = FileReader.ReadStringsFromFile(path);
            Console.ReadLine();
        }
    }
}
