// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] RandomArray(int L)
{
    int[] arr = new int[L];

    for (int i = 0; i < L; i++)
    {
        arr[i] = new Random().Next(0, 100); // Можно обойтись и без ограничения, но тогда будет выглядеть совсем не как на примере: 1417802400, 573679389, 246202337, 1472258481, 1434183524, 2053342103, 838798319, 69631799 -> [1417802400, 573679389, 246202337, 1472258481, 1434183524, 2053342103, 838798319, 69631799]
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