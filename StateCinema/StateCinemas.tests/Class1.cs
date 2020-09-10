using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace StateCinemas
{
    [TestFixture]
    public class StateCinematests
    {
        [TestCase]
        public void Adult_Before_5_test()
        {
            // Arrange
            StateCinemas sut = new StateCinemas();
            // Act 
            decimal lastPrice = sut.Adult_Before_5(3, "Adult", "Monday", 4);
            // Assert
            Assert.AreEqual(lastPrice, 43.5);
        }


        [TestCase]
        public void Adult_After_5_test()
        {
            // Arrange
            StateCinemas sut = new StateCinemas();
            // Act 
            decimal lastPrice = sut.Adult_After_5(2, "Adult", "Monday", 6);
            // Assert
            Assert.AreEqual(lastPrice,35);
        }

        [TestCase]
        public void Adult_Tuesday_test()
        {
            // Arrange
            StateCinemas sut = new StateCinemas();
            // Act 
            decimal lastPrice = sut.Adult_Tuesday(2, "Adult", "Tuesday");
            // Assert
            Assert.AreEqual(lastPrice, 26);
        }


        [TestCase]
        public void Child_Under_16_test()
        {
            // Arrange
            StateCinemas sut = new StateCinemas();
            // Act 
            decimal lastPrice = sut.Child_Under_16(3,"Child");
            // Assert
            Assert.AreEqual(lastPrice, 36);
        }


        [TestCase]
        public void Senior_test()
        {
            // Arrange
            StateCinemas sut = new StateCinemas();
            // Act 
            decimal lastPrice = sut.Senior(2, "Senior");
            // Assert
            Assert.AreEqual(lastPrice, 25);
        }

        [TestCase]
        public void Student_test()
        {
            // Arrange
            StateCinemas sut = new StateCinemas();
            // Act 
            decimal lastPrice = sut.Student(2,"Student");
            // Assert
            Assert.AreEqual(lastPrice, 28);
        }

    }

}



