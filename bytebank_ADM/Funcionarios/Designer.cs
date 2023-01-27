using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer:Funcionario, IBonificacao
    {
        public double GetBonificacao()
        {
            return this.Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public Designer(string Nome, string Cpf):base(Nome, Cpf, 3000)
        {

        }
    }    

}
