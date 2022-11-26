// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(int[,,] array)
{
    // Формируем одномерный массив из неповторяющихся двузначных чисел, размером m*n*k

    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    
    tempArray[0] = new Random().Next(10, 100);

    for (int i = 1; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(10, 100);

        for (int j = 0; j <= i - 1; j++)
        {
            if (tempArray[i] == tempArray[j])
            {
                tempArray[i] = new Random().Next(10, 100);
                j = 0;
            }
        }
    }

    // Забрасываем элементы из одномерного массива в трехмерный

    int r = 0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (int p = 0; p < array.GetLength(2); p++)
            {
                while (array[m, n, p] == 0)
                {
                    array[m, n, p] = tempArray[r];
                    r++;
                }
                Console.WriteLine($"Элемент под номером [{m}, {n}, {p}] = {array[m, n, p]}");
            }
        }
    }
}

Console.Write("Введите первую размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью размерность массива: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] multidimArray = new int[m, n, k];
FillArray(multidimArray);

Console.ReadKey();