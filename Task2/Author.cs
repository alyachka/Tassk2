using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Author
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value != null)
                {
                    surname = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private int birthYear;
        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                if (value >= 0)
                {
                    birthYear = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        public Author(string newName, string newSurname, int newBirthYear)
        {
            Name = newName;
            Surname = newSurname;
            BirthYear = newBirthYear;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {BirthYear}";
        }
    }
}
