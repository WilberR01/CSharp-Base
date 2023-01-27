using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        
        public void PerfilCliente()
        {
            Console.WriteLine("Nome do Titular: " + Nome);
            Console.WriteLine("CPF do Titular: " + Cpf);
            Console.WriteLine("Profissão do Titular: " + Profissao);
        }
    
    }
}
