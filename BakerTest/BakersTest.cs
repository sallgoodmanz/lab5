using System;
using Xunit;
using BLL;

namespace BakerTest
{
    public class BakersTest
    {
        [Fact]
        public void Test_CorrectDatetime_2000_12_12_should_return_true()
        {
            Baker baker = new Baker();
            var dateOfBirth = new DateTime(2000, 12, 12);

            try
            {
                baker.dateOfBirth = dateOfBirth;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(dateOfBirth, baker.dateOfBirth);
        }
        [Fact]
        public void Test_ID_111111_should_return_true()
        {
            Baker baker = new Baker();
            int ID = 111111;

            try
            {
                baker.ID = ID;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(ID, baker.ID);
        }
       
        [Fact]
        public void Test_CanSkyDive_Age_35_should_return_true()
        {
            Baker baker = new Baker();
            var age = 35;
            bool expected = true;
            bool actual;
            try
            {
                actual = baker.CanSkydive(age);
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
            Baker baker = new Baker();
            string expected = "Виконую роботу пекаря...";
            string actual;
            try
            {
                actual = baker.DoWork();
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test_GetMoney_13000_should_return_true()
        {
            Baker baker = new Baker();
            decimal expected = 13000;
            decimal actual;
            try
            {
                actual = baker.GetMoney();
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(expected, actual);
        }
    }
}
