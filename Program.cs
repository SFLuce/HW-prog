// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

 void SortOfElements(int[,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
       {
           for (int k = 0; k < array.GetLength(1)-1; k++)
          {
                 if (array[i,k] < array[i,k+1]) 
                {
                int temp = array[i,k];
                array[i,k] = array[i,k+1];
                array[i,k+1] = temp;
                }
            }
         }  
    } 
}

int[,] myArray = Create2DRandomArray(4, 5, 0, 30);
Print2DArray(myArray);
Console.WriteLine();
SortOfElements(myArray);
Print2DArray(myArray);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void NumberOfRowMinSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int j= 0; j < array.GetLength(1); j++)
    {
        minRow += array[0, j];
    }
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Row of minimum sum -> {minSumRow +1}");
}

int[,] myArray = Create2DRandomArray(5, 4, 0, 10);
Print2DArray(myArray);
NumberOfRowMinSum(myArray);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrixProdukt(int[,] matrix1, int[,] matrix2)
{
    int row1 = matrix1.GetLength(0); int col1 = matrix1.GetLength(1);
    int row2 = matrix2.GetLength(0); int col2 = matrix2.GetLength(1);
    int[,] matrix3 = new int[row1,col2];
    for (int i = 0; i <row1; i++)
    {
       for (int j = 0; j < col2; j++)
       {
        for (int n = 0; n < col1; n++)
            {
               
                matrix3[i,j] += matrix1[i,n] * matrix2[n,j];
            }
       }
    }
    return matrix3;
}

int[,] array1= Create2DRandomArray(2, 2, 0, 10);
Print2DArray(array1);
int[,] array2= Create2DRandomArray(2, 2, 0, 10);
Print2DArray(array2);
Console.WriteLine();
Print2DArray(MatrixProdukt(array1, array2));


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DRandomArray(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, depth];
        for (int i = 0; i <rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
            for (int k = 0; k < depth; k++)
            {
            array[i,j,k]= new Random().Next(minValue, maxValue+1);
            }
       }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
             for (int k = 0; k < array.GetLength(2); k++)
             {
                Console.Write($"{array[i,j,k]}({i},{j} ,{k}) \t");
             }
              Console.WriteLine();
        }
               Console.WriteLine();
    }
}

 int[,,] myArray = Create3DRandomArray(2, 2, 2, 0, 30);
Print3DArray(myArray);






// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07