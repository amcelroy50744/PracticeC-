using System;
using System.Collections.Generic;
using static System.Console;

namespace PracticeSeptember
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string myName = "Hello World, " + "my name is Andre";
            Console.WriteLine(myName);
            string message = "Hello World";

            var dum = "Hello World".Length;

            Console.WriteLine(dum);
            var realDum = myName.Length;
            Console.WriteLine(realDum);
            var newMessage  = message.Substring(2, 5);
            Console.WriteLine(newMessage);
            string[] separator = { ", ", "; " };
            string names = "Peter, John; Andy, , David";
            string[] substrings = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach(var x in substrings) 
            {
                Console.WriteLine(x);
            }

            int[] myArray = new int[10];
            List<int> userAgeList = new List<int>() {11, 21, 31, 41 };
            Console.WriteLine(userAgeList[0]);
            userAgeList.Add(51);
            userAgeList.Add(61);
            foreach(var x in userAgeList) 
            {
                Console.WriteLine(x);
            }

            var myCount = userAgeList.Count;
            Console.WriteLine($"My age list has {myCount} ages in it");
            userAgeList.Insert(2, 34);
            WriteLine(myCount);


            Write("Enter your grade: ");
            string userGrade = ReadLine();

            switch (userGrade) 
            {
                case "A+":
                case "A":
                    Console.WriteLine("Distinction");
                    break;
                case "B+":
                case "B":
                    Console.WriteLine("B Grade");
                    break;
                case "C":
                    Console.WriteLine("C Grade");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;

            }

            for (int i = 0; i <= 5; i++)
            {
                WriteLine(i);
            }

            int[] myNumbers = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < myNumbers.Length; i++)
            {
                WriteLine(myNumbers[i]);
            }

            char[] hMessage = { 'H', 'e', 'l', 'l', 'o' };
            foreach (char i in hMessage) 
            {
                Write(i);
            }

            int counter = 5;
            while (counter > 0) 
            {
                WriteLine("Counter = {0}", counter);
                counter = counter - 1;
            }

            int counter2 = 100;
            do
            {
                Console.WriteLine("Counter = {0}", counter2);
                counter2++;
            } while (counter2 < 0);
        }
        

    }
}
