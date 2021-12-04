using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnitTestApp;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestFileReader
    {
        [Test]
        public void Test_ReadStringsFromFile()
        {
            //Arrange
            FileCreator.CreateFile();
            // Act
            FileCreator.CreateFile();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "data.txt");

            var strList = FileReader.ReadStringsFromFile(path);
            Assert.AreEqual(new List<string> { "one", "two", "three" }, strList);
        }

    }
}
