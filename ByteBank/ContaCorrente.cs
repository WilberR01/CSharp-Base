namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int nAgencia;
        public string agencia;
        public double? saldo;

        public bool Sacar(double valor)
        {
            if (valor > saldo)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public bool Depositar(double valor)
        {
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo += valor;
                return true;
            }
        }
        public bool Transferir(double valor, ContaCorrente destinatario)
        {
            if (valor > saldo)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destinatario.saldo += valor;
                return true;
            }
        }
        public void Perfil()
        {
            Console.WriteLine("\nSeus Dados:\n");
            Console.WriteLine("Nome do Titular: "+ titular);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Número da Agência: "+ nAgencia);
            Console.WriteLine("Agência: " + agencia);
            Console.WriteLine("Saldo: "+ saldo);
            
        }

    }


}