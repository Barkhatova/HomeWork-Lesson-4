//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Arg (int A, int B){
//     int result = 1;
//         for (int curr = 1; curr <= B; curr++){
//         result= result*A;}
//         return result;
//     }
// Console.WriteLine("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int rez = Arg(A,B);
// Console.WriteLine($" число {A} в степени {B} равняется {rez}");

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
//   int Sum(int num){
//    int size = Convert.ToString(num).Length;
//    int result = 0;

//     for (int i = 0; i < size; i++){
//       result += num % 10;;
//       num = num / 10;
//     }
//    return result;
//   }
// int sum = Sum(num);
// Console.WriteLine("Сумма цифр в числе: " + sum);


// Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next();
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size));


