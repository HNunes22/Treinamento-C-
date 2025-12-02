namespace Exercicio4 {
    class Program {
        static void Main(string[] args) {

            // Exercício 1

            /*
             
            Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. 
             
             

            int password = 2002, writePassword;


            do {
                Console.WriteLine("Digite sua senha");
                writePassword = int.Parse(Console.ReadLine());

                if(writePassword == password) {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }

                Console.WriteLine("Acesso Negado!");

            } while (true);
            */

            // ---------------------------------------------- //

            // Exercício 2

            /*
             
              
            Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). 
             
            

            int x, y;

            do {
                Console.Write("Digite o valor de X: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor de Y: ");
                y = int.Parse(Console.ReadLine());

                if(x > 0 && y > 0) {
                    Console.WriteLine("Primeiro Quadrante");
                } else if(x > 0 && y < 0) {
                    Console.WriteLine("Quarto Quadrante");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro Quadrante");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo Quadrante");
                } else {
                    break;
                }

            } while (true);
             */
            // --------------------------------------------- //

            // Exercício 3

            /*
             
             Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
             um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
             4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
             que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
             mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
             exemplo. 
             */

            int alcool = 0, gasolina = 0, diesel = 0, code;


            do {


                Console.WriteLine("Informe um código (o código 4 encerra o programa): ");
                code = int.Parse(Console.ReadLine());


                if(code == 4) {
                    break;
                }




                if(code == 1) {
                    alcool++;
                    
                } else if(code == 2) {
                    gasolina++;
                    
                } else if(code == 3) {
                    diesel++;
                } else {
                    Console.WriteLine("Código inválido!");
                }



            } while (true);


            Console.WriteLine(Result(alcool, gasolina, diesel));
            

        }

        static string Result(int alcool, int gasolina, int diesel) {

            // Verificar se as vendas são iguais ou 0;

            if (alcool == 0 && gasolina == 0 && diesel == 0) {
                return "Nenhum cliente encontrado";
            }

            else {

                // Verificar qual tem mais pedidos, caso não sejam iguais ou 0

                if (alcool > gasolina && alcool > diesel) {
                    return $"Alcool tem mais pedidos, são {alcool} no total.";
                }
                else if (gasolina > diesel) {
                    return $"Gasolina tem mais pedidos, são {gasolina} no total.";
                }
                else {
                    return $"Diesel tem mais pedidos, são {diesel} no total.";
                }

            }

           
        }

    }
}