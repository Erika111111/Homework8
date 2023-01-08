/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int rows, columns;
int[,] sum;

Console.Write("Введите колличество строк в матрице: ");
rows = int.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов в матрице: ");
columns = int.Parse(Console.ReadLine());
sum = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        sum[i,j] = rnd.Next(0, 10);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(sum[i,j] + " ");
    }
    Console.WriteLine();
}

int minRowSum = int.MaxValue, indexMinRow = 0;

for (int i = 0; i < rows; i++)
{
    int rowsum = 0;
    for (int j = 0; j < columns; j++)
    {
        rowsum = rows + sum[i,j];
    }

    if (rowsum < minRowSum)
    {
        minRowSum = rowsum;
        indexMinRow = 1;
    }
}

Console.WriteLine("Строка с минимальной суммой элементов ");
    for (int j = 0; j < columns; j++)
    {
        Console.Write(sum[indexMinRow, j] + " ");
    }