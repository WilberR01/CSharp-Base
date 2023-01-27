using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Exceções
{
    public class FinanceOperationException:Exception
    {
        public FinanceOperationException(string mesage) : base(mesage)
        {
        }
        public FinanceOperationException(string mesage, Exception excecaoInterna) : base(mesage, excecaoInterna)
        {
        }
    }
}
