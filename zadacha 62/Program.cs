/*

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/
int Str = 4;
int Stlb = 4;
int[,] array = new int[Str, Stlb];

int I = 0; // уменьшение строк
int J = 0; // уменьшение столбцов


int k = 1;
int i = 0;
int j = 0;

while (k <= Str * Stlb)
{
    array[i, j] = k;
    if (i == I && j < Stlb - J - 1) //идем вправо
        ++j;
    else if (j == Stlb - J - 1 && i < Str - I - 1) // идем вниз
        ++i;
    else if (i == Str - I - 1 && j > J) // идем влево
        --j;
    else                                       // идем вверх
        --i;

    if ((i == I + 1) && (j == J) && (J != Stlb - J - 1)) // проверка фин. позиции
    {
        ++I;
        ++J;
    }
    ++k;
}

Console.WriteLine();
for (int row = 0; row < array.GetLength(0); row++)
{
    for (int col = 0; col < array.GetLength(1); col++)
    {
        Console.Write($"{array[row, col],3}");
    }
    Console.WriteLine();
}