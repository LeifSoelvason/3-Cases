using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2_ClassLibrary1;
using NUnit.Framework;

namespace Project4_UnitTestProject1
{
    public class PasswordTests
    {
        Password _password;

        [SetUp]
        public void Setup()
        {
            _password = new Password();
        }

        [Test]
        public void PasswordCheck_Length_Test()
        {
            var result = _password.Create_MyPassword("", "sfsfssfs");
            Assert.AreEqual("Password skal være på minimum 12 tegn", result);
        }

        [Test]
        public void LastCharNotaDigit()
        {
            var result = _password.Create_MyPassword("", "sfsfsQs@fdgdg9");
            Assert.AreEqual("Sidste karakter i password må ikke være et tal", result);
        }

        [Test]
        public void FirstCharNotaDigit()
        {
            var result = _password.Create_MyPassword("", "2sfsfsQs@fdgdg");
            Assert.AreEqual("Første karakter i password må ikke være et tal", result);
        }
    }
}
