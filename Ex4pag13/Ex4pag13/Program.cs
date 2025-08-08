// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite em valores booleanos");
bool a = bool.Parse(Console.ReadLine());
Console.WriteLine("Escreva o outro valor");
bool b = bool.Parse(Console.ReadLine());


if(a == true && b== true)
{
    Console.WriteLine("Os valores são verdadeiros");
}
else if (a==false && b== false)
{
    Console.WriteLine("Os valores são falsos ");
}
else
{
    Console.WriteLine("Os valores são falsos ");
}



