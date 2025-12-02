
namespace calculodeRetangulo {
    class Retangulo {
        public double Largura;
        public double Altura;

        private double Area() {
            double Area = Largura * Altura;
            return Area;
        }

        private double Perimetro() {
            double Perimetro = 2 * (Largura + Altura);
            return Perimetro;
        }

        private double Diagonal() {
            double Diagonal = Math.Sqrt((Math.Pow(Largura, 2) + Math.Pow(Altura, 2)));
            return Diagonal;
        }

        public string ResolutionCalcule() {
            double calculeArea = Area();
            double calculePerimetro = Perimetro();
            double calculeDiagonal = Diagonal();

            return $"Area = {calculeArea.ToString("F2")}" +
                $"\nPerimetro = {calculePerimetro.ToString("F2")}" +
                $"\nDiagonal = {calculeDiagonal.ToString("F2")}";
        }
    }
}
