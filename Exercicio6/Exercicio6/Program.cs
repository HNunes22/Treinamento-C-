namespace Exercicio6 {
    class Program {
        static void Main(string[] args) {
            // Exercicio 1

            /*
             
            Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais 
            velha. 

            Exemplo: 
            Dados da primeira pessoa: 
            Nome: Maria 
            Idade: 17 
            Dados da segunda pessoa: 
            Nome: Joao 
            Idade: 16 
            Pessoa mais velha: Maria

            


            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();


            Console.WriteLine("Digite o nome da primeira pessoa: ");
            pessoa1.Name = Console.ReadLine();

            Console.WriteLine("Digite a idade da primeira pessoa: ");
            pessoa1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            pessoa2.Name = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda pessoa: ");
            pessoa2.Age = int.Parse(Console.ReadLine());

            if(pessoa1.Age > pessoa2.Age) {
                Console.WriteLine($"{pessoa1.Name} é mais velho(a) com {pessoa1.Age} anos");
            }
            else {
                Console.WriteLine($"{pessoa2.Name} é mais velho(a) com {pessoa2.Age} anos");
            }
            */


            // Exercicio 2
            // 
            /*
             
            Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário 
            médio dos funcionários. 

            Exemplo: 
            Dados do primeiro funcionário: 
            Nome: Carlos Silva 
            Salário: 6300.00 
            Dados do segundo funcionário: 
            Nome: Ana Marques 
            Salário: 6700.00 
            Salário médio = 6500.00
             
            */

            Funcionario employee_1, employee_2;
            double calculate_avarage_salary;

            employee_1 = new Funcionario();
            employee_2 = new Funcionario();

            Console.WriteLine("Digite o nome do funcionario: ");
            employee_1.Employee_Name = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário");
            Console.Write("U$");
            employee_1.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Digite o nome do funcionario: ");
            employee_2.Employee_Name = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário: ");
            Console.Write("U$");
            employee_2.Salary = double.Parse(Console.ReadLine());

            calculate_avarage_salary = (employee_1.Salary + employee_2.Salary) / 2;

            Console.WriteLine($"Avarage of Salary is U${calculate_avarage_salary:F2}");
            
        }
    }
}