using ByteBank.Exceções;
using ByteBank.Titular;
using System.Drawing;

namespace ByteBank
{
    public class ContaCorrente
    {
        //Static:
        //Propriedade "TotalDeContas" é static pq é uma propriedade da classe inteira e não dos objetos criados com ela.
        //Não pode usar o membro de instancia "this" para propriedades static pq não é uma prop dos objetos.
        public static int TotalDeContas { get; private set; }
        public static float TaxaDeOperacao { get; private set; }
        //Dados da Conta por propriedades
        public Cliente Titular { get; set; }
        private int numero_Agencia;
        public int Conta { get; private set; }

        public int Numero_agencia
        {
            get
            {
                return numero_Agencia;
            }
            private set
            {
                if (value > 0)
                {
                    this.numero_Agencia = value;
                }
            }
        }


        private double? Saldo;

        //Operações da Conta
        public bool Sacar(double valor)
        {
            if (valor > Saldo)
            {
                //Exceção para facilitar a identificação do erro pelo usuário.
                throw new SaldoInsuficienteException("O Saldo para essa operação não é suficiente");
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine(valor + " Reais foram sacados com sucesso");
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
                Saldo += valor;
                return true;
            }
        }
        public bool Transferir(double valor, ContaCorrente destinatario)
        {
            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException("O Saldo para essa operação não é suficiente");
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                destinatario.Saldo += valor;
                Console.WriteLine(valor + " Reais foram transferidos com sucesso");
                return true;
            }
        }
        /*
         * 
         * Função ficou obsoleta e pouco segura pois permitia alteração do saldo a qualquer momento.
         * Utilizado a definição do Saldo direto no construtor ao invés disso.
         * 
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.Saldo = valor;
            }
        }
        */
        public double? GetSaldo()
        {
            return this.Saldo;
        }

        //Método construtor

        public ContaCorrente(string _Nome, string _Cpf, string _Profissao, int _numero_Conta, int _numero_Agencia, double _saldo)
        {
            this.Titular = new Cliente();
            Titular.Nome = _Nome;
            Titular.Cpf = _Cpf;
            Titular.Profissao = _Profissao;
            if(_numero_Conta  <= 0 || _numero_Agencia <= 0)
            {
                throw new ArgumentException("O número da conta e da agência não podem ser menores ou iguais a 0.");
            }
            else
            {
                this.numero_Agencia = _numero_Agencia;
                this.Conta = _numero_Conta;
            }
            this.Saldo = _saldo;
            TotalDeContas++;
            TaxaDeOperacao = 30 / TotalDeContas;
        }
        public void Perfil()
        {
            Console.WriteLine("\nSua Conta:\n");
            Console.WriteLine($"Conta e Agência: {Conta}-{numero_Agencia}");
            Console.WriteLine("Saldo: "+ Saldo);
            
        }
    }
}