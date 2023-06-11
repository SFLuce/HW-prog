// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];
//     Random random = new Random();
//      for (int i = 0; i <rows; i++)
//     {
//        for (int j = 0; j < columns; j++)
//        {
//             array[i,j]= Math.Round(random.Next(minValue, maxValue+1)+ random.NextDouble(),2);
//        }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i <array.GetLength(0); i++)
//     {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//         Console.Write(array[i,j] + "\t");
//        }
//         Console.WriteLine();
//     }  
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minValue of element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue of element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
        for (int i = 0; i <rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
            array[i,j]= new Random().Next(minValue, maxValue+1);
       }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write(array[i,j] + "\t");
       }
        Console.WriteLine();
    }  
}

// int[,] myArray = Create2DRandomArray(6, 5, 0, 50);
// Print2DArray(myArray);
// Console.WriteLine("Input index of row: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input index of column: ");
// int m = Convert.ToInt32(Console.ReadLine());

//   if (n < 0 || n > myArray.GetLength(0) - 1 || m < 0 | m > myArray.GetLength(1) - 1)
// {
//     Console.WriteLine("Элемент не существует ");
// }
//     else
//     {
//     Console.WriteLine("Значение элемента массива = {0}", myArray[n, m]);
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] myArray = Create2DRandomArray(4, 4, 0, 10);
 Print2DArray(myArray);

void FindAverage(int[,] array)
{
   for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
         int n = array.GetLength(0);
        for (int i = 0; i <array.GetLength(0); i++)
       {
             sum = sum + array[i,j];
        }
         Console.WriteLine($"Average of {j} column =  { sum/n }");
    }
     }
  FindAverage(myArray);



