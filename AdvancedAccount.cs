using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCode
{
    public class AdvancedAccount
    {
        public double Balance { get; private set; }
    
        private IAccountState state;
        private AccountManager _islematik;

        public AdvancedAccount()
        {
            _islematik = new AccountManager(() => { Console.WriteLine("Hesabınız askıya alındı"); }, () => { Console.WriteLine("Hesabınız kapatıldı"); });
        }
        public double HesaptanCek(double miktar)
        {
           state =  _islematik.HesaptanCek(() => { Balance -= miktar; Console.WriteLine($"Hesabınızdan {miktar} TL çekildi, kalan miktar {Balance} TL"); });
            return Balance;
        }

        public double HesabaYatır(double miktar)
        {
            state = _islematik.HesabaYatir(() => { Balance += miktar; Console.WriteLine($"Hesabınıza {miktar} TL yatırıldı , hesabınızdaki miktar {Balance} TL"); });
            return Balance;
        }

        public void CloseAccount()
        {
            state = _islematik.Close();
        }

        public void FreezeAccount()
        {
            state = _islematik.Freeze();
        }

        public void HesapDurum()
        {
            Console.WriteLine(state.Durum);
        }
    }
}
