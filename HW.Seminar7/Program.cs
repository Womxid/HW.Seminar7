int NumEnter(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int columns, int maxValue = 100, int minValue = -100)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

start();

void start()
{
    while (true)
    {
Console.ReadLine();
Console.Clear();
System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
System.Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
System.Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
System.Console.WriteLine("0) End"); 

int NumTask = NumEnter("Номер задачи");

switch (NumTask)
{
    case 0: return; break;
    case 47: Ex47(); break;
    case 50: Ex50(); break;
    case 52: Ex52(); break;

}
    }
}



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Ex47()
{
int rows = NumEnter("Введите число m");
int columns = NumEnter("Введите число n");
int[,] matrix = GetRandomMatrix(rows, columns);
printMatrix(matrix);
}
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void Ex50()
{
int rows = NumEnter("Введите число строк массива");
int columns = NumEnter("Введите число колонн массива");
int[,] matrix = GetRandomMatrix(rows, columns);
printMatrix(matrix);
int numRow = NumEnter("Строка");
int numColumn = NumEnter("Столбец");
if(numRow < rows && numColumn < columns) Console.WriteLine($"Найдено число {matrix[numRow, numColumn]}");
else Console.WriteLine($"{matrix[numRow, numColumn]} Такой позиции в массиве нет");
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Ex52()
{
int rows = NumEnter("Введите число строк массива");
int columns = NumEnter("Введите число колонн массива");
int[,] matrix = GetRandomMatrix(rows, columns);
printMatrix(matrix);
Console.WriteLine("---------------------------------------------");
int [] sum = new int [columns];

for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        sum[i] += matrix[j, i];
    }
}

for (int i = 0; i < columns; i++)
{
    Console.Write((sum[i] / rows) + " ");
}
}