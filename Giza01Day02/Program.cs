using System;

namespace Giza01Day02
{
    // 1- info
    // 2- Errors
    // 3- Comment 
    // 4- Variables 
    // 5- Operators
    // 6- Casting 

    // Csharp : 
    // MS  >  Pure OOP
    // andres Heiljsberg > 2000 
    // .net 1.0 : 2002
    // TS : 2012
    // .Net Fullstack .Net/Angular
    // JS : interpreted
    // C : Compiled
    // C#/Java : Hybrid
    // 1- Compiled > IL 
    // 2- Interpreted/Execution > Native

    // Errors : 
    // 1- Syntax errors : easy to fix AI
    // -- IDE help u
    // 2- Logical errors : hard to fix
    // (4,4,9) - tracing / debugging 
    // 3- Runtime errors / Exception 
    // (4,0) - defensive/protective code
    // 4- Warning : take care !

    // Comment :
    // 1- Single line comment //
    // 2- Multi line comment /* */
    // cltr + k + C  : comment 
    // cltrl + K + U : Uncomment

    // Variables : 
    // container : contain changed value
    // int X = 4;
    // X = 7;
    // X= "ali";

    // Data type + Name(Pascal case) + value(match DT) + address(managed code)

    // Name : expressive
    // Conventions : (FirstName)
    // firstName  >> camel case > JS
    // first-name >> snake case(kabab case) > Angular
    // FirstName  >> Pascal case > C# 
    // firstName  -  _firstName : self

    // Value : 
    // match data type - range of values

    // address : 
    // C : Manual : avoid memory leak (self)
    // Csharp : Managed code :
    // CLR : allocate / free resources
    // SW engineer : 
    // 1-Unmanaged resources : Dbconnections, Files .. 
    // 2-Optimize : How? - optimise?

    // Data type
    // .NET : 
    // Cross language 
    // C#(System.Int32) , VB (integer) , F# (int)
    // Same IL !!
    // standards/rules : Define DT
    // ensure languages can interact
    // CTS : Commom type System
    // CLS : Common lang specs : interoperability
    
    // Csharp : DT 
    // 1- Value (int X = 5)
    // holds actual value
    // Size Predictable 
    // allocated on stack 
    // nature of stack - DS : self 
    // 2- Ref
    // hold reference (address of object)
    // Size Unknown class Emp(int age, string name, decimal Salary)
    // allocated on heap 
    // nature of heap - DS : self
    

