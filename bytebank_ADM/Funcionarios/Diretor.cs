using bytebank_ADM.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel, IBonificacao
    {
        public Diretor(string Nome, string Cpf) : base(Nome, Cpf, 5000)
        {
        }

        public double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }    

}
