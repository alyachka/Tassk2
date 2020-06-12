using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Man
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
                if ((value != null) && (value.Length >= 4) && (value.Length <= 30))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ((value > 0) && (value <= 120))
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if ((value > 0))
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }
        private double hight;
        public double Hight
        {
            get
            {
                return hight;
            }
            set
            {
                if ((value > 0))
                {
                    hight = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        public Man(string newName, int newAge, double newWeight, double newHight)
        {
            Name = newName;
            Age = newAge;
            Weight = newWeight;
            Hight = newHight;
        }

        public override string ToString()
        {
            return $"{Name} { Age} { Weight} { Hight}";
        }

        public virtual string GetAge()
        {
            return $"{Age}";
        }
    }
}
