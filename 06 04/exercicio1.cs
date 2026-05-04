using System;

namespace aula_06_04
{
    class exercicio1
    {
        public static void podeDirigir()
        {
            Console.Clear();
            while (true)
            {
                int idade;
                string temCNH;

                Console.Write("Insira sua idade: ");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                {
                    Console.WriteLine("Valor Invalido!");

                }
                else
                {
                    if (idade < 18)
                    {
                        Console.WriteLine("Você é menor de idade e não pode dirigir!");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("Você possui CNH? (S/N): ");
                            temCNH = Console.ReadLine()?.ToLower();
                            if (temCNH == "s" || temCNH == "n")
                            {
                                break;
                            }
                        } while (true);
                        if (temCNH == "s")
                        {
                            Console.WriteLine("Você pode dirigir.");
                        }
                        else
                        {
                            Console.WriteLine("Você não pode dirigir!");
                        }
                    }

                    break;
                }

            }
        }
    }
}