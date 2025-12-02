namespace membrosStaticos {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite um valor de um raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circu, volume;

            circu = Calculadora.Circunferencia(raio);
            volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circu.ToString("F2")}" +
                $"\nVolume: {volume.ToString("F2")}" +
                $"\nValor de PI: {Calculadora.Pi.ToString("F2")}");


        }
    }
}