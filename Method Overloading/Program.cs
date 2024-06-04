using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Iharetence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calclute.Add(10, 20.11F);
        }   

        public class Calclute
        {
            public static  void Add (int x , int y)
            {
                Console.WriteLine("Int: " + (x + y));
            }
            public static void Add(float x , float y)
            {
                Console.WriteLine("flloting " + (x + y));
            }
            public static void Add(int x, float y)
            {
                Console.WriteLine("Max " + (x + y));
            }
        }
    }
}



