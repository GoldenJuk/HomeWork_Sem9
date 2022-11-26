// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,10}", array[i, j]);
        }
        Console.WriteLine();
    }
}
void MakeSortEachRow(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[m,j] > array[m,i])
                {
                    int temp = array[m,i];
                    array[m,i] = array[m,j];
                    array[m,j] = temp;
                }
            }
        }
    }
}

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arrayRandom = new int[m, n];
Console.WriteLine();

FillArray(arrayRandom);
Console.WriteLine("Исходный массив: ");
Console.WriteLine();
PrintArray(arrayRandom);
Console.WriteLine();

MakeSortEachRow(arrayRandom);
Console.WriteLine("Упорядоченный массив: ");
Console.WriteLine();
PrintArray(arrayRandom);

Console.ReadKey();