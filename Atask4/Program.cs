/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


// Метод ввода пользовыателем числа
int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не чило");
        }
    }
    return result;
}

// Метод создания матрици случайных чисел от 1 до 9
int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns;j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

// Метод вывода матрицы
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1);j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод решения задачи
int[,] MatrixProd(int[,] matr1, int[,] matr2)
{
    int[,] result = new int[matr1.GetLength(0), matr2.GetLength(0)];
    int length = matr1.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < length; k++)
            {
                result[i,j] += matr1[i,k]* matr2[k,j];
            }
        }
    }
    return result;
}

int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitMatrix(rows,columns);
int[,] matrix2 = InitMatrix(rows,columns);

PrintMatrix(matrix);
PrintMatrix(matrix2);
int[,] matrix3 = MatrixProd(matrix, matrix2);
int[,] mat1 = {{2, 4}, {3, 2}};
int[,] mat2 = {{3, 4}, {3, 3}};
int[,] mat3 = MatrixProd(mat1, mat2);
PrintMatrix(matrix3);
PrintMatrix(mat3);

