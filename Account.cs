using System;

namespace ObjectOrientedCode
{
    class Account
    {
        public double Balance { get; private set; }
        private bool isFreezed;
        private bool isClosed;

        public double HesaptanCek(double miktar)
        {

            if (isClosed)
                return default(double);

            isFreezed = false;
            Balance -= miktar;
            Console.WriteLine($"Hesabınızdan {miktar} TL çekildi, kalan miktar {Balance} TL");
            return Balance;
        }

        public double HesabaYatır(double miktar)
        {
            if (isClosed)
                return default(double);

            isFreezed = false;
            Balance += miktar;
            Console.WriteLine($"Hesabınıza {miktar} TL yatırıldı , hesabınızdaki miktar {Balance} TL");
            return Balance ; 
        }

        public void CloseAccount()
        {
            isClosed = true;
            Console.WriteLine("Hesabınız kapatıldı");
        }

        public void FreezeAccount()
        {
            isFreezed = true;
            Console.WriteLine("Hesabınız askıya alındı");
        }

    }

}
