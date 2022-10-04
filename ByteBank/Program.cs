using bytebank;

Console.WriteLine("Bem Vindo ao ByteBank");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Wilber Ribeiro";
conta1.conta = "106-wr";
conta1.nAgencia = 52;
conta1.agencia = "Unica";
conta1.saldo = 225;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Julio Moura";
conta2.conta = "107-JM";
conta2.nAgencia = 52;
conta2.agencia = "Unica";
conta2.saldo = 0;

//Saca da conta do Wilber
Console.WriteLine("Saldo atual: " + conta1.saldo);
conta1.Sacar(203);
Console.WriteLine("Saldo atual: " + conta1.saldo);

//Deposita na conta do Wilber
conta1.Depositar(30);
Console.WriteLine("Saldo atual: " + conta1.saldo);

//Transfere da conta do Wilber para a conta do Julio
bool transferencia = conta1.Transferir(50, conta2);

//Confere se a transferencia foi dada
if (transferencia)
{
    Console.WriteLine("Tranferência concluída com sucesso");
}
else
{
    Console.WriteLine("Transferência não autorizada.");
}
Console.WriteLine("Saldo atual(1): " + conta1.saldo);
Console.WriteLine("Saldo atual(2): " + conta2.saldo);

conta1.Perfil();


Console.ReadKey();
