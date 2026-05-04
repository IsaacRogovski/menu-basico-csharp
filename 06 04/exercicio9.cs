using System;

namespace aula_06_04
{
    class exercicio9
    {
        public static void verificarTriangulo()
        {
            Console.Clear();
            while (true)
            {
                int[] numeros = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Insira o {i + 1}º lado do triangulo.");
                    while (!int.TryParse(Console.ReadLine(), out numeros[i]) || numeros[i] <= 0)
                    {
                        Console.WriteLine("Insira um valor válido!");
                    }
                }
                if (numeros[0] + numeros[1] > numeros[2] && numeros[0] + numeros[2] > numeros[1] && numeros[1] + numeros[2] > numeros[0])
                {
                    if (numeros[0] == numeros[1] && numeros[0] == numeros[2])
                    {
                        Console.WriteLine("O Triangulo é Equilatero.");
                    }
                    else if (numeros[0] != numeros[1] && numeros[0] != numeros[2] && numeros[1] != numeros[2])
                    {
                        Console.WriteLine("O triangulo é Escaleno.");
                    }
                    else if (numeros[0] == numeros[1] || numeros[0] == numeros[2] || numeros[1] == numeros[2])
                    {
                        Console.WriteLine("O Triangulo é Isósceles.");
                    }
                }
                else
                {
                    Console.WriteLine("Os valores inseridos não formam um triangulo valido.");
                }
                break;

            }
        }
    }
}