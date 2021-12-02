using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public abstract class Human : ISkydivable, IWorkable, IGettableMoney
    {
        #region data
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (InputProtection.ProtectedLetters(value))
                {
                    name = value;
                }
                else throw new Exception("Перевірте коректність вводу даних про особу!");
            }
        }
       
        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                if (InputProtection.ProtectedLetters(value))
                {
                    surname = value;
                }
                else throw new Exception("Перевірте коректність вводу даних про особу!");
            }
        }
        public int Age { get; set; }
        
        private int id;
        public int ID
        {
            get { return id; }
            set
            {
                if (InputProtection.ProtectedIntegers(value, 6, 999999))
                {
                    id = value;
                }
                else throw new Exception("Перевірте коректність вводу даних про особу!");
            }
        }
       
        public DateTime dateOfBirth = new DateTime();
        #endregion

        public Human() { }
        public Human(string name, string surname, int ID)
        {
            Name = name;
            Surname = surname;
            this.ID = ID;
        }

        public abstract decimal GetMoney();
        public abstract bool CanSkydive(int age);
        public abstract string DoWork();
    }
}
