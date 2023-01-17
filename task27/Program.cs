// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int length(int num)
{
    int i = 0;
    for (; num > 0; num /= 10)
    {
        i++;
    }
    return i;
}

int ProductOfDigits(int len, int num)
{
    int product = 0;

    for (; len > 0; len -= 1)
    {
        product += (num % 10);
        num /= 10;
    }

    return product;
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int L = length(N);

int P = (ProductOfDigits(L, N));

Console.WriteLine($"{N} -> {P}");
