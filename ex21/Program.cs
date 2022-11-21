// Задача№ 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("введите координату двух точек XA: ");
double XA = double.Parse (Console.ReadLine() ?? "");
Console.WriteLine("введите координату двух точек YA: ");
double YA = double.Parse (Console.ReadLine() ?? "");
Console.WriteLine("введите координату двух точек ZA: ");
double ZA = double.Parse (Console.ReadLine() ?? "");
Console.WriteLine("введите координату двух точек XB: ");
double XB = double.Parse (Console.ReadLine() ?? "");
Console.WriteLine("введите координату двух точек YB: ");
double YB = double.Parse (Console.ReadLine() ?? "");
Console.WriteLine("введите координату двух точек ZB: ");
double ZB = double.Parse (Console.ReadLine() ?? "");

double res = DisPoint(XA, YA, ZA, XB, YB, ZB);

Console.WriteLine($" A (); B () -> {res}, разница между ними");

static double DisPoint(double XA, double YA,double ZA, double XB, double YB, double ZB)
{
    return Math.Sqrt(Math.Pow(XA-XB,2) + Math.Pow(YA-YB,2) + Math.Pow(ZA-ZB,2));
}


