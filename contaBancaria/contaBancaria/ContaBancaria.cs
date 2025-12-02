namespace contaBancaria {
    internal class ContaBancaria {

        static double Taxa = 5.00;

        // Atributos Privados
       

        // Atributos com Auto-Propities
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double SaldoConta {  get; private set; }

        // Construtores

        public ContaBancaria (int numeroConta, string titularConta) {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        public ContaBancaria (int numeroConta, string titularConta, double depositoInicial) : this(numeroConta, titularConta) {
            DepositarDinheiro (depositoInicial);
        }
        


        // Propriedades Personalizadas


        // Metodos da Classe

        
        public string SacarDinheiro(double quantidade) {
            double calculate = (SaldoConta - quantidade) - Taxa;
            if (calculate < 0) {
                return "Com seu saldo atual, não podemos sacar";
            }
            SaldoConta = calculate;
            return "Seu saque foi efetuado com sucesso!";
        }

        public string DepositarDinheiro(double quantidade) {
            if(quantidade < 1) {
                return "Não há como fazer depositos com valores menores que R$1.00";
            }

            SaldoConta += quantidade;
            return "Deposito efetuado com sucesso!";
        }


        public override string ToString() {
            return $"Numero da conta: {NumeroConta} / Titular da Conta: {TitularConta} / Saldo: R${SaldoConta.ToString("F2")}";
        }
    }
}
