using System;
using System.ComponentModel.Design;

namespace aula_06_04
{
    class exercicio8
    {
        public static void calcularIMC()
        {
            Console.Clear();

            float altura, imc;
            int peso;

            while (true)
            {
                Console.Write("Insira sua altura em M (Exemplo: 1,75): ");

                if (!float.TryParse(Console.ReadLine(), out altura) || altura <= 0)
                {
                    Console.WriteLine("Insira um valor Valido!");
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Insira seu peso em kg (Exemplo: 75): ");
                        if (!int.TryParse(Console.ReadLine(), out peso) || peso <= 0)
                        {
                            Console.WriteLine("Insira um valor Valido!");
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
                }
            }

            imc = peso / (altura * altura);
            if (imc < 20)
            {
                Console.WriteLine($"IMC: {imc}\nCategoria: Abaixo do peso");
            }
            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine($"IMC: {imc}\nCategoria: Peso ideal");
            }
            else
            {
                Console.WriteLine($"IMC: {imc}\nCategoria: Acima do peso");
            }

            // ---------------- abaixo um codigo para o calculo do imc com base na tabela real...

            // double[] classificacao = { 18.5, 24.9, 29.9, 34.9, 39.9 };
            // string[] categorias = { "Abaixo do peso", "Peso normal", "Sobrepeso", "Obesidade I", "Obesidade II" };



            // if (imc < 40)
            // {
            //     for (int i = 0; i < classificacao.Length; i++)
            //     {
            //         if (imc <= classificacao[i])
            //         {
            //             Console.WriteLine($"IMC: {imc}\nCategoria: {categorias[i]}");
            //             break;
            //         }

            //     }
            // }
            // else
            // {
            //     Console.WriteLine($"IMC: {imc}\nCategoria: Obesidade III");
            // }
        }
    }
}