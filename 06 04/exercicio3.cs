using System;

namespace aula_06_04
{
    class exercicio3
    {
        public static void multiploDeDoisOuTres()
        {
            Console.Clear();
            while (true)
            {
                int numero;
                Console.Write("Insira um numero: ");

                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Insira um valor Valido!");
                }
                else
                {
                    if (numero % 2 == 0 && numero % 3 == 0)
                    {
                        Console.WriteLine($"O numero {numero} é multiplo de 2 e de 3 simultaneamente");
                    }
                    else if (numero % 2 == 0 && numero % 3 != 0)
                    {
                        Console.WriteLine($"O numero {numero} é multiplo apenas de 2.");
                    }
                    else if (numero % 2 != 0 && numero % 3 == 0)
                    {
                        Console.WriteLine($"O numero {numero} é multiplo apenas de 3.");
                    }
                    else
                    {
                        Console.WriteLine($"O numero {numero} não é multiplo de 2 nem de 3.");
                    }
                    break;
                }
            }
        }
    }
}