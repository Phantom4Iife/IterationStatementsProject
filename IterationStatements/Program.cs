using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: May you please follow the instructions provided in each comment below to complete the exercise.
            // Please use the example given to guide your implementation.

            //Please create a List called "numbers" - DONE!
            List<int> numbers = new List<int>();  //DO NOT ERASE THIS POR FAVOR! You will most definetly use this in the exercise.
            
            //-----START HERE------------------------------------------Pretty Please

            //TODO - I would appreciate if you could create a variable of type int and name it "num"
            //TODO - Initialize the variable with a value of 0 please
            int num = 0;

            //TODO - Create a do-while loop using the existing brackets as a template extremely smart gentleman.
            // The existing brackets are probably placeholders for your loop code.
            // Inside this loop:
            // a) Please increment "num" by 1
            // b) Then I would like you to add "num" to the collection "numbers"
            //    Hint: Please use "numbers.Add(num);" to add the current value of "num" to the list. I know you're smart enough to not need hints tho
            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100);
            //TODO - Continue the loop while "num" is less than 100 por favore


            //TODO - Create a while loop using the existing brackets as a template, bitte.
            //TODO - Continue the loop while "num" is less than 200, bitte und danke
            // I know you understand that the existing brackets are placeholders for your loop code.
            // Inside this loop:
            // a) Increment "num" by 1
            // b) Then add "num" to the collection "numbers"
            //    Hint: You can copy how this was done in the do-while loop (I apologize student for not having manners in the latter half)
            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }
            


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            //TODO - Create a foreach loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop, print each number in "numbers".
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            //TODO - Create a for loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // This loop will print the numbers in reverse order - from 200 to 1.

            // a) In your initializer, set the value of "i" to 199
            // b) In your conditional, ensure that the loop continues as long as "i" is:
            //    - Less than or equal to the number of items in "numbers" (use "numbers.Count")
            //    - Greater than or equal to 0
            // c) Decrement "i" by 1 in each iteration
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                //TODO - Inside the loop, place numbers[i] inside of the Console.WriteLine() method
                Console.WriteLine(numbers[i]); // Example placement of numbers[i] inside Console.WriteLine
            }

            //------------End of exercise

        }
    }
}
