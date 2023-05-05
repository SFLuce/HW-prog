// HW001 Найти максимальное из двух чисел

// Console.WriteLine("Input a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input b");
// int b = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (a > b)
// {
//     Console.Write($"Max -> {max}");
// }
// else
// {
//     Console.Write($"Max -> {b}");
// }

// HW002 Найти максимальное из трех чисел

// Console.WriteLine("Input a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input c");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// Console.WriteLine($"Max = {max}");

// HW003 Определить четность числа

// Console.WriteLine("Input  number");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n %2 == 0)
// {
//     Console. WriteLine($"{n} -> even number");
// }
// else
// {
//     Console.WriteLine($"{n} -> uneven number");
// }

// HW004 Вывести все четные числа из ряда от 1 до N 

Console.WriteLine("Input  N");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (count <= n)
{
    if (count %2 == 0)
    {
        Console.Write($"{count} ","" );
     }
     count++;
}

