// 25.Вывести на экран кубы чисел от 1 до N


int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int x = Convert.ToInt32(Math.Pow(i, 3));
    System.Console.WriteLine(x);
}

