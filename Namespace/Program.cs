using pata = ProjectA.TeamA;
using pata = ProjectA.TeamB;

using System;
using System.Runtime.InteropServices;
namespace Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pata.ClassA class = new pata.ClassA();
            ClassA.printhello();

            pata.ClassB class = new pata.ClassA();
            ClassB.printhello();
        }
    }
}


//namespace projectA
//{
//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void printhello()
//            {
//                Console.Write("Hello....");
//            }
//        }
//    }
//}
////////////// using dot. //////////
/////
//namespace projectA.TeamA
//{
//        class ClassA
//        {
//           public static void printhello()
//            {
//                Console.Write("Hello....");
//            }
//        }
//}




