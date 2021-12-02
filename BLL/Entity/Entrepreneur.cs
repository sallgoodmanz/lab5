using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class Entrepreneur : Human
    {
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (InputProtection.ProtectedIntegers(value, 2, 40))
                {
                    year = value;
                }
                else throw new Exception("Перевірте коректність вводу даних про особу!");
            }
        }
        public Entrepreneur() : base() { }
        
        public Entrepreneur(string name, string surname, int ID, int year, DateTime dateOfBirth)
             : base(name, surname, ID)
        {
            if (InputProtection.ProtectedIntegers(year, 2, 6))
            {
                this.dateOfBirth = dateOfBirth;
                Year = year;
                Age = 2021 - this.dateOfBirth.Year;
            }
            else throw new Exception("Перевірте коректність вводу даних про особу!");
        }
        public override decimal GetMoney() { return 33000; }
        public override bool CanSkydive(int age) { return true; }
        public override string DoWork() { return "Виконую роботу підприємця..."; }
    }
}
