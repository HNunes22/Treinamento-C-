namespace ProvaTest3;




public class Program
{
    public static void Main()
    {
        // Variáveis

        double a, b, c, solucao1, solucao2, delta, sqrtDelta;

        // Resgatar valores de a, b e c

        Console.WriteLine("Valor de A: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor de B: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor de C: ");
        c = Convert.ToDouble(Console.ReadLine());

        // 1° Calculo de Delta Delta = -b**2 - 4 x a . c 

       

        delta = Math.Pow(b, 2) -4 * a * c;

        if(a == 0 || delta < 0)
        {
            Console.WriteLine("NÃO PODE SER CALCULADO");
        } else
        {
            sqrtDelta = Math.Sqrt(delta);
            solucao1 = (-b + sqrtDelta) / (2 * a);
            solucao2 = (-b - sqrtDelta) / (2 * a);

            Console.WriteLine($"X1: {solucao1}\nX2: {solucao2}");
        }

            
    }
}