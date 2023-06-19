// ДЗ. Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resMatrix = GetMatrix(rows, columns);

// PrintMatrix(resMatrix); 
// ChangeElements(resMatrix); 
// Console.WriteLine($"Матрица результат: ");
// PrintMatrix(resMatrix); 


// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m,n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
        
//               matrix[i,j] = i + j;
            
//         }
//     }
//     return matrix;

// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t"); 
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeElements(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if(matrix[i,k] < matrix[i,k+1])
//                 {
//                     int temp = matrix[i, k+1];
//                     matrix[i, k+1] = matrix[i,k];
//                     matrix[i,k] = temp;

//                 }
                
//             }

//         }
//     }
               
// }


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resMatrix = GetMatrix(rows, columns);

// Console.WriteLine();
// PrintMatrix(resMatrix);
// GetMinRowElement(resMatrix); 


// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m,n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {

//               matrix[i,j] = i + j;

//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t"); 
//         }
//         Console.WriteLine();
//     }
// }

// int GetMinRowElement(int[,] matrix)
// {
//     int minRowSum = 0;
//     int minSum = 0;

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         minSum = minSum = matrix[0,i];
        
//     }
// for (int i = 1; i < matrix.GetLength(0); i++)
// {
//     int sum =0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sum = sum + matrix[i,j];
        
//     }
//     if (sum < minSum)
//     {
//         minSum = sum;
//         minRowSum = 1;
//     }
// }
// return minRowSum;
// }

// int[,] matrix = GetMatrix(4, 4, 0, 10);
// PrintMatrix(matrix);

// Console.WriteLine($"Строчка с наименьшей суммой элементов: {GetMinRowElement(matrix)}");




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите количество строк для первой матрицы: ");
// int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов для первой матрицы: ");
// int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество строк для второй матрицы: ");
// int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов для второй матрицы: ");
// int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

// int[,] resFirstMatrix = GetMatrix(rowsFirstMatrix, columnsFirstMatrix);
// int[,] resSecondMatrix = GetMatrix(rowsSecondMatrix, columnsSecondMatrix);

// PrintMatrix(resFirstMatrix);
// Console.WriteLine();
// PrintMatrix(resSecondMatrix);
// GetProductMatrix(resFirstMatrix, resSecondMatrix);
// Console.WriteLine($"Матрица результат: ");
// PrintMatrix(resMatrix);


// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m,n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {

//               matrix[i,j] = i + j;

//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t"); 
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetProductMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {
// int[,] resMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

// for (int i = 0; i < firstMatrix.GetLength(0); i++) // строчки первой матрицы
// {
// for (int j = 0; j < secondMatrix.GetLength(1); j++) // столбцы второй матрицы
// {
// for (int k = 0; k < firstMatrix.GetLength(1); k++) // столбцы первой матрицы
// {
// resMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
// // resMatrix = resMatrix + firstMatrix[i, k] * secondMatrix[k, j];
// }
// }
// }
// return resMatrix;
// }






// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите глубину массива: ");
// int deep = Convert.ToInt32(Console.ReadLine());

// int[,,] resMatrix = GetMatrix(rows, columns, deep, 0, 10);
// PrintMatrix(resMatrix); 

// int[,,] GetMatrix(int m, int n, int k, int min, int max)
// {
//     int[,,] matrix = new int[m,n,k]; 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i,j,k] = new Random().Next(min, max + 1);
//             }
    
            
//         }
//     }
//     return matrix;

// }

// void PrintMatrix(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             Console.Write(array[i,j,k] + "\t"); 
//         }
//         Console.WriteLine(); 
//     }
// }

