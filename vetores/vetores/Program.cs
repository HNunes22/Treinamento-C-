namespace vetores {
    class Program {
        static void Main(string[] args) {

            /*
            int x;
            double sum = 0.00, calculateAvarage;


            Console.Write("Digite um número: ");
            x = int.Parse(Console.ReadLine());
            double[] vetor = new double[x]; // Crie um vetor do tamnaho de x
            Console.WriteLine();

            for(int i = 0; i < x; i++) {
                Console.Write("Tamanho: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }

            for(int i = 0;i < vetor.Length; i++) {
                sum += vetor[i];
            }


            calculateAvarage = sum / x;

            Console.WriteLine(calculateAvarage.ToString("F2"));

*/
            // ----------------------------------------------------- //

            int quantityProducts;
            double sum = 0.00, avaragePrice;
            

            Console.Write("Digite a quantidade de produtos desejada: ");
            quantityProducts = int.Parse(Console.ReadLine());

            Product[] products = new Product[quantityProducts];


            for (int i = 0; i < quantityProducts; i++) {
                string name;
                double price;

                Console.WriteLine("--- Digite os seguintes dados do(s) produto(s) ----");

                Console.WriteLine();

                Console.Write("Nome do produto: ");
                name = Console.ReadLine();


                Console.Write("Preço do produto: R$");
                price = double.Parse(Console.ReadLine());
                Console.WriteLine();


                products[i] = new Product(name, price);
            }

            for (int i = 0; i < quantityProducts; i++) {

                sum += products[i].Price;
            }

            avaragePrice = sum / quantityProducts;

            Console.WriteLine($"O preço medio de produtos é: R${avaragePrice.ToString("F2")}");

        }
    }
}