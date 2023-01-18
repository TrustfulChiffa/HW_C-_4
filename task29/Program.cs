// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] RandomArray(int L)
{
    int[] arr = new int[L];

    for (int i = 0; i < L; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

void PrintArray(int L, int[] arr)
{
    for (int i = 0; i < L - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[L - 1]} -> [");

    for (int i = 0; i < L - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[L - 1]}]");
}


int length = 8;

int[] array = RandomArray(length);

PrintArray(length, array);