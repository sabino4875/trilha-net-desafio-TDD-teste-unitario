using CalculatorApp.Entities;
using System;
using System.Collections;
using Xunit;

namespace CalculatorAppTest.Entities
{
    /// <summary>
    /// Teste dos métodos da entidade Calculadora
    /// </summary>
    /// <remarks>
    /// TearUp - Inicialização das entidade utilizadas nos testes
    /// </remarks>
    public class CalculatorTest(CalculatorFixture fixture) : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _fixture = fixture;

        /// <summary>
        /// Deve retornar sucesso ao somar dois números
        /// </summary>
        /// <param name="numberOne">Primeiro número</param>
        /// <param name="numberTwo">Segundo número</param>
        /// <param name="result">Resultado da operação</param>
        [Theory]
        [InlineData(2, 4, 6)]
        [InlineData(3, 6, 9)]
        [InlineData(4, 8, 12)]
        public void MustAddWhenEnteringTwoNumbersReturningSuccess(Double numberOne, Double numberTwo, Double result)
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            //Act
            var calcResult = _fixture.CalculatorTest.Add(numberOne, numberTwo);
            //Assert
            Assert.Equal(result, calcResult);
        }

        /// <summary>
        /// Deve retornar sucesso ao subtrair dois números
        /// </summary>
        /// <param name="numberOne">Primeiro número</param>
        /// <param name="numberTwo">Segundo número</param>
        /// <param name="result">Resultado da operação</param>
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(6, 3, 3)]
        [InlineData(8, 4, 4)]
        public void MustSubtractWhenEnteringTwoNumbersReturningSuccess(Double numberOne, Double numberTwo, Double result)
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            //Act
            var calcResult = _fixture.CalculatorTest.Subtract(numberOne, numberTwo);
            //Assert
            Assert.Equal(result, calcResult);
        }

        /// <summary>
        /// Deve retornar sucesso ao multiplicar dois números
        /// </summary>
        /// <param name="numberOne">Primeiro número</param>
        /// <param name="numberTwo">Segundo número</param>
        /// <param name="result">Resultado da operação</param>
        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(6, 3, 18)]
        [InlineData(8, 4, 32)]
        public void MustMultiplyWhenEnteringTwoNumbersReturningSuccess(Double numberOne, Double numberTwo, Double result)
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            //Act
            var calcResult = _fixture.CalculatorTest.Multiply(numberOne, numberTwo);
            //Assert
            Assert.Equal(result, calcResult);
        }

        /// <summary>
        /// Deve retornar sucesso ao dividir dois números
        /// </summary>
        /// <param name="numberOne">Primeiro número</param>
        /// <param name="numberTwo">Segundo número</param>
        /// <param name="result">Resultado da operação</param>
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(6, 3, 2)]
        [InlineData(8, 4, 2)]
        [InlineData(15, 0, Double.NaN)]
        public void MustToDivideWhenEnteringTwoNumbersReturningSuccess(Double numberOne, Double numberTwo, Double result)
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            //Act
            var calcResult = _fixture.CalculatorTest.ToDivide(numberOne, numberTwo);
            //Assert
            Assert.Equal(result, calcResult);
        }

        /// <summary>
        /// Deve retornar sucesso ao calcular a potência de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <param name="expoent">Expoente</param>
        /// <param name="result">Resultado da operação</param>
        [Theory]
        [InlineData(4, 2, 16)]
        [InlineData(6, 3, 216)]
        [InlineData(8, 4, 4096)]
        [InlineData(15, 0, 1)]
        public void MustCalculateThePowerByEnteringAnumberAndItsExponentReturningSuccess(Double number, Double expoent, Double result)
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            //Act
            var calcResult = _fixture.CalculatorTest.CalculatePower(number, expoent);
            //Assert
            Assert.Equal(result, calcResult);
        }

        /// <summary>
        /// Deve retornar sucesso ao calcular a raiz quadrada de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <param name="result">Resultado da operação</param>
        [Theory]
        [InlineData(2, 1.41421)]
        [InlineData(3, 1.73205)]
        [InlineData(4, 2)]
        [InlineData(0, 0)]
        [InlineData(-1, Double.NaN)]
        public void MustCalculateTheSquareRootByEnteringAnumberReturningSuccess(Double number, Double result)
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            //Act
            var calcResult = Math.Round(_fixture.CalculatorTest.CalculateSquareRoot(number),5);
            //Assert
            Assert.Equal(result, calcResult);
        }

        /// <summary>
        /// Deve retornar sucesso ao calcular a raiz cúbica de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <param name="result">Resultado da operação</param>
        [Theory]
        [InlineData(2, 1.25992)]
        [InlineData(3, 1.44225)]
        [InlineData(4, 1.58740)]
        [InlineData(0, 0)]
        [InlineData(-1, Double.NaN)]
        public void MustCalculateTheCubitRootByEnteringAnumberReturningSuccess(Double number, Double result)
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            //Act
            var calcResult = Math.Round(_fixture.CalculatorTest.CalculateCubitRoot(number), 5);
            //Assert
            Assert.Equal(result, calcResult);
        }

        /// <summary>
        /// Deve retornar sucesso ao calcular o fatorial de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <param name="result">Resultado da operação</param>
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(0, 1)]
        [InlineData(-1, Double.NaN)]
        public void MustCalculateTheFactorialByEnteringAnumberReturningSuccess(Double number, Double result)
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            //Act
            var calcResult = _fixture.CalculatorTest.CalculateFactorial(number);
            //Assert
            Assert.Equal(result, calcResult);
        }

        /// <summary>
        /// Deve retornar sucesso ao calcular o logarítmo de um número
        /// </summary>
        /// <param name="number">Número</param>
        /// <param name="result">Resultado da operação</param>
        [Theory]
        [InlineData(2, 0.69315)]
        [InlineData(3, 1.09861)]
        [InlineData(4, 1.38629)]
        [InlineData(0, Double.NaN)]
        [InlineData(-1, Double.NaN)]
        public void MustCalculateTheLogarithmByEnteringAnumberReturningSuccess(Double number, Double result)
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            //Act
            var calcResult = Math.Round(_fixture.CalculatorTest.CalculateLogarithm(number),5);
            //Assert
            Assert.Equal(result, calcResult);
        }


        /// <summary>
        /// Deve retornar sucesso ao verificar as últimas operações gravadas no histórico
        /// </summary>
        [Fact]
        public void MustVerifyHistoricalInfoReturningSuccess()
        {
            //Arrange
            // instanciação da entidade calculadora na inicialização dos testes
            String[] result = [
                $"date: {DateTime.Now.ToShortDateString()}: ∛ 8 = 2", 
                $"date: {DateTime.Now.ToShortDateString()}: √ 4 = 2", 
                $"date: {DateTime.Now.ToShortDateString()}: fact(3) = 6"

            ];
            //Act
            _fixture.CalculatorTest.CalculatePower(2, 2);
            _fixture.CalculatorTest.CalculateFactorial(3);
            _fixture.CalculatorTest.CalculateSquareRoot(4);
            _fixture.CalculatorTest.CalculateCubitRoot(8);

            var calcResult = _fixture.CalculatorTest.History;
            //Assert
            Assert.Equal(result, calcResult);
        }

    }
}