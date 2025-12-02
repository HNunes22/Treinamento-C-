namespace notaAlunos {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();

            Console.WriteLine("--- Digite o nome e as três notas do aluno ---");
            Console.WriteLine();

            Console.Write("Nome do Aluno: ");
            aluno.NomeAluno = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Nota A: ");
            aluno.NotaA = double.Parse(Console.ReadLine());

            Console.Write("Nota B: ");
            aluno.NotaB = double.Parse(Console.ReadLine());

            Console.Write("Nota C: ");
            aluno.NotaC = double.Parse(Console.ReadLine());

            Console.WriteLine(aluno.ResolucaoAluno());
        }
    }
}