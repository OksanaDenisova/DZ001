// ЗАДАЧА 1
// Напишите цикл который принимает на вход два числа(А и В) и возводит число А в натуральную степень В
// 3,5  = 234
// 2,4 = 16
// Команда math не использовать
// строго уиклом написать, выделяя переменные под результат, проработать поиск степени и выводим пользователю

// Console.WriteLine("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int step = a;

//     for (int i = 1; i < b; i++)
//     {
//         step *= a;
//     }

// Console.WriteLine("А в степени В равно: " + step);

/* ЗАДАЧА 2. НАпишите программу, которая воспринимает на вход число и выдает сумму цифр в числе.
452 = 11
82 = 10
9012 = 12
( мы такое уже делали но искали количество цифр в числе) чтобы найти не количество а сумму цифр в числе нужно 
поменять пару символов */

// int Sum(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result += num % 10;
//         num = num / 10;
//     }
//     return result;
// }
// Console.Write("Введите ваше число: ");
// int number  = Convert.ToInt32(Console.ReadLine());

// int dig = Sum(number);
// Console.WriteLine($"Сумма всех числев в числе {number} равна {dig}");

/*Задача 3. Напишите программу, которая задает массив из M элементов и выводит их на экран
тут нужно попросить пользователя ввести все элементы массива.
потом записать их в массив и вывести на экран
*/

// int[] array = new int [8];
// Console.Write ("[");
//     for(int i = 0; i < array.Length; i ++)
//     {
//         array [i] = new Random().Next(0,100);
//         Console.Write(" " + Method (i) + " ");
//     }
// Console.Write ("]");
// int Method (int a)
// {
//     return array[a];
// }

