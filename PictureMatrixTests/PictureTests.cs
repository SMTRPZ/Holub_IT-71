using Microsoft.VisualStudio.TestTools.UnitTesting;
using PictureMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureMatrix.Tests
{
    [TestClass()]
    public class PictureTests
    {
        [TestMethod()]
        public void AddNameTest()
        {
            //arrange
            string testPath = "test";
            string expected = testPath + @"\test.jpeg";

            //act
            Picture pic = new Picture(@"\test.jpeg");
            string actual = pic.AddName(testPath);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddNameTestEmpty()
        {
            //arrange
            string testPath = "";
            string expected = @"\test.jpeg";

            //act
            Picture pic = new Picture(@"\test.jpeg");
            string actual = pic.AddName(testPath);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddNameTestEmptyName()
        {
            //arrange
            string testPath = "test";
            string expected = testPath;

            //act
            Picture pic = new Picture("");
            string actual = pic.AddName(testPath);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddNameEmpty()
        {
            //arrange
            string testPath = "";
            string expected = testPath;

            //act
            Picture pic = new Picture("");
            string actual = pic.AddName(testPath);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}