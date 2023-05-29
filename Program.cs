// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateArrey(int size)
// {
//     int[] arrey = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Input three-digit element of arrey {i}:  ");
//         arrey[i]=Convert.ToInt32(Console.ReadLine());
//     }
//     return arrey;
// }
// int CountEven(int[] arrey)
// {
//     int count = 0;
//     for (int i = 0; i < arrey.Length; i++)
//     {
//         if (arrey[i] %2 ==0) count++;
//     }
//     return count;
// }
// int[] myArrey = CreateArrey(5);
// Console.WriteLine($"Count even-digit in arrey -> {CountEven(myArrey)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

// int[] CreateArrey(int size, int minValue, int maxValue)
// {
//     int[] newArrey = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArrey[i]= new Random().Next(minValue, maxValue+1);
//     }
//     return newArrey;
// }
// void PrintArrey(int[] arrey)
// {
//     for (int i = 0; i < arrey.Length; i++)
//     {
//         Console.Write(arrey[i] + " ");
//     }
// }

// int SumOddIndex(int[] arrey)
// {
//     int sum = 0;
//     for (int i = 1; i < arrey.Length; i+=2)
//     {
//         sum += arrey[i];
//     }
//     return sum;
// }

// int[] myArrey = CreateArrey(10, -100, 100);
// PrintArrey(myArrey);
// Console.WriteLine();
// Console.WriteLine($"Sum elements in odd index -> {SumOddIndex(myArrey)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArrey(int size, int minValue, int maxValue)
{
   double[] newArrey= new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        newArrey[i]= rand.Next(minValue, maxValue+1)+ rand.NextDouble();
    }
    return newArrey;
}

void PrintArrey(double[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write(arrey[i] + " ");
    }
}


double[] myArrey = CreateArrey(5, -10, 10);

PrintArrey(myArrey);
Console.WriteLine();
Console.WriteLine($"Difference Max & Min elements -> {myArrey.Max()- myArrey.Min()}");

