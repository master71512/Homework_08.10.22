// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
double[,] newArray2(int m, int n)
{
    double[,] a = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = (new Random().Next(-100, 100) / 10.0);
            Console.Write("{0, 6}", a[i, j]);
        }
        Console.WriteLine();
    }
    return a;
}
Console.WriteLine("Введите количество строк и столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] a = newArray2(m, n);