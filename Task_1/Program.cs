// Напишите программу, которая на вход принимает три числа
// и выдает максимальное из этих чисел

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());
int max = 0;
int max1 = 0;
if (numberA > numberB)
{
    max1 = numberA;
    Console.WriteLine(max1);
}
else
{
    max1 = numberB;
Console.WriteLine(max1);
}
if (numberC > max1)
{
    max = numberC;
    Console.WriteLine("Максимальное число = " + max);
}
else
{
    max = max1;
Console.WriteLine("Максимальное число = "+ max);
}

