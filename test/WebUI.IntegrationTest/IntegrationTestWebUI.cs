// code .\test\WebUI.IntegrationTest\IntegrationTestWebUI.cs
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace WebUI.IntegrationTest;

// La clase implementa IClassFixture para inicializar la fábrica
public class IntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient httpClient;

    // Constructor para inicializar la fábrica y el cliente HTTP
    public IntegrationTests(WebApplicationFactory<Program> factory)
    {
        httpClient = factory.CreateClient();
    }

    // Prueba parametrizada para múltiples páginas
    [Theory]
    [InlineData("Index")]
    [InlineData("Privacy")]
    
    

    public async Task TestGetPages(string url)
    {
        // Act: realiza una solicitud GET a la URL proporcionada
        var response = await httpClient.GetAsync(url);

        // Assert: verifica que la respuesta sea exitosa
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        
    }

    [Theory]
[InlineData("Hola")]
[InlineData("Mundo")]
[InlineData("Como")]
public async Task TestPages_ReturnsSuccess(string page)
{
    var response = await httpClient.GetAsync(page);
    response.EnsureSuccessStatusCode(); // Verifica que el código sea 2xx
}

}













