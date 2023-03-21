//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите посследовательность координат: ");
int XA, YA, ZA;
int XB, YB, ZB;

    Console.Write("Введите X точки A: ");
XA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Y точки A: ");
YA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Z точки A: ");
ZA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите X точки B: ");
XB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Y точки B: ");
YB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Z точки B: ");
ZB = Convert.ToInt32(Console.ReadLine());

double number = Math.Pow(XB - XA, 2) + Math.Pow(YB - YA, 2) + Math.Pow(ZB - ZA, 2);
number = Math.Sqrt(number);
number = Math.Round(number, 2);
Console.WriteLine(number);
