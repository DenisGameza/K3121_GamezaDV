using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Game
    {
        Player player;
        public Game(Player player)
        {
            this.player = player;
        }
        public void start()
        {
            Console.WriteLine("Начало игры! Введите стартовый баланс: ");
            player.balance = int.Parse(Console.ReadLine());
            while (player.balance <= 0)
            {
                Console.WriteLine("Ошибка. Введите корректный стартовый баланс.");
                player.balance = int.Parse(Console.ReadLine());
            }
        }
        public void choice()
        {
            bool fg = true;
            while (fg)
            {
                player.setbet();
                Console.WriteLine("Чётное(0) или нечётное(1)?");
                try{
                    int choice = int.Parse(Console.ReadLine());
                    Random rnd = new Random();
                    int temp = rnd.Next(1, 100);
                    temp %= 2;
                    if (temp == choice) player.choice = true;
                    else player.choice = false;
                    player.balancechanging();
                    if (player.balance > 0)
                    {
                        Console.WriteLine("Продолжаем? 1 - да, 0 - нет.");
                        int temp1 = int.Parse(Console.ReadLine());
                        if (temp1 == 1) fg = true;
                        else fg = false;
                    }
                    else fg = false;
                }
                catch (FormatException e) {
                    Console.WriteLine("Ошибка формата: {0}", e.Message);}
            }
            Console.WriteLine("Спасибо за игру.");
        }
    }
}

