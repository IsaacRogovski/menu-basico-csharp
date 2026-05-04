using System;

namespace menuBasicoCsharp.funcoes
{
    public class FuncoesMenu2
    {
        public void verificarSePodeDirigir()
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
                    Console.ReadKey();
                    break;
                    
                }

            }
        }
        public void definirSeAdultoJovemMenorDeIdade()
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
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
