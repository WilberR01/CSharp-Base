using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar:Funcionario, IBonificacao
    {
        public double GetBonificacao()
        {
            return this.Salario * 0.2;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }

        public Auxiliar(string Nome, string Cpf) : base(Nome, Cpf, 2000)
        {

        }
    }    

}
