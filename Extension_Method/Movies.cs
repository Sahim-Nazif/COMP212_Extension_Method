using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Method
{
    public class Movies
    {
        private double Rating;
        private string MovieTitle;
        private string Producer;
        private string Director;
        private double BoxOffice;
        private DateTime ReleaseDate;

        private Genre genre { get; set; }


        public Movies(double rating, string movieTitle, string producer, string director, double boxOffice,DateTime releaseDate, Genre genre)
        {
            Rating = rating;
            MovieTitle = movieTitle;
            Producer = producer;
            Director =director;
            BoxOffice = boxOffice;
            ReleaseDate = releaseDate;

        }
        public double rating
        {
            get => Rating;set => Rating = value;
        }
        public string producer
        {
            get => producer; set =>Producer = value;
        }
        public string director
        {
            get => Director; set => Director = value;
        }
        public double boxOffice
        {
            get => BoxOffice; set => BoxOffice = value;
        }
        public DateTime releaseDate
        {
            get => ReleaseDate; set => ReleaseDate = value;
        }
    }
    
}
