// задача от преподавателя)
// Пользователь вводит с клавиатуры
//  неопределенное количество чисел (while (true)). 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//  Ввод чисел останавливается при помощи ввода слова "stop"

string newArray()
{
    bool stop = false;
    int count = 0;
    string x = "";
    while (stop == false)
    {
        string temp = Console.ReadLine();
        if (temp == "stop")
        {
            stop = true;
            break;
        }
        x += temp;
        count++;
    }
    return x;
    //Console.WriteLine($"x = {x},count = {count}");
}

void zeroMax()
{
    string x = newArray();
    int count = x.Length;
    int zero_max = 0;
    for (int i = 0; i < count; i++)
    {
        if (x[i] > 0) zero_max++;
        Console.WriteLine($"x[{i}] = {x[i]}");
    }
    Console.WriteLine($"x = {x}, zero_max = {zero_max}");
}

zeroMax();