//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int RandomNumber = new Random().Next(0, 1000);
Console.WriteLine(RandomNumber);

int rightNumber = RandomNumber / 10;
int rightNumber2 = rightNumber % 10;

Console.WriteLine(rightNumber2);