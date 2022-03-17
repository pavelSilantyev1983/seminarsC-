//задача 1
/*
int FindMaxNum(int num)
{
    int n1 = num % 10;
    int n2 = num / 10;

    if ( n1 > n2 )
    {
        return n1;
    }
    else{
        return n2;
    }
}

int number = new Random().Next(10,99);
Console.WriteLine("current number is" + number + "max part is" + FindMaxNum(number));
*/

//задача2
/*
int Max(int num){
    int n1 = (num/100)*10;
    int n2 = num % 10;
    return n1+n2;
}
int number = new Random().Next(100,999);
Console.WriteLine(number+ "-->"+Max(number));
*/


//задача3
/*
void Ppp(int num1, int num2){
    if(num1 < num2){
        int a = num1;
        num1 = num2;
        num2 = a;
    }
    if (num1 % num2 ==0){
        Console.WriteLine("второе число кратное первому");
    }
    else{
        Console.WriteLine("второе число не кратное первому, остаток от деления");
        Console.WriteLine(num1 % num2);
    }
}
Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Ppp(number1,number2);
*/


/*
void prprpr (int num1,int num2 ,int num3){
if(num1 % num2 == 0 && num1 % num3 == 0){
    Console.WriteLine(num1 +"является кратным"+ num2 +"и"+ num3);    
}
else{
    Console.WriteLine(num1+" не является кратным"+ num2 +"и"+ num3);
}}

Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

prprpr(number1,number2,number3);
*/


//домашняя работа
//задача10


//задача13


//задача15 про выходные
Console.WriteLine("введите номер дня недели, а я скажу выходной ли это");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 7 && number >= 1)
{
    if(number == 1)
    {
        Console.WriteLine("это не выходной");
    }
    if(number == 2)
    {
        Console.WriteLine("это не выходной");
    }
    if(number == 3)
    {
        Console.WriteLine("это не выходной");
    }
    if(number == 4)
    {
        Console.WriteLine("это не выходной");
    }
    if(number == 5)
    {
        Console.WriteLine("это не выходной, но почти");
    }
    if(number == 6)
    {
        Console.WriteLine("это выходной");
    }
    if(number == 7)
    {
        Console.WriteLine("это ж выходной");
    }
    
}
else
{
    Console.WriteLine("нет такого дня недели ж");
}


