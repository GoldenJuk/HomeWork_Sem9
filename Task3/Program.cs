// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Clear();

int GetAckermanFunction(int num1, int num2)
{
    if (num1 == 0)
        return (num2 + 1);

    else
        if (num1 > 0 && num2 == 0)
        return GetAckermanFunction(num1 - 1, 1);

    else
        return GetAckermanFunction(num1 - 1, GetAckermanFunction(num1, num2 - 1));
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (m > 0 && n > 0)
{
    int result = GetAckermanFunction(m, n);
    Console.WriteLine($"Результат вычисления функции Аккермана для двух неотрицательных чисел {m} и {n} = {result}");
}
else Console.WriteLine("Введите неотрицательные числа.");

Console.ReadKey();