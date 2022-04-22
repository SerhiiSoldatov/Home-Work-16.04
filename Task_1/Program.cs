// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int a = num / 100;
int b = ((num / 10) % 10);
int c = num %10;
System.Console.WriteLine($"{a}{c}");