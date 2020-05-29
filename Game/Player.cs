using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Player
    {
        private int bet;
        public bool choice;
        public int balance;
        public void setbet()
        {
            Console.WriteLine("Введите размер ставки: ");
            bet = int.Parse(Console.ReadLine());
            while (bet <= 0 || bet > balance)
            {
                Console.WriteLine("Ошибка. Введите корректный размер ставки.");
                bet = int.Parse(Console.ReadLine());
            }
        }
        public void getbalance() {
            Console.WriteLine("Ваш баланс {0}", balance); }
        public void balancechanging()
        {
            if (choice == true)
            {
                balance += bet;
                Console.WriteLine("Ваша ставка сыграла. Текущий баланс: {0}", balance);
                choice = false;
            }
            else
            {
                balance -= bet;
                Console.WriteLine("Ваша ставка не сыграла. Текущий баланс: {0}", balance);
            }
        }

    }
}
