// See https://aka.ms/new-console-template for more information
int[] notasmaria = new int[5];
int[] notasjoao = new int[5];
int[] notasbastiao = new int[5];
int[] notasbastiana = new int[5];
Console.WriteLine("Digite as 5 notas de Maria:");
for(int i=0; i<5;i++)
{
    notasmaria[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Digite as 5 notas de Joao:");
for (int i = 0; i < 5; i++)
{
    notasjoao[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Digite as 5 notas de Bastiao:");
for (int i = 0; i < 5; i++)
{
    notasbastiao[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Digite as 5 notas de Bastiana:");
for (int i = 0; i < 5; i++)
{
    notasbastiana[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nMaria; " + CalcularMedia(notasmaria));
Console.WriteLine("\nJoao; " + CalcularMedia(notasjoao));
Console.WriteLine("\nBastiao; " + CalcularMedia(notasbastiao));
Console.WriteLine("\nBastiana; " + CalcularMedia(notasbastiana));
static char CalcularMedia(int[] notas)
{
    int soma = 0;
    foreach(var nota in notas)
    {
        soma += nota;
    }

    int media = soma / 5;

    if (media >= 9) return 'A';
    else if (media >= 7) return 'B';
    else if (media >= 5) return 'C';
    else if (media >= 3) return 'D';
    else return 'E';
}
