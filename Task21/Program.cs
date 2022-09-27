//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int numAX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int numAY = Convert.ToInt32(Console.ReadLine());
Console.Write("C: ");
int numAC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int numBX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int numBY = Convert.ToInt32(Console.ReadLine());
Console.Write("C: ");
int numBC = Convert.ToInt32(Console.ReadLine());

double LenghtLine (int ax, int ay, int ac, int bx, int by, int bc)
{
    if (ay == by && bx == by && ac == bc) return 0;
    int x = bx - ax;
    int y = by - ay;
    int c = bc - ac;
    return Math.Sqrt(x*x + y*y + c*c);
}
double LenghtAB = LenghtLine(numAX, numAY, numAC, numBX, numBY, numBC);
double lenght = Math.Round(LenghtAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"-> {lenght}");
