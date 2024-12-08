// code .\test\Application.UnitTest\UnitTestPrismaRectangular.cs
namespace Application.UnitTest;

public class UnitTestPrismaRectangular
{
    [Theory]
    [InlineData(16, 4, 64)]
    [InlineData(25, 6, 150)]
    
    public void TestVolumen(double area, double altura, double volumen)
    {
        // Arrange – Set up


        // Act – Perform
        double resultado = PrismaRectangular.CalcularVolumen(area, altura);
        
        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}