using System;

namespace tp_6_eje_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string entrada;
            int num, num1;
            num = 0;
            num1 = 0;

            Console.WriteLine("Escriba un numero entero");
            entrada = Console.ReadLine();
            num = Convert.ToInt32(entrada);

            Console.WriteLine("Escriba un numero entero");
            entrada = Console.ReadLine();
            num1 = Convert.ToInt32(entrada);

            if (num == num1)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                if (num < num1)
                {
                    Console.WriteLine("Es mayor es {0}", num1);
                }
                else
                {
                    Console.WriteLine("Es menor es {0} " + num1);
                }
            }

        }
    }
}