    internal class Program
    {
        static void Main01(string[] args)
        {

            #region Value type
            //// value type : actual value 
            //int X;
            //// syntax sugar
            //X = 5;

            //Int32 y = 8;
            //// BCL
            //X = y; // 8

            //y++;//9
            //Console.WriteLine(X);

            //// regions : Problem01 
            #endregion

            #region Ref type
            // Ref type : hold address
            // Point class : CLR allocate 

            Point P1;
            // 1-ref of type Point, ref to null 
            // 2-allocate unintialized 8 bytes at stack 
            // 3-zerp bytes allocated at heap 
            P1 = new Point();
            //1- allocate req bytes at heap (8 bytes)
            //2- initialize bytes with default values (x=0,y=0)
            //3-call user defined ctor
            //4- assign ref to allocated object

            Point P2 = new Point();

            P2 = P1;
            // object referenced by P1 has 2 references
            // object referenced by P2 unreachable(GC)
            Console.WriteLine(P1.X); // 0
            P1.X = 34;
            Console.WriteLine(P2.X); // 34  
            #endregion

            #region fraction Note
            //// Default fraction >> Double / double

            //float X = 65656.78789F;
            //decimal Y = 8687978.789M;
            //double default1 = 57658.99; //C# keyword

            ////readability >> Discard  _
            // long num = 1_000_000_000_000_000;
            // Console.WriteLine(num);

            // Self :
            // transaction / Salary > DT : Double
            // Decimal : the right one 
            // Scientific notatiion : double and float
            // FPU
            #endregion

            #region Operators

            #region Unary Operators
            //// Unary Operators => One Operand (Variable)
            //int X = 5;
            //// PreFix [Increment and then use it (Print)]
            //Console.WriteLine(++X); //6  X = 6
            //// PostFix [use it (Print) and then Increment]
            //Console.WriteLine(X++); //6  X =7
            //// PreFix [Decrement and then Print]
            //Console.WriteLine(--X); //6  X=6
            //// PostFix [Print/use and then Decrement]
            //Console.WriteLine(X--); //6  X=5
            //Console.WriteLine(X); //5
            #endregion

            #region Binary Operators

            //// Binary Operators => Works On Two Operands (Variables)
            //int Sum, Mul, Div, Sub, Mod;
            //int x = 2, y = 4;
            ////Sum = x + y;
            ////Sub = x - y;
            ////Mul = x * y;
            ////Div = x / y;
            //Mod = x % y;

            //Console.WriteLine(Mod);//remainder //2
            //Console.WriteLine(105 % 20); // 5
            //Console.WriteLine(100 % 20); // 0

            #endregion

            #region Assignment Operator

            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2

            #endregion

            #region Relational Operators [Comparsion]

            //int X = 9, Y = 3;
            //Console.WriteLine(X == Y); // Equal //false
            //Console.WriteLine(X != Y); // Not Equal //true
            //Console.WriteLine(X > Y);  // More Than
            //Console.WriteLine(X >= Y); // More Than Or Equal
            //Console.WriteLine(X < Y);  // Less Than
            //Console.WriteLine(X <= Y); // Less Than Or Equal


            #endregion

            #region Logical Operators

            //Console.WriteLine(!false); //true
            //Console.WriteLine(false && true);//false // short circuit
            //Console.WriteLine(true || false);//true

            //Console.WriteLine(5 < 4 && 7 < 9);// false

            #endregion

            #region Bitwise Operators >> self
            // low level opertaionas :, flags ,... : self
            //////with binding
            //Console.WriteLine(false & true); // long circuit
            //Console.WriteLine(true | false);

            //////left shift <<, right shift >>  binary - Enums - Bit level
            //Console.WriteLine(4 < 5 & 7 < 9);

            #endregion

            #region ternary operator[conditional operator]   ? :
            //int x = 9, y = 10;

            //bool res = x > y ? true : false;
            //Console.WriteLine(res); //false
            #endregion

            #region priority of operators [precedence] and associtivity
            ////operators priority / precedence
            ///*
            //1- () Round braces
            //2- * / %  >> order (from left to right) 
            //3- + - >> Associtivity
            // */

            //int res;
            //res = (20 + 10) * 5 / 2; // 75
            //Console.WriteLine(res);// 75
            #endregion

            #endregion

            #region Casting
            ////Casting  DT > DT
            ///*
            // 1-  V  :  V    2- Ref  :  Ref  
            // 3-  V  :  Ref (Boxing)
            // 4-  Ref:  V   (UnBoxing)
            // */

            ////1 - V  :  V
            //// implicit, explicit, Convert , parse
            //int X = 5;  //4 bytes
            //long Y = X; //8 bytes
            //// Valid ? Criteria?
            //// Implicit ? without casting operator >> safe >> no data loss
            //long n1 = 100;  //8 byte
            //long n1 = 9797987878686878;      //8 byte
            //int n2 = (int)n1;   //4 bytes
            //Console.WriteLine(n2); //-754593634
            // Explicit   with casting operator   unsafe casting ? potential exception
            // Data loss
            // over flow exception

            //// Checked block
            //int n2;
            //checked
            //{
            //    n2 = (int)n1;
            //}
            //Console.WriteLine(n2); // ? 1043998254  >> exception !
            // System.OverflowException:
            // unchecked >>  self

            //// with fractions >> large , without fraction >> small
            //long X1 = 100;
            //double X2 = X1;
            //Console.WriteLine(X2);
            //// implicit >> safe >> valid

            //double g1 = 678.8768; // 8 byte
            //long g2 = (long)g1;   // 8 byte
            //Console.WriteLine(g2);//678

            //double g1 = 67879475947954.8768;     //8 bytes
            //int g2 = (int)g1;         //4 bytes
            //Console.WriteLine(g2); // -2147483648

            //int g2;
            //checked
            //{
            //    g2 = (int)g1;
            //}
            //Console.WriteLine(g2);
            //// explicit > casting  +  Checked
            //============================================================

            //// parse : string to datatype u call from it
            //Console.WriteLine("enter ur name");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter ur age");
            //// string > int 
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter ur salary");
            //// string > decimal
            //decimal salary = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("ur name is " + name);
            //Console.WriteLine("ur age is " + age);
            //Console.WriteLine("ur slary is " + salary);

            // Parse ? Null > Parse >> self

            //============================================================

            //// Convert  : ant Dt to any DT , BCL
            //Console.WriteLine("Enter ur name");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Enter ur Age");
            //// string > int 
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter ur Salary");
            //// string > decimal
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("ur name is " + Name);
            //Console.WriteLine("ur Age is " + Age);
            //Console.WriteLine("ur Slary is " + Salary);

            // Convert ? Null  >> self
            // Convert Vs Parse as performance  >> self

            // Valid Casting
            // Enter valid data >> my Role 
            //string msg = "2";
            //bool J = bool.Parse(msg);
            //int J = Convert.ToInt32(msg);
            //Console.WriteLine(J);
            //System.FormatException 

            //Defensive code / protective Code
            // TryParse
            #endregion
        }
    }
}
