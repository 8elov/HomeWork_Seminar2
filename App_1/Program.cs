// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
int a1 = number / 100;
int a2 = number % 100 / 10;
int a3 = number % 10;

Console.WriteLine("Вторая цифра числа: " + a2);
}
else
{
    Console.WriteLine("Число должно быть трёхзначным");
}

