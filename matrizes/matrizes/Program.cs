namespace matrizesTest {
    class Program {
        static void Main(string[] args) {
            int[,] numbers = new int[3, 4];


            // Length: Ele diz quantos valores existem na matriz;

            Console.WriteLine(numbers.Length);

            // Rank: Ele diz quantas dimensões tem uma matriz;

            Console.WriteLine(numbers.Rank);

            // GetLength: Ele diz o número de valores em determinada dimensão

            Console.WriteLine(numbers.GetLength(1));
        }
    }
}