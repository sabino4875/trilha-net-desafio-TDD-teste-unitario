namespace CalculatorAppTest.Entities
{
    using CalculatorApp.Entities;
    using System;
    /// <summary>
    /// Utilizada para os testes da entidade Calculadora
    /// </summary>
    public class CalculatorFixture : IDisposable
    {
        private readonly Calculator _calculator;
        private Boolean _disposable;
        /// <summary>
        /// TearUp - Inicialização das entidade utilizadas nos testes
        /// </summary>
        public CalculatorFixture()
        {
            _calculator = new Calculator(DateTime.Now);
            _disposable = true;
        }

        /// <summary>
        /// Método destrutor da classe
        /// </summary>
        /// <param name="disposing">Executa rotinas adicionais</param>
        protected virtual void Dispose(Boolean disposing)
        {
            if (_disposable && disposing)
            {
                _disposable = false;
            }
        }

        /// <summary>
        /// TearDown - Finalização das entidades utilizadas nos testes
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Método destrutor da classe
        /// </summary>
        ~CalculatorFixture()
        {
            Dispose(false);
        }

        /// <summary>
        /// Instância da entidade calculadora
        /// </summary>
        public Calculator CalculatorTest => _calculator;
    }
}
