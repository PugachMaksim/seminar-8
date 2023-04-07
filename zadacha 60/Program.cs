/*
Задача 60. 
...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
List<int> numb = new List<int>();
for (int i = 10; i <100; i++)
    numb.Add(i);
    
int[, ,]array = new int[2,2,2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int N = new Random(). Next(0, numb.Count);
            array[i,j,k] = numb[N];
            numb.RemoveAt(N);
            Console.Write($"{array[i, j, k],3 }");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void index(int [, ,]arr)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k],3 }({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}
index(array);