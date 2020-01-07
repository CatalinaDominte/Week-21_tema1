using ConsoleApp1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        [TestCase("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
        [TestCase("The quick brown fox jumped over the lazy dog", "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]

        public void Goat_Latin(string input, string expected)
        {
            var actual = Goat.Latin( input);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Format_Excption()
        {
            Assert.Throws<FormatException>(() => Goat.Latin("Ana are 7 me1re"));
        }
    }
}
