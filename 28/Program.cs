// 28. Определить количество цифр в числе. Сделать подпрограмму.

// Без подпрограммы

int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
string f = Convert.ToString(number);

System.Console.WriteLine(f.Length);



// 28. Определить количество цифр в числе. Сделать подпрограмму.

//C подпрограммой

int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int AmountNumbers(int number)
{
    string f = Convert.ToString(number);
    return f.Length;
}

System.Console.WriteLine(AmountNumbers(number));