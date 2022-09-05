using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class LeapYearTest
    {
        [Fact]
        public void IsLeapYear_given_1600_returns_true()
        {
            var leapYear = new LeapYear();

            var isLeapYear = leapYear.IsLeapYear(1600);

            Assert.True(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_given_1700_returns_false()
        {
            var leapYear = new LeapYear();

            var isLeapYear = leapYear.IsLeapYear(1700);

            Assert.False(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_given_1800_returns_false()
        {
            var leapYear = new LeapYear();

            var isLeapYear = leapYear.IsLeapYear(1800);

            Assert.False(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_given_1900_returns_false()
        {
            var leapYear = new LeapYear();

            var isLeapYear = leapYear.IsLeapYear(1900);

            Assert.False(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_given_2000_returns_true()
        {
            var leapYear = new LeapYear();

            var isLeapYear = leapYear.IsLeapYear(2000);

            Assert.True(isLeapYear);
        }

        [Fact]
        public void IsLeapYear_given_2004_returns_true()
        {
            //Assign
            var leapCalculator = new LeapYear();

            //Act
            bool isLeapyear = leapCalculator.IsLeapYear(2004);

            //Assert
            Assert.True(isLeapyear);
        }

        [Fact]
        public void IsLeapYear_given_2001_returns_false()
        {
            //Assign
            var leapCalculator = new LeapYear();

            //Act
            bool isLeapyear = leapCalculator.IsLeapYear(2001);

            //Assert
            Assert.False(isLeapyear);
        }

        [Fact]
        public void IsLeapYear_given_1704_returns_true()
        {
            //Assign
            var leapCalculator = new LeapYear();

            //Act
            bool isLeapyear = leapCalculator.IsLeapYear(1704);

            //Assert
            Assert.True(isLeapyear);
        }
    }
}
