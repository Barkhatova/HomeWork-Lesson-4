// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int[,] CreateRandom2darrayay(int m, int n){
//     int[,] arrayay = new int[m,n];
//     for(int i = 0; i<m; i++)
//         for(int j = 0; j<n; j++)
//             arrayay[i,j] = new Random().Next();
//     return arrayay;
// }

// void Show2darrayay(int[,] arrayay){
//     for(int i = 0; i<arrayay.GetLength(0); i++){
//         for(int j = 0; j<arrayay.GetLength(1); j++){
//             Console.Write(arrayay[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input numb of m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,]arrayay = CreateRandom2darrayay(m,n);
// Show2darrayay(arrayay);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2darrayay(int rows, int cols){
//     int[,] arrayay = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             arrayay[i,j] = new Random().Next();
//     return arrayay;
// }
// void Show2darrayay(int[,] arrayay){
//     for(int i = 0; i<arrayay.GetLength(0); i++){
//         for(int j = 0; j<arrayay.GetLength(1); j++){
//             Console.Write(arrayay[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,]arrayay = CreateRandom2darrayay(rows,cols);
// Show2darrayay(arrayay);

// Console.Write("Input x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] arrayay1 = new int[x, y];

// if (x < arrayay.GetLength(0) && y < arrayay.GetLength(1)) Console.WriteLine(arrayay[x, y]);
// else Console.WriteLine($"{rows}{cols} -> такого числа в массиве нет");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Random random = new Random();
int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("  ");
Console.WriteLine(array.GetLength(0));
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
}
Console.ReadLine();