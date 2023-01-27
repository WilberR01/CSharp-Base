using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceções
{
    public class FinanceOperationException:Exception
    {
        public FinanceOperationException(string mensagem) : base(mensagem)
        {
        }
        public FinanceOperationException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {
        }
    }
}
