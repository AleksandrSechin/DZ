// Напишите программу, которая на вход принимает число и выдает является ли число четным
// 4 -> да

Console.Write("Напишите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0){
    Console.WriteLine("Это четное число");
}
else Console.WriteLine("Это нечетное число");