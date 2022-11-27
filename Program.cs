/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*Console.WriteLine("Enter A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B");
int B = Convert.ToInt32(Console.ReadLine());
var result = Math.Pow(A,B);
Console.WriteLine($"The result is {Math.Pow(A,B)}");*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigit(int num)
{
    int counter = Convert.ToString(num).Length;
    int sumDigit = 0;
    int result = 0;
    for(int i = 0; i < counter; i++)
    {
        sumDigit = num - num % 10;
        result = result + (num - sumDigit);
        num = num / 10;
    }
    return result;
}
int SumDigit = sumDigit(num);
Console.WriteLine($"The sum of digits in a number - {SumDigit}");*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

/*int [] array = new int [8];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,1500);
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("]");*/




















