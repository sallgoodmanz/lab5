using System;
using Xunit;
using BLL;

namespace EntrepreneurTest
{
    public class EntrepreneursTest
    {
        [Fact]
        public void Test_CorrectDatetime_2000_12_12_should_return_true()
        {
            Entrepreneur entrepreneur = new Entrepreneur();
            var dateOfBirth = new DateTime(2000, 12, 12);

            try
            {
                entrepreneur.dateOfBirth = dateOfBirth;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(dateOfBirth, entrepreneur.dateOfBirth);
        }
        [Fact]
        public void Test_Year_70_should_return_false()
        {
            Entrepreneur entrepreneur = new Entrepreneur();
            int Year = 70;

            try
            {
                entrepreneur.Year = Year;
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }

            Assert.NotEqual(Year, entrepreneur.Year);
        }
        [Fact]
        public void Test_Year_2_should_return_true()
        {
            Entrepreneur entrepreneur = new Entrepreneur();
            int Year = 2;

            try
            {
                entrepreneur.Year = Year;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(Year, entrepreneur.Year);
        }
        [Fact]
        public void Test_ID_111111_should_return_true()
        {
            Entrepreneur entrepreneur = new Entrepreneur();
            int ID = 111111;

            try
            {
                entrepreneur.ID = ID;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(ID, entrepreneur.ID);
        }
      
        [Fact]
        public void Test_CanSkyDive_Age_54_should_return_true()
        {
            Entrepreneur entrepreneur = new Entrepreneur();
            var age = 54;
            bool expected = true;
            bool actual;
            try
            {
                actual = entrepreneur.CanSkydive(age);
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test_DoWork_should_return_true()
        {
            Entrepreneur entrepreneur = new Entrepreneur();
            string expected = "¬иконую роботу п≥дприЇмц€...";
            string actual;
            try
            {
                actual = entrepreneur.DoWork();
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test_GetMoney_33000_should_return_true()
        {
            Entrepreneur entrepreneur = new Entrepreneur();
            decimal expected = 33000;
            decimal actual;
            try
            {
                actual = entrepreneur.GetMoney();
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(expected, actual);
        }
    }
}
