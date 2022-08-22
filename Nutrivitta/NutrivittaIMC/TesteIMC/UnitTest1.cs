using NutrivittaIMC;
using System;
using Xunit;

namespace TesteIMC
{
    public class UnitTest1
    {
        [Fact]
        public void CalculoIMC()
        {
            //Arrange

            double peso = 68;
            double altura = 1.70;
            double imc = 23.53;

            //Act
            var resultado = CalcIMC.CalculoIMC(peso, altura);

            //Assert
            Assert.Equal(imc, Math.Round(resultado, 2)); // math round e o 2 após o resultado é para usar até 2 casas depois do ponto (vírgula)
        }

        [Theory]
        
        [InlineData(45, 1.57, 18.26)]
        [InlineData(65, 1.70, 22.49)]
        [InlineData(74, 1.70, 25.61)]
        [InlineData(95, 1.67, 34.06)]
        [InlineData(110, 1.75, 35.92)]
        [InlineData(125, 1.70, 43.25)]

        public void CalcIMCLista(double peso, double altura, double imc)
        {
            var resultado = CalcIMC.CalculoIMC(peso, altura);
            Assert.Equal(imc, Math.Round(resultado, 2));

        }

        [Fact]
        public void ClassIMC()
        {
            //Arrange
            double imc = 23.52;
            var classificar = "Peso Normal";

            //Act
            var result = CalcIMC.ClassificarIMC(imc);

            //Assert
            Assert.Equal(classificar, result);
        }

        [Theory]

        [InlineData(18.26, "Abaixo do peso")]
        [InlineData(22.49, "Peso Normal")]
        [InlineData(25.61, "Sobrepeso")]
        [InlineData(34.06, "Obesidade Grau I")]
        [InlineData(35.92, "Obesidade Grau II")]
        [InlineData(43.25, "Obesidade Grau III")]

        public void ClasseIMClista(double imc, string classificacao)
        {
            var resultado = CalcIMC.ClassificarIMC(imc);
            Assert.Equal(classificacao, resultado);
        }
    }
}