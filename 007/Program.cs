/*ЗАДАЧА 1
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

// double [,] CreateArray(int rows, int columns)
// {
//     double [,] array = new double[rows,columns];
//     for(int i = 0; i < rows; i++)
//         for(int j =0; j< columns;j++)
//         {
//             array[i,j] = new Random().Next(-9,9) / 10.0;
//         }
//     return array;
// }

// void Show2dArray(double [,]array)
// {
//      for(int i = 0; i< array.GetLength(0); i++)
//      {
//         for(int j = 0; j< array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//      }
//      Console.WriteLine();
// }

// Console.Write(" Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] newArray = CreateArray(rows,columns);
// Show2dArray(newArray);

/*ЗАДАЧА 2
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет*/

// int[,] CreateArray2D()
// {   
//     Console.Write(" Введите количество строк массива: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write(" Введите количество столбцов массива: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     int [,] array = new int[m,n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void ShowArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void CheckIndex (int[,] array, int r, int c)
// {
//     if (r < array.GetLength(0) && c < array.GetLength(1))
//     {
//         Console.WriteLine($"Ваш элемент {r}{c}");
//     }
//     else
//     {
//         Console.WriteLine($"{r}{c} - элемента с такими индексами в массиве нет");
//     }
// }

// int [,] newArray = CreateArray2D();
// ShowArray2D(newArray);

// Console.Write(" Введите индекc искомого: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите индекс стоблца: ");
// int c = Convert.ToInt32(Console.ReadLine());
// CheckIndex(newArray,r,c);




/*ЗАДАЧА 3
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

// void CreateArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
 
// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int rows = 3;
// int colums = 4;
// int[,] numbers = new int[rows, colums];
// CreateArray2D(numbers);
// PrintArray2D(numbers);

// double[] avgNumbers = new double[numbers.GetLength(1)];

// for (int i = 0; i < numbers.GetLength(1); i++)
// {
//     double result = 0.0;
//     for (int j = 0; j < numbers.GetLength(0); j++)
//     {
//         result += numbers[j, i];
//     }
//     avgNumbers[i] = result / numbers.GetLength(0);
// }
// PrintArray(avgNumbers);
