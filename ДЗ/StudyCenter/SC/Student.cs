using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter
{
    public class Student : Person
    {
        private string Faculty, Group;
        public Student(string faculty, string group, string name, DateTime birthdate) : base(name, birthdate)
        {
            Faculty = faculty;
            Group = group;
        }
        public override void Print()
        {
            Console.WriteLine("\n\tСтудент\nПолное имя: " + Name + "\nДата рождения: " + Birthdate + "\nВозраст: " + Age + "\nФакультет: " + Faculty + "\nГруппа: " + Group);
        }
        
    }
}
