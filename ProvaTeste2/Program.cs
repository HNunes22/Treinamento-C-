using System.Diagnostics;

namespace ProvaTest2;

public class Program
{
    public static void Main()
    {
        // Variavéis

        bool error_true = false;
        string resolution_message, error_code_message = "Esse código não existe no cardápio";
        int CodeLeitor;
        double value_code_1, value_code_2, value_code_3, value_code_4, value_code_5, calculate_total;

        // Atribuir valor a cada

        value_code_1 = 4;
        value_code_2 = 4.5;
        value_code_3 = 5;
        value_code_4 = 2;
        value_code_5 = 1.5;

        // Obter o Código do Poduto

        Console.WriteLine("Faça seu pedido, coloque o código do produto: ");
        CodeLeitor = Convert.ToInt32(Console.ReadLine());

        // Obter quantidade do produto

        Console.WriteLine("Digite quantidade: ");
        double quantidade = Convert.ToDouble(Console.ReadLine());

        // Switch

        switch(CodeLeitor){
            case 1:
                calculate_total = value_code_1 * quantidade;
                resolution_message = $"Total: R${calculate_total:F2}";
                Console.WriteLine(resolution_message);
                break;
            case 2:
                calculate_total = value_code_2 * quantidade;
                resolution_message = $"Total: R${calculate_total:F2}";
                Console.WriteLine(resolution_message);
                break;
            case 3:
                calculate_total = value_code_3 * quantidade;
                resolution_message = $"Total: R${calculate_total:F2}";
                Console.WriteLine(resolution_message);
                break;
            case 4:
                calculate_total = value_code_4 * quantidade;
                resolution_message = $"Total: R${calculate_total:F2}";
                Console.WriteLine(resolution_message);
                break;
            case 5:
                calculate_total = value_code_5 * quantidade;
                resolution_message = $"Total: R${calculate_total:F2}";
                Console.WriteLine(resolution_message);
                break;
            default:               
                error_true = true;
                break;
        }

        // Resolução


        if (error_true)
        {
            Console.WriteLine(error_code_message);
        }
        



    }   
    
}