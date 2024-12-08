// code .\test\Application.UnitTest\UnitTestRectangulo.cs
namespace Application.UnitTest;

public class UnitTestCuadrado
{
    [Theory]
    [InlineData(1,4,10)]
    [InlineData(2,8,20)]
    [InlineData(3,12,30)]
    [InlineData(4,16,40)]
    [InlineData(5,20,50)]
    public void TestPerimetro(double longitud, double Ancho, double perimetro)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Rectangulo.CalcularPerimetro(longitud, Ancho);

        // Assert – Verify
        Assert.Equal(perimetro, resultado);
    }

    [Theory]
    [InlineData(1,1,1)]
    [InlineData(2,4,8)]
    [InlineData(3,9,27)]
    [InlineData(4,16,64)]
    [InlineData(5,25,125)]
    public void TestArea(double longitud, double Ancho, double area)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Rectangulo.CalcularArea(longitud, Ancho);

        // Assert – Verify
        Assert.Equal(area, resultado);
    }
}