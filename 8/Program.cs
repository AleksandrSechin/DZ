// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// 8 -> 2 4 6 8

Console.Write("Напишите число ");
int N = Convert.ToInt32(Console.ReadLine());
for(int a=1; a<=N; a++){
if (a % 2 == 0)
    Console.Write(a + " ");
}