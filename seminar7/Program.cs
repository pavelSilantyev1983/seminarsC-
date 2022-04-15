//Задайте двумерный массив размером m×n, 
//заполненный случайными двузначными целыми числами.
/*
void Rand(int m, int n)
{
    int [,] matrix = new int[m,n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(-99,100);
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}
Rand(2,6);
*/




//Задайте двумерный массив размера m на n, каждый 
//элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
/*
void Rand(int m, int n)
{
    int [,] matrix = new int[m,n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = i+j;
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}
Rand(5,6);
*/



//Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти 
//элементы на их квадраты.
/*
void Rand(int m, int n)
{
    int [,] matrix = new int[m,n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(1,10);
            
            if (i%2==0 && j%2 ==0)
            {
               
                matrix[i,j]=matrix[i,j]*matrix[i,j];
            }
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}
Rand(3,3);
*/

//Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.
/*
void Matr(int m, int n)
{
    int[,] matrix = new int[m, n];
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            if (i == j)
            {
                sum = sum + matrix[i, j];
            }

            Console.Write(matrix[i, j] + " ");

        }
        Console.WriteLine();
    }
    Console.WriteLine($"сумма элементов главной диагонали равна" + " " + sum);
}
Matr(5, 5);
*/


//ДОМАШНЯЯ РАБОТА
//Задача 1. Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.
/*
Console.WriteLine("введите число строк");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов");
int numB = Convert.ToInt32(Console.ReadLine());
int[,]matrix=new int[numA,numB];
for (int i = 0; i < numA; i++)
{
    for (int j = 0; j < numB; j++)
    {
        matrix[i, j] = new Random().Next(-99,100)/10;
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
*/


//Задача2. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
/*
void Rand(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");

        }
        Console.WriteLine();
    }
    Console.WriteLine("введите номер строки");
    int numA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите номер столбца");
    int numB = Convert.ToInt32(Console.ReadLine());
    int X= matrix[numA-1, numB-1];
    Console.WriteLine("вы выбрали число"+" "+ X);
}
Rand(6, 6);
*/

//Задача 3. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.









