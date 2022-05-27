using System;

namespace StudyCenter
{
    public class Manager : Person, IEmployee
    {
        private string Faculty, Post;
        public int salary;
        public Manager(string faculty, string post, string name, DateTime birthdate) : base(name, birthdate)
        {
            Faculty = faculty;
            Post = post;
        }
        public override void Print()
        {
            Console.WriteLine("\n\tМенеджер\nПолное имя: " + Name + "\nДата рождения:" + Birthdate + "\nВозраст:" + Age + "\nДолжность:" + Post + "\nФакультет: " + Faculty);
        }
        public void Salary()
        {
            Console.WriteLine("\nВведите почасовую ставку менеджера:");
            int rate = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите количество рабочих часов:");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите размер премии (при отсутствии - введите ноль):");
            int bonus = int.Parse(Console.ReadLine());
            salary = rate * hours + bonus;
            Console.WriteLine("\nТекущая заработная плата менеджера составляет: " + salary);
        }
    }
}
