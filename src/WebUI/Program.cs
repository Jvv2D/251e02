// code .\src\WebUI\Startup.cs

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.MapRazorPages();





// Definir rutas sin controladores
app.MapGet("/Hola", () => "Página Hola funcionando correctamente.");
app.MapGet("/Mundo", () => "Página Mundo funcionando correctamente.");
app.MapGet("/Como", () => "Página Como funcionando correctamente.");

// Otras configuraciones necesarias
app.Run();



public partial class Program { }
