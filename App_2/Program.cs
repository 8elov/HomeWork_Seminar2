// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number > 99 && number < 1000)
{
    int a3 = number % 10;
    Console.Write("Третья цифра: " + a3);
}

if (number < 100)
{
    Console.Write("Третьей цифры нет");
}

if (number > 999)
{
    while(number > 999)
    {
        number = number / 10;
    }
int a3 = number % 10;
Console.Write("Третья цифра: " + a3);
}



