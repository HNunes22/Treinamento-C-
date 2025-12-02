namespace ProvaTest4;

public class Proggram
{
    public static void Main()
    {
        int password = 0, corrrect_password = 2002;

        while(password != corrrect_password)
        {
            Console.WriteLine("Digite a senha correta: ");
            password = Convert.ToInt32(Console.ReadLine());
            
        }

        Console.WriteLine("Senha correta!");
    }
}