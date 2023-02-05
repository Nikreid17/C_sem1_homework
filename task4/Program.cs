// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numC = int.Parse(Console.ReadLine());
if (numB > numA)
{
    if (numB > numC)
    {
        Console.WriteLine($"Максимальным является число {numB}");
    }
    else
    {
        Console.WriteLine($"Максимальным является число {numC}");
    }
}
else
{
    if (numA > numC)
    {
        Console.WriteLine($"Максимальным является число {numA}");
    }
    else
    {
        Console.WriteLine($"Максимальным является число {numC}");
    }
}
