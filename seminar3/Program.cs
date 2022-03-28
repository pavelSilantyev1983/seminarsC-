//задача 1: принимает на вход координаты и показывает в какой четверти находится точка
 /*
 int GetQuart(double xPoint, double yPoint)
 {
     if(xPoint > 0 && yPoint > 0) return 1;
     if(xPoint < 0 && yPoint > 0) return 2;
     if(xPoint < 0 && yPoint < 0) return 3; 
     if(xPoint > 0 && yPoint < 0) return 4;
     return 0;
 }
 
Double x, y;
int quartNum;
Console.Write("input x:");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("input y:");
y = Convert.ToDouble(Console.ReadLine());
quartNum = GetQuart(x,y);
if(quartNum == 0) Console.WriteLine("нельзя однозначно определить четверть");
else Console.WriteLine("данная точка находится в"+ quartNum+"четверти");
*/

//принимает номер четверти и выдает значения икс и игрек
/*
void GetQuart(int numQuart){
    if(numQuart == 1) Console.WriteLine("координаты принимают следующие диапазоны: Х > 0; У > 0");
     if(numQuart == 2) Console.WriteLine("координаты принимают следующие диапазоны: Х > 0; У < 0");
     if(numQuart == 3) Console.WriteLine("координаты принимают следующие диапазоны: Х < 0; У < 0");
     if(numQuart == 4) Console.WriteLine("координаты принимают следующие диапазоны: Х < 0; У > 0");
}
int num ;
Console.WriteLine("введите номер четверти");
num = Convert.ToInt32(Console.ReadLine());
GetQuart(num);
*/



/*
//принимает на вход координаты двух точек и находит расстояние между ними
Double xA, yA, xB, yB;
Console.Write("input x of point A");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input y of point A");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input x of point B");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("input y of point B");
yB = Convert.ToDouble(Console.ReadLine());
static double GetDistance(double x1, double x2, double y1, double y2){
    double xDistance = x2-x1;
    double yDistance = y2-y1;
    return Math.Sqrt(Math.Pow(xDistance,2)+Math.Pow(yDistance,2));
}
Console.WriteLine(GetDistance(xA, yA, xB, yB));
*/


//домашняя работа
// задача принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
/*
Double xA, yA, xB, yB, zA, zB;

Console.Write("input x of point A");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input y of point A");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input z of point A");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("input x of point B");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("input y of point B");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("input z of point B");
zB = Convert.ToDouble(Console.ReadLine());

double GetDistance(double x1, double x2, double y1, double y2, double z1, double z2){
    double xDistance = x2-x1;
    double yDistance = y2-y1;
    double zDistance = z2-z1;
    return Math.Sqrt(Math.Pow(xDistance,2)+Math.Pow(yDistance,2)+Math.Pow(zDistance,2));
}
Console.WriteLine(GetDistance(xA, yA, xB, yB, zA, zB));
*/

