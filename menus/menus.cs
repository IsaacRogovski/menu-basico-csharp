using System;
using menuBasicoCsharp.funcoes;

namespace menuBasicoCsharp.menus
{
    class Menus
    {
        public static void criarMenu1()
        {
            FuncoesMenu1 funcoesMenu1 = new FuncoesMenu1();
            bool sistema = true;
            string? opcao;

            while (sistema)
            {
                Console.Clear();
                Console.WriteLine("+───1º Pagina───+\n");
                Console.WriteLine("┌ 1 - Verificar o maior número entre DOIS.");
                Console.WriteLine("├ 2 - Verificar se pode votar com X idade.");
                Console.WriteLine("├ 3 - Verificar se um número é PAR");
                Console.WriteLine("├ 4 - Verificar se um número é multiplo de CINCO.");
                Console.WriteLine("├ 5 - Verificar se um número é maior que DEZ.");
                Console.WriteLine("├ 6 - Sistema basido de compras (Teclado, Mouse e PenDrive).");
                Console.WriteLine("├ 7 - Calcular média de DUAS notas.");
                Console.WriteLine("├ 8 - Ler 2 numeros, exibi-los e depois troca-los de lugar.");
                Console.WriteLine("├ 9 - Formula de Baskhara.");
                Console.WriteLine("├ E - Proxima Página.");
                Console.WriteLine("└ 0 - SAIR.");
                Console.WriteLine("\nUse Q & E para navegar ente as paginas\n");
                Console.Write("Insira a opção que deseja: ");
                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {   
                    case "1":
                        funcoesMenu1.verificaOMaiorEntre2Numeros();
                        break;
                    case "2":
                        funcoesMenu1.votar();
                        break;
                    case "3":
                        funcoesMenu1.ePar();
                        break;
                    case "4":
                        funcoesMenu1.multiploDe5();
                        break;
                    case "5":
                        funcoesMenu1.maiorOuIgual10();
                        break;
                    case "6":
                        funcoesMenu1.valorItens();
                        break;
                    case "7":
                        funcoesMenu1.mediaNota();
                        break;
                    case "8":
                        funcoesMenu1.trocarValores();
                        break;
                    case "9":
                        funcoesMenu1.baskara();
                        break;
                    case "e":
                        criarMenu2();
                        sistema = false;
                        break;
                    case "0":
                        sistema = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void criarMenu2()
        {
            FuncoesMenu2 funcoesMenu2 = new FuncoesMenu2();
            bool sistema = true;
            string? opcao;

            while (sistema)
            {
                Console.Clear();
                Console.WriteLine("+───2º Pagina───+\n");
                Console.WriteLine("┌ 1 - Verificar se pode dirigir.");
                Console.WriteLine("├ 2 - ");
                Console.WriteLine("├ 3 - ");
                Console.WriteLine("├ 4 - ");
                Console.WriteLine("├ 5 - ");
                Console.WriteLine("├ 6 - ");
                Console.WriteLine("├ 7 - ");
                Console.WriteLine("├ 8 - ");
                Console.WriteLine("├ 9 - ");
                Console.WriteLine("├ Q - Página Anterior.");
                Console.WriteLine("└ 0 - SAIR.");
                Console.WriteLine("\nUse Q & E para navegar ente as paginas\n");
                Console.Write("Insira a opção que deseja: ");
                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "1":
                    funcoesMenu2.verificarSePodeDirigir();
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        
                        break;
                    case "5":
                        
                        break;
                    case "6":
                        
                        break;
                    case "7":
                        
                        break;
                    case "8":
                        
                        break;
                    case "9":
                        
                        break;
                    case "q":
                        criarMenu1();
                        sistema = false;
                        break;
                    case "0":
                        sistema = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}