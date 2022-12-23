// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
const int N = 8;

void WriteNumbers (int N)
{
    if(N == 1) System.Console.Write( 1);
    else 
    {
        System.Console.Write(N+", ");
        WriteNumbers(N-1);
    }
}

WriteNumbers(N);