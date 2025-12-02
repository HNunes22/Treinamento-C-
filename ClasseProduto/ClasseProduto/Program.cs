using ClasseProduto;

namespace ClassProduto {
    class Program {
        static void Main(string[] args) {
            int qtd, quantity;
            string name;
            double price;

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            name = Console.ReadLine();

            Console.Write("Preço: ");
            price = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            quantity = int.Parse(Console.ReadLine());

            Produto produto = new Produto(name, price, quantity);

            Console.WriteLine(produto.Nome); // Irá exibir o nome do produto digitado

            produto.Nome = "Abobora"; // Aqui irá trocar o nome definido antes.

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {produto}");
            Console.WriteLine();

            Console.Write("Adicione mais produtos ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.AdicionarEstoque(qtd);
            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine();
            Console.Write("Remova uma quantidade de produto no estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverEstoque(qtd);
            Console.WriteLine($"Dados do produto: {produto}");
        }
    }
}