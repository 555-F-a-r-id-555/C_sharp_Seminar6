// Задача 42: Напишите программу, 
// которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Вариант - 1;
function binary(N) {
    x = "";
    while (N > 0) {
        x = (N % 2) + x;
        N = Math.floor(N / 2);
    }
    console.log(`N2 = ${x}`);
    console.log("-----------------");
}
binary(45);
binary(3);
binary(2);
binary(87);