﻿// 2. Write a C# Program to print the sum of two numbers. Get the Input from the user. 
using System;  
class Program 
{ 
    static void Main(string[] args) 
    { 
        int num1, num2, sum; 
        Console.WriteLine("Enter first number: "); 
        num1 = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Enter second number: "); 
        num2 = Convert.ToInt32(Console.ReadLine()); 
        sum = num1 + num2; 
        Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum); 
    } 
}