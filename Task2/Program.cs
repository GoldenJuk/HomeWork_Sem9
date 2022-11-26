// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N

Console.Clear();

int GetSum(int left, int right)
{
    int sum = 0;
    sum = sum + left;

    if (left == right) return sum;
    return sum + GetSum(left + 1, right);
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int result = GetSum(m, n);
Console.WriteLine(result);

Console.ReadKey();