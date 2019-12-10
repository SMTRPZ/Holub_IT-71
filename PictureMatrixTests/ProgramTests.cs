using Microsoft.VisualStudio.TestTools.UnitTesting;
using PictureMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureMatrixTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestCreatePath()
        {
            //arrange
            string expected = @"C:\Users\Анна\Desktop\root\branch\linux.jpeg";

            //act
            string actual = Program.createPath();


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCreatePathNotNull()
        {
            //act
            string actual = Program.createPath();


            //assert
            Assert.IsNotNull(actual);
        }
    }
}
