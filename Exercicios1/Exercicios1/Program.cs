using System.Globalization;

namespace Exercicios1 {
    class Program {
        static void Main(string[] args) {

            double piValue = 3.14159;

            // Exericício 1

            /*
             
            Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            mensagem explicativa. 

             */
            
            Console.WriteLine("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");
            
            // -------------------------------------------------------- //

            // Exercício 2

            /*
             
             
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            casas decimais conforme exemplos.

            Formula da area = r * raio**2

            valor de r = 3.14159 
             
             */

            


            Console.WriteLine("Digite um raio de um circulo: ");
            double ray = double.Parse(Console.ReadLine());

            double calculateArea = piValue * Math.Pow(ray, 2);
            Console.WriteLine($"Area Value: {calculateArea:F4}");
            

            // ------------------------------------------------------------- //

            // Exercício 3

            /*
             
            Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). 


             */

            

            int valueA, valueB, valueC, valueD, calculationResult;

            Console.WriteLine("Value A: ");
            valueA = int.Parse(Console.ReadLine());

            Console.WriteLine("Value B: ");
            valueB = int.Parse(Console.ReadLine());

            Console.WriteLine("Value C: ");
            valueC = int.Parse(Console.ReadLine());

            Console.WriteLine("Value D: ");
            valueD = int.Parse(Console.ReadLine());

            calculationResult = valueA * valueB - valueC * valueD;

            Console.WriteLine($"Product Difference: {calculationResult}");

            

            // -------------------------------------------------------------- //

            // Exercício 4

            /*
             
              
            Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
            decimais.
             
             */

            

            int employeeID, workHours;
            double  salary, hourlyWage;

            Console.WriteLine("EmployeeID: ");
            employeeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the Employee's Work Hours: ");
            workHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Now Hourly Wage: ");
            hourlyWage = double.Parse(Console.ReadLine());

            salary = hourlyWage * workHours;

            Console.WriteLine($"Number: {employeeID}\nSalary: U${salary:F2}");

            

            // ---------------------------------------------------------------- //

            // Exercício 5

            /*
             
            Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
             
             */

            
            int productID, productID2, quantityProduct, quantityProduct2;
            double priceProduct, priceProduct2, calculateProducts;


            // First Product

            Console.WriteLine("Write ID, Quantity and Price of the first Products: ");
            string[] shoppingCart = Console.ReadLine().Split(' ');

            quantityProduct = int.Parse(shoppingCart[1]);
            priceProduct = double.Parse(shoppingCart[2]);
             

            // Second Product

            Console.WriteLine("Write ID, Quantity and Price of the second Products: ");
            string[] shoppingCart2 = Console.ReadLine().Split(' ');

            quantityProduct2 = int.Parse(shoppingCart2[1]);
            priceProduct2 = double.Parse(shoppingCart2[2]);

            // Calculate and Show result

            calculateProducts = (priceProduct *  quantityProduct) + (priceProduct2 * quantityProduct2);

            Console.WriteLine($"Total Price: R${calculateProducts:F2}");



            // ------------------------------------------------------------- //

            // Exercício 6

            /*
             
            Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
            mostre:  
            a) a área do triângulo retângulo que tem A por base e C por altura.  Formula: Área = (base × altura) / 2
            b) a área do círculo de raio C. (pi = 3.14159)  Formula: area = pi * raio**2
            c) a área do trapézio que tem A e B por bases e C por altura.  Formula: 
            d) a área do quadrado que tem lado B.  
            e) a área do retângulo que tem lados A e B. 
             
             */



            double value_a, value_b, value_c, formulaA, formulaB, formulaC, formulaD, formulaE;

            Console.WriteLine("Value A: ");
            value_a = double.Parse(Console.ReadLine());

            Console.WriteLine("Value B: ");
            value_b = double.Parse(Console.ReadLine());

            Console.WriteLine("Value C: ");
            value_c = double.Parse(Console.ReadLine());

            // Formula A

            double areaFormulaA = (value_a * value_c) / 2;
            Console.WriteLine("Triangulo: " + areaFormulaA.ToString("F3"));

            // Formula B

            double areaFormulaB = piValue * Math.Pow(value_c, 2);
            Console.WriteLine("Circulo: " + areaFormulaB.ToString("F3"));

            // Formula C

            double areaFormulaC = ((value_a + value_b) * value_c) / 2;
            Console.WriteLine("Trapezio: " + areaFormulaC.ToString("F3"));

            // Formula D

            double areaFormulaD = Math.Pow(value_b, 2);
            Console.WriteLine("Quadrado: " + areaFormulaD.ToString("F3"));

            // Formula E

            double areaFormulaE = value_a * value_b;
            Console.WriteLine("Retangulo: " + areaFormulaE.ToString("F3"));


            // Caso for usar um, envolva os outros em comentario de multi-linhas!

        }
    }
}