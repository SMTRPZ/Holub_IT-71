using Microsoft.VisualStudio.TestTools.UnitTesting;
using PictureMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureMatrixTests
{
    [TestClass()]
    public class FolderTests
    {

        [TestMethod()]
        public void AddNameTest()
        {
            //arrange
            string a = @"\test";
            string b = @"\test";

            string expected = b + a;

            //act
            Folder f = new Folder(a);
            string actual = f.AddName(b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddNameEmptyTest()
        {
            //arrange
            string a = "";
            string b = "";

            string expected = b + a;

            //act
            Folder f = new Folder(a);
            string actual = f.AddName(b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddEmptyNameTest()
        {
            //arrange
            string a = "";
            string b = @"\test";

            string expected = b + a;

            //act
            Folder f = new Folder(a);
            string actual = f.AddName(b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddMultipleTest()
        {
            //arrange
            string a = @"\test";
            string b = @"\test1";
            string c = @"\test2";
            string d = @"\test3";

            string expected = a + b + c + d;

            //act
            Component f1 = new Folder(a);
            Component f2 = new Folder(b);
            Component f3 = new Folder(c);
            Component f4 = new Folder(d);
            f1.Add(f2);
            f2.Add(f3);
            f3.Add(f4);
            string actual = f1.AddName("");

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void RemoveTest()
        {
            //arrange
            string a = @"\test";
            string b = @"\test1";
            string c = @"\test2";
            string d = @"\test3";

            string expected = a;

            //act
            Component f1 = new Folder(a);
            Component f2 = new Folder(b);
            Component f3 = new Folder(c);
            Component f4 = new Folder(d);
            f1.Add(f2);
            f2.Add(f3);
            f3.Add(f4);
            f3.Remove(f4);
            f2.Remove(f3);
            f1.Remove(f2);
            string actual = f1.AddName("");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveOneTest()
        {
            //arrange
            string a = @"\test";
            string b = @"\test1";
            string c = @"\test2";
            string d = @"\test3";

            string expected = a + b;

            //act
            Component f1 = new Folder(a);
            Component f2 = new Folder(b);
            Component f3 = new Folder(c);
            Component f4 = new Folder(d);
            f1.Add(f2);
            f2.Add(f3);
            f3.Add(f4);
            f2.Remove(f3);
            string actual = f1.AddName("");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveFirstTest()
        {
            //arrange
            string a = @"\test";
            string b = @"\test1";
            string c = @"\test2";
            string d = @"\test3";

            string expected = a;

            //act
            Component f1 = new Folder(a);
            Component f2 = new Folder(b);
            Component f3 = new Folder(c);
            Component f4 = new Folder(d);
            f1.Add(f2);
            f2.Add(f3);
            f3.Add(f4);
            f1.Remove(f2);
            string actual = f1.AddName("");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveLastTest()
        {
            //arrange
            string a = @"\test";
            string b = @"\test1";
            string c = @"\test2";
            string d = @"\test3";

            string expected = a + b + c;

            //act
            Folder f1 = new Folder(a);
            Folder f2 = new Folder(b);
            Folder f3 = new Folder(c);
            Folder f4 = new Folder(d);
            f1.Add(f2);
            f2.Add(f3);
            f3.Add(f4);
            f3.Remove(f4);
            string actual = f1.AddName("");

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetChildTest()
        {
            //arrange
            string a = @"\test";
            string b = @"\test1";
            string c = @"\test2";
            string d = @"\test3";

            string expected = c + d;

            //act
            Folder f1 = new Folder(a);
            Folder f2 = new Folder(b);
            Folder f3 = new Folder(c);
            Folder f4 = new Folder(d);
            f1.Add(f2);
            f2.Add(f3);
            f3.Add(f4);
            string actual = f2.GetChild(0).AddName("");

            //assert
            Assert.AreEqual(expected, actual);
        }

        public void GetChild2Test()
        {
            //arrange
            string a = @"\test";
            string b = @"\test1";
            string c = @"\test2";
            string d = @"\test3";

            string expected = b + c + d;

            //act
            Folder f1 = new Folder(a);
            Folder f2 = new Folder(b);
            Folder f3 = new Folder(c);
            Folder f4 = new Folder(d);
            f1.Add(f2);
            f2.Add(f3);
            f3.Add(f4);
            string actual = f1.GetChild(0).AddName("");

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
