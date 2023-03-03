// Задача 39: Напишите программу, 
// которая перевернёт одномерный массив 
// (последний элемент будет на первом месте,
//  а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] RandomNumbers(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length - 1; i++) array[i] = Random.Shared.Next(0, 10);
    return array;
}



void Revers(int length)
{
    int[] newArray = RandomNumbers(length);
    Console.WriteLine($"[{string.Join(", ", newArray)}]");
    int temp = newArray[0];
    newArray[0] = newArray[length - 1];
    newArray[length - 1] = temp;
    Console.WriteLine($"[{string.Join(", ", newArray)}]");
    Console.WriteLine("_______________________________");

}

Revers(5);
Revers(10);