using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter
{
    public class Teacher : Person, IEmployee
    {
        private string Faculty, Post;
        private int seniority;
        public int salary;
        public DateTime NowToday;

        public Teacher (DateTime today)
        {
            NowToday = today;
        }

        public Teacher(string faculty, string post, string name, DateTime birthdate) : base(name, birthdate)
        {
            Faculty = faculty;
            Post = post;
            
        }
        public override void Print()
        {
            Console.WriteLine("\n\tПреподаватель\nПолное имя: " + Name + "\nДата рождения:" + Birthdate + "\nВозраст:" + Age + "\nДолжность: " + Post + "\nФакультет: " + Faculty, "\nСтаж: " + seniority);
        }
        public void Salary()
        {
            Console.WriteLine("\nВведите почасовую ставку преподавателя:");
            int rate = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите количество рабочих часов:");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите размер премии (при отсутствии введите ноль):");
            int bonus = int.Parse(Console.ReadLine());
            salary = rate * hours + bonus;
            Console.WriteLine("\nТекущая заработная плата преподавателя составляет: " + salary);
        }
        public void Seniority()
        {
            Console.WriteLine("\nВведите дату начала начала работы преподавателя:");
            DateTime begindate = DateTime.Parse(Console.ReadLine());
            seniority = NowToday.Year - begindate.Year;
            if (begindate > NowToday.AddYears(-seniority))
                seniority--;
        }
    }
}
