// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void fibo(int N)
{
    int[] x = new int[N];
    x[0] = 0;
    x[1] = 1;
    for (int i = 2; i < N; i++)
    {
        x[i] = x[i - 1] + x[i - 2];
    }
    Console.WriteLine($"[{string.Join(", ", x)}]");

}
fibo(5);
fibo(3);
fibo(7);