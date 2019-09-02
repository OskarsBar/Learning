using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            swapPoints(ref p1, ref p2);
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
            Console.Read();


        }

         static void swapPoints(ref Point p1,ref  Point p2)
        {
            Point p3 = new Point(0, 0);
            p3.X = p1.X;
            p3.Y = p1.Y;

            p1.X = p2.X;
            p1.Y = p2.Y;

            p2.X = p3.X;
            p2.Y = p3.Y;
            Console.WriteLine("in function");
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
            return ;
        }
    }
}
