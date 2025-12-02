namespace salarioFuncionario {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        private double SalarioLiquido() {
            double calculateSalarioLiquido = SalarioBruto - Imposto;
            return calculateSalarioLiquido;
        }

        public void aumentarSalario(double porcentagem) {
            double calculatePorcentagem = porcentagem / 100;
            double new_salario = SalarioBruto + (SalarioBruto * calculatePorcentagem);
            SalarioBruto = new_salario;
        }

        public override string ToString() {
            return $"Nome do funcionário: {Nome} / Salario: R${SalarioLiquido().ToString("F2")}";
        }
    }
}
