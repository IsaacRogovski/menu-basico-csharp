using System;

namespace aula_06_04
{
    class exercicio7
    {
        public static void maiorDeTres()
        {
            Console.Clear();
            while (true)
            {

                int[] numeros = new int[3];
                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine($"Insira o {i + 1}º numero.");
                    while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                    {
                        Console.WriteLine("Insira um valor válido!");
                    }
                }

                if (numeros[0] > numeros[1])
                {
                    if (numeros[0] > numeros[2])
                    {
                        Console.WriteLine($"{numeros[0]} é o maior numero.");
                    }
                    else
                    {
                        Console.WriteLine($"{numeros[2]} é o maior numero.");
                    }
                }
                else if (numeros[1] > numeros[2])
                {
                    Console.WriteLine($"{numeros[1]} é o maior numemero.");
                }
                else
                {
                    Console.WriteLine($"{numeros[2]} é o maior numero.");
                }


                break;

            }
        }
    }
}