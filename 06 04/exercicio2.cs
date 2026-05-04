using System;

namespace aula_06_04
{
    class exercicio2
    {
        public static void definirIdade()
        {
            Console.Clear();
            while (true)
            {
                int idade;
                Console.Write("Insira sua idade: ");

                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                {
                    Console.WriteLine("Insira um valor Valido!");
                }
                else
                {
                    if (idade < 18)
                    {
                        Console.WriteLine($"Você tem {idade} anos e é menor de idade!");
                    }
                    else if (idade >= 60)
                    //não se se vc esta lendo aqui professor
                    //mas nao utilizei operador logico pois não há necessidade
                    //se esta em um else if, automaticamente é maior que 60
                    {
                        Console.WriteLine($"Você tem {idade} anos e é idoso!");
                    }
                    else
                    {
                        Console.WriteLine($"Você tem {idade} anos e é adulto");
                    }
                    break;
                }
            }
        }
    }
}