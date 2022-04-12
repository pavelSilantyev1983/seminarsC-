//Напишите программу, которая принимает на вход три числа и 
//проверяет, может ли существовать треугольник с сторонами 
//такой длины.
// A < B + C
/*
void Triangle(int A, int B, int C)
{
    if((A +B)>C && (A+C)>B && (B+C)>A)
    { 
    Console.WriteLine("такой трейгольник существует");
    }
    else 
    {
        Console.WriteLine("такого треугольника не существует");
    }
}

Console.WriteLine("длину первой стороны треугольника");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("длину второй стороны треугольника");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("длину третьей стороны треугольника");
int numC = Convert.ToInt32(Console.ReadLine());
Triangle(numA, numB, numC);
*/




//Напишите программу, которая будет преобразовывать десятичное 
//число в двоичное.
/*
void Binar(int numS)
{
   string answer = " ";
   while (numS > 0)
    {
        answer = Convert.ToString(numS%2)+answer;
        numS = numS / 2;
    }
    Console.WriteLine(answer+ " ");
}
Console.WriteLine("введите число");
int Num = Convert.ToInt32(Console.ReadLine());
Binar(Num);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
/*
void Fibb(int numA)
{
    int[] array = new int [numA];
    array[0]=0;
    array[1]=1;
    Console.Write("0 1 ");
    for (int i = 2; i <= numA; i++)
    {
        array[i]=array[i-1]+array[i-2];
        Console.Write(array[i]+ " ");
    }
    
} 
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
Fibb(num);
*/




//Напишите программу, которая будет создавать копию заданного 
//массива с помощью поэлементного копирования.(3*4)
/*
int[,]matrix=new int[3,4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i,j]=new Random().Next(0,10);
        Console.Write(matrix[ i, j]+" ");
    }
   Console.WriteLine(); 
}
 


//домашняя работа
//Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("введите число M - количество проверяемых цифр ");
int M = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[M];
int pos = 0;

for (int i = 0; i < M; i++)
{
    Console.WriteLine("введите число ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    mass[i] = num;
    if (mass[i] > 0)
    {
        pos = pos + 1;
    }
}
Console.WriteLine("количество положительных чисел равно"+" "+pos);
*/









//Задача 2: Пользователь вводит с клавиатуры кол-во строк и 
//столбцов для массива. Вывести массив в виде матрицы, 
//создав "рамку" из единиц, а внутреннюю зону матрицы 
//заполнить нулями.

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
        matrix[i,j]=1;
        Console.Write(matrix[ i, j]+" ");
        
    }
   Console.WriteLine(); 
}
for (int i = 1; i < numA-1; i++)
{
    for (int j = 1; j < numB-1; j++)
    {
        matrix[i,j]=0;
        Console.Write(matrix[ i, j]+" ");
    }
   Console.WriteLine(); 
}
*/








