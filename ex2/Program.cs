// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 4, N = 8;

int GetSum (int M, int N)
{
    if(N == M) return M;
    else return N + GetSum(M, N-1);
}

int result = GetSum(M, N);
System.Console.WriteLine(result);
