/*ЗАДАЧА 1
Пользователь вводит с клавиатуры m чисел. Посчитайте сколько чисел больше 0 ввел пользователь.
пример: 0,7,8,-2 = 2
        1,-7,567,89,-223 = 3
число m запросить у пользователя
Решить задачу без задачи массива
метод который будет запрашивать в цикле числа и считать сколько там положительных.
*/


// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine());
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");


// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//             count++;
//     }

//     int[] numbers = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }


/* ЗАДАЧА 2
Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
у = k1 * x + b1,
y = k2 * x + b2
Значения b1,b2,k1,k2 задаются пользователем

Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 = (-0.5;0.5)
две линии. линии могут быть паралленьны, пересекаться и совпадать, проверить на все три
метод войд и внутри метода отчитаться с консолем по другим возможным вариантам

*/



// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double numberX = (b2 - b1)/(k1 - k2);
// double numberY = k2 * numberX + b2;

// Console.WriteLine($"Точка пересечения двух прямых: {numberX},{numberY}");