using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCode
{
    class ClosedAccount : IAccountState
    {
        private readonly Action _onClosed;

        public string Durum => "Hesap Kapalı";

        public ClosedAccount(Action onClosed)
        {
            _onClosed = onClosed;
        }
        public IAccountState Close()
        {
            _onClosed();
            return this;
        }

        public IAccountState Freeze() => this;

        public IAccountState HesabaYatir(Action islem) => this;

        public IAccountState HesaptanCek(Action islem) => this;
    }
}
