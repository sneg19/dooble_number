// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int num0 = number / 1000;
if (num0 == 0)
{
int num = number /10;
int num2 = num % 10;

Console.WriteLine($"Вторая цифра {number} это {num2}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}