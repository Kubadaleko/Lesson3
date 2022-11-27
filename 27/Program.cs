// 27. Возведите число А в натуральную степень B используя цикл


int numberA = Convert.ToInt32(Console.ReadLine());
int degreeB = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i <= degreeB; i++)
{
    result = Convert.ToInt32(Math.Pow(numberA, degreeB));
}
System.Console.WriteLine(result);
