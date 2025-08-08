using pag27ex02.models;

banco banco = new();
double valorconta = 0;
Console.WriteLine("\n  insira um valor para ser depositado a sua conta.");
double valor = double.Parse(Console.ReadLine());

valorconta = banco.depositar(valorconta, valor);

Console.WriteLine("seu valor foi depositado com sucesso!!");

Console.WriteLine("\n seu valor na sua conta é " + banco.verificarsaldo(valorconta));

Console.WriteLine("insira um valor para ser sacado da sua conta.");
valor = double.Parse(Console.ReadLine());

Console.WriteLine(banco.sacar(valorconta, valor));