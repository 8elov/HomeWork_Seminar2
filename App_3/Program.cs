// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number > 0 && number < 8)
{
    if (number > 0 && number < 6)
    {
        Console.WriteLine("Будний день");
    }

    if (number == 6 || number == 7)
    {
    Console.WriteLine("Выходной день");
    }
}
else
{
    Console.WriteLine("Дня недели с таким индексом не существует");
}