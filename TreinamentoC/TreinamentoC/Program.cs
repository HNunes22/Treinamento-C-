namespace TreinamentoC {
    class Program {
        static void Main(string[] args) {

            //String(Nome) , Char(Sexo), Int(Idade), Double(Altura:F2)


            string fullName, lastName;
            int age, quantifyRooms;
            double height, priceProduct;

            Console.WriteLine("Entre com seu nome completo: ");
            fullName = Console.ReadLine();
            Console.WriteLine($"Full name: {fullName}");

            Console.WriteLine("Qauntos quartos tem na sua casa? ");
            quantifyRooms = int.Parse(Console.ReadLine());
            Console.WriteLine($"Quantify: {quantifyRooms}");


            Console.WriteLine("Entre com o preço de um produto: ");
            priceProduct = double.Parse(Console.ReadLine());
            Console.WriteLine($"R${priceProduct}");


            Console.WriteLine("Ultimo nome, idade e altura");
            string[] user_data = Console.ReadLine().Split(' ');

            lastName = user_data[0];
            age = int.Parse(user_data[1]);
            height = double.Parse(user_data[2]);

            
            Console.WriteLine($"Last Name: {lastName}\n" +
                $"Age: {age}\n" +
                $"Height: {height}");
            
            
        }
    }
}