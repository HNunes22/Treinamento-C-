namespace dadosFuncionarios {
    class Program {
        static void Main(string[] args) {

            int quantityEmployees, idEmployee;
            string nameEmployee;
            double salaryEmployee;

            List<Employee> employees = new List<Employee>(); // Criar uma lista da Classe Employeer

            Console.WriteLine("How many employees will be register? ");
            quantityEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantityEmployees; i++) {
                while(true) {
                    Console.WriteLine($"Employee #{i+1}");
                    Console.Write("Id: ");
                    idEmployee = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    nameEmployee = Console.ReadLine();

                    Console.Write("Salary: R$");
                    salaryEmployee = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Employee findIdRepeat = employees.Find(x => x.IdEmployee == idEmployee);

                    if (findIdRepeat == null) {
                        employees.Add(new Employee(idEmployee, nameEmployee, salaryEmployee));
                        break;
                    }

                    Console.WriteLine("O ID digitado já existe no sistema!");
                    continue;
                }
            }

            Console.Write("Digite o ID: ");
            idEmployee = int.Parse(Console.ReadLine());

            Console.Write("Porcetagem de aumento salarial: ");
            int salaryPercentage = int.Parse(Console.ReadLine());

            Console.WriteLine(ActivateClassMethod(idEmployee, salaryPercentage, employees));

            foreach (Employee employee in employees) {
                Console.WriteLine(employee);
            }
            
        }

        static string ActivateClassMethod(int id, int percentage, List<Employee> employee) {
            Employee findIDEmployee = employee.Find(x => x.IdEmployee == id);
            if (findIDEmployee == null) {
                return "ID não encontrado";
            }

            findIDEmployee.UpSalary(percentage);

            return $"Salario do(a) {findIDEmployee.NameEmployee} foi aumentado em {percentage}%";
        }
    }
}