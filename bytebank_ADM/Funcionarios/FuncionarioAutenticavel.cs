using bytebank_ADM.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    /*
     * Importante: Uma classe pode herdar apenas de uma outra superclasse, mas pode herdar de várias interfaces.
     * É necessário declarar a superclasse a ser herdada primeiro.
     * Esse conceito é usado na hora de definir qual classe o Gerente de Contas e o diretor irão herdar.
     */
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(string Nome, string Cpf, double Salario) : base(Nome, Cpf, Salario)
        {
        }

        public string Senha { get; set; }
        public string Usuario { get; set; }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public bool Autenticar(string usuario, string senha)
        {
            if (this.Usuario == usuario && this.Senha == senha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
