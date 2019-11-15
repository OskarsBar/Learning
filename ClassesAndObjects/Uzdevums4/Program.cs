using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Casino Royale", "Eon Productions", "PG­13");
            Movie movie2 = new Movie("Glass", "Buena Vista International", "PG­13");
            Movie movie3 = new Movie("Spider - Man: Into the Spider - Verse", "Columbia pictures");
            Movie[] movies = { movie1,movie2,movie3 };
            var a = Movie.moviesWithPG(movies);
            foreach(var b in a)
            {
                
                Console.WriteLine(b.MovieName);
            }
            Console.ReadLine();
        }
    }
}
