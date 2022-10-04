namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int nAgencia;
        public string agencia;
        public double saldo;

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
    }


}