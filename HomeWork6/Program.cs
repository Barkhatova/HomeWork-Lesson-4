// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write($"Введи число N(количество чисел): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] Numbers = new int[n];

// void Show(int n){
// for (int i = 0; i < n; i++)
//   {
//     Console.Write($"Введи {i+1} число: ");
//     Numbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }
// Show(n);

// int Sum(int[] Numbers)
// {
//   int count = 0;
//   for (int i = 0; i < Numbers.Length; i++)
//   {
//     if(Numbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }
// Console.WriteLine($"Чисел больше 0: {Sum(Numbers)} ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите число k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());


int x = (-b2 + b1)/(-k1 + k2);
int y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");