namespace Exericico5 {
    class Program {
        static void Main(string[] args) {

            // Exericio 1

            /*
             
            Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o 
            X, se for o caso. 
             
             

            int indice, x;


            Console.Write("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            if(x <= 0) {
                Console.WriteLine("Esse número não temos como achar ímpares!");
            } else {
                for(indice = 0; indice <= x; indice++) {
                    if(indice % 2 == 0) {
                        continue;
                    }
                    Console.WriteLine(indice);
                }
            }

            Console.WriteLine("Programa Encerrado!");

            */



            // Exericio 2

            /*
             
             
            Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).  


             

            int count_out = 0, count_in = 0, countNumbers, number;

            Console.Write("Quantos números pretende digitar?:  ");
            countNumbers = int.Parse(Console.ReadLine());

            while(countNumbers != 0) {
                Console.Write("Digite um número: ");
                number = int.Parse(Console.ReadLine());

                if (number >= 10 && number <= 20) {
                    count_in++;
                } else {
                    count_out++;
                }

                countNumbers--;
            }

            Console.WriteLine($"São {count_in} in / São {count_out} out");

            Console.WriteLine("Finalizando Programa!");

            */

            // Exericio 3

            /*
             
            Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. 
            Lembrando que, por definição, fatorial de 0 é 1. 
             
             */

            int indice, fatorial, sum = 1;

            Console.Write("Digite o fatorial do número desejado: ");
            fatorial = int.Parse(Console.ReadLine());

            if (fatorial == 0 || fatorial == 1) {
                Console.WriteLine(1);
            }
            else {
                for (indice = fatorial; indice > 1; indice--) {
                    sum *= indice;
                }
                Console.WriteLine(sum);
            }

        }
    }
}