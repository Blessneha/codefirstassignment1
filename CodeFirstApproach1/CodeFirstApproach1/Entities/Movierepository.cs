using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach1.Entities
{
    internal class Movierepository
    {
        public assign2Context assign2Context;
        public Movierepository()
        {
            assign2Context = new assign2Context();

        }
        public List<Movie>GetallMovies()
        {
            try
            {
                List<Movie> mov = assign2Context.Movies.ToList();//return all Employees
                return mov;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddMovie(Movie mov)
        {
            try
            {
                assign2Context.Movies.Add(mov);
                assign2Context.SaveChanges();

            }
            catch(Exception)
            {
                throw;
            }
           
        }

        public Movie GetMoviesbyId(int r)
        {
            try
            {
                Movie movie = assign2Context.Movies.Find(r);
                return movie;

            }
            catch(Exception)
            {
                throw;
            }
        }
        
        public void DeleteMoviesById(int r)
        {
            try
            {
                Movie movie = assign2Context.Movies.Find(r);
                assign2Context.Movies.Remove(movie);
                assign2Context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }

        }

        public void EditMovie(Movie m)
        {
            try
            {
                Movie old1 = assign2Context.Movies.Find(m.Id);
                old1.Name = m.Name;
                assign2Context.SaveChanges();
            }
            catch (Exception)
            {

            }

        }
    }
}
