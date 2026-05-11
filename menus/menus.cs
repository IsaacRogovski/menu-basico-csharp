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
                opcao = (Console.ReadLine() ?? "").ToLower();

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
                Console.WriteLine("├ 2 - Verifica se é adulto, jovem ou menor de idade.");
                Console.WriteLine("├ 3 - Verifica se um numero é multiplo de 2 ou 3.");
                Console.WriteLine("├ 4 - Define a situação da temperatura.");
                Console.WriteLine("├ 5 - Calculo de reajuste salarial.");
                Console.WriteLine("├ 6 - Definir cateroria nadador.");
                Console.WriteLine("├ 7 - Definir o maior numero entre 3 inseridos.");
                Console.WriteLine("├ 8 - Calcular IMC.");
                Console.WriteLine("├ 9 - Verificar triangulo.");
                Console.WriteLine("├ Q - Página Anterior.");
                Console.WriteLine("├ E - Proxima Página.");
                Console.WriteLine("└ 0 - SAIR.");
                Console.WriteLine("\nUse Q & E para navegar ente as paginas\n");
                Console.Write("Insira a opção que deseja: ");
                opcao = (Console.ReadLine() ?? "").ToLower();

                switch (opcao)
                {
                    case "1":
                        funcoesMenu2.verificarSePodeDirigir();
                        break;
                    case "2":
                        funcoesMenu2.definirSeAdultoJovemMenorDeIdade();
                        break;
                    case "3":
                        funcoesMenu2.multiploDeDoisOuTres();
                        break;
                    case "4":
                        funcoesMenu2.definirTemperatura();
                        break;
                    case "5":
                        funcoesMenu2.gerarAumento();
                        break;
                    case "6":
                        funcoesMenu2.idadeNadador();
                        break;
                    case "7":
                        funcoesMenu2.maiorDeTres();
                        break;
                    case "8":
                        funcoesMenu2.calcularIMC();
                        break;
                    case "9":
                        funcoesMenu2.verificarTriangulo();
                        break;
                    case "q":
                        criarMenu1();
                        sistema = false;
                        break;
                    case "e":
                        criarMenu3();
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

        public static void criarMenu3()
        {
            FuncoesMenu3 funcoesMenu3 = new FuncoesMenu3();
            bool sistema = true;
            string? opcao;

            while (sistema)
            {
                Console.Clear();
                Console.WriteLine("+───3º Pagina───+\n");
                Console.WriteLine("┌ 1 - Definir se aluno esta aprovado ou não.");
                Console.WriteLine("├ 2 - Média de 5 alunos.");
                Console.WriteLine("├ 3 - Média de N alunos.");
                Console.WriteLine("├ 4 - Maiores de idade entre 10 pessoas.");
                Console.WriteLine("├ 5 - Números pares do 0 ao 100.");
                Console.WriteLine("├ 6 - Tabuadas do 1 ao 10.");
                Console.WriteLine("├ 7 - Faixa etária");
                Console.WriteLine("├ 8 - Dados por gênero");
                Console.WriteLine("├ 9 - Eleição");
                Console.WriteLine("├ Q - Página Anterior.");
                // Console.WriteLine("├ E - Proxima Página.");
                Console.WriteLine("└ 0 - SAIR.");
                Console.WriteLine("\nUse Q & E para navegar ente as paginas\n");
                Console.Write("Insira a opção que deseja: ");
                opcao = (Console.ReadLine() ?? "").ToLower();

                switch (opcao)
                {
                    case "1":
                        funcoesMenu3.mediaNota();
                        break;
                    case "2":
                        funcoesMenu3.media5Alunos();
                        break;
                    case "3":
                        funcoesMenu3.mediaNAlunos();
                        break;
                    case "4":
                        funcoesMenu3.maioridadeDe10Pessoas();
                        break;
                    case "5":
                        funcoesMenu3.paresDe0A100();
                        break;
                    case "6":
                        funcoesMenu3.tabuadas1A10();
                        break;
                    case "7":
                        funcoesMenu3.faixaEtaria();
                        break;
                    case "8":
                        funcoesMenu3.dadosPorGeneroDe20Pessoas();
                        break;
                    case "9":
                        funcoesMenu3.eleicao();
                        break;
                    case "q":
                        criarMenu2();
                        sistema = false;
                        break;
                    case "e":
                        // criarMenu3();
                        // sistema = false;
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