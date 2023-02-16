// Task1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = ThreeNum("Введите трехзначное число: ");
// if (number < 100 || number >= 1000)
//     Console.WriteLine("Вы ввели не трехзначное число");
// else
//     Console.WriteLine(InCenter(number));

// int ThreeNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int InCenter(int a)
// {
//     int result = ((a / 10) % 10);
//     return result;
// }


//Тask2.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdNum(int num)
// {
//     while (num > 999)
//     {
//         num /= 10;
//     }
//     return num % 10;
// }

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool whatNumber(int num)
// {
// if (num < 100 || num > 1000)
// {
//     Console.WriteLine("число не трехначное: ");
//     return false;
// }
// return true;
// }

// if (whatNumber(num))
//     Console.WriteLine(ThirdNum(num));

//Task3.
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// булевый метод

// bool Weekend (int Day)
// {
//     if (Day > 5)
//         return true;
//     return false;
// }

// Console.WriteLine("Введите день недели!");
// int Day = Convert.ToInt32(Console.ReadLine());
// if(Weekend(Day))
// {
//     Console.WriteLine("Сегодня выходной!");
// }
// else
// {
//     Console.WriteLine("Сегодня рабочий день");
// }