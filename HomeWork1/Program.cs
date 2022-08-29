//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
int a;
int b;

Console.Write("Введи число a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число b: ");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("{0} max", a, b);
}
else
{
     Console.WriteLine("{1} max", a, b);
}

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1;
int num2;
int num3;

Console.Write("Введи число num1: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число num2: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число num3: ");
num3 = Convert.ToInt32(Console.ReadLine());

int maxnum = 0;

if (num1 > maxnum)   maxnum = num1;
if (num2 > maxnum)   maxnum = num2;
if (num3 > maxnum)   maxnum = num3;
        
Console.WriteLine("максимальное из трех " + maxnum);

*/

/*
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("НЕТ!");
}
*/
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " , ");
                    not = false;
                }
                i++;
            }


