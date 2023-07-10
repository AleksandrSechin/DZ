// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел
// 2, 3, 7 -> 7 

Console.WriteLine("Напишите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(max < number2) max = number2;
if(max < number3) max = number3;{
    Console.WriteLine($" Максимальное число {max}");
}