using System;

namespace menuBasicoCsharp.funcoes
{
    public class FuncoesMenu3
    {
        public void mediaNota()
        {
            Console.Clear();
            int[] notas = new int[2];
            double media;
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Insira a {i + 1}º nota: ");
                while (!int.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("Insira um valor válido!");
                }
            }

            media = (notas[0] + (2 * notas[1])) / 3;
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
        public void media5Alunos()
        {
            float somaGeral = 0;

            Console.Clear();


            for (int i = 1; i <= 5; i++)
            {

                float P1 = FuncoesAuxiliares.lerNumeroFlutuante($"Insira a P1 do {i}º aluno: ", 0, 10);
                float P2 = FuncoesAuxiliares.lerNumeroFlutuante($"Insira a P2 do {i}º aluno: ", 0, 10);

                float media = (P1 + P2) / 2;
                Console.WriteLine($"Média do {i}º aluno: {media}");

                somaGeral += media;
                Console.WriteLine("");
            }

            Console.WriteLine($"\nMédia geral: {(somaGeral / 5)}");
            Console.ReadKey();
        }
        public void mediaNAlunos()
        {
            float somaGeral = 0;

            Console.Clear();

            int i = 1;
            while (true)
            {
                int P1 = FuncoesAuxiliares.lerNumeroInteiro($"Insira a P1 do {i}º aluno: ", 0, 10);
                int P2 = FuncoesAuxiliares.lerNumeroInteiro($"Insira a P2 do {i}º aluno: ", 0, 10);

                float media = (P1 + P2) / 2;
                Console.WriteLine($"Média do {i}º aluno: {media}");
                somaGeral += media;
                Console.Write("\nDeseja adicionar a nota de outro aluno (S/N): ");
                if (FuncoesAuxiliares.simOuNao() != true)
                {
                    break;
                }
                i++;
                Console.WriteLine("");
            }

            Console.WriteLine($"\nMédia geral: {(somaGeral / i)}");
            Console.ReadKey();
        }

        public void maioridadeDe10Pessoas()
        {
            int maiores = 0;

            Console.Clear();

            for (int i = 1; i <= 10; i++)
            {
                int idade = FuncoesAuxiliares.lerNumeroInteiro($"Insira a idade da {i}º pessoa: ", 0, 150);
                if (idade >= 18)
                {
                    maiores++;
                    Console.WriteLine("Maior de Idade.");
                }
                else
                {
                    Console.WriteLine("Menor de Idade.");
                }

            }

            Console.WriteLine($"\nMaiores de idade: {maiores}.");
            Console.ReadKey();
        }

        public void paresDe0A100()
        {
            Console.Clear();

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Numero: {i} | par");
            }
            Console.ReadKey();
        }

