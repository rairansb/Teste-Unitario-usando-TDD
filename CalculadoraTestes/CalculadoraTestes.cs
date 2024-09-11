using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
     [Fact]
    public void TesteCalculadoraSomaResultadoNegativo()
    {
        //Arrange
        CalculadoraImp c = new CalculadoraImp();
        //Act
        int resultado = c.Soma(-1, -2);
        //Assert
        Assert.Equal(-3, resultado);
    }

    [Fact]
    public void TesteCalculadoraSomaResltado3()  
    {   
        //Arrange               
        CalculadoraImp c = new CalculadoraImp();
        //Act
        int resultado = c.Soma(1, 2);
        //Assert
        Assert.Equal(3, resultado);
    }   

    [Fact]
    public void TesteCalculadoraSubtrairResultado1Negativo()
    {
        //Arrange
        CalculadoraImp c = new CalculadoraImp();
        //Act
        int resultado = c.Subtrair(1, 2);
        //Assert
        Assert.Equal(-1, resultado);
    }

    [Fact]
    public void TesteCalculadoraMultiplicarResultado2()
    {   
        //Arrange
        CalculadoraImp c = new CalculadoraImp();    
        //Act
        int resultado = c.Multiplicar(1, 2);
        //Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TesteCalculadoraDividirResultado2()
    {
        //Arrange   
        CalculadoraImp c = new CalculadoraImp();
        //Act   
        int resultado = c.Dividir(4, 2);
        //Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TesteCalculadoraDividirPorZero()
    {
        //Arrange
        CalculadoraImp c = new CalculadoraImp();
        //Act & Assert    
        Assert.Throws<System.DivideByZeroException>(() => c.Dividir(4, 0));
    }   

    [Fact]
    public void TesteCalculadora4EhPar()
    {
        //Arrange
        CalculadoraImp c = new CalculadoraImp();
        //Act
        bool resultado = c.EhPar(4);
        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6 })]

    public void TesteCalculadoraEhImpar(int[] numeros)
    {
        //Arrange
        CalculadoraImp c = new CalculadoraImp();
        //Act & Assert
        Assert.All(numeros, x => Assert.True(c.EhPar(x)));
    }


}