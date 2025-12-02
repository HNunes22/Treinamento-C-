using calculodeRetangulo;

namespace calculoDeRetangulo {
    class Program {
        static void Main(string[] args) {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("--- Digite a Largura e Altura de um Retângulo ---");

            Console.WriteLine();

            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine());


            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(retangulo.ResolutionCalcule());
        }
    }
}