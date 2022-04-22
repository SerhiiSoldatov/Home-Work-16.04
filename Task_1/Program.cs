// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int numberA = new Random().Next(100, 1000);
Console.WriteLine(numberA);
int a = numberA %10;
int b = a %10;
int c = b %10;
System.Console.WriteLine($"{c}{a}");