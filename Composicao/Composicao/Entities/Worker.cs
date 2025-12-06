using Composicao.Entities.Enums;

namespace Composicao.Entities
{
    internal class Worker
    {
        public string WorkerName { get; set; }
        public WorkerLevel Level { get; set; } // Enum
        public double BaseSalary { get; set; }
        public Department department { get; set; } // Composição de Objetos Worker --------> Department

        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Para não ser uma lista nula  // Composição de Objetos Worker --------> HourContract

        public Worker() { }

        public Worker(string workerName, WorkerLevel level, double baseSalary, Department department)
        {
            WorkerName = workerName;
            Level = level;
            BaseSalary = baseSalary;
            this.department = department;
        }

        public void addContract(HourContract contract)
        {

            Contracts.Add(contract);

        }

        public void removeContract(HourContract contract)
        {

            Contracts.Remove(contract);

        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.DateContract.Year == year && contract.DateContract.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;

        }

    }
}
