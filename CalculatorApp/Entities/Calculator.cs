namespace CalculatorApp.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Api contendo a implementação dos principais métodos utilizados em uma calculadora
    /// </summary>
    /// <remarks>
    /// Método construtor da classe
    /// </remarks>
    /// <param name="date">Data de registro das operações no histórico</param>
    public class Calculator(DateTime date) : ICalculator
    {
        private readonly List<String> _history = [];
        private readonly DateTime _date = date;

        /// <inheritdoc/>
        public IEnumerable<String> History => RetrieveHistory();


        /// <inheritdoc/>
        public Double Add(Double numberOne, Double numberTwo)
        {
            var result = numberOne + numberTwo;
            AddMessageToHistory(method: $"{numberOne} + {numberTwo}", message: $"{result}");
            return result;
        }

        /// <inheritdoc/>
        public Double CalculatePower(Double number, Double expoent)
        {
            var result = Math.Pow(number, expoent);
            AddMessageToHistory(method: $"{number} ^ {expoent}", message: $"{result}");
            return result;
        }

        /// <inheritdoc/>
        public Double CalculateSquareRoot(Double number)
        {
            var result = Double.NaN;
            if (number > -1)
            {
                result = Math.Sqrt(number);
            }
            AddMessageToHistory(method: $"√ {number}", message: $"{result}");
            return result;
        }

        /// <inheritdoc/>
        public Double CalculateCubitRoot(Double number)
        {
            var result = Double.NaN;
            if (number > -1)
            {
                result = Math.Cbrt(number);
            }
            AddMessageToHistory(method: $"∛ {number}", message: $"{result}");
            return result;
        }

        /// <inheritdoc/>
        public Double CalculateFactorial(Double number)
        {
            var result = Double.NaN;
            if(number > -1)
            {
                result = 1;
                for(var i=number; i>0; i--)
                {
                    result *= i;
                }
            }
            AddMessageToHistory(method: $"fact({number})", message: $"{result}");
            return result;
        }

        /// <inheritdoc/>
        public Double CalculateLogarithm(Double number)
        {
            var result = Double.NaN;
            if (number > 0)
            {
                result = Math.Log(number);
            }
            AddMessageToHistory(method: $"log({number})", message: $"{result}");
            return result;
        }


        /// <inheritdoc/>
        public Double Multiply(Double numberOne, Double numberTwo)
        {
            var result = numberOne * numberTwo;
            AddMessageToHistory(method: $"{numberOne} * {numberTwo}", message: $"{result}");
            return result;
        }

        /// <inheritdoc/>
        public Double Subtract(Double numberOne, Double numberTwo)
        {
            var result = numberOne - numberTwo;
            AddMessageToHistory(method: $"{numberOne} - {numberTwo}", message: $"{result}");
            return result;
        }

        /// <inheritdoc/>
        public Double ToDivide(Double numberOne, Double numberTwo)
        {
            Double result = Double.NaN;
            if(numberTwo != 0.0)
            { 
                result = numberOne / numberTwo; 
            }
            AddMessageToHistory(method: $"{numberOne} / {numberTwo}", message: $"{result}");
            return result;
        }

        /// <summary>
        /// Monta o filtro de histórico para conter apenas as três últimas ações efetuadas
        /// </summary>
        protected IEnumerable<String> RetrieveHistory()
        {
            if(_history.Count > 3)
            {
                var data = _history[..3];
                _history.Clear();
                _history.AddRange(data);
            }
            return _history;
        }

        /// <summary>
        /// Grava uma mensagem no histório
        /// </summary>
        /// <param name="method">Método</param>
        /// <param name="message">Mensagem</param>
        protected void AddMessageToHistory(String method, String message)
        {
            _history.Insert(0, $"date: {_date.ToShortDateString()}: {method} = {message}");
        }
    }
}
