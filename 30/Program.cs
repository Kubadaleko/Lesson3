// // 30. Написать программу вычисления произведения чисел от 1 до N

// Без подпрограммы

int n = Convert.ToInt32(Console.ReadLine());
int product_of_numbers = 1;

for (int i = 1; i <= n; i++)
{
    product_of_numbers = product_of_numbers * i;
}
System.Console.WriteLine(product_of_numbers);


// 30. Написать программу вычисления произведения чисел от 1 до N

// С подпрограммой

int n = Convert.ToInt32(Console.ReadLine());
int product_of_numbers = 1;

int Product(int n)
{
    for (int i = 1; i <= n; i++)
    {
        product_of_numbers = product_of_numbers * i;
    }
    return product_of_numbers;
}

System.Console.WriteLine(Product(n));