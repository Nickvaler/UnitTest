using System.IO;

namespace UnitTestApp
{
    public class FileCreator
    {
        public static void CreateFile()
        {
            if (!File.Exists("data.txt"))
            {
                using (StreamWriter file = File.CreateText("data.txt"))
                {
                    file.WriteLine("one");
                    file.WriteLine("two");
                    file.WriteLine("three");
                }
            }
        }
    }
}
