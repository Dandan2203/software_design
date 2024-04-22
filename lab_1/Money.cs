using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Money
    {
        public int WholePart { get; private set; }
        public int CoinsPart { get; private set; }

        public Money(int whole, int coins)
        {
            SetMoney(whole, coins);
        }

        public void SetMoney(int whole, int coins)
        {
            WholePart = whole;
            CoinsPart = coins;
            Normalize();
        }

        private void Normalize()
        {
            if (CoinsPart >= 100)
            {
                WholePart += CoinsPart / 100;
                CoinsPart = CoinsPart % 100;
            }
        }

        public void Display()
        {
            Console.WriteLine($"{WholePart} грн. {CoinsPart:D2} коп.");
        }
    }
}