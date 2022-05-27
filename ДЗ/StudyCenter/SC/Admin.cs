using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter
{
    public class Admin : Person, IEmployee
    {
        private string Lab;
        public int salary;
        public Admin(string lab, string name, DateTime birthdate) : base(name, birthdate)
        {
            Lab = lab;
        }
        public override void Print()
        {
            Console.WriteLine("\n\tАдминимтратор\nПолное имя: " + Name + "\nДата рождения:" + Birthdate + "\nВозраст:" + Age + "\nЛаборатория: " + Lab);
        }
        public void Salary()
        {
            Console.WriteLine("\nВведите почасовую ставку администратора:");
            int rate = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите количество рабочих часов:");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите размер премии (при отсутствии - введите ноль):");
            int bonus = int.Parse(Console.ReadLine());
            salary = rate * hours + bonus;
            Console.WriteLine("\nТекущая заработная плата администратора: " + salary);
        }
    }
}
