using ExerciciosFixacao;
using System.Globalization;

Conta conta;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Entre com o titular da conta: ");
string titular = Console.ReadLine();

Console.Write("Haverá deposito inicial? (s/n): ");
char haveraDeposito = char.Parse(Console.ReadLine());

if (haveraDeposito == 's' || haveraDeposito == 'S')
{
    Console.Write("Entre com o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    conta = new Conta(numero, titular, depositoInicial);
}
else
{
    conta = new Conta(numero, titular);
}
Console.WriteLine();
Console.WriteLine($"Dados da conta: \n{conta}");
Console.WriteLine();
Console.WriteLine("Entre com um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);

Console.WriteLine($"Dados da conta atualizados: \n{conta}");

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);
Console.WriteLine($"Dados da conta atualizados: \n{conta}");