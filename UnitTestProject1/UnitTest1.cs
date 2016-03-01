using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string attendu = "Bob";

            string str1 = "Bob;Rio;0754205389";
            string resultat;
            resultat = Program.StringToken(str1, ';', 0);

            Assert.AreEqual(resultat, attendu);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string attendu = "0754205389";

            string str1 = "Bob;Rio;0754205389";
            string resultat;
            resultat = Program.StringToken(str1, ';', 2);

            Assert.AreEqual(resultat, attendu);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string attendu = "";

            string str1 = "Bob;Rio;0754205389";
            string resultat;
            resultat = Program.StringToken(str1, ';', -2);

            Assert.AreEqual(resultat, attendu);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string attendu = "";

            string str1 = "Bob;Rio;0754205389";
            string resultat;
            resultat = Program.StringToken(str1, ';', 36);

            Assert.AreEqual(resultat, attendu);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string attendu = "Bob;Rio;0754205389";

            string str1 = "Bob;Rio;0754205389";
            string resultat;
            resultat = Program.StringToken(str1, 'e', 0);

            Assert.AreEqual(resultat, attendu);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string attendu = "";

            string str1 = "";
            string resultat;
            resultat = Program.StringToken(str1, ' ', 12);

            Assert.AreEqual(resultat, attendu);
        }
    }
}
