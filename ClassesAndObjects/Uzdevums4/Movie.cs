using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums4
{
    class Movie
    {
        private string _movie;
        private string _studio;
        private string _rating;


        public Movie(string movieTitle, string studio, string rating)
        {
            _movie = movieTitle;
            _studio = studio;
            _rating = rating;
        }
        public Movie(string movieTitle, string studio)
        {
            _movie = movieTitle;
            _studio = studio;
            _rating = "PG";
        }
        public string MovieName
        {
            get{ return _movie; }

        }
        static public Movie[] moviesWithPG (Movie[] films)
        {
            Movie[] filmsWithPG = new Movie[films.Length];

            for(int i =0;i<films.Length;i++)
            {
                if (films[i]._rating == "PG")
                    filmsWithPG[i] = films[i];

            }
            return filmsWithPG;
        }
    }
}
