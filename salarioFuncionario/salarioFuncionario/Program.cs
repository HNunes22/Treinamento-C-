namespace salarioFuncionario {
    class Program {
        static void Main(string[] args) {

            Funcionario funcionario = new Funcionario();

            Console.WriteLine("--- Digite os dados do funcionário ---");
            Console.WriteLine();


            Console.Write("Nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario bruto do funcionário: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("--- Digite o Imposto ---");

            Console.WriteLine();

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Funcionário: {funcionario}");

            Console.WriteLine();

            Console.Write("Digite a porcentagem de aumento salarial: ");
            double qtd_aumento = double.Parse(Console.ReadLine());
            funcionario.aumentarSalario(qtd_aumento);

            Console.WriteLine($"Funcionário: {funcionario}");
        }
    }
}
