using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCode
{
    public interface IAccountState
    {
        IAccountState HesabaYatir(Action islem);
        IAccountState HesaptanCek(Action islem);
        IAccountState Freeze();
        IAccountState Close();
        string Durum { get;}
    }
}
