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
                            temCNH = (Console.ReadLine() ?? "").ToLower();
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
        public void multiploDeDoisOuTres()
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
                    Console.ReadKey();
                    break;
                }
            }
        }
        public void definirTemperatura()
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
                    {
                        Console.WriteLine($"Está {temperatura} graus, e esta agradavel.");
                    }
                    else
                    {
                        Console.WriteLine($"Está {temperatura} graus, e esta quente.");
                    }
                    Console.ReadKey();
                    break;
                }
            }
        }
        public void gerarAumento()
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
                    Console.ReadKey();
                    break;
                }
            }
        }
        public void idadeNadador()
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
                    Console.ReadKey();
                    break;
                }
            }
        }
        public void maiorDeTres()
        {
            Console.Clear();
            while (true)
            {

                int[] numeros = new int[3];
                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine($"Insira o {i + 1}º numero.");
                    while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                    {
                        Console.WriteLine("Insira um valor válido!");
                    }
                }

                if (numeros[0] > numeros[1])
                {
                    if (numeros[0] > numeros[2])
                    {
                        Console.WriteLine($"{numeros[0]} é o maior numero.");
                    }
                    else
                    {
                        Console.WriteLine($"{numeros[2]} é o maior numero.");
                    }
                }
                else if (numeros[1] > numeros[2])
                {
                    Console.WriteLine($"{numeros[1]} é o maior numemero.");
                }
                else
                {
                    Console.WriteLine($"{numeros[2]} é o maior numero.");
                }
                Console.ReadKey();
                break;
            }
        }
        public void calcularIMC()
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
            
            double[] classificacao = { 18.5, 24.9, 29.9, 34.9, 39.9 };
            string[] categorias = { "Abaixo do peso", "Peso normal", "Sobrepeso", "Obesidade I", "Obesidade II" };

            if (imc < 40)
            {
                for (int i = 0; i < classificacao.Length; i++)
                {
                    if (imc <= classificacao[i])
                    {
                        Console.WriteLine($"IMC: {imc}\nCategoria: {categorias[i]}");
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine($"IMC: {imc}\nCategoria: Obesidade III");
            }
            Console.ReadKey();
        }
        public void verificarTriangulo()
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
                Console.ReadKey();
                break;

            }
        }
    }
}
