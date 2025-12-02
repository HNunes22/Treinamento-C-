namespace Exercicios2 {
    class Program {
        static void Main(string[] args) {

            // Exercício 1

            /*
             
            Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
             
             */

            /*
            Console.WriteLine("Digite um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if(x < 0) {
                Console.WriteLine("Negative!");
            } else {
                Console.WriteLine("Positive!");
            }
            */

            // Exercício 2

            /*
             
            Fazer um programa para ler um número inteiro e dizer se este 
            número é par ou ímpar.
             
             
             */

            /*

            Console.WriteLine("Digite um numero inteiro: ");
            int number = int.Parse(Console.ReadLine());

            bool calculate = number % 2 == 0;

            if (calculate) {
                Console.WriteLine($"{number} é par!");
            }
            else {
                Console.WriteLine($"{number} é ímpar!");
            }
            */

            // Exercício 3

            /*
             
             Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
            ordem crescente ou decrescente.
             
             */

            /*

            int a, b;

            Console.WriteLine("A value: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("B value: ");
            b = int.Parse(Console.ReadLine());

            bool condition_number;

            if (a < b) {
                condition_number = b % a == 0;
                if (condition_number) {
                    Console.WriteLine($"{a} e {b} são multiplos");
                }
                else {
                    Console.WriteLine($"{a} e {b} não são multiplos");
                }
            }
            else {
                condition_number = a % b == 0;
                if (condition_number) {
                    Console.WriteLine($"{a} e {b} são multiplos");
                }
                else {
                    Console.WriteLine($"{a} e {b} não são multiplos");
                }
            }
                */

            // Exercício 4

            /*
             
             
            Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
             
             */

            /*
            int inicialTime, finishTime, result;

            Console.WriteLine("Digite a hora inicial do game: ");
            inicialTime = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite a hora final do game: ");
            finishTime = int.Parse(Console.ReadLine());


            if (finishTime > inicialTime) {
                result = finishTime - inicialTime;
            } 
            else if (finishTime < inicialTime) {
                result = (24 - inicialTime) + finishTime;
            } 
            else {
                result = 24;
            }

            Console.WriteLine($"A duração do jogo foi: {result}h(s)");
            */

            // Exercício 5



            /*
             
              
            Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem 
            que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem 
            qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. 
 
            Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
            mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

            Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de 
            salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é 
            de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com 
            duas casas decimais. 
             
             */

            bool faixa1, faixa2, faixa3, faixa4;
            double salary, calculateSalary, calculateImposto = 0.00;

            Console.WriteLine("Digite o salario: ");
            salary = double.Parse(Console.ReadLine());

            // Padrão calculo da faixa 3 e faixa 4

            double padrao_faixa2 = 1000 * 0.08; // Quando o salario passa da faixa 2
            double padrao_faixa3 = 1500 * 0.18; // Quando o salário passa da faixa 3

            // Verificação de faixa do salario digitado

            faixa1 = salary >= 0 && salary < 2000.01;
            faixa2 = salary > 2000 && salary < 3000.01;
            faixa3 = salary > 3000 && salary < 4500.01;
            faixa4 = salary > 4500;


            if (faixa1) {
                Console.WriteLine("Isento");
            }

            else if (faixa2) {
               calculateSalary = salary - 2000;
               calculateImposto = calculateSalary * 0.08;
            }

            else if (faixa3) {
                calculateSalary = salary - 3000;
                calculateImposto = calculateSalary * 0.18 + (padrao_faixa2); // Pagar pelo que sobrou + o padrão
            }

            else if (faixa4) {
                calculateSalary = salary - 4500;
                calculateImposto = calculateSalary * 0.28 + (padrao_faixa2 + padrao_faixa3);
            }
            else {
                Console.WriteLine("Error!");
            }

            Console.WriteLine($"Total a pagar: R${calculateImposto:F2}");
        }
    }
}