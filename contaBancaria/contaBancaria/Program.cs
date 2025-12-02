namespace contaBancaria {
    class Program {
        static void Main(string[] args) {
            int numeroDaConta;
            string titularDaConta, option;
            double creditoInicial, novoCredito, novoSaque;
            ContaBancaria contaBancaria;


            Console.WriteLine("--- Caixa Eltrônico ---");
            Console.WriteLine();

            Console.WriteLine("Digite os dados da conta a seguir...");
            Console.Write("Digite o número da conta: ");
            numeroDaConta = int.Parse(Console.ReadLine());


            Console.Write("Digite o nome do titular da conta: ");
            titularDaConta = Console.ReadLine();

            Console.Write("Você gostaria de fazer um depósito inicial? (S/N): ");
            option = Console.ReadLine();


            if(option == "S" || option == "s") {
                Console.Write("Digite o valor do deposito inicial: R$");
                creditoInicial = double.Parse(Console.ReadLine());
                contaBancaria = new ContaBancaria(numeroDaConta, titularDaConta, creditoInicial);

            }
            else {
                creditoInicial = 0.00;
                contaBancaria = new ContaBancaria(numeroDaConta, titularDaConta);
            }

            Console.WriteLine();
            Console.WriteLine("Criando a conta....");

            Console.WriteLine("Dados da conta: " + contaBancaria);

           
            Console.Write("Vamos fazer um novo deposito: R$");
            novoCredito = double.Parse(Console.ReadLine());
            Console.WriteLine(contaBancaria.DepositarDinheiro(novoCredito));

            Console.WriteLine();
            Console.WriteLine("Novos dados da conta: " + contaBancaria);

            Console.Write("Saque: R$");
            novoSaque = double.Parse(Console.ReadLine());

            Console.WriteLine(contaBancaria.SacarDinheiro(novoSaque));

            Console.WriteLine("Novos dados da conta: " + contaBancaria);
            

        }
    }
}
