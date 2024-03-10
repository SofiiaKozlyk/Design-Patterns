using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Money : IMoney, IDisplay
    {
        public string Currency { get; set; }
        private int _banknotes;

        public int Banknotes
        {
            get { return _banknotes; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Banknotes have to be more than or equal to 0");
                _banknotes = value;
            }
        }
        private int _coins;

        public int Coins
        {
            get { return _coins; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Coins have to be more than or equal to 0");
                _coins = value;
                while (_coins >= 100)
                {
                    _coins -= 100;
                    Banknotes++;
                }
            }
        }
        public Money(int banknotes, int coins, string currency)
        {
            Banknotes = banknotes;
            Coins = coins;
            Currency = currency;
        }
        public void Display()
        {
            Console.WriteLine($"Amount: {Banknotes}.{Coins:D2} {Currency}");
        }
        public void AddMoney(int banknotes, int coins)
        {
            if (banknotes < 0 || coins < 0)
                throw new ArgumentException("Banknotes/coins have to be more than or equal to 0");
            Banknotes += banknotes;
            Coins += coins;
        }
        public void RemoveMoney(int banknotes, int coins)
        {
            if (banknotes < 0 || coins < 0)
                throw new ArgumentException("Banknotes/coins have to be more than or equal to 0");
            banknotes = Banknotes - banknotes;
            coins = Coins - coins;
            while(banknotes > 0 && coins < 0)
            {
                banknotes--;
                coins += 100;
            }
            if (banknotes < 0 || coins < 0)
                throw new ArgumentException("Banknotes/Сoins have to be more than or equal to 0");
            Banknotes = banknotes;
            Coins = coins;
        }
    }
}
