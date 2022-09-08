// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrom (string num){

//     if (num[0] == num[4] || num[1]==num[3])     Console.WriteLine ("Число является палиндромом");
//     else Console.WriteLine ("Число не является палиндромом");}

// Console.Write("Введите 5-ти значное число: ");
// string num = Console.ReadLine();
// if (num!.Length == 5) Palindrom (num);
// else Console.WriteLine("Некорректный ввод");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// int cube (int N)
// {
//     Console.Write(N*N*N + ",");
//     return N;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= num){
//     cube(i);
//     i++;
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Подход: формула для расстояния между двумя точками в 3-х измерениях, т.е. (x1, y1, z1) и (x2, y2, z2) была получена из теоремы Пифагора, которая такова:
// Расстояние = $ \ sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} $ 


// Console.Write("Введите координаты x1: ");
// double x1= Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты y1: ");
// double y1= Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты z1: ");
// double z1= Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты x2: ");
// double x2= Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты y2: ");
// double y2= Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты z2: ");
// double z2= Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)));

// ИЛИ, сделала через функцию, но не вижу в ней необходимости

Console.Write("Введите координаты x1: ");
double x1= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y1: ");
double y1= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z1: ");
double z1= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты x2: ");
double x2= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y2: ");
double y2= Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z2: ");
double z2= Convert.ToDouble(Console.ReadLine());



double average(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt((x2-x1)*(x2-x1) + 
                   (y2-y1)*(y2-y1) + 
                   (z2-z1)*(z2-z1));
}

double Length =  average(x1, x2, y1, y2, z1, z2);

Console.WriteLine("Расстояние между точками " + Length);




