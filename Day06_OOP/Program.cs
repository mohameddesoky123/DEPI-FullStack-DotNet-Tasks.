using System;

namespace Daye06_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem01
            //Point p1 = new Point();
            //Console.WriteLine($"p1 = {p1}");
            //Point p2 = new Point(10, 20);
            //Console.WriteLine($"p2 = {p2}");
            #endregion

            #region Question01
            /*
             In C#, structs are value types that implicitly inherit directly from System.ValueType and are marked as sealed by the compiler. 
            Because of this sealed nature and memory design,
            structs cannot inherit from any class or struct (though they can implement interfaces).
             */
            #endregion

            #region problem02
            //TypeA A = new TypeA();

            //Console.WriteLine($"H : {A.G}");
            //Console.WriteLine($"H : {A.H}");
            //A.accessModifiers();
            #endregion

            #region Question02
            /*
             Access modifiers set the visibility boundaries for class members, 
            restricting access based on whether the caller is within the same class, 
            a derived class, or a different assembly.
             */
            #endregion

            #region problem03
            //Employee emp = new Employee(111, "John Doe", 50000);
            //Console.WriteLine($"Employee ID: {emp.GetEmpId()}");
            //Console.WriteLine($"Employee Name: {emp.GetName()}");
            //Console.WriteLine($"Employee Salary: {emp.GetSalary()}");

            //emp.SetName("Mohamed Desoky");
            //emp.Salary = 6500;
            //Console.WriteLine($"Updated Name: {emp.GetName()}");
            //Console.WriteLine($"Updated Salary: {emp.Salary:C}");
            #endregion

            #region Question03
            /*
             Encapsulation protects an object's internal state from unauthorized modification and enforces validation rules,
            which reduces side effects, 
            improves maintainability, and hides implementation complexity.
             */
            #endregion

            #region problem04
            point2 P = new point2(9);
            Console.WriteLine($"P = {P}");
            point2 Q = new point2(10, 20);
            Console.WriteLine($"Q = {Q}");

            #endregion

            #region Question04
            /*
             Constructors in structs are special methods used to initialize field members upon creation, 
            ensuring value types begin in a valid state.
             */
            #endregion

        }
    }
}
