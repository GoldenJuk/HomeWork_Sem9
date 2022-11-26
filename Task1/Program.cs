// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

void GetListNumber(int number)
{
    Console.Write($"{number}, ");

    if (number == 2)
    {
        Console.WriteLine("1");
        return;
    }
    GetListNumber(number - 1);
}

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

GetListNumber(n);

Console.ReadKey();