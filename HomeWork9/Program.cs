// ЗЗадайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N


// Запрос данных от пользователя

//  int ReadData(string line)
//     {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine()?? "1");
//     return num;
//     }


//  Рекурсия числа от M до N

// string NumMN (int M, int N)
//     {
//     if (M>N) return "";  // остановка
//     else {
//     string outLine = M + " " + NumMN(M+1,N);
//     return outLine;
//     }
//     }
// void PrintData(string prefix, string num)
//     {
//     Console.WriteLine(prefix+num);
//     }

// int M = ReadData("ВВедите число M: ");
// int N = ReadData("ВВедите число N: ");
// string res = (M<N)? (NumMN(M,N)):(NumMN(N,M));
// PrintData ("Числа в промежутке от заданных чисел: ", res);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// Запрос данных от пользователя

//  int ReadData(string line)
//     {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine()?? "1");
//     return num;
//     }


// // Рекурсия числа от M до N

// int SumMN (int M, int N)
//     {
//     if (M>=N) return N; //остановка
//     else {
//     int outLine = M+ SumMN(M+1,N);
//     return outLine;
//     }
//     }
   
// void PrintData(string prefix, string num)
//     {
//     Console.WriteLine(prefix+num);
//     }


// int M = ReadData("ВВедите число M: ");
// int N = ReadData("ВВедите число N: ");
// int sum = 0;
// if (M < N)  sum = SumMN(M,N);
// else  sum = SumMN(N,M);
// PrintData("Сумма элементов в промежутке заданного числа: ", sum.ToString());


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// / Запрос данных от пользователя

 int ReadData(string line)
    {
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()?? "1");
    return num;
    }

 // Рекурсия числа от M до N

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
   
void PrintData(string prefix, string num)
    {
    Console.WriteLine(prefix+num);
    }


int m = ReadData("ВВедите число m: ");
int n = ReadData("ВВедите число n: ");
int akker = Akkerman(m,n);
PrintData("Вычисление функции Аккермана: ", akker.ToString());


