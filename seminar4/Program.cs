//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
 int ArythmSum(int A)
{
    int result = 0; 
    int i = 1;        
    while(i <=A)
    {
                result=result+i;
                i++;
    }
    return result;
}
Console.WriteLine("введите любое целое число");
int numA = Convert.ToInt32(Console.ReadLine());
if(numA < 1)Console.WriteLine("вы ввели некорректное число");
Console.WriteLine($"сумма чисел от 1 до { numA } равна {ArythmSum(numA)}");
*/


//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
void dlinna(int N){
    int l = 1;
    while(Math.Abs (N/10) > 1)
    {
        N = N/10;
        l++;
    }
    Console.WriteLine("колличество цифр в введенном числе равно"+ l);
}
Console.WriteLine("введите любое целое число");
int num = Convert.ToInt32(Console.ReadLine());
dlinna(num);
*/


//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int N)
{
    int result = 1; 
    int i = 1;        
    while(i <=N)
    {
                result=result*i;
                i++;
    }
    return result;
}
Console.WriteLine("введите любое целое число");
int numN = Convert.ToInt32(Console.ReadLine());
if(numN < 1)Console.WriteLine("вы ввели некорректное число");
Console.WriteLine($"сумма чисел от 1 до { numN } равна {Factorial(numN)}");
*/





//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
void bitArray()
{
    int[] a = new int[8];
    for (int i = 0; i <8; i++)
    {
        a[i] = new Random().Next(0,2);
        Console.Write(a[i]+" ");
    }
}
bitArray();
*/