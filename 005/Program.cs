/*ЗАДАНИЕ 1
Задайте массив заполненный случайными положительными трехзначными числами. Напишите  программу которая покажет количество
четных чисел в массиве
Пример:
[345,897,568,234] = 2
*/
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] num = new int [size];
// int count = 0;
// ArrayRandom(num);
// PrintArray(num);

// for (int i = 0; i < num.Length; i++)
// {
//     if(num[i] % 2 == 0)
//     count++;
// }

// void ArrayRandom(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100,1000);
// }

// void PrintArray( int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine($"В массиве {count} четных чисел");

/*ЗАДАНИЕ 2
Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов стоящих на нечетных позициях.
Пример:
[3,7,23,12] = 19
[-4,-6,86,6] = 0
*/

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] numbers = new int [size];
// ArrayRandom(numbers);
// Console.WriteLine("Массив: ");
// PrintArray(numbers);
// int Sum = 0;

// for (int i = 1; i < numbers.Length; i += 2)
//     Sum = Sum + numbers[i];
// Console.WriteLine($"Всего чисел = {numbers.Length}, сумма элементов стоящих на нечетных позициях = {Sum}");


// void ArrayRandom(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//     }
// }

// void PrintArray (int [] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " , ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }



/*ЗАДАНИЕ 3
Задайте массив вещественных чисел.Найдите разницу между максимальным и минимальным значением элементов массива
Пример:
[3,7,22,2,78] = 76
*/
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double [size];
ArrayRandom(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
    {
        max = numbers[z];
    }
    if (numbers[z] < min)
    {
        min  = numbers[z];
    }
}

Console.WriteLine($"В массиве всего чисел = {numbers.Length}. Максимум = {max}, минимум = {min}");
Console.WriteLine($"Разница между масимумумом и минимумом = {max - min}");

void ArrayRandom(double [] numbers)
{
    for (int i = 0; i<numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000) / 10);
    
    }
}

void PrintArray(double[] numbers)
{
        Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " , ");
    }
    Console.Write("]");
    Console.WriteLine();
}
