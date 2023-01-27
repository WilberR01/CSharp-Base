using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Sistema_Interno
{
    //O Sistema Interno serve para dar mais controle aos diretores, mas pra isso ele precisa de autenticação
    //Ela por sua vez é feita pelo método Autenticar.
    //A interface autenticável entra pra fazer com que os parceiros comerciais possam acessar o sistema sem 
    //serem considerados funcionários pelo programa.
    public class SistemaInterno
    {
        public bool logar (IAutenticavel pessoa, string usuario, string senha)
        {
            var loginAutenticado = pessoa.Autenticar(usuario, senha);
            if(loginAutenticado)
            {
                Console.WriteLine("Bem Vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos.");
                return false;
            }
        }
    }
}