        public void tabuadas1A10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Clear();
                Console.WriteLine($"Tabuada do {i}\n");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }

                Console.WriteLine("\nPressione qualquer tecla...");
                Console.ReadKey();
            }
        }

        public void faixaEtaria()
        {
            Console.Clear();
            int[] faixas = new int[5];
            string[] rangeFaixas = { "1 até 15", "16 até 30", "31 até 45", "45 até 60", "Mais de 60" };

            for (int i = 0; i < 15; i++)
            {
                int idade = FuncoesAuxiliares.lerNumeroInteiro($"Insira a idade da {i + 1}º pessoa: ", 0, 150);

                if (idade <= 15) faixas[0]++;
                else if (idade <= 30) faixas[1]++;
                else if (idade <= 45) faixas[2]++;
                else if (idade <= 60) faixas[3]++;
                else faixas[4]++;
            }
            Console.WriteLine("");
            for (int i = 0; i < faixas.Length; i++)
            {
                Console.WriteLine($"De {rangeFaixas[i]} anos: {faixas[i]} pessoa(s) | {faixas[i] * 100.0 / 15:F2}%");
            }

            Console.ReadKey();
        }

        public void dadosPorGeneroDe20Pessoas()
        {
            Console.Clear();
            int masculino = 0, feminino = 0, outro = 0;
            double pesoM = 0, pesoF = 0, pesoO = 0;

            for (int i = 1; i <= 3; i++)
            {
                string genero = "";
                while (true)
                {
                    Console.Write($"Insira o gênero da {i}º pessoa (M - Masculino / F - Feminino / O - Outro): ");
                    genero = (Console.ReadLine() ?? "").ToLower();
                    if (genero == "m" || genero == "f" || genero == "o") break;
                    else Console.WriteLine("Insira um gênero valido!");
                }

                float peso = FuncoesAuxiliares.lerNumeroFlutuante($"Insira o peso da {i}º pessoa em KGs (exemplo: 75,5): ", 0, 500);
                float altura = FuncoesAuxiliares.lerNumeroFlutuante($"Insira a altura da {i}º pessoa em metros (exemplo: 1,75):", 0, 500);
                switch (genero)
                {
                    case "m":
                        masculino++;
                        pesoM += peso;
                        break;
                    case "f":
                        feminino++;
                        pesoF += peso;
                        break;
                    case "o":
                        outro++;
                        pesoO += peso;
                        break;
                }
            }

            int total = masculino + feminino + outro;

            Console.WriteLine("");
            if (masculino > 0)
                Console.WriteLine($"Masculino: {masculino} | {masculino * 100.0 / total}% | Média: {pesoM / masculino} KGs");

            if (feminino > 0)
                Console.WriteLine($"Feminino: {feminino} | {feminino * 100.0 / total}% | Média: {pesoF / feminino} KGs");

            if (outro > 0)
                Console.WriteLine($"Outro: {outro} | {outro * 100.0 / total}% | Média: {pesoO / outro} KGs");

            Console.ReadKey();
        }


        public void eleicao()
        {
            int[] opcoesVotos = new int[6];
            int votos = 0;
            float[] porcentagem = new float[6];
            string opcaoEleicao;
            bool sistema = true;

            while (sistema)
            {
                Console.Clear();

                Console.WriteLine("+───Eleição───+\n");
                Console.WriteLine("┌ 1 - Candidato 1.");
                Console.WriteLine("├ 2 - Candidato 2.");
                Console.WriteLine("├ 3 - Candidato 3.");
                Console.WriteLine("├ 4 - Candidato 4.");
                Console.WriteLine("├ 5 - Voto Nulo.");
                Console.WriteLine("├ 6 - Voto em Branco.");
                Console.WriteLine("└ 0 - SAIR.");

                Console.Write("\nInsira a opção que deseja: ");

                opcaoEleicao = Console.ReadLine() ?? "";

                switch (opcaoEleicao)
                {
                    case "1":
                        opcoesVotos[0]++;
                        votos++;
                        break;

                    case "2":
                        opcoesVotos[1]++;
                        votos++;
                        break;

                    case "3":
                        opcoesVotos[2]++;
                        votos++;
                        break;

                    case "4":
                        opcoesVotos[3]++;
                        votos++;
                        break;

                    case "5":
                        opcoesVotos[4]++;
                        votos++;
                        break;

                    case "6":
                        opcoesVotos[5]++;
                        votos++;
                        break;

                    case "0":

                        if (votos > 0)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                porcentagem[i] = ((float)opcoesVotos[i] / votos) * 100;
                            }
                        }

                        Console.Clear();

                        Console.WriteLine("+───Resultado───+\n");

                        Console.WriteLine($"Votos candidato 1: {opcoesVotos[0]} | {porcentagem[0]:F2}%");
                        Console.WriteLine($"Votos candidato 2: {opcoesVotos[1]} | {porcentagem[1]:F2}%");
                        Console.WriteLine($"Votos candidato 3: {opcoesVotos[2]} | {porcentagem[2]:F2}%");
                        Console.WriteLine($"Votos candidato 4: {opcoesVotos[3]} | {porcentagem[3]:F2}%");
                        Console.WriteLine($"Votos nulos: {opcoesVotos[4]} | {porcentagem[4]:F2}%");
                        Console.WriteLine($"Votos em branco: {opcoesVotos[5]} | {porcentagem[5]:F2}%");

                        Console.ReadKey();
                        sistema = false;
                        break;

                    default:
                        Console.WriteLine("\nInsira uma opção válida!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
