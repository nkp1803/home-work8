// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int SearchMinSum(int[,] array)
{
    int index = -1;
    int min = 30000;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j]; // sum = sum + array[i,j];
        }

        if (sum < min)
        {
            min = sum;
            index = i;
        }
    }

    return index;
}

int row = Prompt("Количество строк >");
int column = Prompt("Количество столбцов >");

while (row == column)
{
    System.Console.WriteLine("Масив не прямоугольный ! Введите новые данные => ");
    row = Prompt("Количество строк >");
    column = Prompt("Количество столбцов >");
}

int min = -10;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
int index = SearchMinSum(array);
System.Console.WriteLine($"Строка с минимальной суммой : {index+1}");
