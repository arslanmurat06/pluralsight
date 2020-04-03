using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCode
{
    class FreezedAccount : IAccountState
    {
        private readonly Action _onFreezedAction;

        public string Durum => "Hesap Askıda";

        public FreezedAccount(Action onFreezedAction)
        {
            _onFreezedAction = onFreezedAction;
        }
        public IAccountState Close() => this;
        public IAccountState HesabaYatir(Action islem) => this;

        public IAccountState HesaptanCek(Action islem) => this;

        public IAccountState Freeze()
        {
            _onFreezedAction();
            return this;
        }
    }
}
