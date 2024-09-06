namespace CalculatorApp
{
    using System;

    /// <summary>
    /// Representação do programa principal
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Método inicializador do programa
        /// </summary>
        /// <param name="_">Parâmetros adicionais - não utilizado</param>
        static void Main(String[] _)
        {
            String[] resources = 
                [
                    "Hello, World!"
                ];
            Console.WriteLine(resources[0]);
        }
    }
}
