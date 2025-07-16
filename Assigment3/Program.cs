using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ASSIGMEN[3]
            //1.Write a program that allows the user to enter a number then print it.
            //int Number;
            //Console.Write("Enter Number:");
            //bool flagNumber = int.TryParse(Console.ReadLine() , out Number);
            //Console.WriteLine(flagNumber);
            //Console.WriteLine($"Number Is {Number}");


            //2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //string Str = "Num";
            //int Number = Convert.ToInt32(Str); //EXEPTION
            //int Number = int.Parse(Str); //EXEPTION

            //int Number;
            //int.TryParse(Str, out Number);
            //Console.WriteLine(Number); //HERE PRINT 0 // BECAUSE IN CASE FAIL THE CONVERT RETURN 0 AND VARIBLE SAVE 0 

            //SHOLUD USE TRYPARSE 


            //3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //double Res , X = 20.6 , Y = 23.5 ;
            //Res = X + Y;
            //Console.WriteLine(Res); // 44.1


            //4.Write C# program that Extract a substring from a given string.
            //string str = Console.ReadLine();
            //Console.WriteLine(str.Substring(1 , 2));

            //if(str.Length >= 3)
            //{
            //    Console.WriteLine(str.Substring(1 , 2));
            //}
            //else
            //{
            //    Console.WriteLine("Input is too short");
            //}



            //5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int X = 5;
            //int Y = X;// Y = 5 , X = 5 
            //X+=5; //X = 10 , Y = 5
            //Y Not change when x changed 
            //And because int is value type
            //Console.WriteLine($"X = {X} , Y = {Y}");

            //6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //BUT IN STRING IS DIFFERENT BECAUSE STRING IS REFERANCE TYPE 
            //string A = "Hello";
            //string B = A;        // B points to same string as A IN HEAP

            //A = "World";         // A now points to new string IN HEAP
            //Console.WriteLine($"A = {A}, B = {B}"); // A = World, B = Hello

            //Anther example

            //Box firstBox = new Box
            //{
            //    Width = 10
            //};

            //Console.WriteLine(firstBox.Width); // 10

            //Box secondBox = firstBox; 
            //Console.WriteLine(secondBox.Width); // 10


            //secondBox.Width = 20;

            //Console.WriteLine(secondBox.Width); // 20
            //Console.WriteLine(firstBox.Width);// 20
            //Two varibles in stack points to same object in heap
            //when one from two change the anther change



            //7.Write C# program that take two string variables and print them as one variable 
            //Console.Write("Enter first value: ");
            //string firstSubString = Console.ReadLine();
            //Console.Write("Enter second value: ");
            //string secondSubString = Console.ReadLine();
            //Console.WriteLine($"{firstSubString}{secondSubString}");


            //8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            // Note: The formula for simple interest is Interest = (principal * rate * time) / 100.
            //decimal Interest, principal, rate, time;
            //Console.Write("Enter principal value: ");
            //decimal.TryParse(Console.ReadLine(), out principal);
            //Console.Write("Enter rate value: ");
            //decimal.TryParse(Console.ReadLine(), out rate);
            //Console.Write("Enter time value: ");
            //decimal.TryParse(Console.ReadLine(), out time);

            //Interest = (principal * rate * time) / 100m;
            //Console.Clear();
            //Console.Write($"Interest value = {Interest}");


            //9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            //Note :The formula for BMI is BMI = (Weight)/(Height*Height)

            //decimal BMI , Weight, Height;
            //Console.Write("Enter Weight value(kg): ");
            //decimal.TryParse(Console.ReadLine(), out Weight);
            //Console.Write("Enter Height value(m): ");
            //decimal.TryParse(Console.ReadLine(), out Height);

            //BMI = (Weight) / (Height * Height);
            //Console.Clear();
            //Console.Write($"BMI value = {BMI}");




            //10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
            //Note:
            //a.that below 10 degrees is "Just Cold"
            //b.above 30 degrees is "Just Hot"
            //c.anything else is "Just Good"

            //Console.Write("Enter Your Degree:");
            //bool valid = int.TryParse(Console.ReadLine(), out int  degree);

            //if (!valid) {
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    return;
            //}
            //string message = degree < 10 ? "Just Cold" : degree > 30 ? "Just Hot" : "Just Good";
            //Console.Write(message);


            //11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            //Console.Write("Enter a date (e.g. 20/11/2001): ");

            //if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            //{
            //    Console.WriteLine("Invalid date.");
            //    return;
            //}

            //Console.Clear();

            //Console.WriteLine($"Today's date : {date:dd} , {date:MM} , {date:yyyy}");

            //Console.WriteLine($"Today's date : {date:dd} / {date:MM} / {date:yyyy}");

            //Console.WriteLine($"Today's date : {date:dd} - {date:MM} - {date:yyyy}");



            //12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Example(1)
            //Input: 12
            //Output: Yes
            //Example(2)
            //Input: 9
            //Output: No

            //Console.Write("Enter a Numbere: ");

            //bool vaild = int.TryParse(Console.ReadLine(), out int Num);
            //string Mes = !vaild ? 
            //             "Number is invild" : 
            //             Num % 4 == 0 && Num % 3 == 0 ? 
            //             "YES" : "NO";
            //Console.Clear();
            //Console.Write(Mes);


            //13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Example(1)
            //Input: -5
            //Output: negative
            //Example(2)
            //Input: 10
            //Output: positive


            //bool vaild = int.TryParse(Console.ReadLine(), out int Num);
            //string Mes = !vaild ?
            //             "Number is invild" :
            //             Num > 0 ? "positive" :
            //             Num == 0 ? "Number is 0" : "negative";
            //Console.Clear();
            //Console.Write(Mes);


            //    14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            //    Example(1)
            //    Input: 7,8,5
            //    Output:
            //            max element = 8
            //    min element = 5
            //—--------------------------------
            //    Example(2)
            //    Input: 3 6 9
            //    Outputs:
            //            Max element = 9
            //    Min element = 3

            //int num1, num2, num3;

            //Console.Write("Enter first number: ");
            //int.TryParse(Console.ReadLine(), out num1);

            //Console.Write("Enter second number: ");
            //int.TryParse(Console.ReadLine(), out num2);

            //Console.Write("Enter third number: ");
            //int.TryParse(Console.ReadLine(), out num3);

            //int max = num1;
            //if (num2 > max) max = num2;
            //if (num3 > max) max = num3;

            //int min = num1;
            //if (num2 < min) min = num2;
            //if (num3 < min) min = num3;

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");


            //15 - Write a program that allows the user to insert
            //an integer number then check If a number is even or odd.

            //bool vaild = int.TryParse(Console.ReadLine(), out int Num);
            //string Mes = !vaild ?
            //             "Number is invild" :
            //             Num % 2 == 0 ? "EVEN" : "ODD";
                         
            //Console.Clear();
            //Console.Write(Mes);




            //16 - Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //Example(1)
            //Input: O
            //Output: vowel
            //Example(2)
            //Input: b
            //Output: Consonant

            char ch = Console.ReadKey().KeyChar;

            if(!char.IsLetter(ch))
            {
                Console.WriteLine("Invalid input. Please enter a letter only.");
                return;
            }

            ch = char.ToLower(ch);

            bool isVowel = ch == 'a' || ch == 'e' ||
                           ch == 'i' || ch == 'o' ||
                           ch == 'u';

            string Mes = isVowel ?"Vowel" : "consonant";

            Console.Clear();
            Console.WriteLine(Mes);

            //17 - Write a program to input the month number and print the number of days in that month.
            //Example
            //Input: Month Number: 1
            //Output: Days in Month: 31

            Console.Write("Enter month number (1 - 12): ");
            bool valid = int.TryParse(Console.ReadLine(), out int month);

            if (!valid || month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month number.");
            }
            else
            {
                int days = 0;

                if (month == 2)
                {
                    days = 28;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    days = 30;
                }
                else
                {
                    days = 31;
                }

                Console.WriteLine($"Days in month: {days}");
            }



            #endregion
        }
    }

    class Box
    {
        public int Width;
    }


}
