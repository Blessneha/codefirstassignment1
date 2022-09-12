using CodeFirstApproach1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Movierepository repository = new Movierepository();
            //  Movie mo = new Movie(){Id=2,Name="Rapanzul"};
            // repository.AddMovie(mo);
            do
            {
                Console.WriteLine("1.GetAllMovies\n2.GetMoviesByid\n3.AddMovies\n4.DeleteMovies\n5.Editmovies");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            List<Movie> moviees = repository.GetallMovies();
                            foreach (var m in moviees)
                            {
                                Console.WriteLine($"ID:{m.Id} Name:{m.Name}");
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter EmployeeId");
                            int Id = int.Parse(Console.ReadLine());
                           Movie movv=repository.GetMoviesbyId(Id);
                            if (movv != null)
                            {
                                Console.WriteLine($"ID:{movv.Id} Name:{movv.Name}");
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;
                    
                    case 3:
                        {
                            Movie m = new Movie();
                            Console.WriteLine("Enter MovieId");
                            m.Id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter name");
                            m.Name= Console.ReadLine();
                          
                            repository.AddMovie(m);

                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter Id");
                            int Id = int.Parse(Console.ReadLine());
                            repository.DeleteMoviesById(Id);
                        }
                        break;
                    case 5:
                        {
                            Movie m = new Movie();
                            Console.WriteLine("Enter MovieId");
                            m.Id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter name");
                            m.Name = Console.ReadLine();
                            repository.EditMovie(m);

                        }
                        break;
                }
            } while (true);




        }
    }
}
