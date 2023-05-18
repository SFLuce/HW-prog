// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// bool Palyndrom(int num)
// {
//     if (num/10000 == num % 10 && num/1000 %10 == num/10 % 10) return true;
//     else return false;
// }
// Console.WriteLine("Введите пятизначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num<10000)
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
//     return;
// }
// Console.WriteLine($"{num} -> {Palyndrom(num)}");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindSection(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)),2);
}
Console.WriteLine("Input coordinate X to A:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Y to A:");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Z to A:");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate X to B:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Y to B:");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Z to A:");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Length AB -> {FindSection(xa, ya, za, xb, yb, zb)}");



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube (int num)
// {
//     int i = 1;
//     while (i<=num)
//     {
//         Console.WriteLine($"{i} -> {i*i*i}");
//         i++;
//     }
// }
// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Cube(num);

