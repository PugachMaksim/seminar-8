/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int [,] massiv = new int [3,3];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i,j] = new Random(). Next (10);
        Console.Write($"{massiv[i,j],2} ");
    }   
        Console.WriteLine(); 
}
    Console.WriteLine();

int[] sum = new int[massiv.GetLength(0)];
int lastSum = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    { 
        int sumJ = 0;
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            sumJ = sumJ + massiv[i,j];
            sum[lastSum] = sumJ;   
        }
        Console.Write($"{sum[lastSum]} ");
        lastSum++;
    }
Console.WriteLine();

void Index(int[]array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
            {
                min = array[i];
            }
    }
    Console.WriteLine($"{min}");

    for (int index = 0; index < array.Length; index++)
    {
        if(array[index] == min)
        {
        Console.WriteLine($"минимальная сумма находится в {index+1} строчке");
        break;
        }
    }
}
Index(sum);

