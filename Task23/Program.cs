//Задача  23 

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());

int counter = 1;
string cube (int num)
{
    return $"{num}  {num*num*num}";
}

while(counter <= numX)
{
    Console.WriteLine(cube(counter));
    counter++;
}