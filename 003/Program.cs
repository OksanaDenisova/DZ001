//ЗАДАЧА1
/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 > нет;  12821 -> да; 23432 -> да    */
// как во второй домашке второго семинара бегать по числам
//

// Console.Write("Введите числ: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int revers(int num)
// {
//     int i = 0;
//     while(num > 0)
//     {
//         i = i * 10 + num % 10;
//         num  = num / 10;
//     }
//     return i;
// }
// int palindrome(int n)
// {
//     int revNum  = revers(n);
//     if (revNum == n)
//         return 1;
//     else
//         return 0;
// }
// int input = palindrome(num);
// if(input > 0 )
//     Console.WriteLine("Палиндром");
// else
//     Console.WriteLine("Не палиндром");



/*ЗАДАЧА2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53 */
 
// double GetDistance (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2- z1)*(z2-z1));
// }

// Console.Write("Введите координату Х первой точки: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату У первой точки: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату z первой точки: ");
// double z1= Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координату Х второй точки: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y второй точки: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату z второй точки: ");
// double z2 = Convert.ToDouble(Console.ReadLine());



// double Input  = GetDistance(x1, y1, z1, x2, y2, z2);
// Console.WriteLine($"Расстояние между точками равно: " + Math.Round((Input), 2));


/*ЗАДАЧА3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125  */

// void qube(int n)
// {
//     int currentNum = 1;
//     while(currentNum <= n)
//     {
//         Console.WriteLine(currentNum + "-" + (currentNum*currentNum*currentNum));
//         currentNum++;
//     }
// }
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 0)
//     qube(n);
// else
//     Console.Write("Введите число больше 0");
