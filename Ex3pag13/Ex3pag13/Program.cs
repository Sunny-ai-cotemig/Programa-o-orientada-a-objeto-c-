// See https://aka.ms/new-console-template for more information


static int Somar(int a, int b)
{
    return a + b;
}

int a, b, c, resulsoma;

Console.WriteLine("Escreva os valores de a, b e c, a programação vai mostra se a soma de A+B é menor que C ou não");

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

resulsoma = Somar(a, b);

if(resulsoma > c)
{
    Console.WriteLine("A soma não é menor que C");
}
else
{
    Console.WriteLine("A soma é menor que C");
}