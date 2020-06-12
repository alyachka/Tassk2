using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student : Man
    {
        private int admissionYear;
        public int AdmissionYear
        {
            get
            {
                return admissionYear;
            }
            set
            {
                if ((value >= 1020))
                {
                    admissionYear = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private string course;
        public string Course
        {
            get
            {
                return course;
            }
            set
            {
                if ((value != null))
                {
                    course = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        private int group;
        public int Group
        {
            get
            {
                return group;
            }
            set
            {
                if ((value > 0))
                {
                    group = value;
                }
                else
                {
                    throw new ArgumentException("Внимание! Неверное значение");
                }
            }
        }

        public Student(string newName, int newAge, double newWeigh, double newHight, int newAdmissionYear, string newCourse, int newGroup) : base(newName, newAge, newWeigh, newHight)
        {
            AdmissionYear = newAdmissionYear;
            Course = newCourse;
            Group = newGroup;

        }

        public override string ToString()
        {
            return $"{Name} { Age} { Weight} { Hight} { AdmissionYear} { Course} { Group}";
        }

        public override string GetAge()
        {
            return $"{Age} {AdmissionYear}";
        }

    }
}
