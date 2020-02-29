using System;
using System.Collections.Generic;
using System.Linq;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movies> movies = new List<Movies>()
           {
               new Movies(6.6,"The Invisible Man"," Blumhouse Productions", "Leigh Whannell",Genre.Scifi,"9 million USD", new DateTime(2020,02,28)),
               new Movies(6.1,"Uder Water","20th Century Studios", "William Eubank",Genre.Drama,"39 million USD", new DateTime(2020,01,10)),
               new Movies(4.6,"Fantasy Island","Jeff Wadlow ","Jeff Wadlow",Genre.Mystery,"23.7 million USD", new DateTime(2020,02,14)),

           };

            var highRating = from m in movies
                            where m.rating >5
                            select m;

            foreach (var item in highRating)
            {
                Console.WriteLine(item.rating);
            }


            var producer = from m in movies
                            where m.producer.Contains("Blumhouse")
                            select m;

            foreach (var item in producer)
            {
                Console.WriteLine(item.producer);
            }


        }
    }
}
