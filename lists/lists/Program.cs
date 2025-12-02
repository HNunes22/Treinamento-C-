

namespace listTest {
    class Program {
        static void Main(string[] args) {

            List<string> names = new List<string>(); // Lista vazia

            List<int> numbers = new List<int> { 1, 2, 3,4 ,5}; // Lista com valores

            // Add: Adicionar a lista

            names.Add("Beta");
            names.Add("Charlie");
            names.Add("Aplha");
            names.Add("Ramma");
            names.Add("Richard");
            names.Add("Guerobinha");
            names.Add("Julião");
            names.Add("Stylex");
            names.Add("Lourin");

            foreach (string name in names) { 
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------------------------");

            // Insert: Adicionar a lista dependendo do Index

            names.Insert(3, "Rimeiro");
            foreach (string name in names) {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------------------------");

            // Count: contar quantos valores existem na lista

            Console.WriteLine("Count List: " + names.Count());

            Console.WriteLine("--------------------------------------");

            // Find: procurar valor que satisfaça uma condição (obs. ele retorna o primeiro valor que satisfazer a condição)

            string findName = names.Find(letra => letra[0] == 'R'); // Procure o nome cujo comece com a letra 'R';
            Console.WriteLine(findName);


            Console.WriteLine("--------------------------------------");

            // FindLast: procurar valor que satisfaça uma condição (obs. ele retorna o ultimo  valor que satisfaça a condição)

            string findLastName = names.FindLast(letra => letra[0] == 'R'); // Procure o nome cujo comece com a letra 'R';
            Console.WriteLine(findLastName);

            Console.WriteLine("--------------------------------------");

            // FindIndex: procurar o index do valor que satisfaça uma condição (obs. ele retorna o primeiro valor que satisfaça a condição)

            int indexFindName = names.FindIndex(letra => letra[0] == 'R');
            Console.WriteLine(indexFindName);

            Console.WriteLine("--------------------------------------");

            // FindLastIndex: procurar o index do valor que satisfaça uma condição (obs. ele retorna o ultimo valor que satisfaça a condição)

            int indexLastFindName = names.FindLastIndex(letra => letra[0] == 'R');
            Console.WriteLine(indexLastFindName);

            Console.WriteLine("--------------------------------------");
            

            // FindAll: Filtrar com base em uma condição, irá retorna uma nova lista com os valores filtrados[

            Console.WriteLine("Nomes Filtrados: ");
            Console.WriteLine();


            List<string> filterNames = names.FindAll(name => name.Length > 5); // Filtrar nomes ~que sejam maiores que 4 
            foreach (string name in filterNames) {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------------------------");


            // Remove: Remove um valor na lista

            names.Remove("Guerobinha");

            foreach (string name in names) {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------------------------");

            // RemoveAll: Remover todos os valores que satisfaçam uma condição

            names.RemoveAll(name => name[0] == 'R');
            foreach (string name in names) {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------------------------");

            // RemoveAt: Remover valor pelo index

            names.RemoveAt(2);
            foreach (string name in names) {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------------------------");

            // RemoveRange: remover de uma faixa e quantidade de valores

            names.RemoveRange(1, 2); // Apartir do index 1, remova 2 valores.
            foreach (string name in names) {
                Console.WriteLine(name);
            }


        }
    }
}