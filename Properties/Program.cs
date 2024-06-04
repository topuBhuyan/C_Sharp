using System;
using System.Runtime.CompilerServices;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            {
                s.name = null;
                s.id = -10;
                s.rol = 010;
                s.passMark = 10;

                Console.WriteLine("id={0}, name={1}, rol ={2}, passMark{3}",s.name, s.id, s.rol, s.passMark);
            }

        }

        //class Student
        //{
        //    public string name;
        //    public int id;
        //    public int rol;
        //    public int passMark;
        //}


    }
}
