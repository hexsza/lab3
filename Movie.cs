using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public enum MovieGenre
    {
        Action = 1,
        Comedy = 2,
        ScienceFiction = 3,
        Drama = 4,
        Horror = 5
    }

    internal class Movie
    {
        public int Number;
        public string Name;
        public int Year;
        public MovieGenre Genre;
        public int Views;
        public int Likes;

        public Movie(string input)
        {
            string[] parts = input.Split(' ');

            Number = int.Parse(parts[0]);
            Name = parts[1];
            Year = int.Parse(parts[2]);

            int genreNumber = int.Parse(parts[3]);

            switch (genreNumber)
            {
                case 1:
                    Genre = MovieGenre.Action;
                    break;
                case 2:
                    Genre = MovieGenre.Comedy;
                    break;
                case 3:
                    Genre = MovieGenre.ScienceFiction;
                    break;
                case 4:
                    Genre = MovieGenre.Drama;
                    break;
                case 5:
                    Genre = MovieGenre.Horror;
                    break;
                default:
                    throw new ArgumentException("not 1-5");
            }

            Views = int.Parse(parts[4]);
            Likes = int.Parse(parts[5]);
        }

        public double CalculateRating()
        {
            if (Views == 0)
                return 0;

            return Math.Sqrt((double)Likes * Likes / Views);
        }

public override string ToString()
{
    return string.Format(
        "{0,4} {1,-15} {2,-8} {3,-12} {4,8:0.000}",
        Number,
        Name,
        "(" + Year + ")",
        Genre,
        CalculateRating()
    );
}
    }
}
