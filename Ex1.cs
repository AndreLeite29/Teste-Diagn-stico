using System;

namespace Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string opc;
            string valor1;
            string valor2;

            Console.WriteLine("Digite um número");
            valor1 = Console.ReadLine();
            num1 = Convert.ToInt32(valor1);

            Console.WriteLine("Digite um número");
            valor2 = Console.ReadLine();
            num2 = Convert.ToInt32(valor2);

            Console.WriteLine("\n1- Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("3- Dividir");
            Console.WriteLine("4- Multiplicar");
            opc = Console.ReadLine();

            if (opc == "1")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (opc == "2")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (opc == "3")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (opc == "4")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Essa operação não existe!");
            }

        }
    }
}
