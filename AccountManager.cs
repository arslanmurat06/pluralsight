using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCode
{
    class AccountManager : IAccountState
    {
        private readonly Action _onFreezedAction;
        private readonly Action _onClosedAction;

        public AccountManager(Action onfreezedAction, Action onClosedAction)
        {
            _onFreezedAction = onfreezedAction;
            _onClosedAction = onClosedAction;
        }

        public string Durum => "Hesap Aktif";

        public IAccountState Close() => new ClosedAccount(_onClosedAction).Close();

        public IAccountState Freeze() => new FreezedAccount(_onFreezedAction).Freeze();

        public IAccountState HesabaYatir(Action islem)
        {
           islem();

            return this;
        }

        public IAccountState HesaptanCek(Action islem)
        {
           islem();
            return this;
        }
    }
}
