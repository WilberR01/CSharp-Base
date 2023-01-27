using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceções
{
    public class SaldoInsuficienteException:FinanceOperationException
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }
    }
}
