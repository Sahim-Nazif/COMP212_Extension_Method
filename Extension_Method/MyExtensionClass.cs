using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Method
{
    public static class MyExtensionClass
    {
        //need to create a static method to access the properties of the movies class

        public static void HorroMovie(this Movies movies)
        {
            Console.WriteLine("{0} movie's Rating is {1} ", movies.movieTitle, movies.rating);
           
        }

    }
   
}
