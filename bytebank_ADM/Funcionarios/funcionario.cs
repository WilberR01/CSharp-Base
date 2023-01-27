using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public abstract void AumentarSalario();

        public Funcionario(string Nome, string Cpf, double Salario)
        {
            this.Nome = Nome;
            this.Salario = Salario;
            this.Cpf = Cpf;
            TotalDeFuncionarios++;
        }
        
    }
}
