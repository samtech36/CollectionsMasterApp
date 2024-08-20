using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //utilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //Create an integer Array of size 50 (DONE)

            var numbers = new int[50];
            
            

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50 (DONE)
            Populater(numbers);
            

            //Print the first number of the array (DONE)
            
            Console.WriteLine($"First number is: {numbers[0]}");

            //Print the last number of the array (DONE)
            Console.WriteLine($"Second number is: {numbers[numbers.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console. (DONE)
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            
            Array.Reverse(numbers);

            Console.WriteLine("All Numbers Reversed:");
            
            NumberPrinter(numbers);
            

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");
            
            

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers (DONE)
            
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(numbers);
            
            NumberPrinter(numbers);
           

            Console.WriteLine("-------------------");

            //Sort the array in order now (DONE)
            /*      Hint: Array.____()      */
            
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List (DONE)
            var numberList = new List<int>();

            //Print the capacity of the list to the console (DONE)
            Console.WriteLine($"Capacity list: {numberList.Capacity}");
            

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this (DONE)        
            Populater(numberList);

            //Print the new capacity (DONE)
            Console.WriteLine($"Capacity list after population: {numberList.Capacity}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list (DONE)
            //Remember: What if the user types "abc" accident your app should handle that!

            int searchNumber;
            bool matchNumber;


            do
            {
                Console.WriteLine("What number you want to search for in the list?");
                matchNumber = int.TryParse(Console.ReadLine(), out searchNumber);


            } while (!matchNumber);

            NumberChecker(numberList, searchNumber);
            
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            // Create a method that will remove all odd numbers from the list then print results (DONE)
            
            Console.WriteLine("Evens Only!!");
            
            OddKiller(numberList);
            NumberPrinter(numberList);
            
            
            Console.WriteLine("------------------");

            //Sort the list then print results (DONE)
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable (DONE)
            var convertList = numberList.ToArray();

            //Clear the list (DONE)
            numberList.Clear();
            Console.WriteLine("The list is cleared!");

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                
                
            }
            
            
            
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
                    
            }
            
            

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes, the number {searchNumber} is on the list");
            }
            else
            {
                Console.WriteLine($"No, the number {searchNumber} is not on the list");
            }
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
           
            
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 51));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }

           
            

        }        

        
        //Reverse Array
        private static void ReverseArray(int[] array)
        {
            int begin = 0;
            int end = array.Length - 1;

            while (begin < end)
            {
                int temp = array[begin];
                array[begin] = array[end];
                array[end] = temp;

                begin++;
                end--;
            }

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
