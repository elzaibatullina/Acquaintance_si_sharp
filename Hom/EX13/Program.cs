﻿//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

//78 -> третьей цифры нет

// 32679 -> 6

int n = 78;


 if (n >= 1000)
 {
    n /= 100;
    Console.WriteLine(n % 10);
 }
  
 else
 {
    Console.WriteLine ("Третьей цифры нет");
 }
 
 






 