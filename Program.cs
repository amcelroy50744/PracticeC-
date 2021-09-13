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


        }
    }
}
