// Task1. Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// 5,7 =7
// 2,10 = 10
// -9, -3 = -3

// Console.Write("Введите первое число: ");
// int num1  = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.WriteLine($"Первое число {num1} больше чем второе {num2}");
// }
// else
// {
//     Console.WriteLine($"Второе число {num2} больше чем первое {num1}");
// }

//Task2. Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

/* 2,3,7 = 7
44,5,78 = 78
22,3,9 = 22*/


// Console.Write("Введите первое число: ");
// int num1  = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число:");
// int num3 = Convert.ToInt32(Console.ReadLine());


// int max = num1;

// if(num2 > max)
//     max = num2;
// else
//     num1 = max;

// if(num3 > max)
//     max = num3;
// else
//     num2 = max;

// Console.WriteLine("Самое большое число:" + max);




//Task3. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/* 4 = четное
-3 = не четное
7 = не четное*/


// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine(" Число четное!");
// }
// else
// {
//     Console.WriteLine("Число нечетное!");
// }




//Task4.  Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
/* 5  = 2,4
8 = 2,4,6,8*/

// Console.WriteLine("Введите число:");
// int  num = Convert.ToInt32(Console.ReadLine());

// int current = 1;

// while(current <= num)
// {
//     if (current % 2 ==0)
//     {
//         Console.Write(current + ",");
//     }
//     current++;
// }
