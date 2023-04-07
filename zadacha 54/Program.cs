/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int n;
int m;
Console.WriteLine("Введите кол-во строк:");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine("Введите кол-во строк:");
int.TryParse(Console.ReadLine(), out m);

List<List<int>> massiv = new List<List<int>>();
for (int i = 0; i < n; i++)
{
    massiv.Add (new List<int>());
    for (int j = 0; j < m; j++)
    {
        massiv[i].Add(new Random().Next(20));
    }
}
foreach (var massiv2 in massiv)
{
    foreach (var item in massiv2)
    {
        Console.Write($"{item, 3} ");
    }
    Console.WriteLine();
}


List<List<int>> sort = new List<List<int>>();

for (int i = 0; i < n; i++)
{
    var xxx = new List<int>();
    for (int j = 0; j < m; j++)
        xxx.Add(massiv[i] [j]);
    xxx.Sort();
    xxx.Reverse();
    sort.Add(xxx);
}
Console.WriteLine();

foreach (var list2 in sort)
{
    foreach (var item in list2)
        Console.Write($"{item,3} ");
    Console.WriteLine();
}
*/

int n;
int m;
Console.WriteLine("Введите кол-во строк:");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine("Введите кол-во строк:");
int.TryParse(Console.ReadLine(), out m);
List<List<int>> massiv = new List<List<int>>();
for (int i = 0; i < n; i++)
{
    massiv.Add(new List<int>());
    for (int j = 0; j < m; j++)
    {
        massiv[i].Add(new Random().Next(20));
        Console.Write($"{massiv[i][j],3} ");
    }
    massiv[i].Sort();
    massiv[i].Reverse();
    Console.WriteLine();
}
Console.WriteLine();
foreach (var massiv2 in massiv)
{
    foreach (var item in massiv2)
    {
        Console.Write($"{item,3} ");
    }
    Console.WriteLine();
}