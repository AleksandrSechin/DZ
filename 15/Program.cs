// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день
//  выходным. 6 -> да  1 -> нет


Console.Write("Напишите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Нет такого номера дня недели");
}
else if ((number == 6) || (number == 7))
{
    Console.WriteLine("Этот день выходной");
}
else
{
    Console.WriteLine("День не является выходным");
}