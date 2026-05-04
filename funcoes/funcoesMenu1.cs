using System;

namespace menuBasicoCsharp.funcoes
{
    public class FuncoesMenu1
    {
        public void verificaOMaiorEntre2Numeros()
        {

            {
                int n1, n2;

                Console.Clear();
                n1 = LerInteiro.lerInteiro("Insira um numero: ");
                n2 = LerInteiro.lerInteiro("Insira outro: ");

                if (n1 > n2)
                {
                    Console.WriteLine($"{n1} é maior que {n2}.");
                }
                else if (n2 == n1)
                {
                    Console.WriteLine("Os numeors são iguais.");
                }
                else
                {
                    Console.WriteLine($"{n2} é maior que {n1}.");
                }
                Console.ReadKey();
            }
        }
        public void votar()
        {
            int idade;
            Console.Clear();
            Console.Write("Insira sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);
            if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("Você pode votar!");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Você DEVE votar!");
            }
            else
            {
                Console.WriteLine($"Voce ainda nao pode votar, e só poderá daqui a {16 - idade} anos!");
            }
            Console.ReadKey();
        }

        public void ePar()
        {
            int n1;
            Console.Clear();
            Console.Write("Insira um numeo: ");
            int.TryParse(Console.ReadLine(), out n1);
            if (n1 % 2 == 0)
            {
                Console.WriteLine($"O numero {n1} é Par.");
            }
            else
            {
                Console.WriteLine($"O numero {n1} é Impar.");
            }
            Console.ReadKey();
        }

        public void multiploDe5()
        {
            int n1;
            Console.Clear();
            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out n1);
            if (n1 % 5 == 0)
            {
                Console.WriteLine($"O numero {n1} é multiplo de cinco.");
            }
            else
            {
                Console.WriteLine($"O numero {n1} não é multiplo de Cinco.");
            }
            Console.ReadKey();
        }

        public void maiorOuIgual10()
        {
            int n1;
            Console.Clear();
            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out n1);
            if (n1 < 10)
            {
                Console.WriteLine($"O numero {n1} é menor que 10.");
            }
            else if (n1 == 10)
            {
                Console.WriteLine("O numero inserido é literalmente 10!");
            }
            else
            {
                Console.WriteLine($"O numero {n1} é maior que 10.");
            }
            Console.ReadKey();
        }

        public void trocarValores()
        {
            int a, b, c;
            Console.Clear();
            Console.Write("Insira um numero: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Insira outro numero: ");
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine($"A = {a}\nB = {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"Após a troca:\nA = {a}\nB = {b}");
            Console.ReadKey();
        }

        public void valorItens()
        {
            int penDrives, teclados, mouses, total, valorPago;
            Console.Clear();
            Console.Write("Insira o numero de teclados: ");
            int.TryParse(Console.ReadLine(), out teclados);
            Console.Write("Insira o numero de mouses: ");
            int.TryParse(Console.ReadLine(), out mouses);
            Console.Write("Insira o numero de pendrives: ");
            int.TryParse(Console.ReadLine(), out penDrives);
            total = teclados * 100 + mouses * 35 + penDrives * 60;
            Console.WriteLine($"valor total a ser pago: {total.ToString("C")}");
            Console.Write("Insira o valor que o cliente pagou: ");
            int.TryParse(Console.ReadLine(), out valorPago);
            if (valorPago >= total)
            {
                Console.WriteLine($"Valor suficiente, troco de {(valorPago - total).ToString("C")}");
            }
            else
            {
                Console.WriteLine($"Valor insuficiente! Faltou {(total - valorPago).ToString("C")}");
            }
            Console.ReadKey();
        }
        public void mediaNota()
        {
            int n1, n2, media;
            Console.Clear();
            Console.Write("Insira a primeira nota: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Insira a segunda nota: ");
            int.TryParse(Console.ReadLine(), out n2);
            media = (n1 + n2) / 2;
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
            Console.ReadKey();
        }

        public void baskara()
        {
            int a, b, c;
            double x1, x2, delta;
            Console.Clear();
            Console.Write("Insira A: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Insira B: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("Insira C: ");
            int.TryParse(Console.ReadLine(), out c);
            delta = b * b - (4 * a * c);
            if (delta >= 1)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
            else if (delta == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
            }
            else
            {
                Console.WriteLine("Equação invalida!");
            }
            Console.ReadKey();


        }

    }
}
