//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] mass = new int[12];
int pos = 0;
int neg = 0;
for (int i = 0; i < 12; i++)
{
    mass[i] = new Random().Next(-9,10);
    if (mass[i] > 0)
    {
        pos = pos + mass[i];
    }
    else
    {
        neg = neg + mass[i];
    }
    Console.WriteLine(mass [i]);
}
Console.WriteLine($"pos is{pos} , neg is {neg}");
*/


//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] mass = new int[12];

for (int i = 0; i < 12; i++)
{
    mass[i] = new Random().Next(-9,10);
    Console.Write(mass [i]+" ");
    Console.WriteLine();
}
for (int i = 0; i < 12; i++)
{
    Console.Write((mass[i]*(-1))+" ");
}
*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] arra = new int [15];
int tumbler = 0;
for (int i = 0; i < 15; i++)
{
    arra[i] = new Random().Next(1,20);
    Console.Write(arra[i] + " ");
}
Console.WriteLine("enter the number");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 15; i++)
{
    if (arra[i] == num) 
    {
        Console.WriteLine("yes");
        tumbler = 1;
        break;
    }
}
if (tumbler == 0) Console.WriteLine("no");
*/


//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] arra = new int [123];
int count = 0;
for (int i = 0; i < 123; i++)
{
    arra[i] = new Random().Next(1,1000);
    if (arra[i] < 100 && arra[i] > 9) count++;        
}
Console.WriteLine(count);
*/


//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

/*
Console.WriteLine("enter massive length");
int num = Convert.ToInt32(Console.ReadLine());
int[] arra = new int [num];

int dlina=1;
if(num/2==0) dlina = 0;
int[] arra2 = new int[(num/2)+dlina];

for (int i = 0; i < num; i++)
{
    arra[i] = i+1; 
    Console.Write(arra[i]+ " ");     
}
Console.WriteLine();
for (int i = 0; i < ((num/2)+dlina); i++)
{
    arra2[i]=arra[i]*(arra[num-1-i]);
    if(i==num-i-1) arra2[i]=arra[i];
    Console.Write(arra2[i]+" ");
}
*/


//домашняя работа

//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.WriteLine("введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] arra = new int [num];
int count = 0;
for (int i = 0; i < num; i++)
{
    arra[i] = new Random().Next(100,1000);
    Console.Write(arra[i]+" ");
    if (arra[i] % 2 == 0) count++;        
}

Console.Write($"в массиве четных чисел { count }");
*/





//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.WriteLine("введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] arra = new int [num];
int count = 0;
for (int i = 0; i < num; i++)
{
    arra[i] = new Random().Next(1,100);
    Console.Write(arra[i]+" ");
    if(i%2==0) count= count+arra[i];      
}

Console.Write($"сумма элементов, стоящих на нечетных позициях равна { count }");
*/
/*
// тут я определил еще и для четных
Console.WriteLine("введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] arra = new int [num];
int count = 0;
for (int i = 0; i < num; i++)
{
    arra[i] = new Random().Next(1,100);
    Console.Write(arra[i]+" ");
    if((i%2-1)==0) count= count+arra[i];      
}

Console.Write($"сумма элементов, стоящих на четных позициях равна { count }");
*/



//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
