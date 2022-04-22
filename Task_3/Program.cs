// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите цифру, отвечающую дню недели: ");
int day;
day = int.Parse(Console.ReadLine());
if (day == 1)
    Console.WriteLine("Monday, go to work");
if (day == 2)
    Console.WriteLine("Tuesday, go to work");
if (day == 3)
    Console.WriteLine("Wednesday, go to work");
if (day == 4)
    Console.WriteLine("Thursday, go to work");
if (day == 5)
    Console.WriteLine("Friday, go to work");
if (day == 6)
    Console.WriteLine("Saturday, day off!");
if (day == 7)
    Console.WriteLine("Saturday, day off!");  