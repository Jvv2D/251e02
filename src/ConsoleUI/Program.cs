// code .\src\ConsoleUI\Program.cs
double perimetro;
double area;
double volumen;
double ancho;

Console.WriteLine("Calculadora de Perímetro y Area del Rectangulo; y Volumen de un Prisma Rectangular");

Console.Write("Dame el longitud: ");
double longitud = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame el Ancho: ");
double Ancho = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

perimetro = Application.Rectangulo.CalcularPerimetro(longitud, Ancho);
area = Application.Rectangulo.CalcularArea(longitud, Ancho);

volumen = Application.PrismaRectangular.CalcularVolumen(area, altura);

Console.WriteLine();
Console.WriteLine($"Perímetro: {perimetro}cm\nÁrea: {area}cm2\nVolumen {volumen}cm3");
