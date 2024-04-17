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

        public Money(int wholePart, int coinsPart)
        {
            SetMoney(wholePart, coinsPart);
        }

        public void SetMoney(int wholePart, int coinsPart)
        {
            WholePart = wholePart;
            CoinsPart = coinsPart;
            Normalize();
        }

        private void Normalize()
        {
            if (CoinsPart >= 100)
            {
                WholePart += CoinsPart / 100;
                CoinsPart %= 100;
            }
        }

        public override string ToString()
        {
            return $"{WholePart}.{CoinsPart:D2}";
        }
    }
}