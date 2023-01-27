using bytebank_ADM.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas:FuncionarioAutenticavel, IBonificacao
    {
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public double GetBonificacao()
        {
            return this.Salario *= 0.15;
        }

        public GerenteDeContas(string Nome, string Cpf) : base(Nome, Cpf, 4000)
        {

        }
    }    

}
