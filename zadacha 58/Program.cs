/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int a, b, A, B;

Console.WriteLine("Введите количество строк в 1 матрице: ");
int.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Введите количество столбцов в 1 матрице: ");
int.TryParse(Console.ReadLine(), out b);

Console.WriteLine("Введите количество строк в 2 матрице: ");
int.TryParse(Console.ReadLine(), out A);

Console.WriteLine("Введите количество столбцов в 2 матрице: ");
int.TryParse(Console.ReadLine(), out B);

int[,] massiv1 = new int[a, b];
int[,] massiv2 = new int[A, B];

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random(). Next (5);
        }
    }
}
FillArray(massiv1);
FillArray(massiv2);
void PrintArray(int [,] array)
  {
    for (int i=0; i<array.GetLength(0); i++)
    {
      for (int j=0; j<array.GetLength(1); j++)
      {
        Console.Write($"{array[i, j], 3}");
      }
      Console.WriteLine ();
    }
  }
PrintArray(massiv1);
Console.WriteLine ();
PrintArray(massiv2);
Console.WriteLine ();
Console.WriteLine ();
if (b == A)

{ 
int[,] rezult = new int[massiv1.GetLength(0), massiv2.GetLength(1)];
    for (int i = 0; i < massiv1.GetLength(0); i++)
        {
            for (int j = 0; j < massiv2.GetLength(1); j++)
            {
                for (int k = 0; k < massiv1.GetLength(0); k++)
                {
                    rezult[i,j] += massiv1[i,k] * massiv2[k,j];
                }
            }
        }

PrintArray(rezult);
}
else
    Console.WriteLine ("Введены неверные параметры!" );
