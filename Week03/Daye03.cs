using System;
using System.Text;

namespace Daye03
{
    internal class Daye03
    {
        static void Main(string[] args)
        {

            //Part01
            #region problem01 
            /*
             Problem: Write a program to:
                o Accept a string input from the user.
                o Convert it to an integer using both int.Parse and Convert.ToInt32.
                o Handle potential exceptions using a try-catch block. 

             */
            //    Console.WriteLine("Enter a Number : ");
            //    string input = Console.ReadLine();
            //    //int number1 = int.Parse(input);
            //    //      Console.WriteLine($"The number is: {number1}");
            //     //int number2 = Convert.ToInt32(input);
            //     //   Console.WriteLine($"The number is: {number2}");

            //try
            //{
            //    int number1 = int.Parse(input);
            //    Console.WriteLine($"The number is: {number1}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Input is not in a correct format.");
            //}

            //try
            //{
            //    int number2 = Convert.ToInt32(input);
            //    Console.WriteLine($"The number is: {number2}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Input is not in a correct format.");
            //}

            #endregion

            #region Qustion01
            //int.Parse(null) throws an ArgumentNullException, whereas Convert.ToInt32(null) handles null safely and returns 0.
            #endregion

            #region problem02

            //Console.WriteLine("Enter a number : ");
            //string inp = Console.ReadLine();
            //bool flag = int.TryParse(inp, out int number);
            //if (flag && number > 0)
            //{
            //    Console.WriteLine($"The number is valid = {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Number! Please enter a valid integer.");
            //}
            #endregion

            #region Qustion02
            //TryParse is recommended because it safely handles invalid user input without throwing performance-heavy exceptions, preventing application crashes.
            #endregion

            #region problem03

            //object obj;

            //obj = 15;
            //Console.WriteLine($"Value: {obj} | Type: {obj.GetType()} | HashCode: {obj.GetHashCode()}");

            //obj = "Hello, World!";
            //Console.WriteLine($"Value: {obj} | Type: {obj.GetType()} | HashCode: {obj.GetHashCode()}");

            //obj = 3.14;
            //Console.WriteLine($"Value: {obj} | Type: {obj.GetType()} | HashCode: {obj.GetHashCode()}");

            #endregion

            #region Qustion03
            /*
             The primary purpose of GetHashCode() is to return an integer value used
            for fast indexing and lookup in hash-based collections, such as Dictionary and HashSet.
             */
            #endregion

            #region problem04

            //Person P1 = new Person();
            //Person P2 = new Person();
            //P1.Name = "Mohamed";
            //P2 = P1;
            //Console.WriteLine($"P1.Name: {P1.Name}");
            //Console.WriteLine($"P2.Name: {P2.Name}");

            //P1.Name = "Ali";

            //Console.WriteLine($"P1.Name: {P1.Name}");
            //Console.WriteLine($"P2.Name: {P2.Name}");


            #endregion

            #region Qustion04

            /*
             Reference equality determines whether two reference variables point to the exact same object instance in memory (Heap)
            , rather than just holding equal values.
             */

            #endregion

            #region problem05

            //string text = "Good Morning,";
            // Console.WriteLine($"Text Before: {text}");
            // Console.WriteLine($"HashCode Before Modifying: {text.GetHashCode()}");

            // text += "Hi Willy";

            // Console.WriteLine($"Text After: {text}");
            // Console.WriteLine($"HashCode After Modifying: {text.GetHashCode()}");

            #endregion

            #region Qustion05

            /*
             Strings are immutable in C# for thread safety, security, and memory optimization through String Interning.
             */

            #endregion

            #region problem06

            //StringBuilder Text = new StringBuilder("Good Morning,");
            //Console.WriteLine($"Text Before: {Text}");
            //Console.WriteLine($"HashCode Before Modifying: {Text.GetHashCode()}");

            //Text.Append("Hi Willy");
            //Console.WriteLine($"Text Before: {Text}");
            //Console.WriteLine($"HashCode Before Modifying: {Text.GetHashCode()}");


            #endregion

            #region Qustion06

            /*
            StringBuilder uses a dynamic mutable character buffer to modify strings in-place
            without allocating new memory objects during concatenation.
             */

            #endregion

            #region Qustion06_2

            /*
           StringBuilder is faster because it modifies a single, mutable memory buffer directly, 
            avoiding the heavy performance cost of creating, copying, 
            and destroying thousands of immutable string objects during large-scale concatenations.
             */

            #endregion

            #region problem07

            //Console.Write("Enter Frist Number: ");
            //    int input1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Number: ");
            //    int input2 = int.Parse(Console.ReadLine());

            //int sum = input1 + input2;
            ////Concatenation (+ operator) 
            //Console.WriteLine("Concatenated Sum is :" + input1 + " + " + input2 + " = " + sum);
            ////Composite formatting (string.Format) 
            //Console.WriteLine(string.Format("Composite sum is    : {0} + {1} = {2} ", input1, input2, sum));
            ////String interpolation ($) 
            //Console.WriteLine($"Interpolated Sum is : {input1} + {input2} = {sum}");


            #endregion

            #region Qustion07

            /*
           String Interpolation ($) is the most widely used method because it provides better code
            readability, maintainability, and reduces index-mismatch errors found in Composite Formatting.
             */

            #endregion

            #region problem08
            // StringBuilder Text = new StringBuilder("Hello");
            //    Console.WriteLine($"Text Before: {Text}");
            //Text.Append(" World");
            //    Console.WriteLine($"Text After: {Text}");
            //Text.Replace("World", "C#");
            //    Console.WriteLine($"Text After Replace: {Text}");
            //Text.Insert(5, " Developer");
            //    Console.WriteLine($"Text After Insert: {Text}");
            //Text.Remove(0, 5);
            //    Console.WriteLine($"Text After Remove: {Text}");


            #endregion

            #region Qustion08

            /*
               StringBuilder manages an internal expandable buffer of characters that allows in-place
                modifications without allocating new memory objects or triggering frequent garbage collection.
             */

            #endregion


        }
    }
}
