// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int GetNumber(string message) //число в консоли
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int[,] InitMatrix(int m, int n) //инициализация массива
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix) //печать массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

int line = 4;
int column = 4;
Console.WriteLine();
int[,] matrix = InitMatrix(line, column);

Console.WriteLine("Задан массив размером 4х4. Укажите позицию для поиска числа.");
Console.WriteLine();

int numberLine = GetNumber("Строка");
int numberColumn = GetNumber("Столбец");

if (numberLine <= matrix.GetLength(0) && numberColumn <= matrix.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine($"Число в {numberLine} строке и {numberColumn} столбце это {matrix[numberLine - 1, numberColumn - 1]}");
}
else
{
    Console.WriteLine("Размер 4х4 же, за пределами массива пустота, попробуйте снова.");
}
Console.WriteLine();
PrintArray(matrix);