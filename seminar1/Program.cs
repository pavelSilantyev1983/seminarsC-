/*
//1 задача1
Console.WriteLine("введите целое число ");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value*value;
Console.WriteLine("квадрат данного числа равен ");
Console.WriteLine(value*value);
*/


/*
//2 задача
Console.Write("введите первое число ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int value2 = Convert.ToInt32(Console.ReadLine());

int kvadrat_value2 = value2*value2;

if(kvadrat_value2 == value1)
{
    Console.WriteLine("квадрат второго числа равен первому числу");

}
else
{
    Console.WriteLine("искомых соответствий не выявлено");
}
*/


/*
//3 задача

Console.WriteLine("введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 7 && number >= 1)
{
    if(number == 1)
    {
        Console.WriteLine("это понедельник");
    }
    if(number == 2)
    {
        Console.WriteLine("это вторник");
    }
    if(number == 3)
    {
        Console.WriteLine("это среда");
    }
    if(number == 4)
    {
        Console.WriteLine("это четверг");
    }
    if(number == 5)
    {
        Console.WriteLine("это пятница");
    }
    if(number == 6)
    {
        Console.WriteLine("это суббота");
    }
    if(number == 7)
    {
        Console.WriteLine("это ж воскресенье");
    }
    
}
else
{
    Console.WriteLine("нет такого дня недели ж");
}
*/



/*
// 4 задача

Console.WriteLine("введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n*(-1);

while (neg_n <= n)
{
    Console.WriteLine(neg_n);
    neg_n ++;
}
*/







// ДОМАШНЕЕ ЗАДАНИЕ

/*
// 1задача
Console.Write("введите первое число ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int value2 = Convert.ToInt32(Console.ReadLine());
if(value1 > value2)
{
    Console.Write("большее число ");
    Console.Write(value1);
}
else{
    Console.Write("большее число ");
    Console.Write(value2);
}
*/

/*
// 2 задача
Console.Write("введите первое число ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int value2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число ");
int value3 = Convert.ToInt32(Console.ReadLine());

if(value1 > value2)
{
    if (value1 > value3)
        {
            Console.Write("самое большое число ");
            Console.Write(value1);
        }
    else
        {
        Console.Write("самое большое число ");
        Console.Write(value3);
        }
    }                

else
    {
        if (value2 > value3)
        {
            Console.Write("самое большое число ");
            Console.Write(value2); 
        }
        else{
        Console.Write("самое большое число ");
        Console.Write(value3); 
        }   
    }
*/


/*
//3 задача
Console.Write("введите любое число ");
int value = Convert.ToInt32(Console.ReadLine());
if (value/2)
{
    Console.WriteLine("это четное число ");
}
else
{
    Console.WriteLine("это нечетное число ");
}
*/

/*
//4 задача
Console.Write("введите любое положительное число ");
int N = Convert.ToInt32(Console.ReadLine());
int X[i];
while (X[i]<=N)
{
    if (X[i]/2)

    {
        Console.Write("X[i]");
    else{   
    i ++
    }
    }
}
*/