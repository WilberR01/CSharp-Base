using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Sistema_Interno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }
        public string Usuario { get; set; }
        public bool Autenticar(string usuario, string senha);
        
    }
}
