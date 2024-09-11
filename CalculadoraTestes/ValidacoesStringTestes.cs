using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {
        private ValidacoesStrig _validacoes;

        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesStrig();
        }

        [Fact]
        public void TesteContarCaracteres()
        {
            //Arrange
            string texto = "Teste";
            //Act
            int resultado = _validacoes.ContarCaracteres(texto);
            //Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void TesteContarCaracteresVazio()
        {
        //Arrange
        string texto = "";
        //Act
        int resultado = _validacoes.ContarCaracteres(texto);
        //Assert
        Assert.Equal(0, resultado);
        }

        [Fact]
        public void TesteContarCaracteresNulo()
{
         // Arrange
         string texto = null;

        // Act & Assert
         Assert.Throws<ArgumentNullException>(() => _validacoes.ContarCaracteres(texto));
}

    }
}