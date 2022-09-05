// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

// int Number2() 
// {
// int num = new Random().Next(100,1000);
// Console.WriteLine("Number is - " +num);
// int num2 = (num/10) % 10;
// int result = num2;
// return result;
// }
// int number = Number2();
// Console.WriteLine("2 цифра числа - " + number);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

// Console.WriteLine("Введите числo: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string textnumber = Convert.ToString(number);

// if (number/100 > 0)
// {
//    Console.WriteLine( "третья цифра заданного числа: "+ textnumber[2]); 
// }
// else{
//     Console.WriteLine("третьей цифры нет");
// }

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// пн, вт, ср, чт, пт, суб, вск
// 0    1   2   3   4   5   6
Console.WriteLine("Введите числo: ");
int number = Convert.ToInt32(Console.ReadLine());
string textnumber = Convert.ToString(number);

if (number >=5)
{
   if (number <7 )
   {
   Console.WriteLine( "да, выходной"); 
}
else {
     Console.WriteLine( "такого дня не существует");
}}
else{
    Console.WriteLine("нет, будний");
}
