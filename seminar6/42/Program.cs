// Задача 42: Напишите программу, 
// которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Вариант - 1;
void binary(int N)
{
    string x = "";
    while (N > 0)
    {
        x = (N % 2) + x;
        N = N / 2;
    }
    Console.WriteLine($"N2 = {x}");
    Console.WriteLine("--------------");

}
binary(45);
binary(3);
binary(2);
binary(1);
binary(87);

// Вариант - 2;

// void printFunction(int N)
// {
//     Console.Write("N2 = ");
//     Console.Write($"{binary1(N)}");
//     Console.WriteLine("\n**************");

// }

// int binary1(int N)
// {
//     string x = "";

//     if (N > 0)
//     {

//         x += N % 2;
//         Console.Write($"{x}");
//         return binary1(N / 2);
//     }
//     else return 0;

// }
//binary1(45);
// binary1(46);
// Console.WriteLine($"\nText");


// void revers(int N)
// {
//     string x = $"{binary1(N)}";
//     //Console.WriteLine($"{x}");

//     int[] newX = new int[x.Length - 1];
//     for (int i = x.Length - 1; i > 0; i--)
//     {
//         newX[i - x.Length - 1] = x[i];


//     }
//     Console.WriteLine($"{string.Join(", ", newX)}");
//Console.WriteLine($"_____________");
//}
//revers(45);
// revers(46);

// printFunction(45);
// printFunction(3);
// printFunction(2);
// printFunction(1);
// printFunction(87);


