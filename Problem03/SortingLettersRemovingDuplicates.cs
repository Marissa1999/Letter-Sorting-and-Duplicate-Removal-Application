//ID: 1775227
//Name: Marissa Goncalves
//Assignment 3 - Problem 3: Sorting Letters and Removing Duplicates

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class SortingLettersRemvoingDuplicates
    {
        static void Main(string[] args)
        {

            //Create a new random object generating random numbers.
            Random randomNumber = new Random();

            //Create a new list which stores numbers.
            List<int> numberList = new List<int>();

            //For every number from 1 to 30,
            for(int number = 1; number <= 30; number++)
            {
                //Add a random number to the list of integers from 10 to 99.
                numberList.Add(randomNumber.Next(10, 100));
            }



            //a) Display the original List.

            //Print the title for the original number list.
            Console.WriteLine("Original Number List: ");

            //For every element in the list of numbers,
            foreach (var element in numberList)
            {
                //Print the element from the list.
                Console.Write($"{element} ");
            }

            //Skip a line.
            Console.WriteLine();

            //Skip a line.
            Console.WriteLine();




            //b) Use LINQ to sort the List in ascending order.

            //Create a LINQ variable to sort the list in ascending order according to the number.
            var sortedAscendingNumberList =
                from value in numberList
                orderby value ascending
                select value;

            //Print the title for the number list in ascending order.
            Console.WriteLine("Number List in Ascending Order: ");

            //For every element in the sorted number list by ascending order,
            foreach (var element in sortedAscendingNumberList)
            {
                //Print the element from the sorted list.
                Console.Write($"{element} ");
            }

            //Skip a line.
            Console.WriteLine();

            //Skip a line.
            Console.WriteLine();





            //c) Use LINQ to sort the List in descending order.

            //Create a LINQ variable to sort the list in descending order according to the number.
            var sortedDescendingNumberList =
                from value in numberList
                orderby value descending
                select value;

            //Print the title for the number list in descending order.
            Console.WriteLine("Number List in Descending Order: ");

            //For every element in the sorted number list by descending order,
            foreach (var element in sortedDescendingNumberList)
            {
                //Print the element from the sorted list.
                Console.Write($"{element} ");
            }

            //Skip a line.
            Console.WriteLine();

            //Skip a line.
            Console.WriteLine();




            //d) Display the List in ascending order with duplicates removed.

            //Create a LINQ variable to sort the list in ascending order and remove duplicate numbers.
            var distinctAscendingNumberList =
                from value in numberList
                orderby value ascending
                select value;

            //Print the title for the number list in ascending order and duplicates removed.
            Console.WriteLine("Number List in Ascending Order with Duplicates Removed: ");

            //For every element in the sorted number list by ascending order, while removing duplicates,
            foreach (var element in distinctAscendingNumberList.Distinct())
            {
                //Print the element from the sorted and unique list.
                Console.Write($"{element} ");
            }

            //Skip a line.
            Console.WriteLine();

            //Skip a line.
            Console.WriteLine();





        }
    }
}
