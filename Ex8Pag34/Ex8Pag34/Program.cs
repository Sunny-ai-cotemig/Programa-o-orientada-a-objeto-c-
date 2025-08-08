using Ex8Pag34.Models;

Triangulo Triangulo = new Triangulo();
Retangulo Retangulo = new Retangulo();
Circulo Circulo = new Circulo();
Trapezio Trapezio = new Trapezio();

Console.WriteLine("Ecreva o valor da altura");
int Altura = int.Parse(Console.ReadLine());
Console.WriteLine("Ecreva o valor da base maior");
int BaseMaior = int.Parse(Console.ReadLine());
Console.WriteLine("Ecreva o valor da base menor");
int BaseMenor = int.Parse(Console.ReadLine());
Console.WriteLine("Ecreva o valor do raio");
int Raio = int.Parse(Console.ReadLine());

double AreaTriangulo = Triangulo.CalcularArea(BaseMaior,Altura,BaseMenor,Raio);
double AreaRetangulo = Retangulo.CalcularArea(BaseMaior, Altura, BaseMenor, Raio);
double AreaCirculo = Circulo.CalcularArea(BaseMaior, Altura, BaseMenor, Raio);
double AreaTrapezio = Trapezio.CalcularArea(BaseMaior, Altura, BaseMenor, Raio);

Console.WriteLine($"Valor da area do triangulo {AreaTriangulo}");
Console.WriteLine($"Valor da area do retangulo {AreaRetangulo}");
Console.WriteLine($"Valor da area do circulo {AreaCirculo}");
Console.WriteLine($"Valor da area do trapezio {AreaTrapezio}");