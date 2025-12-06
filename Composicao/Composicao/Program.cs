using Composicao.Entities;
using Composicao.Entities.Enums;
using System.Globalization;

namespace ComposicaoTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string departName, workerName, workerLevelQuest;
            WorkerLevel workerLevel;
            double baseSalary;
            int quantityContracts;

            // Nome do departamento
            Console.Write("Enter department's name: ");
            departName = Console.ReadLine();

            // Dados do Funcionário
            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine()); 

            Console.Write("Base Salary: ");
            baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department depart = new Department(departName);
            Worker workerDatas = new Worker(workerName, workerLevel, baseSalary, depart);


            // Contratatos

            Console.Write("How manu contracts to this worker? ");
            quantityContracts = int.Parse(Console.ReadLine());


            for (int i = 1; i <= quantityContracts; i++) {
                DateTime dateContract;
                int contractDuration;
                double valuePerHour;


                Console.WriteLine($"Enter #{i} contract data: ");

                Console.Write("Date: ");
                dateContract = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration: ");
                contractDuration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(dateContract, valuePerHour, contractDuration);
                workerDatas.addContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {workerDatas.WorkerName}");
            Console.WriteLine($"Department: {workerDatas.department.DepartmentName}");
            Console.WriteLine($"Income for {monthAndYear}: R${workerDatas.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)} ");

        }

    }
}