// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int sexponentiation(int number, int degree)
{
    int c = 1;

    for (int i = 0; i < degree; i++)
    {
        c *= number;
    }
    return c;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую необходимо возвести число: ");
int deg = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int res = sexponentiation(num, deg);

Console.WriteLine($"{num}, {deg} -> {res}");