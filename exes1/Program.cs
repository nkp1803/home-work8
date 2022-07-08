// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        bool flag = true;
        while (flag)
        {
            flag = false;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int tmp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = tmp;

                    flag = true;
                }

            }
        }
    }
    return array;
}

int row = Prompt("Количество строк >");
int column = Prompt("Количество столбцов >");
int min = -10;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
int[,] arr = SortArray(array);
System.Console.WriteLine();
PrintArray(arr);