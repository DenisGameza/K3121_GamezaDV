using System;
namespace Chet_nechet
{
    class Game
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Начало игры! Введите стартовый баланс: ");
                int balance = int.Parse(Console.ReadLine());
                while (balance <= 0 )
                {
                    Console.WriteLine("Ошибка. Введите корректный стартовый баланс.");
                    balance = int.Parse(Console.ReadLine());
                }
                bool fg = true;
                while (fg)
                {
                    int bet = 0;
                    makebet(ref balance, ref bet);
                    int choice = makechoice();
                    if (choice == -1) Console.WriteLine("Ошибка ввода. Конец игры.");
                    else
                    {
                        if (check(ref balance, bet, choice, randomint()))
                        {
                            Console.WriteLine("Конец игры.");
                        }
                    }
                    Console.WriteLine("Продолжаем? 1 - да, 0 - нет.");
                    int temp = int.Parse(Console.ReadLine());
                    if (temp == 1) fg = true;
                    else fg = false;
                }
                Console.WriteLine("Спасибо за игру.");
            }
            catch (FormatException e) {
                Console.WriteLine("Ошибка формата: {0}", e.Message); }
            catch (Exception e) {
                Console.WriteLine("Ошибка: {0}", e.Message); }
        }
        static void makebet(ref int balance,ref int bet)
        {
            Console.WriteLine("Введите размер ставки: ");
            bet = int.Parse(Console.ReadLine());
            while (bet<=0 || bet > balance)
            {
                Console.WriteLine("Ошибка. Введите корректный размер ставки.");
                bet = int.Parse(Console.ReadLine());
            }
        }
        static int makechoice()
        {
            Console.WriteLine("Чётное(0) или нечётное(1)?");
            try
            {
                int temp = int.Parse(Console.ReadLine());
                return temp;
            }
            catch (FormatException e) {
                Console.WriteLine("Ошибка формата: {0}", e.Message); return -1;
            }
        }
        static int randomint()
        {
            Random rnd = new Random();
            int temp = rnd.Next(1,100);
            return temp % 2;
        }
        static bool check(ref int balance,int bet,int choice,int random)
        {
            if (choice == random)
            {
                balance += bet;
                Console.WriteLine("Ваша ставка сыграла. Текущий баланс: {0}",balance);
            }
            else
            {
                balance -= bet;
                Console.WriteLine("Ваша ставка не сыграла. Текущий баланс: {0}", balance);
                if (balance <= 0) return true;
            }
            return false;
        }
    }
}
