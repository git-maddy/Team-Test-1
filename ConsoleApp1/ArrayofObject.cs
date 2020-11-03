using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayofObject
    {
        class Movie
        {
            int id;
            String moviename;

            internal Movie(int id, string moviename)
            {
                this.id = id;
                this.moviename = moviename;
            }

            internal void DisplayMovie()
            {
                Console.WriteLine("ID:{0}||MovieName:{1}", id, moviename);

            }
        }
        class ArrayofObjectsEg
        {
            static void Main()
            {
                int n, id;
                string name;

                Console.WriteLine("No of movies should be displayed:");
                n = Convert.ToInt32(Console.Read());
                Movie[] mov = new Movie[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter Movie id and Movie Name:");
                    id = Convert.ToInt32(Console.Read());
                    name = Console.ReadLine();
                    mov[i] = new Movie(id, name);
                }
                for (int i = 0; i < n; i++)
                {
                    mov[i].DisplayMovie();
                }


                Console.Read();


            }
        }
    }
}
