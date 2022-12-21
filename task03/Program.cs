//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите кол-во строк");
int rows=int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] result = new int[rows, columns];
CreateNewRandom2DArray(array);
Print2DArray(array);
Console.WriteLine();
CreateNewRandom2DArray(secondArray);
Print2DArray(secondArray);
Console.WriteLine();
ProductMatrix(array);

int[,] CreateNewRandom2DArray(int[,] array)
{
    Random random = new Random();
    int[,] arr = new int[4, 4];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ProductMatrix(int[,] array)
{
    if (array.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine(" Нельзя перемножить ");
        return ;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                result[i, j] += array[i, k] * secondArray[k, j];
            }
        }
    }

    Print2DArray(result);

}