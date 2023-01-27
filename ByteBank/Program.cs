using ByteBank;
using ByteBank.Exceções;
using ByteBank.Titular;
using System.Linq.Expressions;

Console.WriteLine("Bem Vindo ao ByteBank");

ContaCorrente marcos = new ContaCorrente("Marcos Narciso", "123.456.789-10", "Operário", 1000, 2, 1588);
ContaCorrente felipe = new ContaCorrente("Felipe Castro", "111.222.333-44", "Arquiteto", 1001, 2, 977);

//Função pra testar a exceção de Saldo Insuficiente.

try
{
    //marcos.Sacar(1600);
    marcos.Sacar(1100);
    felipe.Transferir(1000, marcos);
}
catch(FinanceOperationException exc1)
{
    Console.WriteLine(exc1.Message);
}
//Outras operações ja haviam sido testadas antes, mas perdi o resto.