namespace dadosFuncionarios {
    internal class Employee {
        public int IdEmployee {  get; set; }
        public string NameEmployee { get; set; }
        public double SalaryEmployee { get; private set; }

        public Employee(int idEmployeer, string nameEmployeer, double salaryEmployeer) {
            IdEmployee = idEmployeer;
            NameEmployee = nameEmployeer;
            SalaryEmployee = salaryEmployeer;
        }

        public void UpSalary(int percentage) {
            SalaryEmployee = SalaryEmployee + (SalaryEmployee * ((double) percentage / 100));
        }
        public override string ToString() {
            return $"{IdEmployee}, {NameEmployee}, R${SalaryEmployee}";
        }
    }
}
