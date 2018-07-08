using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppUI
{
    public class Movie
    {
        public string MovieName { get; set; }

        public string ISBNNum{ get; set; }

        public string ReleaseDate { get; set; }

        public string Location { get; set; }

        public string Genre { get; set; }

        public string Rating { get; set; }

        public string Duration { get; set; }

        public double Price { get; set; }

        public Movie(string movieName, string isbn, string releaseDate, string location, string genre, string rating, string duration, double price)
        {
            this.MovieName = movieName;
            this.ISBNNum = isbn;
            this.ReleaseDate = releaseDate;
            this.Location = location;
            this.Genre = genre;
            this.Rating = rating;
            this.Duration = duration;
            this.Price = price;
        }

        public Movie(string movieName, string releaseDate, string location, string genre, string rating, string duration, double price)
        {
            this.MovieName = movieName;
            this.ReleaseDate = releaseDate;
            this.Location = location;
            this.Genre = genre;
            this.Rating = rating;
            this.Duration = duration;
            this.Price = price;
        }

        public override string ToString()
        {
            return "Movie: " + MovieName + " ISBN: " + ISBNNum +  "  Release:" + ReleaseDate + "  Location:" +
                    Location + "  Genre:" + Genre + "  Rating:" + Rating + "  Duration:"  + Duration + "  Price:$" + Price;
        }

        public string ToFileString()
        {
            return   MovieName + ":" + ISBNNum + ":" + ReleaseDate + ":" +
                    Location + ":" + Genre + ":" + Rating + ":" + Duration + ":" + Price;
        }
    }
}
