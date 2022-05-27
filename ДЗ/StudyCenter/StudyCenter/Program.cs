using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter
{
    public class Program
    {
        public static DateTime today = DateTime.Today;
        public static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            Admin admin1 = new Admin("Физическая лаборатория", "Смирнов И.А.", new DateTime(1973, 03, 18));
            Manager manager1 = new Manager("ИКТ", "Кадровый менеджер", "Устинов П.Р.", new DateTime(1981, 11, 09));
            Teacher teacher1 = new Teacher("ИКТ", "Преподаватель по информатике", "Куманов Г.А. ", new DateTime(1989, 09, 28));
            Student student1 = new Student("ИКТ", "К3122", "Заболотная Н.А.", new DateTime(1999, 12, 30));
            person.Add(admin1);
            person.Add(manager1);
            person.Add(teacher1);
            person.Add(student1);

            bool exit = false;
            do
            {
                try
                {
                    Console.WriteLine("\n\tУчебный центр\n1 - Перечень сотрудников и студентов\n2 - Рассчитать з/п человека\n3 - Поиск персон по возрасту\n4 - Выход ");
                    int Selection = int.Parse(Console.ReadLine());
                    switch (Selection)
                    {
                        case 1:
                            Console.WriteLine("\tПеречень сотрудников и студентов");
                            foreach (Person P in person)
                            {
                                P.Print();
                            }
                            break;
                        case 2:

                            Console.Write("\n\tЗаработная плата\nВведите должность сотрудника: ");
                            string Option = Console.ReadLine();
                            switch (Option)
                            {
                                case "Администратор" :
                                    admin1.Salary();
                                    break;
                                case "Менеджер":
                                    manager1.Salary();
                                    break;
                                case "Преподаватель":
                                    teacher1.Salary();
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write("\n\tПоиск людей\nВведите диапазон возраста:\nОт: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("До: ");
                            int b = int.Parse(Console.ReadLine());
                            foreach (Person p in person)
                            {
                                if (p.Age >= a && p.Age <= b) 
                                { 
                                    p.Print(); 
                                }
                            }
                            break;
                        case 4:
                            exit = true;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введенно некоректное значение");
                }
            } 
            while (exit == false);
        }
    }
}
