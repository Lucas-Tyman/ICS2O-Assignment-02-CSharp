// Created by: Lucas Tyman
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
      public static void Main(string[] args)
      {
         // This function accepts user input
         double lengthSquare;
         double perimeter;
         
         // input
         Console.WriteLine("This program finds the perimeter of a sqaure. ");
         Console.WriteLine("");
         Console.WriteLine("the formula is: L x 4");
         Console.WriteLine("");
         Console.WriteLine("please enter the measurements (cm)");
         Console.WriteLine("");
         
         Console.Write("Input the measurement for the length :");
         lengthSquare=Convert.ToDouble(Console.ReadLine());
         
         // process
         perimeter = lengthSquare * 4;
        
         // output
         Console.WriteLine("");
         Console.WriteLine("The perimeter of the square is, " + perimeter.ToString("0.00") + " cm");
         Console.WriteLine(" InDone."); 
     }
}