// code .\test\Application.IntegrationTest\IntegrationTestApplication.cs
namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(4, 4, 64,1024)]
    [InlineData(5, 6, 150,4500)]
    
    public void TestVolumen(double longitud, double Ancho, double altura, double volumen)
    {
        // Arrange – Set up
        double area = Rectangulo.CalcularArea(longitud, Ancho);

        // Act – Perform
        double resultado = PrismaRectangular.CalcularVolumen(area, altura);

        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}