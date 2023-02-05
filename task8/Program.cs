// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int A = 2;
int rem = N % 2;
if (rem == 0)
{
    while (A <= N)
{
    Console.Write($"{A} ");
    A = A + 2;
}
}
else
{
    while (A < N)
{
    Console.Write($"{A} ");
    A = A + 2;
}
}