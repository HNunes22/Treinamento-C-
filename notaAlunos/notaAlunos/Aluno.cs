namespace notaAlunos {
    class Aluno {
        public string NomeAluno;
        public double NotaA;
        public double NotaB;
        public double NotaC;


        private double CalcularNotaDoAluno() {
            double calculate = NotaA + NotaB + NotaC;
            return calculate;
        }

        public string ResolucaoAluno() {
            double totalNota = CalcularNotaDoAluno(), calculateRestante = 60 - totalNota;
            
            if(totalNota < 60) {
                return $"Nota Total = {totalNota}\nAluno reprovado, faltando {calculateRestante} para ser aprovado!";
            }
            return $"Nota Total = {totalNota}\nAluno aprovado!";
        }



        public override string ToString() {
            return $"Nome: {NomeAluno}";
        }
    }
}
