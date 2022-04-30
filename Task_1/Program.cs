// Напишите программу, которая на вход принимает 
// число и выдает, является ли число чётным 
// (делится ли оно на два без остатка)

double num = double.Parse(Console.ReadLine());
double result = num % 2;
Console.WriteLine(result);
if (result > 0)
{
    Console.WriteLine("Число " + num + " является нечетным");
}

else
{
    Console.WriteLine("Число " + num + " является четным");
}
