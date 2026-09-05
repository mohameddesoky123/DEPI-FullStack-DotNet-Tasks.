using System;

namespace Daye04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem01

            //int[] arr1 = new int[3];
            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;


            //int[] arr2 = new int[] { 40, 50, 60 };


            //int[] arr3 = { 70, 80, 90 };


            //Console.WriteLine($"arr1 elements: {arr1[0]}, {arr1[1]}, {arr1[2]}");
            //Console.WriteLine($"arr2 elements: {arr2[0]}, {arr2[1]}, {arr2[2]}");
            //Console.WriteLine($"arr3 elements: {arr3[0]}, {arr3[1]}, {arr3[2]}");


            //try
            //{
            //    Console.WriteLine("\nTrying to access index 5 in arr1 (size 3)...");
            //    int value = arr1[5]; 
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Error: IndexOutOfRangeException caught!");
            //}
            #endregion

            #region Question01
            /*
             Array elements in C# are automatically initialized to their type's default value:
            0 for numeric types
            , false for booleans
            , and null for reference types.
             */
            #endregion

            #region problem02

            //int[] arr1 = { 10, 20, 30 };


            //int[] arr2 = arr1; 

            //Console.WriteLine($"arr1[0] before modification: {arr1[0]}"); 
            //arr2[0] = 99; 
            //Console.WriteLine($"arr1[0] after arr2[0] = 99: {arr1[0]} (Affected!)");


            //int[] arr3 = (int[])arr1.Clone(); 

            //arr3[0] = 500;
            //Console.WriteLine($"\narr3[0] after modification: {arr3[0]}"); // 500
            //Console.WriteLine($"arr1[0] remains unchanged:  {arr1[0]} (Not Affected!)");

            #endregion

            #region Question02
            /*
             Array.Clone() creates and returns a new array object containing all elements, requiring an explicit type cast.

             Array.Copy() is a static method that copies elements from a source array into an already existing destination array, 
            more flexibility like copying sub-ranges or partial elements.
             */
            #endregion

            #region problem03

            //int[,] grades = new int[3, 3];


            //Console.WriteLine(" Enter Student Grades : ");
            //for (int i = 0; i < grades.GetLength(0); i++) 
            //{
            //    Console.WriteLine($"\nEnter grades for Student {i + 1}:");
            //    for (int j = 0; j < grades.GetLength(1); j++) 
            //    {
            //        Console.Write($"  Subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //Console.WriteLine("\n Displaying Grades :");
            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    Console.Write($"Student {i + 1}: ");
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.Write($"[Subject {j + 1}: {grades[i, j]}] ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Question03
            /*
             Length returns the total count of all elements across all dimensions combined (e.g., 3 x 3 = 9).

             GetLength(dimension) returns the number of elements in a specific 
            dimension (e.g., GetLength(0) returns the number of rows,
            and GetLength(1) returns the number of columns).
             */
            #endregion

            #region  problem04

            //int[] numbers = { 40, 10, 50, 20, 30 };

            //Console.WriteLine(" Original Array ");
            //Console.WriteLine(string.Join(", ", numbers));


            //Array.Sort(numbers);
            //Console.WriteLine("\n1. After Array.Sort():");
            //Console.WriteLine(string.Join(", ", numbers)); 


            //Array.Reverse(numbers);
            //Console.WriteLine("\n2. After Array.Reverse():");
            //Console.WriteLine(string.Join(", ", numbers));


            //int position = Array.IndexOf(numbers, 30);
            //Console.WriteLine($"\n3. Array.IndexOf(30): Element 30 is at Index {position}");


            //int[] copiedArray = new int[5];
            //Array.Copy(numbers, copiedArray, numbers.Length);
            //Console.WriteLine("\n4. After Array.Copy():");
            //Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));


            //Array.Clear(numbers, 0, 2);
            //Console.WriteLine("\n5. After Array.Clear(0, 2):");
            //Console.WriteLine(string.Join(", ", numbers)); 
            #endregion

            #region Question04
            /*
             Array.Copy() performs a standard copy element-by-element; 
            if an exception occurs mid-operation (e.g., type mismatch),
            the destination array is left partially modified.

             Array.ConstrainedCopy() guarantees an atomic operation (all-or-nothing).
            If a type mismatch or failure occurs during copy, 
            it rolls back and leaves the destination array completely untouched.
             */
            #endregion

            #region problem05

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //Console.WriteLine(" 1. Using For Loop ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();


            //Console.WriteLine("\n 2. Using Foreach Loop");
            //foreach (int num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.WriteLine();


            //Console.WriteLine("\n 3. Using While Loop (Reverse)");
            //int index = numbers.Length - 1; 
            //while (index >= 0)
            //{
            //    Console.Write($"{numbers[index]} ");
            //    index--; 
            //}
            //Console.WriteLine();
            #endregion

            #region Question05
            /*
             foreach is preferred for read-only operations because it provides cleaner and more readable code,
            automatically prevents IndexOutOfRangeException by managing iteration bounds,
            and enforces safety by making the iteration variable read-only (preventing accidental modifications).
             */
            #endregion

            #region problem06

            //int number;
            //bool isValid;

            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    string input = Console.ReadLine();


            //    bool isParsed = int.TryParse(input, out number);


            //    isValid = isParsed && number > 0 && number % 2 != 0;


            //    if (!isValid)
            //    {
            //        Console.WriteLine("Invalid input! Please enter a valid number that is POSITIVE and ODD.\n");
            //    }

            //} while (!isValid); 

            //Console.WriteLine($"\nSuccess! You entered a valid positive odd number: {number}");
            #endregion

            #region Question06
            /*
             Input validation is essential to prevent application crashes, 
            data integrity, and maintain system security by preventing invalid or malicious data from entering the application logic.
             */
            #endregion

            #region problem07

            //int[,] matrix = {
            //{ 1,  2,  3 },
            //{ 4,  5,  6 },
            //{ 7,  8,  9 }
            //};

            //Console.WriteLine(" Matrix Representation ");

            //for (int i = 0; i < matrix.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++) 
            //    {

            //        Console.Write($"{matrix[i, j],-5}");
            //    }
            //    Console.WriteLine(); 
            //}
            #endregion

            #region Question07
            /*
             You can format the output of a 2D array by using string interpolation alignment specifiers (e.g., $"{val,-5}"), tab characters (\t),
            and calling Console.WriteLine() at the end of each row iteration to ensure elements line up neatly in rows and columns
             */
            #endregion

            #region problem08

            //Console.Write("Enter a month number (1-12): ");
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{

            //    Console.WriteLine("\n Using If-Else ");
            //    if (month == 1) Console.WriteLine("Month: January");
            //    else if (month == 2) Console.WriteLine("Month: February");
            //    else if (month == 3) Console.WriteLine("Month: March");
            //    else if (month == 4) Console.WriteLine("Month: April");
            //    else if (month == 5) Console.WriteLine("Month: May");
            //    else if (month == 6) Console.WriteLine("Month: June");
            //    else if (month == 7) Console.WriteLine("Month: July");
            //    else if (month == 8) Console.WriteLine("Month: August");
            //    else if (month == 9) Console.WriteLine("Month: September");
            //    else if (month == 10) Console.WriteLine("Month: October");
            //    else if (month == 11) Console.WriteLine("Month: November");
            //    else if (month == 12) Console.WriteLine("Month: December");
            //    else Console.WriteLine("Invalid month number!");


            //    Console.WriteLine("\n Using Switch");
            //    switch (month)
            //    {
            //        case 1: Console.WriteLine("Month: January"); break;
            //        case 2: Console.WriteLine("Month: February"); break;
            //        case 3: Console.WriteLine("Month: March"); break;
            //        case 4: Console.WriteLine("Month: April"); break;
            //        case 5: Console.WriteLine("Month: May"); break;
            //        case 6: Console.WriteLine("Month: June"); break;
            //        case 7: Console.WriteLine("Month: July"); break;
            //        case 8: Console.WriteLine("Month: August"); break;
            //        case 9: Console.WriteLine("Month: September"); break;
            //        case 10: Console.WriteLine("Month: October"); break;
            //        case 11: Console.WriteLine("Month: November"); break;
            //        case 12: Console.WriteLine("Month: December"); break;
            //        default: Console.WriteLine("Invalid month number!"); break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a valid number.");
            //}
            #endregion

            #region Question08
            /*
             A switch statement is preferred over if-else when evaluating a single variable against multiple fixed/discrete values.
            It improves code readability, maintainability, 
            and allows compiler optimizations like lookup tables for faster execution.
             */
            #endregion

            #region problem09

            //int[] numbers = { 50, 20, 10, 20, 40, 20, 30 };

            //Console.WriteLine(" Original Array ");
            //Console.WriteLine(string.Join(", ", numbers));


            //Array.Sort(numbers);
            //Console.WriteLine("\n After Array.Sort() ");
            //Console.WriteLine(string.Join(", ", numbers));


            //int searchValue = 20;
            //int firstIndex = Array.IndexOf(numbers, searchValue);
            //int lastIndex = Array.LastIndexOf(numbers, searchValue);

            //Console.WriteLine($"\nFirst index of {searchValue}: {firstIndex}");
            //Console.WriteLine($"Last index of {searchValue}: {lastIndex}");

            #endregion

            #region Question09
            /*
             The time complexity of Array.Sort() is $O(N \log N)$ on average and in the worst-case scenario.
             */
            #endregion

            #region problem10

            //int[] numbers = { 10, 20, 30, 40, 50 };


            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}
            //Console.WriteLine($"Sum using for loop: {sumFor}");


            //int sumForeach = 0;
            //foreach (int num in numbers)
            //{
            //    sumForeach += num;
            //}
            //Console.WriteLine($"Sum using foreach loop: {sumForeach}");

            #endregion

            #region Question10
            /*
             For single-dimensional arrays, both for and foreach have practically identical
            performance because the C# compiler and JIT optimize foreach on arrays directly 
            into index-based iteration without allocating an enumerator object.
             */
            #endregion


        }
    }
}
