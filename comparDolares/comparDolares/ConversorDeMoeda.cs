namespace comparDolares {
    class ConversorDeMoeda {

        static double Iof = 0.06;

        public static double CalcularCompra(double cotacao, double quantidadeDolares) {
            double calcularQuantiaDeDolares = quantidadeDolares * cotacao;
            double calcularComImposto = calcularQuantiaDeDolares + (calcularQuantiaDeDolares * Iof);
            return calcularComImposto;
        }

    }
}
