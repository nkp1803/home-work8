// Задача 3: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

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

int[,] MultiplyMatrix(int[,] arr_a, int[,] arr_b)  //Проиведение матриц
{
    int row = arr_a.GetLength(0);
    int column = arr_b.GetLength(1);

    var arr_c = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            int sum = 0;
            for (int k = 0; k < arr_a.GetLength(1); k++)
            {
                sum += arr_a[i, k] * arr_b[k, j];
            }
            arr_c[i, j] = sum;
        }
    }
    return arr_c;

}
int min = -10;
int max = 10;

// м-ца 1
int row1 = Prompt("Количество строк м-цы 1 => ");
int column1 = Prompt("Количество столбцов м-цы 1 => ");

System.Console.WriteLine();

// м-ца 2
int row2 = Prompt("Количество строк м-цы 2 => ");
int column2 = Prompt("Количество столбцов м-цы 2 => ");

while (column1 != row2)
{
    System.Console.WriteLine("Вы ввели не корректные размерности матриц => ");
    row1 = Prompt("Количество строк м-цы 1 => ");
    column1 = Prompt("Количество столбцов м-цы 1 => ");

    System.Console.WriteLine();

    row2 = Prompt("Количество строк м-цы 2 => ");
    column2 = Prompt("Количество столбцов м-цы 2 => ");
}

int[,] arr_a = GenerateArray(row1, column1, min, max);
int[,] arr_b = GenerateArray(row2, column2, min, max);

System.Console.WriteLine("М-ца A");
PrintArray(arr_a);
System.Console.WriteLine("М-ца B");
PrintArray(arr_b);

int[,] arr_c = MultiplyMatrix(arr_a, arr_b);
System.Console.WriteLine("М-ца C");
PrintArray(arr_c);

