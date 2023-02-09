using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {

            double valor1 = 0;
            double valor2 = 0;

            string opcao = "";
            while (opcao != "não")
            {
                
                Console.WriteLine("Digite um número por favor: ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite outro valor: ");
                valor2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Qual a operação você quer fazer?");
                Console.WriteLine("1- Soma");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Divisão");
                Console.WriteLine("4- Miltiplicação");
                Console.WriteLine("5- Sair" + "\n");

                switch (Console.ReadLine())
                {

                    case "1":
                        Console.WriteLine("A Soma dos valores é: " + (valor1 + valor2));

                        break;

                    case "2":
                        Console.WriteLine("A Subtração dos valores é: " + (valor1 - valor2));
                        break;


                    case "3":

                        if (valor1 <= valor2)
                        {
                            Console.WriteLine("Divisão Iválida.");
                        }
                        else
                            Console.WriteLine("A Divisão dos valores é " + (valor1 / valor2));
                        break;


                    case "4":

                        Console.WriteLine("A Multiplicação dos valores é: " + (valor1 * valor2));
                        break;


                    case "5":

                        Console.WriteLine("Estaremos a sua disposição.");

                        break;

                }
                Console.WriteLine("Deseja Continuar? " + "\n");
                opcao = Console.ReadLine();
                Console.WriteLine("Muito Obrigada");

            }   

            



        }
    }
}