using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.Sistema_Interno;
using bytebank_ADM.Utilitario;

#region
//Diretor roberta = new Diretor("745.032.888-10");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
//Console.WriteLine("CPF da roberta: " + roberta.Cpf);

//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do roberta: " + roberta.Salario);
#endregion

UsarSistema();
CalcularBonificacao();

void CalcularBonificacao()
    //Era necessário designar bonificações diferentes para cada cargo, com o mínimo de repetição de código 
    //e de forma a deixar o código limpo e com fácil manutenção.
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("Ulisses Ferreira", "123456");

    Diretor paula = new Diretor("Paula Castro", "789555");

    Auxiliar igor = new Auxiliar("Igor Correia", "789456");
    
    GerenteDeContas camila = new GerenteDeContas("Camila Dias", "896547");

    
    gerenciador.Registrar(camila);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonficacao);
}

void UsarSistema()
    //Já nesse caso, a intenção era que tivessemos um sistema interno que apenas os funcionários de alto escalão
    //ou os parceiros comerciais pudessem acessar.
{
    var sistema = new SistemaInterno();

    Diretor rafael = new Diretor("Rafael Macedo", "775596");
    rafael.Senha = "123";
    rafael.Usuario = "rafa22";

    GerenteDeContas rodrigo = new GerenteDeContas("Rodrigo Macedo", "775596");
    rodrigo.Senha = "569";
    rodrigo.Usuario = "rodrigaodelas";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Usuario = "caiobank";
    caio.Senha = "444";
    
    sistema.logar(rafael,"rafa22", "123");
    sistema.logar(rodrigo,"rodrigaodelas", "456");
    sistema.logar(caio, "caiobank", "444");

}