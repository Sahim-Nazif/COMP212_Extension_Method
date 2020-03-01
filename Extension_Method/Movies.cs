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
        private string BoxOffice;
        private DateTime ReleaseDate;

        private Genre genre { get; set; }


        public Movies(double rating, string movieTitle, string producer, string director, Genre genre,string boxOffice,DateTime releaseDate)
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
        public string movieTitle
        {
            get => MovieTitle;set => MovieTitle = value;
        }
        public string producer
        {
            get => Producer; set =>Producer = value;
        }
        public string director
        {
            get => Director; set => Director = value;
        }
        public string boxOffice
        {
            get => BoxOffice; set => BoxOffice = value;
        }
        public DateTime releaseDate
        {
            get => ReleaseDate; set => ReleaseDate = value;
        }
    }
    
}
