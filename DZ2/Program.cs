// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] ArrayWithRandom(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 10);
        }

    }
    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

string SearchByIndexes(int[,] matrix, int idx0, int idx1)
{
    if (idx0 >= 0 && idx0 < matrix.GetLength(0)
        && idx1 >= 0 && idx1 < matrix.GetLength(1))
    {
        return $"По указанным индексам находится число {matrix[idx0, idx1]}";
    }
    else
    {
        return "Элемент по заданным индексам не существует в массиве";
    }
}

string SearchForValue(int[,] matrix, int value)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == value) return $"Число {value} находится на строке с индексом {i} на столбце с индексом {j}";
        }
    }
    return "Такого числа в массиве нет";
}
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = ArrayWithRandom(row, column);
PrintMatrix(matrix);
Console.WriteLine("Введите:\n1 чтобы узнать индексы введенного числа в массиве" +
            "\n2 чтобы узнать число в введенных индексов ");
row = Convert.ToInt32(Console.ReadLine());
switch (row)
{
    case 1:
        Console.Write("Введите число которую ищите ");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.Write(SearchForValue(matrix, value));
        break;

    case 2:
        Console.Write("Введите индекс строки: ");
        int idxRow = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите индекс столбца: ");
        int idxColumn = Convert.ToInt32(Console.ReadLine());
        Console.Write(SearchByIndexes(matrix, idxRow, idxColumn));
        break;
    default:
        Console.Write("Ошибка введите только 1 или 2");
        break;
}