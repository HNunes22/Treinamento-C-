namespace ProvaTest;

// Fórmula: area = rValue.raio**2 
// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
// casas decimais conforme exemplos.
// Entrada: Saída:  
//     2.00 A= 12.5664

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Prova 2 ===\n");


        // Variáveis

        double rValue = 3.14159, area, raio;

        Console.WriteLine("Digite o raio: ");
        raio = Convert.ToDouble(Console.ReadLine());

        area = rValue * Math.Pow(raio, 2);

        Console.WriteLine($"{area.ToString("F4")}");
    }
}