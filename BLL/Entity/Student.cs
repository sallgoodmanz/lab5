using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class Student : Human
    {
        #region data
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (InputProtection.ProtectedIntegers(value, 1, 6))
                {
                    year = value;
                }
                else throw new Exception("Перевірте коректність вводу даних про особу!");
            }
        }
      
        private int studentTicket;
        public int StudentTicket
        {
            get { return studentTicket; }
            set
            {
                if (InputProtection.ProtectedIntegers(value, 6, 999999))
                {
                    studentTicket = value;
                }
                else throw new Exception("Перевірте коректність вводу даних про особу!");
            }
        }
        #endregion

        public Student() : base() { }
        public Student(string name, string surname, int ID, int year, int studentTicket, DateTime dateOfBirth)
            : base(name, surname, ID)
        {
            this.dateOfBirth = dateOfBirth;
            Year = year;
            StudentTicket = studentTicket;
            Age = 2021 - this.dateOfBirth.Year;
        }

        public override decimal GetMoney() { return 2000; }
        public override bool CanSkydive(int age) 
        {
            if (age >= 18)
                return true;
            else return false;
        }
        public override string DoWork() { return "Виконую лабораторну роботу..."; }
    }
}
