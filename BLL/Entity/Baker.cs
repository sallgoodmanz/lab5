using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class Baker : Human
    {
        public Baker() : base() { }
       
        public Baker(string name, string surname, int ID, DateTime dateOfBirth)
           : base(name, surname, ID)
        {
            this.dateOfBirth = dateOfBirth;
            Age = 2021 - this.dateOfBirth.Year;
        }
        public override decimal GetMoney() { return 13000; }
        public override bool CanSkydive(int age) { return true; }
        public override string DoWork() { return "Виконую роботу пекаря..."; }
    }
}