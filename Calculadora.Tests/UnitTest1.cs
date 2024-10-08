namespace Calculadora.Tests;

public class UnitTest1
{

    public Calculadora construirClasse()
    {
        string data = "22/10/2024";
        Calculadora calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        construirClasse();

        int resultadoCalculo = construirClasse().somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculo);
    }


    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(10, 5, 5)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        construirClasse();

        int resultadoCalculo = construirClasse().subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculo);
    }

    [Theory]
    [InlineData(3, 2, 6)]
    [InlineData(3, 5, 15)]
    public void TesteMultriplicar(int val1, int val2, int resultado)
    {
        construirClasse();

        int resultadoCalculo = construirClasse().multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculo);
    }


    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 5, 2)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        construirClasse();

        int resultadoCalculo = construirClasse().dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculo);
    }


    [Fact]
    public void TestarDivisaoPorZero()
    {
        construirClasse();

        Assert.Throws<DivideByZeroException>(
             () => construirClasse().dividir(3, 0)
             );
    }

    [Fact]
    public void TestarHistorico()
    {
        var calculadora = construirClasse();

        calculadora.somar(1, 2);
        calculadora.somar(3, 2);
        calculadora.somar(2, 4);
        calculadora.somar(4, 5);


        var lista = calculadora.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

}