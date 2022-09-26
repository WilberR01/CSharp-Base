using bytebank;

Console.WriteLine("Bem Vindo ao ByteBank");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Wilber Ribeiro";
conta1.conta = "106-wr";
conta1.nAgencia = 52;
conta1.agencia = "Unica";
conta1.saldo = 225.88;

Console.WriteLine(conta1.titular);
Console.WriteLine(conta1.nAgencia);
Console.ReadKey();