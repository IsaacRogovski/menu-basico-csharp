using System;

namespace aula_06_04
{
    class exercicio4
    {
        public static void definirTemperatura()
        {
            Console.Clear();
            while (true)
            {
                int temperatura;
                Console.Write("Insira a temperatura: ");

                if (!int.TryParse(Console.ReadLine(), out temperatura))
                {
                    Console.WriteLine("Insira um valor Valido!");
                }
                else
                {
                    if (temperatura < 15)
                    {
                        Console.WriteLine($"Está {temperatura} graus, e esta frio.");
                    }
                    else if (temperatura <= 25)
                    //não se se vc esta lendo aqui professor
                    //mas nao utilizei operador logico pois não há necessidade
                    //se esta em um else if, automaticamente é maior que 15
                    {
                        Console.WriteLine($"Está {temperatura} graus, e esta agradavel.");
                    }
                    else
                    {
                        Console.WriteLine($"Está {temperatura} graus, e esta quente.");
                    }
                    break;
                }
            }
        }
    }
}