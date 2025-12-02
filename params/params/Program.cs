namespace paramsTest {
    class Program {
        static void Main(string[] args) {

            // Params

            int s1 = Calculadora.Sum(1, 2, 3, 4, 5); 
            Console.WriteLine("Sum: " + s1);

            // Ref

            int n = 10;
            Calculadora.Triple(ref n);
            Console.WriteLine("Triple: " + n);

            // Out

            n = 35;
            int doubleResult;
            Calculadora.Double(n, out doubleResult);
            Console.WriteLine("Double: " + doubleResult);
        }
    }
}