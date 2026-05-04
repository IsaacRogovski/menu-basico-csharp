using System;

namespace aula_06_04
{
    class exercicio6
    {
        public static void idadeNadador()
        {
            Console.Clear();
            while (true)
            {
                int idade;
                Console.Write("Insira a idade do nadador: ");

                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                {
                    Console.WriteLine("Insira um valor Valido!");
                }
                else
                {
                    if (idade < 5)
                    {
                        Console.WriteLine("Muito pequeno para competir!");
                    }
                    else if (idade <= 7)
                    {
                        Console.WriteLine("Infantil A");
                    }
                    else if (idade <= 10)
                    {
                        Console.WriteLine("Infantil B");
                    }
                    else if (idade <= 13)
                    {
                        Console.WriteLine("Juvenil A");
                    }
                    else if (idade <= 17)
                    {
                        Console.WriteLine("Juvenil B");
                    }
                    else
                    {
                        Console.WriteLine("Sênior");
                    }

                    break;
                }
            }
        }
    }
}