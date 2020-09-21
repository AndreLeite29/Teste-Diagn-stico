using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int a = 0;
            
            while (a == 0)
            {
                int num1 = aleatorio.Next(1, 50);
                int num2 = aleatorio.Next(1, 50);
                int num3 = aleatorio.Next(1, 50);
                int num4 = aleatorio.Next(1, 50);
                int num5 = aleatorio.Next(1, 50);
                int num6 = aleatorio.Next(1, 12);
                int num7 = aleatorio.Next(1, 12);

                if (num1 != num2 || num1 != num3 || num1 != num4 || num1 != num5 || num2 != num3 || num2 != num4 || num2 != num5 || num3 != num4 || num3 != num5 || num4 != num5 && num6 != num7)
                {
                    char[] arraynum = { num1, num2, num3, num4, num5 };
                    char[] arrayestrelas = { num6, num7 };
                    a = 1;
                }
                else
                {
                    num1 = aleatorio.Next(1, 50);
                    num2 = aleatorio.Next(1, 50);
                    num3 = aleatorio.Next(1, 50);
                    num4 = aleatorio.Next(1, 50);
                    num5 = aleatorio.Next(1, 50);
                    num6 = aleatorio.Next(1, 12);
                    num7 = aleatorio.Next(1, 12);
                }
            }
        }
    }
}
