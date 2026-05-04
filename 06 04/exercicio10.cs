using System;

namespace aula_06_04
{
    class exercicio10
    {
        public static void mediaNota()
        {
            Console.Clear();
            int[] notas = new int[2];
            double media;
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Insira a {i + 1}º nota: ");
                while (!int.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("Insira um valor válido!");
                }
            }

            media = (notas[0] + (2 * notas[1])) / 3;
            if (media >= 6)
            {
                Console.WriteLine($"Media: {media}, aprovado!");
            }
            else if (media >= 4)
            {
                Console.WriteLine($"Media: {media}, IFA!");
            }
            else
            {
                Console.WriteLine($"Media: {media}, Reprovado!");
            }
        }
    }
}