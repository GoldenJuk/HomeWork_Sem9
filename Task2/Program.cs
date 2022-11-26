// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,10}", array[i, j]);
            sum = sum + array[i, j];
        }
        Console.Write($"   Сумма элементов: {sum}");
        Console.WriteLine();
    }
}
int FindRowWithSummin(int[,] array)
{
    int[] sumElementsInRows = new int[array.GetLength(0)];
    int numRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];    
        }
        sumElementsInRows[i] = sum;
    }
    for (int i = 1; i < sumElementsInRows.Length - 1; i++)
    {
        int min = sumElementsInRows[0];

        if (sumElementsInRows[i] < min)
        {
            numRow = i;
        }
    }
    return numRow;
}    

Console.Write("Введите размер прямоугольного двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arrayRandom = new int[m, m];
Console.WriteLine();

FillArray(arrayRandom);
PrintArray(arrayRandom);
Console.WriteLine();

int numberOfRow = FindRowWithSummin(arrayRandom);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberOfRow+1}");

Console.ReadKey();