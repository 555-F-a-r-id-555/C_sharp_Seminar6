// Задача 45: Напишите программу, которая будет
// создавать копию заданного массива
// с помощью поэлементного копирования.

int[] RandomNumbers(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length - 1; i++) array[i] = Random.Shared.Next(0, 10);
    return array;
}


void CopyArray(int length)
{
    int[] new_array = new int[length];
    int[] old_array = RandomNumbers(length);

    for (int i = 0; i < length; i++)
    {
        new_array[i] = old_array[i];
    }
    Console.WriteLine($"new_array = [{string.Join(", ", old_array)}]");
    old_array[0] = -5;
    Console.WriteLine($"new_array = [{string.Join(", ", old_array)}]");
    Console.WriteLine($"new_array = [{string.Join(", ", new_array)}]");
}



CopyArray(5);