using NUnit.Framework;
using Project2_ClassLibrary1;
using System;



namespace Project4___Nunit
{
    public class DancerTests
    {     
        
        //Dancer Dancer1;
        //Dancer Dancer2;
        

        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void Dancer_Test()
        {   
            //Arrange
            Dancer Dancer1 = new Dancer("Dave", 4);
            Dancer Dancer2 = new Dancer("Jessica", 8);
            Dancer Dancer3 = new Dancer();

            //Act
            //Dancer3.Points = Dancer1.Points + Dancer2.Points;
            //Dancer3.Name = Dancer1.Name + " og " + Dancer2.Name;
            Dancer3 = Dancer1 + Dancer2;

            //Assert
            
            Assert.AreEqual(12, Dancer3._Points);
            
            
            
            
            Assert.AreEqual("Dave og Jessica", Dancer3.Name);
        }
    }
}