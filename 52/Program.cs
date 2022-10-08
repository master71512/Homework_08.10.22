// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int[,] newArray2(int m, int n)
{
    int[,] a = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = new Random().Next(10, 100);
            Console.Write("{0, 6}", a[i, j]);
        }
        Console.WriteLine();
    }
    return a;
}
Console.WriteLine("Введите количество строк и столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] a = newArray2(m, n);
for (int j = 0; j < a.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        sum += a[i, j];
    }
    sum /= a.GetLength(0);
    Console.WriteLine("Среднее арифметическое {0, 3}-го столбца равно {1:#.##}", j, sum);

}