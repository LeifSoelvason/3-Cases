
using NUnit.Framework;
using Project2_ClassLibrary1;
using System;



namespace Project4___Nunit
{
    public class FootballTests
    {

        Football _football;

        [SetUp]
        public void Setup()
        {//Arrange – Arranger.
            _football = new Football();
        }

        [Test] //Test1 
        public void Aflevering()
        {
            //Act – Handling.
            var result = _football.Aflevering(0);

            Assert.AreEqual("Shh", result);

            var result1 = _football.Aflevering(1);

            Assert.AreEqual("Huh!", result1);


            var result3 = _football.Aflevering(10);

            Assert.AreEqual("High Five – Jubel!!!", result3);

        }

        [Test] //Test2
        public void Mål()
        {
            //Act – Handling.
            var result = _football.Mål(0, "mål");

            Assert.AreEqual("Ole ole ole!", result);

            var result1 = _football.Mål(2, "mål");

            Assert.AreEqual("Ole ole ole!", result1);

            var result3 = _football.Mål(1, "");

            Assert.AreEqual("Huh!", result3);
        }
    }
}