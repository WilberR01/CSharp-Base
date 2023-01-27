using bytebank_ADM.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public string Usuario { get; set; }

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
