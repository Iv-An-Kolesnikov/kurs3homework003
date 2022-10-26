﻿//19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//============================================================================================================
Console.Clear();
Console.Write("Введите пожалуйста пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num < 9999) || (num >= 99999)) 
{
    Console.WriteLine($"Введено не пятизначное число");
}
else
{
    int[] arr = {num / 10000, (num / 1000) % 10, (num / 10) % 10, (num % 10)};
    if ((arr[0] == arr[3]) & (arr[1] == arr[2])) Console.Write($"{num} -> Да");
    else Console.Write($"{num} -> Нет");
}