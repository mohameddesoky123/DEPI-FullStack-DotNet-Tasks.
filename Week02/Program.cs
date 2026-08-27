using System;

namespace Daye02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Problem-01
            // int x = 10;
            /*int y = 20;
            int sum = x + y;
            Console.WriteLine(sum);*/
            #endregion

            #region Part01 Question-01
            // Ctrl + K + C to comment the code
            // Ctrl + K + U to uncomment the code
            #endregion

            #region Part01 Problem-02
            //int x = "10";
            //console.WriteLine(x + y);
            //fixed
            //int x = 10;
            //int y = 2;
            //Console.WriteLine(x + y);
            #endregion

            #region Part01 Question-02
            ////Runtime Error
            ////when the syntax is valid, but the program encounters an impossible operation while running.
            //int x = 100;
            //int y = 0;

            //// Throws System.DivideByZeroException and crashes the application
            //int pricePerItem = x / y;
            //-------------------------------------------------------
            ////Logical Error
            ///*when a program runs smoothly without crashing,
            //  but yields incorrect results because the underlying logic or algorithm is flawed..*/
            //double x = 10;
            //double y = 20;

            //// Intended: Calculate average -> (10 + 20) / 2 = 15
            //// Bug: Missing parentheses causes operator precedence to divide first -> 10 + (20 / 2) = 20
            //double average = x + y / 2;

            //Console.WriteLine(average); // Outputs 20 instead of 15 without crashing
            #endregion

            #region Part01 Problem-03
            String fullName = "Mohamed Desoky";
            int age = 21;
            decimal monthlySalary = 100m;
            bool isStudent = true;
            #endregion

            #region Part01 Question-03
            /*
             
            * Aligns your codebase with official Microsoft .NET conventions
            * Identifies code elements at a glance (PascalCase for Classes/Methods/Properties vs. camelCase for Variables/Parameters).
            * Readability & Collaboration: Enhances code maintainability, streamlines code reviews, and simplifies teamwork.
            
             */
            #endregion

            #region Part01 Problem-03

            //Ref P1 = new Ref(); //create object from class Ref
            //   Ref P2 = new Ref(); //create object from class Ref
            //      P1 = P2;

            //Console.WriteLine(P1.num1);
            //P2.num1 = 100;
            //Console.WriteLine(P2.num1);
            #endregion

            #region Part01 Question-04
            /*
             Value types store their actual data directly on the Stack, 
              while reference types store a reference pointer on the Stack that points to object data on the Heap.
             */
            #endregion

            #region Part01 Problem-04

            //int x = 15;
            //int y = 4;
            //int sum = x + y;
            //Console.WriteLine(sum);
            //int sub = x - y;
            //Console.WriteLine(sub);
            //int mul = x * y;
            //Console.WriteLine(mul);
            //double div = (double)x / y;
            //Console.WriteLine(div);
            //double mod = x % y;
            //Console.WriteLine(mod);


            #endregion

            #region Part01 Question-05
            //int a = 2, b = 7;
            //Console.WriteLine(a % b);
            ////What will be the output of the following code? Explain why: 
            ////هيطبع 2 لان باقي القسمة 2 علي 7 هو 2
            #endregion

            #region Part01 Problem-05

            //int Z = 20;

            //if (Z > 10)

            //    Console.WriteLine("Z is greater than 10");

            //    else
            //    {
            //        Console.WriteLine("Z is less than or equal to 10");
            //    }

            //if (Z % 2 == 0)
            //{
            //    Console.WriteLine("Z is even");
            //}
            //    else
            //    {
            //        Console.WriteLine("Z is odd");
            //    }

            #endregion

            #region Part01 Question-06
            /*
              stops evaluating as soon as the first condition is false (short-circuiting), 
              whereas & always evaluates both sides and can also perform bitwise operations.
             */
            #endregion

            #region Part01 Problem-06

            //Console.Write("Enter a double number: ");
            //double y = double.Parse(Console.ReadLine());

            //  // (Explicit Casting)
            //int explicitInt = (int)y;
            //Console.WriteLine(explicitInt); // The decimal part was truncated in explicitInt

            //  // (Implicit Casting)
            //int x = 10;
            //double implicitDouble = x;
            //Console.WriteLine(implicitDouble); // The value of x is converted to double

            #endregion

            #region Part01 Question-06
            /*
             Because converting a double to an int is a narrowing conversion that causes data loss (truncating the decimal part),
            requiring explicit authorization to prevent accidental data loss.
             */
            #endregion

            #region Part01 Problem-07

            //Console.WriteLine("Enter Your Age: ");
            //String ageInput = Console.ReadLine();
            //int Age = int.Parse(ageInput);
            //if (Age > 0 )
            //{
            //    Console.WriteLine("Your age is valid = "+Age);
            //}
            //else
            //{
            //    Console.WriteLine("Your age is invalid.");
            //}

            #endregion

            #region Part01 Problem-08

            //// 1. Prefix (++x)

            //int x = 5;
            //Console.WriteLine("Before Prefix Increment: " + x);
            //int preResult = ++x; // Increment x first, then assign to preResult

            //Console.WriteLine("After Prefix Increment: " + preResult);

            //// --- Postfix ---
            //int y = 5;
            //int postResult = y++; // Assign y (5) to postResult first, then increment y to 6

            //Console.WriteLine("y Value: " + y);           // Output: 6
            //Console.WriteLine("postResult: " + postResult); // Output: 5

            #endregion

            #region Part01 Question-08
            /*
             The value of x after execution is 7 (and y becomes 12).

                Step-by-Step Execution:

                int x = 5;

                x is initialized to 5.

                ++x (Prefix Increment - Evaluated First):

                Increments x from 5 to 6 immediately in memory.

                Evaluates to 6 for the left side of the addition.

                State: x is now 6.

                x++ (Postfix Increment - Evaluated Second):

                Uses the current value of x (6) for the right side of the addition.

                Then increments x in memory from 6 to 7.

                State: x is now 7.

                Final Result:

                y = 6 + 6 = 12

                x = 7
             */
            #endregion




        }
    }
}
