# DIO - Trilha .NET - Blindando Seu Código com TDD e Testes Unitários Usando .NET Core
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo Blindando seu código com TDD e testes unitários usando .NET Core da DIO.

## Contexto
Explore todo o potencial dos testes unitários e entenda como eles podem ajudá-lo a criar soluções cada vez mais robustas e eficientes. Para isso, o expert demonstra como a cobertura de pode ser uma grande aliada para levar a qualidade de suas aplicações para outro patamar.

Por fim, você é desafiado a criar seu próprio projeto (ou reproduzir o que o expert fez). Com isso, você pode definir sua própria meta de cobertura de testes (80%, por exemplo), o que acha? Bons estudos!

# Estrutura do Projeto
``CalculatorApp``: 

Contém a aplicação principal.

``CalculatorAppTest``: 

Contém os testes unitários para a aplicação.

## CalculatorApp

### Descrição

O **CalculatorApp** é uma aplicação de exemplo que define uma interface `ICalculator` para realizar várias operações matemáticas, como adição, subtração, multiplicação, divisão, cálculo de potência, raízes, fatorial e logaritmo. A interface também mantém um histórico das operações realizadas.
Também define uma classe `Calculator`, que implementa os métodos definidos na interface.

### Estrutura do Projeto

O projeto está organizado da seguinte forma:

- **Namespace**: `CalculatorApp.Entities`
- **Interface**: `ICalculator`

---

- **Namespace**: `CalculatorApp.Entities`
- **Classe**   : `Calculator`

---
- **Namespace**: `CalculatorApp`
- **Classe**   : `Program`

### Funcionalidades

A interface `ICalculator` define os seguintes métodos:

- `Double Add(Double numberOne, Double numberTwo)`: Adiciona dois números.
- `Double Subtract(Double numberOne, Double numberTwo)`: Subtrai o segundo número do primeiro.
- `Double Multiply(Double numberOne, Double numberTwo)`: Multiplica dois números.
- `Double ToDivide(Double numberOne, Double numberTwo)`: Divide o primeiro número pelo segundo.
- `Double CalculatePower(Double number, Double expoent)`: Calcula a potência de um número.
- `Double CalculateSquareRoot(Double number)`: Calcula a raiz quadrada de um número.
- `Double CalculateCubitRoot(Double number)`: Calcula a raiz cúbica de um número.
- `Double CalculateFactorial(Double number)`: Calcula o fatorial de um número.
- `Double CalculateLogarithm(Double number)`: Calcula o logaritmo de um número.
- `IEnumerable<String> History { get; }`: Obtém o histórico das operações realizadas.
---
A classe `Calculator` implementa os seguintes métodos da interface `ICalculator`:
- `Double Add(Double numberOne, Double numberTwo)`: Adiciona dois números.
- `Double Subtract(Double numberOne, Double numberTwo)`: Subtrai o segundo número do primeiro.
- `Double Multiply(Double numberOne, Double numberTwo)`: Multiplica dois números.
- `Double ToDivide(Double numberOne, Double numberTwo)`: Divide o primeiro número pelo segundo.
- `Double CalculatePower(Double number, Double expoent)`: Calcula a potência de um número.
- `Double CalculateSquareRoot(Double number)`: Calcula a raiz quadrada de um número.
- `Double CalculateCubitRoot(Double number)`: Calcula a raiz cúbica de um número.
- `Double CalculateFactorial(Double number)`: Calcula o fatorial de um número.
- `Double CalculateLogarithm(Double number)`: Calcula o logaritmo de um número.
- `IEnumerable<String> History { get; }`: Obtém o histórico das operações realizadas.

---
A classe `Program` possui o seguinte método:

- `static void Main(String[] _)`: Método inicializador do programa que exibe a mensagem "Hello, World!" no console.

## CalculatorAppTest

### Descrição

Este projeto contém testes unitários para a entidade `Calculadora` do aplicativo `CalculatorApp`. Os testes são implementados usando o framework `Xunit`.

### Estrutura do Projeto

- **Entities**
  - `CalculatorFixture.cs`: Arquivo de configuração e preparação para os testes.
  - `CalculatorTest.cs`: Arquivo contendo os testes unitários para a calculadora.

### Funcionalidades

A classe `CalculatorFixture` possui as seguintes funcionalidades:

- **Construtor**: Inicializa uma nova instância da classe `Calculator` com a data atual.
- **Propriedade `CalculatorTest`**: Retorna a instância do `Calculator`.
- **Método `Dispose`**: Libera os recursos utilizados pela instância de `CalculatorFixture`.
- **Método `Dispose(Boolean disposing)`**: Método protegido que realiza a liberação condicional dos recursos.
- **Destrutor**: Garante a liberação dos recursos quando o objeto é coletado pelo garbage collector.

---

A classe `CalculatorTest` contém os testes unitários para os métodos da entidade `Calculadora`
- **Soma**: Testa a soma de dois números.
- **Subtração**: Testa a subtração de dois números.
- **Multiplicação**: Testa a multiplicação de dois números.
- **Divisão**: Testa a divisão de dois números, incluindo divisão por zero.
- **Potência**: Testa o cálculo da potência de um número.
- **Fatorial**: Testa o cálculo do fatorial de um número.
- **Logaritmo**: Testa o cálculo do logaritmo de um número.
- **Histórico**: Verifica as últimas operações gravadas no histórico.


## Como Usar

* Clone o repositório:

    ```bash
    git clone https://github.com/seu-usuario/CalculatorApp.git
    ```

Projeto:

1. Navegue até o diretório:
    ```bash
    cd CalculatorApp
    ```
2. Execute o projeto
    ```bash
    dotnet run
    ```

Testes:

1. Navegue até o diretório do projeto:
    ```bash
        cd CalculatorAppTest
    ```
2. Execute os testes:
    ```bash
    dotnet test
    ```

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.

## Documentação gerada por Inteligência artificial, e revisada por humano.