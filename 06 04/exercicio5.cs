using System;

namespace aula_06_04
{
    class exercicio5
    {
        public static void gerarAumento()
        {
            Console.Clear();
            while (true)
            {
                double salario;
                Console.Write("Insira o salario para o calculo do aumento: ");

                if (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
                {
                    Console.WriteLine("Insira um valor Valido!");
                }
                else
                {
                    if (salario < 2000)
                    {
                        salario += salario * 0.3;
                        Console.WriteLine($"O salario inserido tem direito ao aumento! Valor reajustado em {salario}");
                    }
                    else
                    {
                        Console.WriteLine($"O salario inserido não possui direito ao aumento!");
                    }
                    break;
                }
            }
        }
    }
}