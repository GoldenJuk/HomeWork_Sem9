// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц

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
int[,] GetMultTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multArray = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
    int resElemetnt = 0;

    //Первым циклом (m) формируем строки результирующей матрицы. Втрорым (n) - столбцы. Циклом i делаем операции умножения матриц.
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix1.GetLength(0); n++)
        {
           resElemetnt = 0;
            
            for (int i = 0; i < matrix1.GetLength(1); i++)
            {
                resElemetnt = resElemetnt + matrix1[m, i] * matrix2[i, n];
            }
            multArray[m, n] = resElemetnt;
        }
    }
    return multArray;
}

Console.Write("Введите количество строк первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (m1 == n2 || n1 == m2)
{
    int[,] arrayRandom1 = new int[m1, n1];
    Console.WriteLine();

    FillArray(arrayRandom1);
    Console.WriteLine("Исходная первая матрица: ");
    Console.WriteLine();
    PrintArray(arrayRandom1);
    Console.WriteLine();

    int[,] arrayRandom2 = new int[m2, n2];
    Console.WriteLine();

    FillArray(arrayRandom2);
    Console.WriteLine("Исходная вторая матрица: ");
    Console.WriteLine();
    PrintArray(arrayRandom2);
    Console.WriteLine();

    int[,] multMatrix = new int[m1, m1];

    multMatrix = GetMultTwoMatrix(arrayRandom1, arrayRandom2);
    Console.WriteLine("Произведение двух матриц: ");
    Console.WriteLine();
    PrintArray(multMatrix);
}
else
{
    Console.WriteLine("Вы ввели несогласованные матрицы (количество столбцов матрицы 1 не равно количеству строк матрицы 2), поробуйте еще раз");
}

Console.ReadKey();