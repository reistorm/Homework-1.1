// Напишите программу, которая на вход принимает 
// число (N), а выход показывает все четные числа
// от 1 до N

Console.Write("Введите целое число = ");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    Console.WriteLine(i + " ");
}
for(int i = 1; i <= n-1; i++)
{
  int num = i % 2;
  if (num < 0)
  {
      Console.Write(i);
  }
  else
  {
      i++;
  }
  Console.Write(i + " ");
}

