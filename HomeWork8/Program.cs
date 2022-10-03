// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("введите количество строк");
int Cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int Rows = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[Cols, Rows];
CreateRandomArray(array);
Console.WriteLine();
ShowArray(array);

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//     {
//         for (int n = 0; n < array.GetLength(1) - 1; n++)
//         {
//             if (array[i, n] < array[i, n + 1]) 
//             {
//                 int temp = 0;
//                 temp = array[i, n];
//                 array[i, n] = array[i, n + 1];
//                 array[i, n + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();

// ShowArray(array);

void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
                for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
                Console.WriteLine("");
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
void NumbersRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}
NumbersRow(array);


//  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int len = 4;
int[,] array = new int[len, len];
CreateRandomArray(array, len);
ShowArray(array);

void CreateRandomArray(int[,] array, int n)
{
    int i = 0, j = 0;
    int temp = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = temp++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = temp++;
        for (k = 0; k < n - 1; k++) array[i, j--] = temp++;
        for (k = 0; k < n - 1; k++) array[i--, j] = temp++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}