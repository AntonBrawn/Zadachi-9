// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


using System;
using static System.Console;
Clear();
{
WriteLine("Введите A: ");
int A = int.Parse(ReadLine());
WriteLine("Введите B: ");
int B = int.Parse(ReadLine());

WriteLine(Ackermann(A, B));

int Ackermann (int m, int n)
{
    return m==0? n+1
    : m>0 && n==0? Ackermann(m-1,1)
    : Ackermann(m-1,Ackermann(m, n-1));
}

}