using System;

namespace menuBasicoCsharp.funcoes
{
    class LerInteiro
    {
        public static int lerInteiro(string prompt)
        {
            int resultado;
            string input = "";
            Console.Write(prompt);

            while (true)
            {
                var key = Console.ReadKey(intercept: true);

                if (key.Key == ConsoleKey.Enter)
                {
                    if (int.TryParse(input, out resultado))
                    {
                        Console.WriteLine();
                        return resultado;
                    }
                    Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                    Console.Write(prompt);
                    input = "";
                }
                else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input = input[..^1];
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    input += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }
        }
    }
}