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
    public class DefaultStrategyTests
    {

        [TestMethod]
        public void TestCountParameters()
        {
            //arrange
            double i = 2;
            double j = 3;
            int expectedCon = 6;
            int expectedAsm = 36;
            int expectedCor = 36;
            int expectedEnt = 6;

            //act
            DefaultStrategy def = new DefaultStrategy();
            def.countParameters(i, j);

            //assert
            Assert.AreEqual(expectedCon, def.getCon());
            Assert.AreEqual(expectedCor, def.getCor());
            Assert.AreEqual(expectedEnt, def.getEnt());
            Assert.AreEqual(expectedAsm, def.getAsm());
        }

        [TestMethod]
        public void TestCountParametersNotNull()
        {
            //arrange
            double i = 2;
            double j = 3;

            //act
            DefaultStrategy def = new DefaultStrategy();
            def.countParameters(i, j);

            //assert
            Assert.IsNotNull(def.getCon());
            Assert.IsNotNull(def.getCor());
            Assert.IsNotNull(def.getEnt());
            Assert.IsNotNull(def.getAsm());
        }

        [TestMethod]
        public void TestASMILessJ()
        {
            //arrange
            double i = 2;
            double j = 3;
            int expected = 36;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ASM(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestASMjlLessi()
        {
            //arrange
            double i = 4;
            double j = 3;
            int expected = 144;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ASM(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestASMNotNull()
        {
            //arrange
            double i = 3;
            double j = 3;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ASM(i, j);

            //assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestASMjequali()
        {
            //arrange
            double i = 3;
            double j = 3;
            int expected = 81;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ASM(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestENTjequali()
        {
            //arrange
            double i = 3;
            double j = 3;
            int expected = 18;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ENT(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestENTjLessi()
        {
            //arrange
            double i = 12;
            double j = 8;
            int expected = 384;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ENT(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestENTiLessj()
        {
            //arrange
            double i = 2;
            double j = 8;
            int expected = 32;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ENT(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestENTWith0()
        {
            //arrange
            double i = 0.11;
            double j = 0;
            int expected = 0;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ENT(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestP0()
        {
            //arrange
            double i = 0.11;
            double j = 0;
            int expected = 0;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.p(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Testp()
        {
            //arrange
            double i = 0.3;
            double j = 0.3;
            int expected = 0;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.p(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestP()
        {
            //arrange
            double i = 5;
            double j = 4.46;
            int expected = 20;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.p(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestpEquals()
        {
            //arrange
            double i = 8.56;
            double j = 8.56;
            int expected = 64;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.p(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestpNotNUll()
        {
            //arrange
            double i = 11;
            double j = 13;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ENT(i, j);

            //assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestENTGeneral()
        {
            //arrange
            double i = 0.11;
            double j = 0.7;
            int expected = 0;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.ENT(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCONjLESSi()
        {
            //arrange
            double i = 11;
            double j = 7;
            int expected = 1232;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.CON(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCONGeneral()
        {
            //arrange
            double i = 0.11;
            double j = 0.7;
            int expected = 0;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.CON(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCONNotNUll()
        {
            //arrange
            double i = 1;
            double j = 7;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.CON(i, j);

            //assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestCON()
        {
            //arrange
            double i = 1;
            double j = 7;
            int expected = 252;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.CON(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCOR()
        {
            //arrange
            double i = 1;
            double j = 7;
            int expected = 49;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.COR(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCOR0()
        {
            //arrange
            double i = 1;
            double j = 0;
            int expected = 0;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.COR(i, j);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCORPow()
        {
            //arrange
            double i = 3;
            double j = 5;
            int expected = 15;

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.COR(i, j);

            //assert
            Assert.AreEqual(Math.Pow(expected, 2), actual);
        }

        [TestMethod]
        public void TestCORNotNuLL()
        {
            //arrange
            double i = 3;
            double j = 5;
            

            //act
            DefaultStrategy def = new DefaultStrategy();
            int actual = def.COR(i, j);

            //assert
            Assert.IsNotNull(actual);
        }
    }
}
