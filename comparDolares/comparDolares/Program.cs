using comparDolares;

namespace comprarDolares {
    class Program {
        static void Main(string[] args) {

            double resultadoDaCompra, cotacao, quantiaDeDolares;

            Console.WriteLine("--- Digite os seguintes dados ---");

            Console.WriteLine();

            Console.Write("Cotação: ");
            cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantia de Dolares: ");
            quantiaDeDolares = double.Parse(Console.ReadLine());

            resultadoDaCompra = ConversorDeMoeda.CalcularCompra(cotacao, quantiaDeDolares);

            Console.WriteLine();

            Console.WriteLine($"Total a pagar em reais(com imposto IOF de 6% incluso): R${resultadoDaCompra.ToString("F2")}");




        }
    }
}