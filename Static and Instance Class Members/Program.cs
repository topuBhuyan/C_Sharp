/*
using System;

namespace Static_and_Instance_Class_Members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.CalculateArea();

            circle circle = new Circle(6);
            Circle2.CalculateArea();

            circle circle = new Circle(7);
            circle3.CalculateArea();

        }
    }
    public class circle
    {
        public static float _PI = 3.1416F;
        int _Radius;

        public circle(int radius)
        {
            this._Radius = radius;
        }
        public void CalculateArea()
        {
            Console.WriteLine("Radius Value: "+  _PI * _Radius * _Radius);
        }
    }
    
}
*/

using System;
using static Static_and_Instance_Class_Members.Program;

namespace Static_and_Instance_Class_Members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployees fe = new FullTimeEmployees();
            fe.FirstName = "Manoj";
            fe.LastName = "Roy";
            fe.Email = "manoj@gmail.com";
            fe.YearlySalary = 500000F;
            fe.PrintFullName();

            PartTimeEmployee pe = new PartTimeEmployee();
            pe.FirstName = "Abdur";
            pe.LastName = "Rouf";
            pe.Email = "Rouf@gmail.com";
            pe.HourSalary = 100000F;
            pe.PrintFullName();

        }

        public class Emplyee
        {
            public string FirstName;
            public string LastName;
            public string Email;
    

            public void PrintFullName()
            {
                Console.WriteLine("Full Name: {0} {1}", FirstName, LastName + " From Full Tiem Emplyee");
            }
        }

        public class FullTimeEmployees : Emplyee
        {
            public float YearlySalary;
        }

        public class PartTimeEmployee : Emplyee
        {
            public float HourSalary;

            public void PrintFullName()
            {
                Console.WriteLine("Full Name: {0} {1}", FirstName, LastName+ " From part Time");
            }
        }
    }
}


