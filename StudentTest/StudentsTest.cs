using Xunit;
using BLL;
using System;

namespace StudentTest
{
    public class StudentsTest
    {
        [Fact]
        public void Test_Name_Arthur_should_return_true()
        {
            Student student = new Student();
            string name = "Arthur";

            try
            {
                student.Name = name;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(name, student.Name);
        }
        [Fact]
        public void Test_Surname_Zadniprovskyi_should_return_true()
        {
            Student student = new Student();
            string surname = "Zadniprovskyi";

            try
            {
                student.Surname = surname;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(surname, student.Surname);
        }
        [Fact]
        public void Test_CorrectDatetime_2000_12_12_should_return_true()
        {
            Student student = new Student();
            var dateOfBirth = new DateTime(2000, 12, 12);

            try
            {
                student.dateOfBirth = dateOfBirth;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(dateOfBirth, student.dateOfBirth);
        }
        [Fact]
        public void Test_Year_9_should_return_false()
        {
            Student student = new Student();
            int Year = 9;

            try
            {
                student.Year = Year;
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }

            Assert.NotEqual(Year, student.Year);
        }
        [Fact]
        public void Test_Year_2_should_return_true()
        {
            Student student = new Student();
            int Year = 2;

            try
            {
                student.Year = Year;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(Year, student.Year);
        }
        [Fact]
        public void Test_ID_111111_should_return_true()
        {
            Student student = new Student();
            int ID = 111111;

            try
            {
                student.ID = ID;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(ID, student.ID);
        }
        [Fact]
        public void Test_StudentTicket_999999999_should_return_false()
        {
            Student student = new Student();
            int StudentTicket = 999999999;

            try
            {
                student.StudentTicket = StudentTicket;
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }

            Assert.NotEqual(StudentTicket, student.StudentTicket);
        }
        [Fact]
        public void Test_StudentTicket_123456_should_return_true()
        {
            Student student = new Student();
            int StudentTicket = 123456;

            try
            {
                student.StudentTicket = StudentTicket;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(StudentTicket, student.StudentTicket);
        }
        [Fact]
        public void Test_CanSkyDive_Age_19_should_return_true()
        {
            Student student = new Student();
            var age = 19;
            bool expected = true;
            bool actual;
            try
            {
                actual = student.CanSkydive(age);
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
            Student student = new Student();
            string expected = "Виконую лабораторну роботу...";
            string actual;
            try
            {
                actual = student.DoWork();
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test_GetMoney_2000_should_return_true()
        {
            Student student = new Student();
            decimal expected = 2000;
            decimal actual;
            try
            {
                actual = student.GetMoney();
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

            Assert.Equal(expected, actual);
        }
    }
}
