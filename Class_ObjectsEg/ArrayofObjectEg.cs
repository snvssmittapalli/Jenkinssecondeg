using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Movie
    {
        int id;
        string moviename;
        internal Movie(int id, string moviename)
        {
            this.id = id;
            this.moviename = moviename;
        }
        internal void Displaymovie()
        {
            Console.WriteLine("id :{0}  || moviename : {1}", id, moviename);
        }
    }
    class ArrayofObjectEg
    {
        static void Main()
        {
            Movie movie = new Movie(101, "dangal");
            movie.Displaymovie();
            Movie[] mov = new Movie[2];
            mov[0] = new Movie(102, "Roja");
            mov[1] = new Movie(103, "boss");
            Console.WriteLine("----------------------------");
            Console.WriteLine("enter how many num of movies you want to print");
            int size = Convert.ToInt32(Console.ReadLine());
            Movie[] move = new Movie[size];
            for (int j=0;j<size; j++)
            {
                Console.WriteLine("entr movie id");
                int movieid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter moviename");
                string mname = Console.ReadLine();
                move[j] = new Movie(movieid, mname);
               
                
            }
            for(int j=0;j<size;j++)
            {
                move[j].Displaymovie();
            }

            Console.Read();

        }
    }
}
