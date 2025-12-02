namespace Classes {
    class Program {
        static void Main(string[] args) {
            double p, areaX, areaY;
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os três valores de X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Digite os três valores de Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());


            double calculateAreaX = x.Area();
            double calculateAreaY = y.Area();

            Console.WriteLine($"Area X: {calculateAreaX:F4}");

            Console.WriteLine($"Area Y: {calculateAreaY:F4}");

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=");

            if (calculateAreaX > calculateAreaY) {
                Console.WriteLine("Maior area: X");
            } else {
                Console.WriteLine("Maior area: Y");
            }

        }
    }
}
