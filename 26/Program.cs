// 26.Найти сумму чисел от 1 до А

int a = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 1; i <= a; i++)
{
    result = result + i;
}
System.Console.WriteLine(result);