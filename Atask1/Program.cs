/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

//функция получения числа
int GetNumber(string message)
{
    int result = 0;
     while (true)
     {
       Console.WriteLine(message);
       if (int.TryParse(Console.ReadLine(), out result))
       {
        break;
       }
       else
       {
        Console.WriteLine("Ввели не число ");
       }
     }
     return result;
}
 // Функция создания массива рандомом 
 int[,]InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }
    return matrix;
}
// Функция вывода двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
void ElementRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
     int[] exchange = new int[columns];

     for (int i = 0; i < rows; i++)
     {
        for (int j = 0; j < columns; j++)
        {
            exchange[j] = matrix[i,j];
        }
        Array.Sort(exchange);
        Array.Reverse(exchange);
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = exchange[j];
        }
     }
}

int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите колличество столбцов: ");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
ElementRows(matrix);
PrintMatrix(matrix);
