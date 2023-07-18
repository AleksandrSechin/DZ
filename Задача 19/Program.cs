// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет    12821 -> да   23432 -> да


Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число! ");
}

// int rev, sum = 0, result = number;
// for (number!= 0; number = number /10){
//     rev = number % 10;    52321     1 2 3 2 5
//     sum = sum * 10 + rev;           1 12 12325
// }
// if (result == sum){
//     Console.WriteLine("Да");
// }
// else {
//      Console.WriteLine("Нет");
// }


// или if (number % 10 == number / 10000 && (number / 10) % 10 == (number / 1000) % 10)