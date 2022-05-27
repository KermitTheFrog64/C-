using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_1
{
    class Program
    {
        public static int Game(int balance)
        {
            Console.Write("Текущий баланс: {0}\n", balance);
            Console.Write("Введите сумму ставки\n");

            int bet = int.Parse(Console.ReadLine());
            if (bet > balance || bet <= 0)
            {
                Console.Write("Недопустимое значение ставки!\n");
                return balance;
            }
            else
            {
                Console.Write("Введите выбранную позицию\n0 - Чёт\n1 - Нечёт\n");
                int choice = int.Parse(Console.ReadLine());
                if ((choice != 0) & (choice != 1))
                {
                    Console.Write("Введено несуществующее значение!\n");
                    return balance;
                }
                Random rnd = new Random();
                int value = rnd.Next(1, 10);
                if (value % 2 == choice)
                {
                    balance += bet;
                    Console.Write("Победа!\nТекущий баланс:{0}\n", balance);
                }
                else
                {
                    balance -= bet;
                    Console.Write("Увы, мимо :(\nТекущий баланс:{0}\n", balance);
                }
            }

            return balance;
        }

        public static void Print(int balance)
        {

            Console.Write("Текущий баланс = {0}\n", balance);
        }

        static void Main(string[] args)
        {
            int balance = 10000, exit = 1;
            do
            {
                Console.Write("Выберите действие: \n1 - начать игру\n2 - узнать баланс \n3 - выйти\nВведите выбранное действие:\n");
                try
                {
                    int selection = int.Parse(Console.ReadLine());
                    switch (selection)
                    {
                        case 1:
                            int cont = 1;
                            while ((balance > 0) & (cont == 1))
                            {
                                balance = Game(balance);
                                Console.Write("Следующий раунд? 1 - продолжить, 0 - выйти из игры\n");
                                cont = int.Parse(Console.ReadLine());
                                if ((cont != 0) & (cont != 1))
                                {
                                    Console.Write("Введено некорректное значение.\n");
                                    break;
                                }
                            }
                            if (balance == 0) Console.Write("На вашем счету недостаточно средств.\n");
                            break;

                        case 2:
                            Print(balance);
                            break;

                        case 3:
                            exit = 0;
                            break;

                        default:
                            Console.Write("Введите корректное значение!\n");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введено некорректное значение.\n");
                }
            }
            while (exit != 0);
        }
    }
}
