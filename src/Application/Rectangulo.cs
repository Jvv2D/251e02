// code .\src\Application\Rectangulo.cs
namespace Application;

public static class Rectangulo
{
    public static double CalcularPerimetro(double longitud, double Ancho)
    {
        return longitud + longitud + Ancho + Ancho;
    }
    public static double CalcularArea(double longitud, double Ancho)
    {
        return longitud * Ancho;
    }
}