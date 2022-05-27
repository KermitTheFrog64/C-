using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter
{
    public abstract class Person
    {
        protected string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public DateTime Today;
        protected Person (DateTime today)
        {
            Today = today;
        }

        public Person() { }

        protected Person(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
            Age = Today.Year - Birthdate.Year;
            if (Birthdate > Today.AddYears(-Age)) 
                Age--;
        }
        public abstract void Print();
        
    }
}
