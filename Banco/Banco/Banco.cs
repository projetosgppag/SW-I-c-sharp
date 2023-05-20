using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco // <--- motherclass
{
    internal interface Banco
    {
        void Register();
        bool Login();
        void Deposito();
        void Emprestimo();
    }
}
