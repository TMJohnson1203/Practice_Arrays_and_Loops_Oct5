using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Arrays_and_Loops_Oct5
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] myFavBooks = { "Sense and Sensibility”, “War and Peace”, “The King has Returned" };
            //Console.WriteLine(myFavBooks.Length-1);

            // when you know HOW MANY slots you have but do NOT know the VALUE for those slots


            //string[] myFavBooks = new string[3];
            //myFavBooks[0] = "Sense and Sensibility";
            //myFavBooks[1] = "War and Peace";
            //myFavBooks[2] = "The King has Returned";
            //Console.WriteLine(myFavBooks[2].Length-1);


            //// when you KNOW the data


            // .Legnth - 1 (or other amount)
            //string[] dayOfWeek = {"sun", "mon", "tues", "weds", "thurs", "fri", "sat" };

            //int[] studentAge = new int[7];

            //Console.WriteLine(dayOfWeek[dayOfWeek.Length -2]);
            // will print fri



            // .Length method

            //string[] firstLetters = { "T", "E", "R", "E", "S", "A"};
            //Console.WriteLine(firstLetters.Length);

            string[] catsNames = { "Mia", "Murphy", "Scruffy" };
            Console.WriteLine(Array.IndexOf(catsNames, "Mia"));

            // will print MIA

            string[] friendNames = { "Rashida", "Melissa", "Ryan", "Tim" };
            Console.WriteLine(Array.IndexOf(friendNames, "Ryan"));

            //// LAST index of
            //int[] luckyNum = { 1, 2, 3, 7, 13, 1, 23, 3, 19 };

            //Console.WriteLine(Array.LastIndexOf(luckyNum, 3));



            //  REVERSE
            int[] luckyNum = { 1, 2, 3, 7, 13, 1, 23, 3, 19 };
            Array.Reverse(luckyNum);
            Console.WriteLine(luckyNum[0]);

            // SORT from 1-10 or A-Z
            int[] sortLucky = { 1, 2, 3, 7, 13, 1, 23, 3, 19 };
            Array.Sort(sortLucky);

            string[] kidNames = { "Rashida", "Melissa", "Ryan", "Tim" };
            Array.Sort(kidNames);
            Console.WriteLine(kidNames[0] + " "  + kidNames[3]);


            // for Loop

            string[] days = {"Mon", "Tue", "Weds", "Thurs"};
            
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

            // LOOPS
            // intitalizer, condition, updater (updates the condition)

            int counter = 0;
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            int sum = 0;
            int numberCount = 1;
            while (numberCount <= 10)
            {
                sum += numberCount;
                numberCount++;
            }
            //Console.WriteLine(sum);

            //// user gives range of low number and high number
            //int[] rangeofNumbers = { };
            //rangeofNumbers = ;

            //int[] highNumber;
            //int[] LowNumber;

            //while ()
            {

            }

            int[] userNumStart = { };

            int[] userNumEnd = { };

            Console.WriteLine("Please enter a whole number to serve as your starting number");


            while (int userNum = 50; userNum <= 100; userNum++)
            {
                Console.WriteLine(userNum);
            }


        }
    }
}
