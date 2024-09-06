namespace CalculatorApp.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contrato com os principais métodos utilizados em uma calculadora
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Soma dois números
        /// </summary>
        /// <param name="numberOne">Primeiro número</param>
        /// <param name="numberTwo">Segundo número</param>
        /// <returns>O resultado da operação</returns>
        Double Add(Double numberOne, Double numberTwo);

        /// <summary>
        /// Subtrai dois números
        /// </summary>
        /// <param name="numberOne">Primeiro número</param>
        /// <param name="numberTwo">Segundo número</param>
        /// <returns>O resultado da operação</returns>
        Double Subtract(Double numberOne, Double numberTwo);

        /// <summary>
        /// Multiplica dois números
        /// </summary>
        /// <param name="numberOne">Primeiro número</param>
        /// <param name="numberTwo">Segundo número</param>
        /// <returns>O resultado da operação</returns>
        Double Multiply(Double numberOne, Double numberTwo);

        /// <summary>
        /// Divide dois números
        /// </summary>
        /// <param name="numberOne">Primeiro número</param>
        /// <param name="numberTwo">Segundo número</param>
        /// <returns>O resultado da operação</returns>
        Double ToDivide(Double numberOne, Double numberTwo);

        /// <summary>
        /// Calcula a potência de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <param name="expoent">Expoente</param>
        /// <returns>O resultado da operação</returns>
        Double CalculatePower(Double number, Double expoent);

        /// <summary>
        /// Calcula a raiz quadrada de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <returns></returns>
        Double CalculateSquareRoot(Double number);

        /// <summary>
        /// Calcula a raiz cúbica de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <returns></returns>
        Double CalculateCubitRoot(Double number);

        /// <summary>
        /// Calcula o fatorial de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <returns></returns>
        Double CalculateFactorial(Double number);

        /// <summary>
        /// Calcula o logarítmo de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <returns></returns>
        Double CalculateLogarithm(Double number);

        /// <summary>
        /// Histórico com as operações realizadas
        /// </summary>
        IEnumerable<String> History { get; }
    }
}
