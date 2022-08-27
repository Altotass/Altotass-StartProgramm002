// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Calendar()
{
    Console.WriteLine ("Напишите число от 1 до 7");
    Console.WriteLine ("x= ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 5) Console.WriteLine("Да, выходной день");    
    else Console.WriteLine("Нет, это будний день");
}
Calendar();