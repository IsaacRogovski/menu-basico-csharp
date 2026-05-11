using System;

namespace menuBasicoCsharp.funcoes
{
    public class FuncoesAuxiliares
    {
        public static int lerNumeroInteiro(string enunciado, int valorMinimo, int valorMaximo)
        {
            int valor;
            Console.Write(enunciado);
            while (!int.TryParse(Console.ReadLine(), out valor) || valorMinimo > valor || valor > valorMaximo)
            {

                Console.WriteLine("Insira um valor valido!");
                Console.Write(enunciado);
            }

            return valor;
        }

        public static float lerNumeroFlutuante(string enunciado, float valorMinimo, float valorMaximo)
        {
            float valor;
            Console.Write(enunciado);
            while (!float.TryParse(Console.ReadLine(), out valor) || valorMinimo > valor || valor > valorMaximo)
            {

                Console.WriteLine("Insira um valor valido!");
                Console.Write(enunciado);
            }

            return valor;
        }

        public static bool simOuNao()
        {

            string opcaoSelecionadaSimOuNao = (Console.ReadLine() ?? "").ToLower();
            return opcaoSelecionadaSimOuNao == "s" ? true : false;
        }
    }
}