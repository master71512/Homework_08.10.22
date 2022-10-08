// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
int[,] newArray2(int m, int n)
{
    int[,] a = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = new Random().Next(-100, 100);
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
Console.WriteLine("Введите номер строки и столбца элемента массива");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if ((x >= m) | (y >= n)) Console.WriteLine("Такой позиции нет в этом массиве");
else Console.WriteLine($"a [{x}, {y}] = {a[x, y]}");