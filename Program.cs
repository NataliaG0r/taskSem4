// Урок 4. Функции
// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("введите первое число(основание)");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число(степень)");
int b = Convert.ToInt32(Console.ReadLine());
if ((b > 0) && (b % 1 == 0))
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    System.Console.WriteLine(result);
}

else System.Console.WriteLine($"{b}не является натуральным числом");



// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.WriteLine("введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num / 10 != 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
System.Console.WriteLine(sum + num);



// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]




int n = 8;
int[] arr = GetArray(n);

int[] GetArray(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine("введите  число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write(arr[i] + " ");
}
